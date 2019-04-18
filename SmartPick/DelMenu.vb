
Imports System.Data.SqlClient
Imports System.IO

Public Class DelMenu

    Dim Conn As New SqlClient.SqlConnection("Data Source=Desktop-Kbtk5sb;Initial Catalog=MenuTTS;Integrated Security=True")
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Carga el menu en el idioma Esp por default'
        Conn.Open()
        Dim menuTable As New DataTable
        Dim Command As New SqlCommand("Exec loadMenuGeneral;", Conn)
        Dim Adapter As New SqlDataAdapter(Command)
        Adapter.Fill(menuTable)
        DatagridMenu.DataSource = menuTable
        Conn.Close()


        Conn.Open()
        Dim menuTable2 As New DataTable
        Dim Command2 As New SqlCommand("Select CategorySpa from Categories;", Conn)
        Dim reader2 As SqlDataReader
        reader2 = Command2.ExecuteReader
        CombCate.Items.Clear()
        Do While reader2.Read
            CombCate.Items.Add(reader2.GetValue(0).ToString)
        Loop
        Conn.Close()


        Conn.Open()
        Dim menuTable3 As New DataTable
        Dim Command3 As New SqlCommand("Select TypeSpa from Types;", Conn)
        Dim reader3 As SqlDataReader
        reader3 = Command3.ExecuteReader
        CombComida.Items.Clear()
        Do While reader3.Read
            CombComida.Items.Add(reader3.GetValue(0).ToString)
        Loop
        Conn.Close()

    End Sub
End Class