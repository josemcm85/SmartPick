Public Class AdminMain

    Private Sub EditarPlatoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarPlatoToolStripMenuItem.Click
        Loading.Show()
        For index As Integer = 1 To 1000000
        Next
        editMenu.Show()
        Loading.Close()

    End Sub

    Private Sub EliminarPlatoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarPlatoToolStripMenuItem.Click
        Loading.Show()
        DelMenu.Show()
        Loading.Close()

    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriaToolStripMenuItem.Click
        Category.Show()
    End Sub

    Private Sub ModificarTipoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarTipoToolStripMenuItem.Click

        Tipo.Show()

    End Sub

    Private Sub AgregarEliminarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarEliminarUsuarioToolStripMenuItem.Click

        FormAddUser.Show()

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub AgregarPlatoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPlatoToolStripMenuItem.Click
        Loading.Show()

        addMenu.Show()

        Loading.Close()
    End Sub

    Private Sub CrearCuponesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearCuponesToolStripMenuItem.Click

        FormCoupons.Show()

    End Sub
End Class