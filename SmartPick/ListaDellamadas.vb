Imports System.Data.SqlClient

Public Class ListaDellamadas
    Dim Conn As New SqlClient.SqlConnection("Data Source=Desktop-Kbtk5sb;Initial Catalog=MenuTTS;Integrated Security=True")
    Private Sub ListaDellamadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn.Open()
        Dim menuTable As New DataTable
        Dim Command As New SqlCommand("Select * from Solicitudes;", Conn)
        Dim Adapter As New SqlDataAdapter(Command)
        Adapter.Fill(menuTable)
        DTGList.DataSource = menuTable
        Conn.Close()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click

        Me.Close()

    End Sub
End Class