Public Class Tipo
    Private Sub TypesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TypesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TypesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MenuTTSDataSet1)

    End Sub

    Private Sub Tipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MenuTTSDataSetCate1.Categories' Puede moverla o quitarla según sea necesario.
        Me.CategoriesTableAdapter.Fill(Me.MenuTTSDataSetCate1.Categories)
        'TODO: esta línea de código carga datos en la tabla 'MenuTTSDataSet1.Types' Puede moverla o quitarla según sea necesario.
        Me.TypesTableAdapter.Fill(Me.MenuTTSDataSet1.Types)

    End Sub
End Class