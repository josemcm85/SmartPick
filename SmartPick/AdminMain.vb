Public Class AdminMain

    Private Sub EditarPlatoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarPlatoToolStripMenuItem.Click

        For index As Integer = 1 To 1000000
        Next
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

    Private Sub AgregarEliminarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs)

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

    Private Sub OrdenesToolStripMenuItem_Click(sender As Object, e As EventArgs)

        FormOrderDetails.Show()


    End Sub

    Private Sub AdministrarOrdenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarOrdenesToolStripMenuItem.Click

    End Sub

    Private Sub AdministrarPersonalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarPersonalToolStripMenuItem.Click
        FormAddUser.Show()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Me.Close()

        FormLogin.Show()

        FormLogin.txtUser.Text = Nothing
        FormLogin.txtPass.Text = Nothing
    End Sub

    Private Sub VerSolicitudesDePersonalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerSolicitudesDePersonalToolStripMenuItem.Click
        ListaDellamadas.Show()

    End Sub

    Private Sub SatisfacciónAlClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SatisfacciónAlClienteToolStripMenuItem.Click
        AdminCustomerSatisfaction.Show()
    End Sub

    Private Sub AdministrarOrdenesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AdministrarOrdenesToolStripMenuItem1.Click
        FormOrderDetails.Show()
    End Sub

    Private Sub ReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteToolStripMenuItem.Click

        FormReport.Show()


    End Sub
End Class