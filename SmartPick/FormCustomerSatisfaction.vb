Imports System.Data.SqlClient

Public Class FormCustomerSatisfaction

    Dim Conn As New SqlClient.SqlConnection("Data Source=ulatina.database.windows.net;Initial Catalog=MenuTTS;User ID=josemcm85;Password=Pass1234 ")

    Private Sub FormCustomerSatisfaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSend.Click


        Dim insertQuery As String = "INSERT INTO customerSatisfaction (rating,comments) VALUES(" & ratingStars.Value & ",'" & TextBoxComments.Text & "')"

        ExecuteQuery(insertQuery)

        MessageBox.Show("Gracias por valorarnos.Lo esperamos pronto!")




    End Sub

    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, Conn)

        Conn.Open()

        command.ExecuteNonQuery()

        Conn.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class