
Public Class Login
    Const user = "safe", pass = "123"
    Public Shared newuser, newpass As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = user And TextBox2.Text = pass) Or (TextBox1.Text = newuser And TextBox2.Text = newpass) Then
            'close the form when go to mainmenu
            Close()
            'user and pass correct
            Portal.ShowDialog()
        Else
            'user and pass incorrect
            MessageBox.Show("Unauthorized!")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'checked box show password
        If CheckBox1.CheckState = CheckState.Checked Then
            'if checked
            TextBox2.UseSystemPasswordChar = True
        Else
            'if not checked
            TextBox2.UseSystemPasswordChar = False

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Register.Show()
    End Sub
End Class