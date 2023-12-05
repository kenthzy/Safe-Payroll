Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Connect to the MySQL database
        Dim connStr As String = "server=localhost;user=root;password=;database=login_form"
        Dim conn As New MySqlConnection(connStr)
        Try
            conn.Open()

            ' Execute a SELECT statement to retrieve the login information
            Dim cmd As New MySqlCommand("SELECT username, password FROM login WHERE username=@username", conn)
            cmd.Parameters.AddWithValue("@username", TextBox13.Text)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Check if the username and password match
            If reader.Read() AndAlso reader.GetString("password") = TextBox2.Text Then
                ' Close the database connection and show the Portal form
                conn.Close()
                Close()
                Portal.ShowDialog()
            Else
                ' Close the database connection and show an error message
                conn.Close()
                MessageBox.Show("Unauthorized!")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ' Show/hide password
        If CheckBox1.Checked Then
            TextBox2.UseSystemPasswordChar = True
        Else
            TextBox2.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Show the Register form
        Me.Hide()
        Register.Show()
    End Sub


End Class