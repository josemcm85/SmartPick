Imports System.Data.SqlClient
Imports System.IO
Public Class FormTable
    Dim item As String
    Dim connectionString As String = "Data Source=ulatina.database.windows.net;Initial Catalog=MenuTTS;User ID=josemcm85;Password=Pass1234 "
    Dim connection As SqlConnection
    Private Sub tableSelectLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Private Sub FormTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class