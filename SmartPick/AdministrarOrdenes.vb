Imports System.Data.SqlClient
Imports System.IO

Public Class AdministrarOrdenes

    Dim Conn As New SqlClient.SqlConnection("Data Source=ulatina.database.windows.net;Initial Catalog=MenuTTS;User ID=josemcm85;Password=Pass1234 ")
    Dim NoOrden As Integer

    Private Sub AdministrarOrdenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn.Open()
        Dim menuTable As New DataTable
        Dim Command As New SqlCommand("Select * from ListaOrdenes;", Conn)
        Dim Adapter As New SqlDataAdapter(Command)
        Adapter.Fill(menuTable)
        ListaOrdenes.DataSource = menuTable
        Conn.Close()
    End Sub

    Private Sub ListaOrdenes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListaOrdenes.CellContentClick

        TextBox1.Clear()

        Dim index, j As Integer
        'i = ListaOrdenes.CurrentRow.Index
        'NoOrden = Convert.ToInt64(ListaOrdenes.Item(0, i).Value)
        'MsgBox(NoOrden)
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = ListaOrdenes.Rows(index)
        NoOrden = selectedRow.Cells(0).Value.ToString()
        MsgBox(NoOrden)

        Conn.Open()
        Dim menuTable As New DataTable
        Dim Command As New SqlCommand("Select * from Orden where Orden=" & NoOrden & ";", Conn)
        Dim Adapter As New SqlDataAdapter(Command)
        Adapter.Fill(menuTable)
        Detalle.DataSource = menuTable
        Conn.Close()

        Conn.Open()
        Dim Command2 As New SqlCommand("Select * from OrdenesCompletas where NoOrden=" & NoOrden & ";", Conn)
        Dim Adapter2 As SqlDataReader = Command2.ExecuteReader

        If Adapter2.HasRows Then
            TextBox1.Text = "Orden finalizada!"
        Else
            TextBox1.Text = "Orden Pendiente!"
        End If
        Conn.Close()

    End Sub

    Private Sub BtnFinalizar_Click_1(sender As Object, e As EventArgs) Handles BtnFinalizar.Click

        Dim Result As Integer = MessageBox.Show("Está seguro que quiere cerrar la orden" & NoOrden & "?", "Cerrar Orden", MessageBoxButtons.YesNo)
        If Result = DialogResult.No Then
            MessageBox.Show("Función cancelada")
        ElseIf Result = DialogResult.Yes Then
            Conn.Open()
            Try
                Dim CommandInsert As New SqlCommand("Exec CompletarOrden'" & NoOrden & "';", Conn)
                Dim Adapter As New SqlDataAdapter(CommandInsert)
                CommandInsert.ExecuteNonQuery()

                Dim Command2 As New SqlCommand("Select * from OrdenesCompletas where NoOrden=" & NoOrden & ";", Conn)
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

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click

        Me.Close()

    End Sub
End Class