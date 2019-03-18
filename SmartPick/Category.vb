Public Class Category

    Private Sub CategoriesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CategoriesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MenuTTSDataSet1)
    End Sub

    Private Sub CategoriesBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles CategoriesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CategoriesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MenuTTSDataSet1)

    End Sub

    Private Sub Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MenuTTSDataSet1.Categories' Puede moverla o quitarla según sea necesario.
        Me.CategoriesTableAdapter.Fill(Me.MenuTTSDataSet1.Categories)
    End Sub

    Private Sub CategoriesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CategoriesDataGridView.CellContentClick
        Me.DataGridViewTextBoxColumn1.Visible = False
    End Sub
End Class