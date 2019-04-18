Imports System.Data.SqlClient

Public Class CallMesero

    Dim connectionString As String = "Data Source=Desktop-Kbtk5sb;Initial Catalog=MenuTTS;Integrated Security=True"
    Dim connection As SqlConnection

    Private Sub BunifuCustomLabel1_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel1.Click

    End Sub

    Private Sub CallMesero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FormMenu.ButtonAppetizer.Text.Equals("Appetizers") Then
            BunifuCustomLabel1.Text = "Please select your table:"

            BunifuCustomLabel3.Text = "Leave a comment (Optional):"

            Button2.Text = "Pay bill"
            btnClose.Text = "Close"

        End If


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

            If FormMenu.ButtonAppetizer.Text.Equals("Appetizers") Then
                MsgBox("Your waiter will be right with you")
            Else
                MsgBox("Su mesero llegará pronto")
            End If


        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        PagoCliente.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class