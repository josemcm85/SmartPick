Imports System.Data.SqlClient

Public Class AdminCustomerSatisfaction

    Dim item As String
    Dim connection As New SqlClient.SqlConnection("Data Source=ulatina.database.windows.net;Initial Catalog=MenuTTS;User ID=josemcm85;Password=Pass1234 ")

    Private Sub AdminCustomerSatisfaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Open()



        Dim adapter As New SqlDataAdapter("Select * FROM customerSatisfaction", connection)
        Dim table1 As New DataTable()
        adapter.Fill(table1)
        dgvSatisfaction.DataSource = table1


        connection.Close()
        'dgvCoupons.Columns(0).Visible = False
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class