Imports System.Web.UI.WebControls
Imports MySql.Data.MySqlClient

Public Class Register
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Validate password confirm
        If TextBox2.Text = TextBox3.Text Then
            ' Connect to the MySQL database
            Dim connStr As String = "server=localhost;user=root;password=;database=login_form"
            Dim conn As New MySqlConnection(connStr)
            Try
                conn.Open()

                ' Execute an INSERT statement to add the new user information to the "login" table
                Dim cmd As New MySqlCommand("INSERT INTO login (username, password) VALUES (@username, @password)", conn)
                cmd.Parameters.AddWithValue("@username", TextBox4.Text)
                cmd.Parameters.AddWithValue("@password", TextBox2.Text)
                cmd.ExecuteNonQuery()

                ' Close the database connection and show the Login form
                conn.Close()
                Login.Show()
                Me.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Passwords do not match.")
        End If
    End Sub

    Private Sub Mainmenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Show the Login form when the Register form is closed
        Login.Show()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        ' Show the Login form
        Me.Hide()
        Login.Show()
    End Sub
End Class