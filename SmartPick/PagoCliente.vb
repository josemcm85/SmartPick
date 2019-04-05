Imports System.Data.SqlClient
Public Class PagoCliente
    Dim Conn As New SqlClient.SqlConnection("Data Source=ulatina.database.windows.net;Initial Catalog=MenuTTS;User ID=josemcm85;Password=Pass1234 ")
    Dim Sum As Integer = 0
    Dim Impuesto As Integer
    Dim Total As Integer


    Private Sub PagoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles Btn.Click
        Dim item As Integer = Convert.ToInt64(txtNoOrden.Text)

        Try
            Conn.Open()
            Dim Command2 As New SqlCommand("Select * from OrdenesCompletas where NoOrden=" & item & ";", Conn)
            Dim Adapter2 As SqlDataReader = Command2.ExecuteReader

            If Adapter2.HasRows Then
                TextBox1.Text = "Orden finalizada!"
            Else
                TextBox1.Text = "Orden Pendiente!"

            End If
            Conn.Close()
        Catch ex As Exception

            MsgBox("Numero de orden no encontrado")
        End Try

        Conn.Open()
        Dim menuTable As New DataTable
        Dim Command As New SqlCommand("Select * from Orden where Orden=" & item & ";", Conn)
        Dim Adapter As New SqlDataAdapter(Command)
        Adapter.Fill(menuTable)
        DTGList.DataSource = menuTable
        Conn.Close()



        For i As Integer = 0 To DTGList.Rows.Count() - 1 Step +1
            Sum = Sum + DTGList.Rows(i).Cells(4).Value
        Next

        Impuesto = Sum * 0.013
        Total = Sum + Impuesto

        txtPrecio.Text += Convert.ToString(Sum)
        txtDescuento.Text += "0%"
        txtImpuesto.Text += Convert.ToString(Impuesto)
        txtTotal.Text += Convert.ToString(Total)







    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim item As Integer = Convert.ToInt64(txtNoOrden.Text)

        Try
            Conn.Open()
            Dim Command2 As New SqlCommand("Select * from OrdenesCompletas where NoOrden=" & item & ";", Conn)
            Dim Adapter2 As SqlDataReader = Command2.ExecuteReader

            If Adapter2.HasRows Then
                TextBox1.Text = "Orden finalizada!"
            Else
                TextBox1.Text = "Orden Pendiente!"
            End If
            Conn.Close()
        Catch ex As Exception

            MsgBox("Numero de orden no encontrado")
        End Try
    End Sub

    Private Sub buttonValidateCpn_Click(sender As Object, e As EventArgs) Handles buttonValidateCpn.Click



        txtDescuento.Text = "Descuento ₡: "
        txtImpuesto.Text = "Impuestos ₡: "
        txtTotal.Text = "Total ₡: "



        Conn.Open()
        'Dim input = textboxCoupon.Text

        Dim cmd0 As New SqlCommand("Select * FROM dbo.Coupons WHERE Coupon =@CUPON", Conn)
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

            Dim appliedDiscount As Double
            Dim taxAfterDiscount As Double

            appliedDiscount = Sum * CDbl(discount) / 100
            taxAfterDiscount = (Sum - (Sum * CDbl(discount) / 100)) * 0.13

            lblPriceTotalDiscount.Text += Convert.ToString(Sum - appliedDiscount + taxAfterDiscount)
            lblSum.Text += Convert.ToString(Sum)
            txtDescuento.Text += Convert.ToString(appliedDiscount)
            txtImpuesto.Text += Convert.ToString(taxAfterDiscount)
            txtTotal.Text = Convert.ToString(Sum + taxAfterDiscount)

            textboxCoupon.Enabled = False
        Else

            MsgBox("Cupón no válido.")
            Conn.Close()
            Conn.Open()
        End If
    End Sub

    Private Sub txtDescuento_Click(sender As Object, e As EventArgs) Handles txtDescuento.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Conn.Open()
        Dim NoMesa As String
        Dim menuTable As New DataTable
        Dim Command As New SqlCommand("Select NoTable from ListaOrdenes where idOrden=" & txtNoOrden.Text & ";", Conn)
        Command.ExecuteNonQuery()
        Dim reader As SqlDataReader = Command.ExecuteReader()
        reader.Read()
        NoMesa = Convert.ToString(reader.GetString(0))
        reader.Close()
        MsgBox(NoMesa)


        Conn.Close()

        Conn.Open()
        Dim Command2 As New SqlCommand("exec addSoli '" & NoMesa & "','Pago de Cuenta';", Conn)
        Dim Adapter2 As SqlDataReader = Command2.ExecuteReader
        Conn.Close()

    End Sub
End Class