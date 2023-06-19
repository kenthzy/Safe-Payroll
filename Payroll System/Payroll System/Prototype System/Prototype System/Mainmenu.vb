Public Class Mainmenu

    ' Event handler for the "Insert" button click
    Private Sub bttnInsert_Click(sender As Object, e As EventArgs) Handles bttnInsert.Click
        Try
            ' Get the values of the input fields and use them to construct an INSERT query
            Dim position As String = If(position1.SelectedItem IsNot Nothing, position1.SelectedItem.ToString(), "")
            Dim gender As String = If(gender1.SelectedItem IsNot Nothing, gender1.SelectedItem.ToString(), "")
            Dim salary As Double = If(salary1.SelectedItem IsNot Nothing, salary1.SelectedItem.ToString(), "")
            insert("INSERT INTO employees (empid, Name, position, gender, salary) VALUES ('" & empid1.Text & "','" & name1.Text & "','" & position & "','" & gender & "'," & salary & ")")
            ' Show success message
            MessageBox.Show("Data inserted successfully.")
        Catch ex As Exception
            ' Show error message if an exception occurred
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Event handler for the "Reload" button click
    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        Try
            ' Execute a SELECT query to reload data into the DataGridView control
            reload("SELECT * FROM employees", DTGLIST)
        Catch ex As Exception
            ' Show error message if an exception occurred
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Event handler for the "Credits" button click
    Private Sub btnCredits_Click(sender As Object, e As EventArgs) Handles btnCredits.Click
        ' Hide the current form and show the "CREDITS" form
        Me.Hide()
        CREDITS.Show()
    End Sub

    ' Event handler for the "Payroll" button click
    Private Sub btnPayroll_Click(sender As Object, e As EventArgs) Handles btnPayroll.Click
        ' Hide the current form and show the "Payroll" form as a dialog box
        Me.Hide()
        Payroll.ShowDialog()
    End Sub

    ' Event handler for the "Update" button click
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            ' Get the values of the input fields and use them to construct an UPDATE query
            Dim position As String = If(position1.SelectedItem IsNot Nothing, position1.SelectedItem.ToString(), "")
            Dim gender As String = If(gender1.SelectedItem IsNot Nothing, gender1.SelectedItem.ToString(), "")
            Dim salary As Double = If(salary1.SelectedItem IsNot Nothing, salary1.SelectedItem.ToString(), "")
            updates("UPDATE employees SET Name = '" & name1.Text & "', position = '" & position & "', gender = '" & gender & "', salary = " & salary & " WHERE empid = '" & empid1.Text & "'")
            ' Show success message
            MessageBox.Show("Data updated successfully.")
        Catch ex As Exception
            ' Show error message if an exception occurred
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Event handler for the DataGridView control's CellContentClick event
    Private Sub DTGLIST_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGLIST.CellContentClick
        'this will get the data from database and data gridview and display it to textbox to if you click
        empid1.Text = DTGLIST.CurrentRow.Cells(0).Value
        name1.Text = DTGLIST.CurrentRow.Cells(1).Value
        position1.SelectedItem = DTGLIST.CurrentRow.Cells(2).Value
        gender1.SelectedItem = DTGLIST.CurrentRow.Cells(3).Value
        salary1.SelectedItem = DTGLIST.CurrentRow.Cells(4).Value
    End Sub

    ' Event handler for the "Delete" button click
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            ' Use the value of the "empid" input field to construct a DELETE query
            delete("DELETE FROM employees WHERE empid='" & empid1.Text & "'")
        Catch ex As Exception
            ' Show error message if an exception occurred
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Event handler for the "New" button click
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ' Clear the values of all input fields
        empid1.Text = ""
        name1.Clear()
        position1.SelectedItem = Nothing
        gender1.SelectedItem = Nothing
        salary1.SelectedItem = Nothing
    End Sub

End Class