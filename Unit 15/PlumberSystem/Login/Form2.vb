Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim MyObject As Object
        Dim h, t, p, c, ch As Double

        'Calculations
        MyObject = New MyClass1()
        h = Labour.Text
        Label1.Text = (MyObject.Labour(h))

        t = Travel.Text
        Label2.Text = (MyObject.Travel(t))

        p = PlasticPipes.Text
        Label3.Text = (MyObject.PlasticPipes(p))

        c = CopperPipes.Text
        Label4.Text = (MyObject.Copperpipes(c))

        ch = ChromePipes.Text
        Label5.Text = (MyObject.Chromepipes(ch))



        VAT.Text = Val(OverallCost.Text) * 0.2
        Discount.Text = Val(OverallCost.Text) * 0.05


        OverallCost.Text = Val(MyObject.Labour(h)) + Val(MyObject.Travel(t) + Val(MyObject.PlasticPipes(p) + Val(MyObject.CopperPipes(c) + Val(MyObject.ChromePipes(ch)))))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Help and Support Form
        Form4.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Database Form
        Form3.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Clearing
        Me.Labour.Text = ""
        Me.Travel.Text = ""
        Me.PlasticPipes.Text = ""
        Me.ChromePipes.Text = ""
        Me.CopperPipes.Text = ""
        Me.VAT.Text = ""
        Me.OverallCost.Text = ""
        Me.Discount.Text = ""

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        'Closing application
    End Sub
End Class
