Public Class Form2

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        'Closing application
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Const VAT As Double = 0.2

        'Calculations
        TextBox13.Text = Labour()
        TextBox14.Text = Travel()
        TextBox15.Text = PlasticPipes()
        TextBox16.Text = CopperPipes()
        TextBox17.Text = ChromePipes()
        TextBox18.Text = OverallCost()

        'VAT
        TextBox20.Text = Val(TextBox18.Text) + Val(TextBox18.Text * VAT)

        'Total Cost After Discount
        TextBox19.Text = TextBox21.Text + TextBox20.Text

        'Discount
        If TextBox18.Text > 500 Then
            TextBox21.Text = Val(TextBox18.Text) - Val(TextBox18.Text * 0.05)
        End If

        'Non-Numerical e.g. negative
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Enter only numbers", vbInformation)
            TextBox1.Text = ""
        End If

    End Sub
Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    Me.Text = "Pete's Plumbing"
    Me.BackColor = Color.LightBlue

    Me.MinimizeBox = True
    Me.MaximizeBox = False

End Sub
Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Showing Help and Support Form
        Help_and_Support.Show()
End Sub

Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form3.Show()
        'Showing Form3 - Database
        Form5.Show()
End Sub

Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Clearing
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
        'Adding items to Form4
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
Function Labour() As Decimal
        'Functions
        Labour = Val(TextBox1.Text) * Val(Textbox23.Text)
End Function
Function Travel() As Decimal
    Travel = Val(TextBox2.Text) * Val(TextBox9.Text)
End Function
Function PlasticPipes() As Decimal
    PlasticPipes = Val(TextBox3.Text) * Val(TextBox8.Text)
End Function
Function CopperPipes() As Decimal
    CopperPipes = Val(TextBox5.Text) * Val(TextBox7.Text)
End Function
Function ChromePipes() As Decimal
    ChromePipes = Val(TextBox4.Text) * Val(TextBox6.Text)
End Function
Function OverallCost() As Decimal
    OverallCost = Val(TextBox13.Text) + Val(TextBox14.Text) + Val(TextBox15.Text) + Val(TextBox16.Text) + Val(TextBox17.Text) + Val(TextBox18.Text)
End Function

    Private Sub Textbox1_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        'Only Numerical Data is allowed to be entered
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Only Numerical Data")
            TextBox1.Text = ""
        End If

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        'Only enter until 40
        If TextBox10.Text > 40 Then
            MessageBox.Show(" Enter less than 40 hours")
            TextBox10.Text = 0
        End If
    End Sub
End Class
