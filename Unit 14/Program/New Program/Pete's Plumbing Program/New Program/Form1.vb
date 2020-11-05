Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("My First Visual Basic Program")
        'Message box indicating first program

        Me.Text = "Pete's Plumbing"
        Me.MaximizeBox = False


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim X As String


        If TextBox1.Text = "Usman123" Then
            MsgBox("Sucessful Username")
        Else
            MsgBox("Sorry, Username or Password Incorrect", MsgBoxStyle.OkOnly, "Invalid")
        End If
        'If statement for Username

        Do Until TextBox1.Text = "Usman123"
            Me.Close()
        Loop

            Do
                X = InputBox("Enter Password Please")
            Loop While X <> "Hello"
            MsgBox("Welcome")
            Form2.Show()
        'Do Loop for Password
    End Sub
End Class