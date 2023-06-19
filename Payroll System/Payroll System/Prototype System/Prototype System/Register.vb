Public Class Register
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'validation password confirm
        If TextBox2.Text = TextBox3.Text Then
            Login.newuser = TextBox4.Text 'good
            Login.newpass = TextBox2.Text 'good
            Login.Show()
            Me.Close()
        Else
            MessageBox.Show("Passwords do not match.")
        End If
    End Sub

    Private Sub Mainmenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Login.Show()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class