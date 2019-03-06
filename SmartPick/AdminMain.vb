Public Class AdminMain
    Private Sub AgregarPlatoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPlatoToolStripMenuItem.Click
        addMenu.Show()


    End Sub

    Private Sub EditarPlatoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarPlatoToolStripMenuItem.Click
        editMenu.Show()

    End Sub

    Private Sub EliminarPlatoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarPlatoToolStripMenuItem.Click
        DelMenu.Show()

    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriaToolStripMenuItem.Click
        Category.Show()
    End Sub

    Private Sub ModificarTipoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarTipoToolStripMenuItem.Click
        Tipo.Show()

    End Sub
End Class