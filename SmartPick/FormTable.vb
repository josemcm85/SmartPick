Imports System.Data.SqlClient
Imports System.IO
Public Class FormTable
    Dim item As String
    Dim connectionString As String = "Data Source=Desktop-Kbtk5sb;Initial Catalog=MenuTTS;Integrated Security=True"
    Dim connection As SqlConnection
    Private Sub tableSelectLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Private Sub FormTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class