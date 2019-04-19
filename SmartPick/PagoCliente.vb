Imports System.Data.SqlClient
Public Class PagoCliente
    Dim Conn As New SqlClient.SqlConnection("Data Source=Desktop-Kbtk5sb;Initial Catalog=MenuTTS;Integrated Security=True")
    Dim Sum As Integer = 0
    Dim Impuesto As Integer
    Dim Total As Integer


    Private Sub PagoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FormMenu.ButtonAppetizer.Text.Equals("Appetizers") Then
            Label1.Text = "Please wait until your order is finished."
            Label3.Text = "Please enter your order number."
            Label2.Text = "Order status."
            Label4.Text = "Coupons."
            lblNotice.Text = "Summary"
            txtDescuento.Text = "Price ₡:"
            txtDescuento.Text = "Discount ₡:"
            txtImpuesto.Text = "Tax ₡:"
            txtTotal.Text = "Total"
            buttonValidateCpn.Text = "Validate"
            Button1.Text = "Pay"
            btnClose.Text = "Close"
        End If

    End Sub

    Private Sub Btn_Click(sender As Object, e As EventArgs)
        Dim item As Integer = Convert.ToInt64(txtNoOrden.Text)

        Try
            Conn.Open()
            Dim Command2 As New SqlCommand("Select * from OrdenesCompletas where NoOrden=" & item & ";", Conn)
            Dim Adapter2 As SqlDataReader = Command2.ExecuteReader

            If Adapter2.HasRows Then
                If FormMenu.ButtonAppetizer.Text.Equals("Appetizers") Then
                    TextBox1.Text = "Order finalized!"
                Else
                    TextBox1.Text = "Orden finalizada!"
                End If
            Else
                If FormMenu.ButtonAppetizer.Text.Equals("Appetizers") Then
                    TextBox1.Text = "Pending order!"
                Else
                    TextBox1.Text = "Orden Pendiente!"
                End If

            End If
            Conn.Close()
        Catch ex As Exception

            If FormMenu.ButtonAppetizer.Text.Equals("Appetizers") Then
                MsgBox("Order number not found")
            Else
                MsgBox("Numero de orden no encontrado")
            End If
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



        Btn.Enabled = False



    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim item As Integer = Convert.ToInt64(txtNoOrden.Text)

        Try
            Conn.Open()
            Dim Command2 As New SqlCommand("Select * from OrdenesCompletas where NoOrden=" & item & ";", Conn)
            Dim Adapter2 As SqlDataReader = Command2.ExecuteReader

            If Adapter2.HasRows Then
                If FormMenu.ButtonAppetizer.Text.Equals("Appetizers") Then
                    TextBox1.Text = "Order finalized!"
                Else
                    TextBox1.Text = "Orden finalizada!"
                End If

            Else
                If FormMenu.ButtonAppetizer.Text.Equals("Appetizers") Then
                    TextBox1.Text = "Pending order!"
                Else
                    TextBox1.Text = "Orden Pendiente!"
                End If

            End If
                Conn.Close()
        Catch ex As Exception
            If FormMenu.ButtonAppetizer.Text.Equals("Appetizers") Then
                MsgBox("Order number not found")
            Else
                MsgBox("Numero de orden no encontrado")
            End If
        End Try
    End Sub

    Private Sub buttonValidateCpn_Click(sender As Object, e As EventArgs) Handles buttonValidateCpn.Click

        If FormMenu.ButtonAppetizer.Text.Equals("Appetizers") Then
            txtDescuento.Text = "Discount ₡: "
            txtImpuesto.Text = "Tax ₡: "
            txtTotal.Text = "Total ₡: "

        End If

        txtDescuento.Text = "Descuento ₡: "
        txtImpuesto.Text = "Impuestos ₡: "
        txtTotal.Text = "Total ₡: "

        'Dim sqlConn = New SqlConnection(connectionString)
        'sqlConn.Open()


        Dim Sum As Integer = 0
        For i As Integer = 0 To DTGList.Rows.Count() - 1 Step +1
            Sum = Sum + DTGList.Rows(i).Cells(4).Value
        Next




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
            If FormMenu.ButtonAppetizer.Text.Equals("Appetizers") Then
                MsgBox("A " + discount + " %  discount will be applied.")
            Else
                MsgBox("Se aplicará un descuento del " + discount + " %.")
            End If

            Dim appliedDiscount As Double
                Dim taxAfterDiscount As Double

                appliedDiscount = Sum * CDbl(discount) / 100
                taxAfterDiscount = (Sum - (Sum * CDbl(discount) / 100)) * 0.13

                lblPriceTotalDiscount.Text += Convert.ToString(Sum - appliedDiscount + taxAfterDiscount)
                lblSum.Text += Convert.ToString(Sum)
                txtDescuento.Text += Convert.ToString(appliedDiscount)
                txtImpuesto.Text += Convert.ToString(taxAfterDiscount)
                txtTotal.Text += Convert.ToString(Sum - appliedDiscount + taxAfterDiscount)

                textboxCoupon.Enabled = False
            Else

            If FormMenu.ButtonAppetizer.Text.Equals("Appetizers") Then
                MsgBox("Invalid coupon.")
            Else
                MsgBox("Cupón no válido.")
            End If
            Conn.Close()
                Conn.Open()

            End If
            Conn.Close()

    End Sub

    Private Sub txtDescuento_Click(sender As Object, e As EventArgs) Handles txtDescuento.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
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

        FormCustomerSatisfaction.Show()

    End Sub

    Private Sub txtNoOrden_TextChanged(sender As Object, e As EventArgs) Handles txtNoOrden.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

        Me.Close()

        FormMenu.DataGridViewMenu.DataSource = DBNull.Value
        FormMenu.DataGridViewDescription.DataSource = DBNull.Value
        FormMenu.DataGridViewOrder.Rows.Clear()
        FormMenu.PictureBoxItem.Image = Nothing
        FormMenu.TextBoxSum.Text = Nothing

        FormCustomerSatisfaction.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Btn.Click
        Dim item As Integer = Convert.ToInt64(txtNoOrden.Text)

        Try
            Conn.Open()
            Dim Command2 As New SqlCommand("Select * from OrdenesCompletas where NoOrden=" & item & ";", Conn)
            Dim Adapter2 As SqlDataReader = Command2.ExecuteReader

            If Adapter2.HasRows Then
                If FormMenu.ButtonAppetizer.Text.Equals("Appetizers") Then
                    TextBox1.Text = "Order finalized!"
                Else
                    TextBox1.Text = "Orden finalizada!"
                End If
            Else
                If FormMenu.ButtonAppetizer.Text.Equals("Appetizers") Then
                    TextBox1.Text = "Pending order!"
                Else
                    TextBox1.Text = "Orden Pendiente!"
                End If

            End If
                Conn.Close()
        Catch ex As Exception
            If FormMenu.ButtonAppetizer.Text.Equals("Appetizers") Then
                MsgBox("Order number not found")
            Else
                MsgBox("Numero de orden no encontrado")
            End If

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



        Btn.Enabled = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class