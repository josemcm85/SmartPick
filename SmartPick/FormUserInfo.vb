Imports System.Data.SqlClient

Public Class FormUserInfo

    Dim Conn As New SqlClient.SqlConnection("Data Source=Desktop-Kbtk5sb;Initial Catalog=MenuTTS;Integrated Security=True")


    Private Sub BtnUser_Click(sender As Object, e As EventArgs) Handles BtnUser.Click

        If TextBoxIdUser.Text = "" Or TextBoxName.Text = "" Or TextBoxLastN.Text = "" Or TextBoxUserName.Text = "" Or TextBoxPass.Text = "" Or TextBoxtitle.Text = "" Or TextBoxemail.Text = "" Then

            MsgBox("Por favor revisar que toda la información haya sido ingresada")

        Else

            Conn.Open()
            Dim Table As New DataTable
            Dim Command As New SqlCommand("Exec addUsuario '" & TextBoxIdUser.Text & "','" & TextBoxName.Text & "','" & TextBoxLastN.Text & "','" & TextBoxUserName.Text & "','" & TextBoxPass.Text & "','" & TextBoxtitle.Text & "','" & TextBoxemail.Text & "';", Conn)
            Dim Adapter As New SqlDataAdapter(Command)
            Adapter.Fill(Table)
            Conn.Close()

            MsgBox("Usuario Ingresado al Sistema")

            TextBoxIdUser.Text = ""
            TextBoxName.Text = ""
            TextBoxLastN.Text = ""
            TextBoxUserName.Text = ""
            TextBoxPass.Text = ""
            TextBoxtitle.Text = ""
            TextBoxemail.Text = ""

        End If

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click

        Me.Close()
        FormAddUser.UserTableShowTableAdapter.Fill(FormAddUser.MenuTTSDataSet11.UserTableShow)

    End Sub

    Private Sub FormUserInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class