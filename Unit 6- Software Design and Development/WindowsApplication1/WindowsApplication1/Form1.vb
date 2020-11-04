Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'Calculate the Gross Pay'
            TextBox3.Text = GrossPay()
            'Calculate the tax'
            TextBox4.Text = Tax()
            'Calculate the National Insurance'
            TextBox5.Text = NI()
            'Calculate the NetPay' 
            TextBox6.Text = NetPay()

            If TextBox1.Text = 0 Then
                MessageBox.Show(" Numbers must be greater than 1, try again")
            End If
            If TextBox2.Text = 0 Then
                MessageBox.Show(" Numbers must be greater than 1, try again")
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'to see if it is over 40'
        If TextBox1.Text > 40 Then
            MessageBox.Show(" Enter less than 40 hours")
            TextBox1.Text = 0
        End If
    End Sub
    Private Sub Textbox1_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Only Numerical Data")

        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        'To see if it is over 20'
        If TextBox2.Text > 20 Then
            MessageBox.Show(" Enter less than £20")
            TextBox2.Text = 0
        End If
    End Sub
    Private Sub Textbox2_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Only Numerical Data")

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Open another form'
        Form2.Show()
        Form2.TextBox1.Text = Me.TextBox1.Text
        Form2.TextBox2.Text = Me.TextBox2.Text
        Form2.TextBox3.Text = Me.TextBox3.Text
        Form2.TextBox4.Text = Me.TextBox4.Text
        Form2.TextBox5.Text = Me.TextBox5.Text
        Form2.TextBox6.Text = Me.TextBox6.Text
    End Sub
    Function GrossPay()
        GrossPay = Val(TextBox2.Text) * Val(TextBox1.Text)
    End Function
    Function Tax()
        Tax = Val(TextBox3.Text) * Val(0.2)
    End Function
    Function NI()
        NI = Val(TextBox3.Text) * Val(0.1)
    End Function
    Function NetPay()
        NetPay = Val(TextBox3.Text) - Val(TextBox4.Text) - Val(TextBox5.Text)

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class

