Public Class Form3

    Private customerDatabase As Dictionary(Of Integer, Customer)

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        customerDatabase = New Dictionary(Of Integer, Customer)
    End Sub

    
    Public Sub AddStudent(ByVal IDNumber As Integer, ByVal student As Customer)

        If (customerDatabase.ContainsKey(IDNumber)) Then
            Dim studentToCheck As Customer = customerDatabase.Item(IDNumber)
            Dim msgboxResult As DialogResult

            msgboxResult = MessageBox.Show("That ID Number already exists! It belongs to: " & studentToCheck.FirstName & " " & _
                                           studentToCheck.LastName & "Would you like to replace this student?", _
                                           "Replace?", MessageBoxButtons.YesNo)
            If (msgboxResult = Windows.Forms.DialogResult.Yes) Then
                'Replace the student
                customerDatabase.Remove(IDNumber)
                customerDatabase.Add(IDNumber, student)
            End If

        Else
            customerDatabase.Add(IDNumber, student)
        End If
        RefreshListbox()
    End Sub

    Public Sub DeleteStudent(ByVal IDNumber As Integer)
        customerDatabase.Remove(IDNumber)
        RefreshListbox()
    End Sub

    Public Sub RefreshListbox()
        lst_customers.Items.Clear()
        '1000000: Student Jon
        For Each id As Integer In customerDatabase.Keys
            Dim customer As Customer = customerDatabase.Item(id)

            lst_customers.Items.Add(id & ": " & customer.FirstName & " " & customer.LastName & ", Job Type: " & customer.jobtype & ", Amount: £" & customer.amountmoney & " ")

        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.txt_job.Text = " "
        Me.txt_studentFirstName.Text = " "
        Me.txt_studentID.Text = " "
        Me.txt_studentLastName.Text = " "
        Me.txt_amountmoney.Text = " "

    End Sub


    

    Private Sub btn_add_Click_1(sender As Object, e As EventArgs) Handles btn_add.Click
        For Each c As Control In GroupBox1.Controls
            If (TypeOf c Is TextBox) Then
                Dim cText As TextBox = CType(c, TextBox)
                If (cText.Text.Equals("")) Then
                    MsgBox("all fields must be filled!")
                    Return
                End If
            End If
        Next

        'Continuation of sub
        If (btn_add.Text.Equals("Add Student")) Then
            Dim customertoAdd As New Customer(txt_studentFirstName.Text, txt_studentLastName.Text, txt_job.Text, txt_amountmoney.Text)
            AddStudent(CInt(txt_studentID.Text), customertoAdd)

        End If
    End Sub

    Private Sub btn_edit_Click_1(sender As Object, e As EventArgs) Handles btn_edit.Click
        '45455: Tony Lyon (Teacher)
        If Not (lst_customers.SelectedItem Is Nothing) Then
            Dim StudentInformation As String = lst_customers.SelectedItem.ToString
            txt_studentID.Text = StudentInformation.Split(":")(0).ToString

            txt_studentFirstName.Text = StudentInformation.Split(":")(1).Split(" ")(1).ToString
            txt_studentLastName.Text = StudentInformation.Split(":")(1).Split(" ")(2).ToString
            Dim Job As String = StudentInformation.Split(":")(1).Split(" ")(3).ToString
            Job = Job.Replace("(", "")
            Job = Job.Replace(")", "")
            txt_job.Text = Job
        End If
    End Sub

    Private Sub btn_delete_Click_1(sender As Object, e As EventArgs) Handles btn_delete.Click
        If Not (lst_customers.SelectedItem Is Nothing) Then
            Dim StudentInformation As String = lst_customers.SelectedItem.ToString
            Dim studentID As Integer = CInt(StudentInformation.Split(":")(0))
            DeleteStudent(studentID)
        End If
    End Sub

    Private Sub Print_Click(sender As Object, e As EventArgs) Handles Print.Click
        PrintForm3.Print()
    End Sub
End Class
