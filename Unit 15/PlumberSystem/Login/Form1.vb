Public Class Form1



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_Password.Text = "1" Or txt_Username.Text = "Usman" Then
            Form2.Show()
        Else
            MsgBox("Username and Password do not match")

            Dim conn As New System.Data.OleDb.OleDbConnection()
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LibraryManagementSystem.accdb"

        End If

        Dim con As New OleDb.OleDbConnection
        Dim dbProvider As String
        Dim dbSource As String
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim sql As String

        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dbSource = "Data Source = Z:/COLLEGE/Database.mdb"

        con.ConnectionString = dbProvider & dbSource

        con.Open()
        sql = "SELECT * FROM tblContacts"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Database")


    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        'User clicking on cancel button only clears field
        ' and refocus to first field
        txt_Username.Text = ""
        txt_Password.Text = ""
        txt_Username.Focus()
    End Sub

End Class
