Imports System.Data.SqlClient

Public Class FormOrderDetails

    Dim item As String
    Dim connectionString As String = "Data Source=Desktop-Kbtk5sb;Initial Catalog=MenuTTS;Integrated Security=True"
    Dim Conn As New SqlClient.SqlConnection("Data Source=Desktop-Kbtk5sb;Initial Catalog=MenuTTS;Integrated Security=True")
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

        Conn.Open()
        Dim Command2 As New SqlCommand("Select * from OrdenesCompletas where NoOrden=" & item & ";", Conn)
        Dim Adapter2 As SqlDataReader = Command2.ExecuteReader

        If Adapter2.HasRows Then
            TextBox1.Text = "Orden finalizada!"
        Else
            TextBox1.Text = "Orden Pendiente!"
        End If
        Conn.Close()

    End Sub

    Private Sub BtnClose3_Click(sender As Object, e As EventArgs) Handles BtnClose3.Click

        Me.Close()

    End Sub

    Private Sub DGOrders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGOrders.CellContentClick

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Result As Integer = MessageBox.Show("Está seguro que quiere cerrar la orden" & item & "?", "Cerrar Orden", MessageBoxButtons.YesNo)
        If Result = DialogResult.No Then
            MessageBox.Show("Función cancelada")
        ElseIf Result = DialogResult.Yes Then
            Conn.Open()
            Try
                Dim CommandInsert As New SqlCommand("Exec CompletarOrden'" & item & "';", Conn)
                Dim Adapter As New SqlDataAdapter(CommandInsert)
                CommandInsert.ExecuteNonQuery()

                Dim Command2 As New SqlCommand("Select * from OrdenesCompletas where NoOrden=" & item & ";", Conn)
                Dim Adapter2 As SqlDataReader = Command2.ExecuteReader

                If Adapter2.HasRows Then
                    TextBox1.Text = "Orden finalizada!"
                Else
                    TextBox1.Text = "Orden Pendiente!"
                End If


                MsgBox("Orden se ha marcado como finalizada")

            Catch ex As Exception
                MsgBox("Error al cerrar orden")
            End Try

            Conn.Close()
        End If
    End Sub
End Class