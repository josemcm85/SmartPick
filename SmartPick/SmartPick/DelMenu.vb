
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Public Class DelMenu

    Dim Conn As New SqlClient.SqlConnection("Server= DESKTOP-4K5GMDN\PROGRA;Database=MenuTTS; Integrated Security= true")
    Dim Objeto As String
    Dim item As String
    Dim RowIndex As Integer

    Private Sub DelMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn.Open()
        Dim menuTable As New DataTable
        Dim Command As New SqlCommand("Exec loadMenuEsp;", Conn)
        Dim Adapter As New SqlDataAdapter(Command)
        Adapter.Fill(menuTable)
        DatagridMenu.DataSource = menuTable

        Conn.Close()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click



        Select Case MsgBox("Seguro?", MsgBoxStyle.YesNoCancel, "Eliminar Elemento")
            Case MsgBoxResult.Yes
                MessageBox.Show("Datos Eliminados!")
                Try

                    Conn.Open()
                    Dim Table As New DataTable
                    Dim Command As New SqlCommand("Delete from MenuEsp where CodPlato = '" & txtrandom.Text & "';", Conn)
                    Dim Adapter As New SqlDataAdapter(Command)
                    Adapter.Fill(Table)
                    Conn.Close()

                Catch ex As Exception

                    MsgBox("Error al borrar")
                End Try


            Case MsgBoxResult.Cancel
                MessageBox.Show("Cancel button")
            Case MsgBoxResult.No
                MessageBox.Show("NO button")
        End Select







    End Sub

    Private Sub DatagridMenu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatagridMenu.CellContentClick
        RowIndex = e.RowIndex

        Dim row As DataGridViewRow = DatagridMenu.Rows(RowIndex)
        item = row.Cells(0).Value

        MsgBox("Item Seleccionado: " & row.Cells(1).Value)
        txtrandom.Text = item

        txtNombre.Text = row.Cells(1).Value
        TxtDesEsp.Text = row.Cells(2).Value
        CombCate.Text = row.Cells(3).Value
        CombComida.Text = row.Cells(4).Value
        txtPrecio.Text = row.Cells(5).Value
        txtCal.Text = row.Cells(6).Value
        Dim Bytes As [Byte]() = row.Cells(7).Value
        Dim ms As New MemoryStream(Bytes)
        PicBox.Image = Image.FromStream(ms)
        txtDesIng.Text = row.Cells(8).Value
    End Sub

    Private Sub BtnOkload_Click(sender As Object, e As EventArgs) Handles BtnOkload.Click
        If selecIdiom.SelectedItem.ToString = "Español" Then


            Conn.Open()
            Dim menuTable As New DataTable
            Dim Command As New SqlCommand("Exec loadMenuEsp;", Conn)
            Dim Adapter As New SqlDataAdapter(Command)
            Adapter.Fill(menuTable)
            DatagridMenu.DataSource = menuTable

            Conn.Close()
        ElseIf selecIdiom.SelectedItem.ToString = "Inglés" Then

            Conn.Open()
            Dim menuTable As New DataTable
            Dim Command As New SqlCommand("Exec loadMenuIng;", Conn)
            Dim Adapter As New SqlDataAdapter(Command)
            Adapter.Fill(menuTable)
            DatagridMenu.DataSource = menuTable

            Conn.Close()

        End If
    End Sub
End Class