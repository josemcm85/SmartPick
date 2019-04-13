Imports System.Data.SqlClient

Public Class CallMesero

    Dim connectionString As String = "Data Source=ulatina.database.windows.net;Initial Catalog=MenuTTS;User ID=josemcm85;Password=Pass1234 "
    Dim connection As SqlConnection

    Private Sub BunifuCustomLabel1_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel1.Click

    End Sub

    Private Sub CallMesero_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        connection = New SqlConnection(connectionString)
        connection.Open()

        Dim Filtro As New DataTable
        Dim commandFilter As New SqlCommand("Select Mesa from ResTables;", connection)
        Dim Reader As SqlDataReader = commandFilter.ExecuteReader()

        While Reader.Read()

            ComboMesa.Items.Add(Reader.GetString(0))

        End While

        connection.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try

            connection = New SqlConnection(connectionString)
            connection.Open()
            Dim llamarMesero As New SqlCommand("Exec addSoli '" & ComboMesa.SelectedItem.ToString & "','" & txtComentario.Text & "';", connection)
            Dim dataAdapter As New SqlDataAdapter(llamarMesero)
            llamarMesero.ExecuteNonQuery()
            connection.Close()
            MsgBox("Su mesero llegará pronto || Your waiter will be right with you")

        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        PagoCliente.Show()

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            connection = New SqlConnection(connectionString)
            connection.Open()
            Dim llamarMesero As New SqlCommand("Exec addSoli '" & ComboMesa.SelectedItem.ToString & "','" & txtComentario.Text & "';", connection)
            Dim dataAdapter As New SqlDataAdapter(llamarMesero)
            llamarMesero.ExecuteNonQuery()
            connection.Close()
            MsgBox("Su mesero llegará pronto || Your waiter will be right with you")

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PagoCliente.Show()
    End Sub
End Class