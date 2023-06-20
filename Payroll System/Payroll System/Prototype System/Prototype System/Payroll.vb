Imports System.Data.SqlClient
Imports System.Web.UI.WebControls

Public Class Payroll
    'my connection on database
    Private connectionString As String = "server=localhost;user id=root;password=;database=dbsafe"

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Hide()
        Portal.Show()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        'this will reload the database
        Try
            reload("SELECT empid, Name, position, gender, salary FROM employees", DTGLIST1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DTGLIST1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGLIST1.CellContentClick
        'this will get the data from database and data gridview and display it to textbox to if you click
        empid1.Text = DTGLIST1.CurrentRow.Cells(0).Value
        name1.Text = DTGLIST1.CurrentRow.Cells(1).Value
        position1.SelectedItem = DTGLIST1.CurrentRow.Cells(2).Value
        gender1.SelectedItem = DTGLIST1.CurrentRow.Cells(3).Value
        salary1.SelectedItem = DTGLIST1.CurrentRow.Cells(4).Value
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        'declare variables and get input values


        Dim monthlySalary As Double = Convert.ToDouble(salary1.SelectedItem.ToString())
        Dim workdays As Integer = CInt(txtWorkdays.Text) 'get number of work days from TextBox
        Dim sssDeduction, pagIbigDeduction, philHealthDeduction, tax As Double 'initialize variables for deductions
        Dim totalDeductions, netSalary As Double 'initialize variables for total deductions and net salary

        ' Get selected position from ComboBox
        Dim position As String = position1.SelectedItem.ToString()
        ' Calculate position-based salary
        Dim positionSalary As Double = 0.0
        Select Case position
            Case "CEO"
                positionSalary = 180000
            Case "Director"
                positionSalary = 120000
            Case "Manager"
                positionSalary = 60000
            Case "Team Lead"
                positionSalary = 40000
            Case "Regular"
                positionSalary = 25000
            Case "Security"
                positionSalary = 15000
            Case "Maintenance"
                positionSalary = 10000
        End Select
        ' Calculate deductions
        If monthlySalary <= 35000 Then
            sssDeduction = monthlySalary * 0.045 ' Compute SSS deduction as 4.5% of monthly salary
        Else
            sssDeduction = 1575 ' Set maximum SSS contribution for employee
        End If

        ' Calculate net salary
        If workdays < 24 Then
            ' Calculate deductions for incomplete work days
            Dim dailySalary As Double = positionSalary / 4 ' Calculate daily salary based on position-based salary
            Dim incompleteDays As Integer = 24 - workdays ' Calculate the number of incomplete work days
            Dim incompleteSalary As Double = dailySalary * incompleteDays ' Calculate the salary deduction for incomplete work days

            netSalary = monthlySalary - totalDeductions - incompleteSalary ' Subtract deductions and incomplete salary from the monthly salary
        Else
            netSalary = monthlySalary - totalDeductions ' Subtract total deductions from the monthly salary
        End If


        pagIbigDeduction = monthlySalary * 0.01 ' Compute Pag-IBIG deduction as 1% of monthly salary
        philHealthDeduction = monthlySalary * 0.015 ' Compute PhilHealth deduction as 1.5% of monthly salary

        If monthlySalary * 12 <= 250000 Then
            tax = 0 ' No tax for annual income below or equal to PHP 250,000
        Else
            ' Calculate tax using the revised tax criteria
            ' Calculate tax using the revised tax criteria
            Dim annualIncome As Double = monthlySalary * 12 ' Compute annual income based on monthly salary
            Dim taxableIncome As Double = annualIncome - (sssDeduction * 12) - (pagIbigDeduction * 12) - (philHealthDeduction * 12) ' Compute taxable income after deducting mandatory contributions

            Dim maxTaxPercentage As Double = 0.3 ' Maximum tax percentage (30% in this example)
            Dim maxTaxDeduction As Double = monthlySalary * maxTaxPercentage ' Maximum tax deduction based on the monthly salary

            If taxableIncome <= 400000 Then
                tax = Math.Min(taxableIncome * 0.15, maxTaxDeduction) ' Compute tax as 15% of taxable income or maximum tax deduction, whichever is lower
            ElseIf taxableIncome <= 550000 Then
                tax = Math.Min(22500 + ((taxableIncome - 400000) * 0.2), maxTaxDeduction) ' Compute tax using the tax bracket for PHP 400,001 to 550,000 or maximum tax deduction, whichever is lower
            Else
                ' Compute tax for higher income brackets with additional 5% tax for every additional PHP 150,000, limited by the maximum tax deduction
                Dim additionalIncome As Double = taxableIncome - 550000
                Dim additionalTax As Double = Math.Ceiling(additionalIncome / 150000) * 5
                tax = Math.Min(62500 + ((taxableIncome - 400000) * 0.2) + additionalTax, maxTaxDeduction)
            End If

        End If

        totalDeductions = sssDeduction + pagIbigDeduction + philHealthDeduction + tax ' Compute total deductions

        'calculate net salary
        netSalary = ((positionSalary / 4) * workdays) - totalDeductions
        'compute net salary based on position-based salary, work days, and total deductions

        ' Calculate net salary
        netSalary = monthlySalary - totalDeductions

        ' Format output as a string
        Dim output As String = ""
        output &= "" & vbCrLf
        output &= "   SAFE PAYROLL" & vbCrLf
        output &= "--------------------------" & vbCrLf
        output &= "EMPLOYEE PAYCHECK SUMMARY" & vbCrLf
        output &= "--------------------------" & vbCrLf
        output &= "Position: " & position & vbCrLf
        output &= "Salary: PHP " & Format(monthlySalary, "0.00") & " per month" & vbCrLf
        output &= "Work days: " & workdays & vbCrLf
        output &= "--------------------------" & vbCrLf
        output &= "DEDUCTIONS" & vbCrLf
        output &= "--------------------------" & vbCrLf
        output &= "SSS: PHP " & Format(sssDeduction, "0.00") & vbCrLf
        output &= "Pag-IBIG: PHP " & Format(pagIbigDeduction, "0.00") & vbCrLf
        output &= "PhilHealth: PHP " & Format(philHealthDeduction, "0.00") & vbCrLf
        output &= "Tax: PHP " & Format(tax, "0.00") & vbCrLf
        output &= "--------------------------" & vbCrLf
        output &= "TOTAL DEDUCTIONS: PHP " & Format(totalDeductions, "0.00") & vbCrLf
        output &= "--------------------------" & vbCrLf
        output &= "NET SALARY: PHP " & Format(netSalary, "0.00") & vbCrLf
        output &= "--------------------------"

        TextBox2.Text = output
        TextBox2.TextAlign = HorizontalAlignment.Center
        TextBox2.Font = New Font("Courier New", 10)
        TextBox2.SelectionStart = TextBox2.TextLength
        TextBox2.ScrollToCaret()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' Create a new PrintDocument object
        Dim printDoc As New Printing.PrintDocument()

        ' Add a PrintPage event handler to the PrintDocument object
        AddHandler printDoc.PrintPage, AddressOf PrintReceipt

        ' Print the document using the default printer
        printDoc.Print()
    End Sub

    Private Sub PrintReceipt(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs)
        ' Create a new font and brush to use for drawing the text
        Dim font As New Font("Courier New", 10)
        Dim brush As New SolidBrush(Color.Black)

        ' Get the left and top margins of the printable area
        Dim startX As Integer = e.MarginBounds.Left
        Dim startY As Integer = e.MarginBounds.Top

        ' Calculate the height of one line of text
        Dim lineHeight As Integer = font.Height

        ' Calculate the number of lines that can fit on one page
        Dim linesPerPage As Integer = e.MarginBounds.Height \ lineHeight

        ' Split the text in TextBox2 into an array of lines
        Dim lines() As String = TextBox2.Text.Split(vbCrLf)

        ' Keep track of the starting index of the lines to print on each page
        Dim startIndex As Integer = 0

        ' Loop through all the lines in the text
        While startIndex < lines.Length
            ' Calculate the ending index of the lines to print on the current page
            Dim endIndex As Integer = Math.Min(startIndex + linesPerPage, lines.Length)

            ' Get the lines to print on the current page
            Dim pageLines() As String = lines.Skip(startIndex).Take(endIndex - startIndex).ToArray()

            ' Join the lines into a single string with line breaks
            Dim text As String = String.Join(vbCrLf, pageLines)

            ' Measure the size of the text
            Dim textSize As SizeF = e.Graphics.MeasureString(text, font)

            ' Calculate the X and Y coordinates to draw the text in the center of the page
            Dim x As Single = startX + (e.MarginBounds.Width - textSize.Width) / 2
            Dim y As Single = startY

            ' Draw the text on the page
            e.Graphics.DrawString(text, font, brush, x, y)

            ' Update the starting index for the lines to print on the next page
            startIndex += linesPerPage

            ' Update the Y coordinate for the next page
            startY += Convert.ToInt32(textSize.Height) + lineHeight

            ' If there are more lines to print, set HasMorePages to True so that the PrintPage event will be called again
            If startIndex < lines.Length Then
                e.HasMorePages = True
                Return
            End If
        End While

        ' If all the lines have been printed, set HasMorePages to False to indicate that printing is complete
        e.HasMorePages = False
    End Sub

End Class
