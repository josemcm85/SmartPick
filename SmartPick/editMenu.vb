﻿Imports System.Data.SqlClient
Imports System.IO

Public Class editMenu
    Dim Conn As New SqlClient.SqlConnection("Data Source=ulatina.database.windows.net;Initial Catalog=MenuTTS;User ID=josemcm85;Password=Pass1234 ")
    Dim Objeto As String
    Dim item As String
    Dim RowIndex As Integer

    Private Sub editMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn.Open()
        Dim menuTable As New DataTable
        Dim Command As New SqlCommand("Exec loadMenuGeneral;", Conn)
        Dim Adapter As New SqlDataAdapter(Command)
        Adapter.Fill(menuTable)
        DataGridMenu.DataSource = menuTable

        Conn.Close()

    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click

        Dim Salir As Integer

        Salir = 0


        If txtrandom.Text = Nothing Or txtNombre.Text = Nothing Or TxtDesEsp.Text = Nothing Or txtDesIng.Text = Nothing Or txtPrecio.Text = Nothing Or txtCal.Text = Nothing Or CombCate.SelectedItem.ToString = Nothing Or CombComida.SelectedItem.ToString = Nothing Or PicBox.Image Is Nothing Or txtNombreIng.Text = Nothing Then

            MsgBox("Verifique que los espacios no esten vacios!")
        Else

            Try


                If Salir = 0 Then
                    Try

                        Conn.Open()
                        Dim Table As New DataTable
                        Dim Command As New SqlCommand("Exec EditPlato '" & txtrandom.Text & "','" & txtNombre.Text & "','" & TxtDesEsp.Text & "','" & CombCate.SelectedItem.ToString & "','" & CombComida.SelectedItem.ToString & "','" & txtPrecio.Text & "','" & txtCal.Text & "','" & txtDesIng.Text & "','" & txtNombreIng.Text & "';", Conn)
                        Dim Adapter As New SqlDataAdapter(Command)
                        Adapter.Fill(Table)
                        DatagridMenu.DataSource = Table
                        Conn.Close()
                        Salir = Salir + 1

                    Catch ex As Exception

                        MsgBox("Error en editar los platos")

                    End Try

                End If

                If Salir = 1 Then

                    Try
                        Dim Command As New SqlCommand("Update FotosMenu set Nombre=@Nom, Foto=@Foto where CodPlato=@Cod", Conn)
                        Dim ms As New MemoryStream
                        PicBox.Image.Save(ms, PicBox.Image.RawFormat)
                        Command.Parameters.Add("@Cod", SqlDbType.VarChar).Value = txtrandom.Text
                        Command.Parameters.Add("@Nom", SqlDbType.VarChar).Value = txtNombre.Text
                        Command.Parameters.Add("@Foto", SqlDbType.Image).Value = ms.ToArray()

                        Conn.Open()

                        If Command.ExecuteNonQuery() = 1 Then

                        Else
                            MsgBox("Error en editar imagen")

                        End If

                        Conn.Close()


                    Catch ex As Exception

                    End Try

                End If

                MsgBox("Datos guardados con éxito!")

            Catch ex As Exception

                MsgBox("Error en guardar los datos")

            End Try

        End If


        Conn.Open()
        Dim menuTable2 As New DataTable
        Dim Command2 As New SqlCommand("Exec loadMenuGeneral;", Conn)
        Dim Adapter2 As New SqlDataAdapter(Command2)
        Adapter2.Fill(menuTable2)
        DatagridMenu.DataSource = menuTable2
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

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            With OpenFileDialog1.Filter = ("Images |*.png;*.bmp;*.jpg;*.jpeg;*.gif;*.ico;")

            End With

            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                PicBox.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnDespejar.Click
        txtrandom.Text = Nothing
        txtNombre.Text = Nothing
        TxtDesEsp.Text = Nothing
        txtDesIng.Text = Nothing
        txtPrecio.Text = Nothing
        txtCal.Text = Nothing
        CombCate.Text = ""
        CombComida.Text = ""
        PicBox.Image = Nothing
        txtNombreIng.Text = ""
    End Sub
End Class