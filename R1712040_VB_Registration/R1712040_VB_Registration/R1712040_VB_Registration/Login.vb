Public Class frmlogin

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblwelcome.Click

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtusername.Text = ("munya") And txtpassword.Text = ("henry") Then
            MsgBox("Successful Login")
            frmmenu.Show()
            Me.Hide()
        Else
            MsgBox("Login Failed")

        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Close()
    End Sub
End Class
