Imports System.Data.SqlClient

Public Class FormLogin
    Dim Conn As New SqlClient.SqlConnection("Data Source=ulatina.database.windows.net;Initial Catalog=MenuTTS;User ID=josemcm85;Password=Pass1234 ")


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Recuperar.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs)
        'Ejecuta el procedimineto del Login
        ' El procedimiento comprueba si el usuario y la password existan y sean iguales en la base de datos 
        Conn.Open()
        Dim menuTable As New DataTable
        Dim Command As New SqlCommand("Exec UserLogin '" & txtUser.Text & "','" & txtPass.Text & "';", Conn)
        Dim Adapter As New SqlDataAdapter(Command)
        Adapter.Fill(menuTable)

        'Si el data table se llena por el procedimiento significa que es diferente a cero'
        If menuTable.Rows.Count <> 0 Then
            AdminMain.Show()

            Me.Hide()


        Else
            'De lo contrario va a tirar error'

            MsgBox("Usuario incorrecto")

        End If

        Conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'Boton para activar o desactivar el passwordChar y poder ver lo que dice el texto
        'UseSystemPasswordChar es la propiedad para que el texto se oculte con asteriscos

        If txtPass.isPassword = True Then

            txtPass.isPassword = False

        Else

            txtPass.isPassword = True

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)



        Me.Hide()
        FormLanguage.Show()


    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtPass_OnValueChanged(sender As Object, e As EventArgs) Handles txtPass.OnValueChanged

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        If txtPass.isPassword = True Then

            txtPass.isPassword = False

        Else

            txtPass.isPassword = True

        End If
    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub BunifuCustomLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        'Ejecuta el procedimineto del Login
        ' El procedimiento comprueba si el usuario y la password existan y sean iguales en la base de datos 
        Conn.Open()
        Dim menuTable As New DataTable
        Dim Command As New SqlCommand("Exec UserLogin '" & txtUser.Text & "','" & txtPass.Text & "';", Conn)
        Dim Adapter As New SqlDataAdapter(Command)
        Adapter.Fill(menuTable)

        'Si el data table se llena por el procedimiento significa que es diferente a cero'
        If menuTable.Rows.Count <> 0 Then
            AdminMain.Show()

            Me.Hide()


        Else
            'De lo contrario va a tirar error'

            MsgBox("Usuario incorrecto")

        End If

        Conn.Close()

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Recuperar.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Recuperar.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ButtonMenu.LinkClicked
        Me.Hide()
        FormLanguage.Show()

    End Sub

    Private Sub txtUser_OnValueChanged(sender As Object, e As EventArgs) Handles txtUser.OnValueChanged
        'Cambio test
    End Sub
End Class
