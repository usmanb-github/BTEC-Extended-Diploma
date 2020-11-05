<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help_and_Support
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.New_Program.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(207, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(373, 230)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(239, 247)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Each step would show you how the whole program works"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(348, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Step 1: Enter username and password to use Pete’s plumbing password."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Step 2: Fill in the fields that are required"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 318)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(283, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Step 3: Fill in the labour, then how many hours are required"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 343)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(481, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Step 4: Enter a number for the travel. You have to fill in all of the fields, so " & _
    "that you can move forward"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 370)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(449, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Step 5: Once all of the fields are complete, click the calculate button to do all" & _
    " the calculations."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 400)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(466, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Step 6: If any errors are displayed, or any missing fields, you have to go back a" & _
    "nd complete them. "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 429)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(218, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Step 7: The grand total of it will be displayed."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 457)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(713, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Step 8: You will be referred to a Microsoft Excel spreadsheet, and this would be " & _
    "a completion of what you have entered. You can save the document. "
        '
        'Help_and_Support
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 577)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Help_and_Support"
        Me.Text = "Help_and_Support"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
