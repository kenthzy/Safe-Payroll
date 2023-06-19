Imports MySql.Data.MySqlClient

Module SAFEDbConnection

    ' Define global variables
    Public strcon As MySqlConnection = strconnection()
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable

    ' Function to create a new MySQL connection
    Public Function strconnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;password=;database=dbsafe")
    End Function

    ' Sub procedure to insert data into the database
    Public Sub insert(ByVal sql As String)
        Try
            ' Open the database connection
            strcon.Open()
            ' Execute the SQL query
            With cmd
                .Connection = strcon
                .CommandText = sql
                ' Show success message if the query was executed successfully or error message if it failed
                If cmd.ExecuteNonQuery > 0 Then
                    MessageBox.Show("DATA HAS BEEN SAVED ON THE DATABASE", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("FAILED TO SAVE THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            ' Show error message if an exception occurred
            MessageBox.Show(ex.Message)
        Finally
            ' Close the database connection
            strcon.Close()
        End Try
    End Sub

    ' Sub procedure to reload data from the database into a DataGridView control
    Public Sub reload(ByVal sql As String, ByVal DTG As Object)
        Try
            ' Create a new DataTable object
            dt = New DataTable
            ' Open the database connection
            strcon.Open()
            ' Execute the SQL query
            With cmd
                .Connection = strcon
                .CommandText = sql
            End With
            ' Use a DataAdapter to fill the DataTable with the results of the SQL query
            da.SelectCommand = cmd
            da.Fill(dt)
            ' Set the DataSource property of the DataGridView control to the DataTable
            DTG.datasource = dt
        Catch ex As Exception
            ' Show error message if an exception occurred
            MessageBox.Show(ex.Message)
        Finally
            ' Close the database connection and dispose of the DataAdapter object
            strcon.Close()
            da.Dispose()
        End Try
    End Sub

    ' Sub procedure to update data in the database
    Public Sub updates(ByVal sql As String)
        Try
            ' Open the database connection
            strcon.Open()
            ' Execute the SQL query
            With cmd
                .Connection = strcon
                .CommandText = sql
                ' Show success message if the query was executed successfully or error message if it failed
                If cmd.ExecuteNonQuery > 0 Then
                    MessageBox.Show("DATA HAS BEEN UPDATED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("DATE FAILED TO UPDATE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            ' Show error message if an exception occurred
            MessageBox.Show(ex.Message)
        Finally
            ' Close the database connection
            strcon.Close()
        End Try
    End Sub

    ' Sub procedure to delete data from the database
    Public Sub delete(ByVal sql As String)
        Try
            ' Open the database connection
            strcon.Open()
            ' Execute the SQL query
            With cmd
                .Connection = strcon
                .CommandText = sql
                ' Show success message if the query was executed successfully or error message if it failed
                If cmd.ExecuteNonQuery > 0 Then
                    MessageBox.Show("DATA HAS BEEN DELETED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("DATA FAILED TO DELETE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            ' Show error message if an exception occurred
            MessageBox.Show(ex.Message)
        Finally
            ' Close the database connection
            strcon.Close()
        End Try
    End Sub

End Module