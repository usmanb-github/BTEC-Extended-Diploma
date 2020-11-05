Public Class Form5

    Private Sub TblContactsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblContactsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblContactsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.tblContacts' table. You can move, or remove it, as needed.
        Me.TblContactsTableAdapter.Fill(Me.DatabaseDataSet.tblContacts)

    End Sub
End Class