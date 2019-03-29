Imports System.Data.SqlClient

Public Class FormOrderDetails

    Dim item As String
    Dim connectionString As String = "Data Source=ulatina.database.windows.net;Initial Catalog=MenuTTS;User ID=josemcm85;Password=Pass1234 "
    Dim connection As SqlConnection

    Private Sub FormOrderDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MenuTTSDataSet1.ListaOrdenes' table. You can move, or remove it, as needed.
        Me.ListaOrdenesTableAdapter.Fill(Me.MenuTTSDataSet1.ListaOrdenes)

    End Sub

    Private Sub DGOrders_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGOrders.CellClick

        If (e.RowIndex = -1) Then Return

        Dim rowIndexMenu As Integer
        rowIndexMenu = e.RowIndex

        Dim rowMenu As DataGridViewRow = DGOrders.Rows(rowIndexMenu)
        item = rowMenu.Cells(0).Value

        connection = New SqlConnection(connectionString)

        Dim OrdersDetailTable As New DataTable
        Dim commandSelect As New SqlCommand("SELECT Orden '# Orden', Nombreitem 'Item', Cantidad, Total 'Costo ¢' FROM Orden o WHERE o.orden = '" & item & "'", connection)

        Dim dataAdapter As New SqlDataAdapter(commandSelect)
        dataAdapter.Fill(OrdersDetailTable)


        DGOrderDetails.DataSource = OrdersDetailTable



    End Sub

    Private Sub BtnClose3_Click(sender As Object, e As EventArgs) Handles BtnClose3.Click

        Me.Close()

    End Sub
End Class