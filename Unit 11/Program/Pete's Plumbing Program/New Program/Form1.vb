Public Class Form1
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "Usman123" And TextBox2.Text = "Ranger" Then
            MsgBox("Sucessfully Logged in")
            Form2.Show()

        Else
            MsgBox("Sorry, Username or Password Incorrect", MsgBoxStyle.OkOnly, "Invalid")

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Pete's Plumbing"

        Me.MaximizeBox = False

    End Sub
End Class
