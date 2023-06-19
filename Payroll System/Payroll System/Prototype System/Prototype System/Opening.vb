Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Disable the button to prevent multiple clicks
        Button1.Enabled = False

        ' Reset the progress bar
        ProgressBar1.Value = 0

        ' Perform the loading process
        For i As Integer = 1 To 100
            ' Simulate a delay to show the progress
            System.Threading.Thread.Sleep(20)

            ' Update the progress bar
            ProgressBar1.Value = i

            ' Refresh the form to update the UI
            Me.Refresh()
        Next

        ' Enable the button after the loading process is completed
        Button1.Enabled = True

        'hide the form
        Me.Hide()

        ' Display the Login form
        Login.Show()

    End Sub
End Class
