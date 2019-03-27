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

    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub BunifuCustomTextbox1_TextChanged(sender As Object, e As EventArgs) Handles textboxCoupon.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles buttonValidateCpn.Click


        Dim sqlConn = New SqlConnection(connectionString)
        sqlConn.Open()


        Dim Sum As Integer = 0
        For i As Integer = 0 To DTGList.Rows.Count() - 1 Step +1
            Sum = Sum + DTGList.Rows(i).Cells(2).Value
        Next


        'Dim input = textboxCoupon.Text

        Dim cmd0 As New SqlCommand("Select * FROM dbo.Coupons WHERE Coupon =@CUPON", sqlConn)
        cmd0.Parameters.AddWithValue("@CUPON", SqlDbType.NChar).Value = textboxCoupon.Text

        Dim adapter As New SqlDataAdapter(cmd0)

        Dim table As New DataTable()

        adapter.Fill(table)

        Dim discount As String

        Dim reader0 As SqlDataReader = cmd0.ExecuteReader()
        If (reader0.HasRows) Then

            'TextBoxPrueba.Text = table.Rows(0)(1).ToString()

            discount = table.Rows(0)(1).ToString()
            MsgBox("Se aplicará un descuento del " + discount + " %.")

            lblNotice.Visible = True
            lblPriceTotalDiscount.Visible = True
            lblSum.Visible = True
            lblTax.Visible = True
            lblDiscount.Visible = True
            Label4.Visible = False
            Label6.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            lblTotal.Visible = False

            Dim appliedDiscount As Double
            Dim taxAfterDiscount As Double

            appliedDiscount = Sum * CDbl(discount) / 100
            taxAfterDiscount = (Sum - (Sum * CDbl(discount) / 100)) * 0.13

            lblPriceTotalDiscount.Text = Sum - appliedDiscount + taxAfterDiscount
            lblSum.Text = Sum
            lblDiscount.Text = appliedDiscount
            lblTax.Text = taxAfterDiscount

            textboxCoupon.Enabled = False
        Else

            MsgBox("Cupón no válido.")
            sqlConn.Close()
            sqlConn.Open()
        End If

    End Sub

    Private Sub NoOrden_Click(sender As Object, e As EventArgs) Handles NoOrden.Click

    End Sub
End Class