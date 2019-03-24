Imports System.Data.SqlClient

Public Class FormAddUser

    Dim item As String
    Dim Conn As New SqlClient.SqlConnection("Data Source=ulatina.database.windows.net;Initial Catalog=MenuTTS;User ID=josemcm85;Password=Pass1234 ")

    Private Sub FormAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Loads The Users list

        Me.UserTableShowTableAdapter.Fill(Me.MenuTTSDataSet11.UserTableShow)



    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click

        Me.Close()

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        FormUserInfo.Show()

    End Sub

    Public Sub DGUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGUsers.CellClick


        'Selection of Row
        Dim rowIndexMenu As Integer
        rowIndexMenu = e.RowIndex

        Dim rowMenu As DataGridViewRow = DGUsers.Rows(rowIndexMenu)
        item = rowMenu.Cells(3).Value



    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BtnDelUser.Click

        'Erase User from the list

        Conn.Open()
        Dim Table As New DataTable
        Dim Command As New SqlCommand("DELETE FROM Usuarios WHERE idUsuario= '" & item & "';", Conn)
        Dim Adapter As New SqlDataAdapter(Command)
        Adapter.Fill(Table)
        Conn.Close()
        Me.UserTableShowTableAdapter.Fill(Me.MenuTTSDataSet11.UserTableShow)



    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DGUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGUsers.CellContentClick

    End Sub
End Class