<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.lst_customers = New System.Windows.Forms.ListBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_amountmoney = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_job = New System.Windows.Forms.TextBox()
        Me.lbl_job = New System.Windows.Forms.Label()
        Me.txt_studentLastName = New System.Windows.Forms.TextBox()
        Me.lbl_studentLastName = New System.Windows.Forms.Label()
        Me.txt_studentID = New System.Windows.Forms.TextBox()
        Me.txt_studentFirstName = New System.Windows.Forms.TextBox()
        Me.lbl_studentFirstName = New System.Windows.Forms.Label()
        Me.lbl_studentID = New System.Windows.Forms.Label()
        Me.PrintForm3 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Print = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 152)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(24, 321)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(155, 23)
        Me.btn_edit.TabIndex = 22
        Me.btn_edit.Text = "Edit Student"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(346, 321)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(155, 23)
        Me.btn_delete.TabIndex = 21
        Me.btn_delete.Text = "Delete Student"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'lst_customers
        '
        Me.lst_customers.FormattingEnabled = True
        Me.lst_customers.Location = New System.Drawing.Point(29, 181)
        Me.lst_customers.Name = "lst_customers"
        Me.lst_customers.Size = New System.Drawing.Size(472, 134)
        Me.lst_customers.TabIndex = 20
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(346, 146)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(155, 23)
        Me.btn_add.TabIndex = 19
        Me.btn_add.Text = "Add Student"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_amountmoney)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_job)
        Me.GroupBox1.Controls.Add(Me.lbl_job)
        Me.GroupBox1.Controls.Add(Me.txt_studentLastName)
        Me.GroupBox1.Controls.Add(Me.lbl_studentLastName)
        Me.GroupBox1.Controls.Add(Me.txt_studentID)
        Me.GroupBox1.Controls.Add(Me.txt_studentFirstName)
        Me.GroupBox1.Controls.Add(Me.lbl_studentFirstName)
        Me.GroupBox1.Controls.Add(Me.lbl_studentID)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(477, 134)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Information"
        '
        'txt_amountmoney
        '
        Me.txt_amountmoney.Location = New System.Drawing.Point(101, 109)
        Me.txt_amountmoney.Name = "txt_amountmoney"
        Me.txt_amountmoney.Size = New System.Drawing.Size(65, 20)
        Me.txt_amountmoney.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Amount money"
        '
        'txt_job
        '
        Me.txt_job.Location = New System.Drawing.Point(101, 87)
        Me.txt_job.Name = "txt_job"
        Me.txt_job.Size = New System.Drawing.Size(365, 20)
        Me.txt_job.TabIndex = 8
        '
        'lbl_job
        '
        Me.lbl_job.AutoSize = True
        Me.lbl_job.Location = New System.Drawing.Point(71, 90)
        Me.lbl_job.Name = "lbl_job"
        Me.lbl_job.Size = New System.Drawing.Size(24, 13)
        Me.lbl_job.TabIndex = 7
        Me.lbl_job.Text = "Job"
        '
        'txt_studentLastName
        '
        Me.txt_studentLastName.Location = New System.Drawing.Point(101, 68)
        Me.txt_studentLastName.Name = "txt_studentLastName"
        Me.txt_studentLastName.Size = New System.Drawing.Size(365, 20)
        Me.txt_studentLastName.TabIndex = 6
        '
        'lbl_studentLastName
        '
        Me.lbl_studentLastName.AutoSize = True
        Me.lbl_studentLastName.Location = New System.Drawing.Point(37, 71)
        Me.lbl_studentLastName.Name = "lbl_studentLastName"
        Me.lbl_studentLastName.Size = New System.Drawing.Size(58, 13)
        Me.lbl_studentLastName.TabIndex = 5
        Me.lbl_studentLastName.Text = "Last Name"
        '
        'txt_studentID
        '
        Me.txt_studentID.Location = New System.Drawing.Point(101, 19)
        Me.txt_studentID.Name = "txt_studentID"
        Me.txt_studentID.Size = New System.Drawing.Size(365, 20)
        Me.txt_studentID.TabIndex = 3
        '
        'txt_studentFirstName
        '
        Me.txt_studentFirstName.Location = New System.Drawing.Point(101, 45)
        Me.txt_studentFirstName.Name = "txt_studentFirstName"
        Me.txt_studentFirstName.Size = New System.Drawing.Size(365, 20)
        Me.txt_studentFirstName.TabIndex = 2
        '
        'lbl_studentFirstName
        '
        Me.lbl_studentFirstName.AutoSize = True
        Me.lbl_studentFirstName.Location = New System.Drawing.Point(20, 52)
        Me.lbl_studentFirstName.Name = "lbl_studentFirstName"
        Me.lbl_studentFirstName.Size = New System.Drawing.Size(82, 13)
        Me.lbl_studentFirstName.TabIndex = 0
        Me.lbl_studentFirstName.Text = "Customer Name"
        '
        'lbl_studentID
        '
        Me.lbl_studentID.AutoSize = True
        Me.lbl_studentID.Location = New System.Drawing.Point(34, 26)
        Me.lbl_studentID.Name = "lbl_studentID"
        Me.lbl_studentID.Size = New System.Drawing.Size(68, 13)
        Me.lbl_studentID.TabIndex = 1
        Me.lbl_studentID.Text = "Customer ID:"
        '
        'PrintForm3
        '
        Me.PrintForm3.DocumentName = "document"
        Me.PrintForm3.Form = Me
        Me.PrintForm3.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm3.PrinterSettings = CType(resources.GetObject("PrintForm3.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm3.PrintFileName = Nothing
        '
        'Print
        '
        Me.Print.Location = New System.Drawing.Point(220, 337)
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(64, 23)
        Me.Print.TabIndex = 24
        Me.Print.Text = "Print"
        Me.Print.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 372)
        Me.Controls.Add(Me.Print)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.lst_customers)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents lst_customers As System.Windows.Forms.ListBox
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_amountmoney As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_job As System.Windows.Forms.TextBox
    Friend WithEvents lbl_job As System.Windows.Forms.Label
    Friend WithEvents txt_studentLastName As System.Windows.Forms.TextBox
    Friend WithEvents lbl_studentLastName As System.Windows.Forms.Label
    Friend WithEvents txt_studentID As System.Windows.Forms.TextBox
    Friend WithEvents txt_studentFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lbl_studentFirstName As System.Windows.Forms.Label
    Friend WithEvents lbl_studentID As System.Windows.Forms.Label
    Friend WithEvents PrintForm3 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents Print As System.Windows.Forms.Button
End Class
