Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
        MsgBox("Database is now open")
        con.Close()
        MsgBox("Database is now closed")

        txtFirstName.Text = ds.Tables("Database").Rows(0).Item(1)
        txtSurname.Text = ds.Tables("Database").Rows(0).Item(2)
    End Sub
End Class