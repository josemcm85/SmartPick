Imports System.Data.SqlClient

Public Class FormCustomerSatisfaction

    Dim Conn As New SqlClient.SqlConnection("Data Source=Desktop-Kbtk5sb;Initial Catalog=MenuTTS;Integrated Security=True")
    Dim NumeroOrden As Integer = 1

    Private Sub FormCustomerSatisfaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FormMenu.ButtonAppetizer.Text.Equals("Appetizers") Then
            Label1.Text = "Your opinion matters to us!"
            Label3.Text = "Order number:"
            Label11.Text = "Comments:"
            btnSend.Text = "Send"
            btnClose.Text = "Close"
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSend.Click


        Dim insertQuery As String = "INSERT INTO customerSatisfaction (rating,comments,idOrden) VALUES(" & ratingStars.Value & ",'" & TextBoxComments.Text & "'," & CInt(txtNoOrden.Text) & ")"

        ExecuteQuery(insertQuery)

        If FormMenu.ButtonAppetizer.Text.Equals("Appetizers") Then
            MessageBox.Show("Thank you for your comments. We hope to see you back!")
        Else
            MessageBox.Show("Gracias por valorarnos. Lo esperamos pronto!")
        End If




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