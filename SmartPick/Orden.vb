Imports System.Data.SqlClient
Imports System.IO
Public Class Orden
    Dim connectionString As String = "Data Source=ulatina.database.windows.net;Initial Catalog=MenuTTS;User ID=josemcm85;Password=Pass1234 "
    Dim connection As SqlConnection
    Dim NumeroOrden As Integer = 1
    Dim SourceTab As DataGridView = FormMenu.DataGridViewOrder
    Dim Target As DataGridView = Me.DTGList


    Private Sub Orden_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NoOrden.Text = NumeroOrden
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

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim Linea As Integer = 1
        Try
            connection = New SqlConnection(connectionString)
            connection.Open()
            Dim CreateOrder As New SqlCommand("Exec addOrden '" & NoOrden.Text & "','" & ComboMesa.SelectedItem.ToString & "','" & lblTotal.Text & "';", connection)
            Dim dataAdapter As New SqlDataAdapter(CreateOrder)
            CreateOrder.ExecuteNonQuery()
            connection.Close()



            Dim ListaOrder As New SqlCommand("Exec listaOrden @id,@linea,@Nombre,@Cant,@Precio ", connection)
            ListaOrder.Parameters.Add("@id", SqlDbType.Int)
            ListaOrder.Parameters.Add("@Linea", SqlDbType.Int)
            ListaOrder.Parameters.Add("@Nombre", SqlDbType.VarChar)
            ListaOrder.Parameters.Add("@Cant", SqlDbType.Int)
            ListaOrder.Parameters.Add("@Precio", SqlDbType.Float)

            connection.Open()
            ListaOrder.Connection = connection
            For i As Integer = 0 To DTGList.Rows.Count() - 1 Step +1
                ListaOrder.Parameters(0).Value = NoOrden.Text
                ListaOrder.Parameters(1).Value = Linea
                ListaOrder.Parameters(2).Value = DTGList.Rows(i).Cells(1).Value
                ListaOrder.Parameters(3).Value = DTGList.Rows(i).Cells(4).Value
                ListaOrder.Parameters(4).Value = DTGList.Rows(i).Cells(2).Value
                ListaOrder.ExecuteNonQuery()
                Linea = Linea + 1


            Next
            connection.Close()
            MsgBox("Orden Realizada!")
            NumeroOrden = NumeroOrden + 1
            Linea = 1


        Catch ex As Exception
            MsgBox(ex.Message)
            NumeroOrden = NumeroOrden

        End Try
    End Sub
End Class