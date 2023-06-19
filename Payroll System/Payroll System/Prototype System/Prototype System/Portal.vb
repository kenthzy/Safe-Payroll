Public Class Portal
    Private Sub btnEmp_Click(sender As Object, e As EventArgs) Handles btnEmp.Click
        Me.Hide()
        Mainmenu.Show()
    End Sub

    Private Sub btnPayroll_Click(sender As Object, e As EventArgs) Handles btnPayroll.Click
        Me.Hide()
        Payroll.Show()
    End Sub
End Class