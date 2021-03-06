﻿Imports System.Data.SqlClient
Imports System.IO
Public Class Orden
    Dim connectionString As String = "Data Source=Desktop-Kbtk5sb;Initial Catalog=MenuTTS;Integrated Security=True"
    Dim connection As SqlConnection
    Dim NumeroOrden As Integer = 1
    Dim SourceTab As DataGridView = FormMenu.DataGridViewOrder
    Dim Target As DataGridView = Me.DTGList


    Private Sub Orden_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If FormMenu.ButtonAppetizer.Text.Equals("Appetizers") Then
            Label1.Text = "Table"
            Label11.Text = "Details"
            Label4.Text = "Total price (ATI):"
            Label3.Text = "Price ₡:"
            BunifuFlatButton1.Text = "COMPLETE"
            Button1.Text = "BACK"
            Label10.Text = "ORDER"
        End If




        Me.lblTotal.Text = FormMenu.LblTotal.Text

        'lblTotal.Text = (From row As DataGridViewRow In DTGList.Rows Where row.Cells(1).FormattedValue.ToString() <> String.Empty Select Convert.ToInt32(row.Cells(1).FormattedValue)).Sum().ToString()

        Dim Sum As Integer = 0
        For i As Integer = 0 To DTGList.Rows.Count() - 1 Step +1
            Sum = Sum + DTGList.Rows(i).Cells(2).Value
        Next
        lblTotal.Text = (Sum + (Sum * 0.13)).ToString()

        Try
            connection = New SqlConnection(connectionString)
            connection.Open()

            Dim Filtro As New DataTable
            Dim commandFilter As New SqlCommand("Select Mesa from ResTables;", connection)
            Dim Reader As SqlDataReader = commandFilter.ExecuteReader()

            While Reader.Read()

                ComboMesa.Items.Add(Reader.GetString(0))

            End While

            connection.Close()


        Catch ex As Exception

            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub DTGList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGList.CellContentClick

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs)
        Dim Linea As Integer = 1
        Try
            connection = New SqlConnection(connectionString)
            connection.Open()
            Dim CreateOrder As New SqlCommand("Exec addOrden '" & ComboMesa.SelectedItem.ToString & "','" & lblTotal.Text & "';", connection)
            Dim dataAdapter As New SqlDataAdapter(CreateOrder)
            CreateOrder.ExecuteNonQuery()

            Dim LastOrderId As New SqlCommand("SELECT IDENT_CURRENT('ListaOrdenes')", connection)

            LastOrderId.ExecuteNonQuery()
            Dim reader As SqlDataReader = LastOrderId.ExecuteReader()

            reader.Read()
            Dim idLastOrder As Integer
            idLastOrder = Integer.Parse(reader.GetDecimal(0))

            reader.Close()

            Dim ListaOrder As New SqlCommand("Exec listaOrden @id,@Nombre,@Cant,@Precio ", connection)
            ListaOrder.Parameters.Add("@id", SqlDbType.Int)
            ListaOrder.Parameters.Add("@Nombre", SqlDbType.VarChar)
            ListaOrder.Parameters.Add("@Cant", SqlDbType.Int)
            ListaOrder.Parameters.Add("@Precio", SqlDbType.Float)

            ListaOrder.Connection = connection



            For i As Integer = 0 To DTGList.Rows.Count() - 1 Step +1
                ListaOrder.Parameters(0).Value = idLastOrder
                ListaOrder.Parameters(1).Value = DTGList.Rows(i).Cells(1).Value
                ListaOrder.Parameters(2).Value = Integer.Parse(DTGList.Rows(i).Cells(4).Value)
                ListaOrder.Parameters(3).Value = Double.Parse(DTGList.Rows(i).Cells(2).Value)
                ListaOrder.ExecuteNonQuery()



            Next
            connection.Close()
            MsgBox("Orden Realizada!")



        Catch ex As Exception
            MsgBox(ex.Message)
            NumeroOrden = NumeroOrden

        End Try
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim Linea As Integer = 1

        If ComboMesa.Text = "" Then
            If FormMenu.ButtonAppetizer.Text.Equals("Appetizers") Then
                MsgBox("Please select your table!")
            Else
                MsgBox("Por favor selecciona tu mesa!")
            End If

        Else

            Try
                connection = New SqlConnection(connectionString)
                connection.Open()
                Dim CreateOrder As New SqlCommand("Exec addOrden '" & ComboMesa.SelectedItem.ToString & "','" & lblTotal.Text & "';", connection)
                Dim dataAdapter As New SqlDataAdapter(CreateOrder)
                CreateOrder.ExecuteNonQuery()

                Dim LastOrderId As New SqlCommand("SELECT IDENT_CURRENT('ListaOrdenes')", connection)

                LastOrderId.ExecuteNonQuery()
                Dim reader As SqlDataReader = LastOrderId.ExecuteReader()

                reader.Read()
                Dim idLastOrder As Integer
                idLastOrder = Integer.Parse(reader.GetDecimal(0))

                reader.Close()

                Dim ListaOrder As New SqlCommand("Exec listaOrden @id,@Nombre,@Cant,@Precio ", connection)
                ListaOrder.Parameters.Add("@id", SqlDbType.Int)
                ListaOrder.Parameters.Add("@Nombre", SqlDbType.VarChar)
                ListaOrder.Parameters.Add("@Cant", SqlDbType.Int)
                ListaOrder.Parameters.Add("@Precio", SqlDbType.Float)

                ListaOrder.Connection = connection



                For i As Integer = 0 To DTGList.Rows.Count() - 1 Step +1
                    ListaOrder.Parameters(0).Value = idLastOrder
                    ListaOrder.Parameters(1).Value = DTGList.Rows(i).Cells(1).Value
                    ListaOrder.Parameters(2).Value = Integer.Parse(DTGList.Rows(i).Cells(4).Value)
                    ListaOrder.Parameters(3).Value = Double.Parse(DTGList.Rows(i).Cells(2).Value)
                    ListaOrder.ExecuteNonQuery()



                Next
                connection.Close()

                If FormMenu.ButtonAppetizer.Text.Equals("Appetizers") Then
                    MsgBox("Order placed, your order number is: " & idLastOrder)
                Else
                    MsgBox("Orden Realizada, tu número de orden es: " & idLastOrder)

                End If
                PagoCliente.txtNoOrden.Text = idLastOrder
                FormCustomerSatisfaction.txtNoOrden.Text = idLastOrder


                FormMenu.DataGridViewMenu.DataSource = DBNull.Value
                FormMenu.DataGridViewDescription.DataSource = DBNull.Value
                FormMenu.DataGridViewOrder.Rows.Clear()
                FormMenu.PictureBoxItem.Image = Nothing
                FormMenu.TextBoxSum.Text = Nothing


            Catch ex As Exception
                MsgBox(ex.Message)
                NumeroOrden = NumeroOrden

            End Try

        End If




    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs)
        CallMesero.Show()

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub BunifuImageButton_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
        CallMesero.Show()

    End Sub
End Class