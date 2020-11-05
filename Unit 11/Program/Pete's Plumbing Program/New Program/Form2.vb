Public Class Form2

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox13.Text = Val(TextBox1.Text) * Val(0.4)
        TextBox14.Text = Val(TextBox2.Text) * Val(0.1)
        TextBox15.Text = Val(TextBox3.Text) * Val(0.2)
        TextBox16.Text = Val(TextBox5.Text) * Val(0.3)
        TextBox17.Text = Val(TextBox4.Text) * Val(0.4)

        TextBox18.Text = Val(TextBox13.Text) + Val(TextBox14.Text) + Val(TextBox15.Text) + Val(TextBox16.Text) + Val(TextBox17.Text)
        TextBox20.Text = Val(TextBox18.Text) + Val(TextBox18.Text * 0.2)
        If TextBox20.Text > 500 Then
            TextBox21.Text = Val(TextBox20.Text) * Val(TextBox18.Text * 0.05)
        End If

        If TextBox20.Text > 500 Then
            TextBox19.Text = Val(TextBox20.Text) + TextBox21.Text

        End If
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Pete's Plumbing"
        Me.BackColor = Color.LightBlue

        Me.MinimizeBox = True
        Me.MaximizeBox = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Help_and_Support.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form3.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.TextBox4.Text = ""
        Me.TextBox5.Text = ""
        Me.TextBox6.Text = ""
        Me.TextBox7.Text = ""
        Me.TextBox8.Text = ""
        Me.TextBox9.Text = ""
        Me.Textbox23.Text = ""
        Me.TextBox11.Text = ""
        Me.TextBox12.Text = ""
        Me.TextBox13.Text = ""
        Me.TextBox14.Text = ""
        Me.TextBox15.Text = ""
        Me.TextBox16.Text = ""
        Me.TextBox17.Text = ""
        Me.TextBox18.Text = ""
        Me.TextBox19.Text = ""
        Me.TextBox20.Text = ""
        Me.TextBox21.Text = ""

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form4.Show()
        Form4.ListBox1.Items.Add("Labour")
        Form4.ListBox1.Items.Add(Val(TextBox1.Text))
        Form4.ListBox1.Items.Add("£" & Val(TextBox13.Text))
        Form4.ListBox1.Items.Add("Travel")
        Form4.ListBox1.Items.Add(Val(TextBox2.Text))
        Form4.ListBox1.Items.Add("£" & Val(TextBox14.Text))
        Form4.ListBox1.Items.Add("Plastic Pipes")
        Form4.ListBox1.Items.Add(Val(TextBox3.Text))
        Form4.ListBox1.Items.Add("£" & Val(TextBox15.Text))
        Form4.ListBox1.Items.Add("Copper Pipes")
        Form4.ListBox1.Items.Add(Val(TextBox5.Text))
        Form4.ListBox1.Items.Add("£" & Val(TextBox16.Text))
        Form4.ListBox1.Items.Add("Chrome Pipes")
        Form4.ListBox1.Items.Add(Val(TextBox4.Text))
        Form4.ListBox1.Items.Add("£" & Val(TextBox17.Text))
        Form4.ListBox1.Items.Add("£" & Val(TextBox18.Text))
    End Sub
End Class