
Imports System.Data.SqlClient
Imports System.IO

Public Class DelMenu

    Dim Conn As New SqlClient.SqlConnection("Data Source=ulatina.database.windows.net;Initial Catalog=MenuTTS;User ID=josemcm85;Password=Pass1234 ")
    Dim Objeto As String
    Dim item As String
    Dim RowIndex As Integer

    Private Sub DelMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn.Open()
        Dim menuTable As New DataTable
        Dim Command As New SqlCommand("Exec loadMenuGeneral;", Conn)
        Dim Adapter As New SqlDataAdapter(Command)
        Adapter.Fill(menuTable)
        DatagridMenu.DataSource = menuTable

        Conn.Close()
    End Sub

    Private Sub DatagridMenu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatagridMenu.CellContentClick
        RowIndex = e.RowIndex

        Dim row As DataGridViewRow = DatagridMenu.Rows(RowIndex)
        item = row.Cells(0).Value

        MsgBox("Plato seleccionado: " & row.Cells(1).Value)
        txtrandom.Text = item

        txtNombre.Text = row.Cells(1).Value
        txtNombreIng.Text = row.Cells(2).Value
        TxtDesEsp.Text = row.Cells(3).Value
        txtDesIng.Text = row.Cells(4).Value
        CombCate.Text = row.Cells(5).Value
        CombComida.Text = row.Cells(6).Value
        txtPrecio.Text = row.Cells(7).Value
        txtCal.Text = row.Cells(8).Value

        'Pasa el mapa de Bytes a una imagen 
        Dim Bytes As [Byte]() = row.Cells(9).Value
        Dim ms As New MemoryStream(Bytes)
        PicBox.Image = Image.FromStream(ms)
    End Sub


    Private Sub BtnEliminar_Click_1(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        Select Case MsgBox("Seguro?", MsgBoxStyle.YesNo, "Eliminar Elemento")
            Case MsgBoxResult.Yes
                MessageBox.Show("Datos Eliminados!")
                Try

                    Conn.Open()
                    Dim Table As New DataTable
                    Dim Command As New SqlCommand("Delete from MenuEsp where CodPlato = '" & txtrandom.Text & "';", Conn)
                    Dim Adapter As New SqlDataAdapter(Command)
                    Adapter.Fill(Table)
                    Conn.Close()

                    Conn.Open()
                    Dim menuTable As New DataTable
                    Dim Command2 As New SqlCommand("Exec loadMenuGeneral;", Conn)
                    Dim Adapter2 As New SqlDataAdapter(Command2)
                    Adapter2.Fill(menuTable)
                    DatagridMenu.DataSource = menuTable

                    Conn.Close()

                Catch ex As Exception

                    MsgBox("Error al borrar")
                End Try

            Case MsgBoxResult.No
                Conn.Open()
                Dim menuTable2 As New DataTable
                Dim Command3 As New SqlCommand("Exec loadMenuGeneral;", Conn)
                Dim Adapter3 As New SqlDataAdapter(Command3)
                Adapter3.Fill(menuTable2)
                DatagridMenu.DataSource = menuTable2

                Conn.Close()

        End Select


    End Sub

    Private Sub BtnClose2_Click_1(sender As Object, e As EventArgs) Handles BtnClose2.Click

        Me.Close()

    End Sub
End Class