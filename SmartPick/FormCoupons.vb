Imports System.Data.SqlClient

Public Class FormCoupons

    Dim item As String
    Dim connection As New SqlClient.SqlConnection("Data Source=ulatina.database.windows.net;Initial Catalog=MenuTTS;User ID=josemcm85;Password=Pass1234 ")

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAddCoupon.Click








        If String.IsNullOrEmpty(txtCoupon.Text) = False And String.IsNullOrEmpty(txtPercentage.Text) = False Then





            If txtPercentage.Text > 0 And txtPercentage.Text < 101 Then



                Dim insertQuery As String = "INSERT INTO Coupons (Coupon,Discount) VALUES('" & txtCoupon.Text & "'," & txtPercentage.Text & ")"

                ExecuteQuery(insertQuery)

                MessageBox.Show("Cupón creado.")

                connection.Open()
                Dim adapter3 As New SqlDataAdapter("Select * FROM Coupons", connection)
                Dim table2 As New DataTable()
                adapter3.Fill(table2)
                dgvCoupons.DataSource = table2
                connection.Close()


            Else
                MessageBox.Show("Digitar un número entre 1 y 100.")
            End If

        Else
            MessageBox.Show("Datos no válidos.")

        End If



    End Sub
    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, connection)

        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()

    End Sub

    Private Sub FormCoupons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Open()



        Dim adapter As New SqlDataAdapter("Select * FROM Coupons", connection)
        Dim table1 As New DataTable()
        adapter.Fill(table1)
        dgvCoupons.DataSource = table1


        connection.Close()
        'dgvCoupons.Columns(0).Visible = False
    End Sub

    Private Sub dgvCoupons_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCoupons.CellClick

        'Selection of Row
        Dim RowIndex As Integer
        RowIndex = e.RowIndex

        Dim row As DataGridViewRow = dgvCoupons.Rows(rowIndex)
        item = row.Cells(0).Value

    End Sub

    Private Sub BtnDelUser_Click(sender As Object, e As EventArgs) Handles BtnDelCoupon.Click
        connection.Open()
        Dim Table As New DataTable
        Dim Command As New SqlCommand("DELETE FROM Coupons WHERE Coupon = '" & item & "';", connection)
        Dim Adapter As New SqlDataAdapter(Command)
        Adapter.Fill(Table)
        connection.Close()

        MessageBox.Show("Cupón eliminado.")

        connection.Open()
        Dim adapter2 As New SqlDataAdapter("SELECT * FROM Coupons", connection)
        Dim table1 As New DataTable()
        adapter2.Fill(table1)
        dgvCoupons.DataSource = table1
        connection.Close()



    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub dgvCoupons_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCoupons.CellContentClick

    End Sub
End Class