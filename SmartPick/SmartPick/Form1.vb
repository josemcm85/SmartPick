Imports System.Data.SqlClient
Public Class Form1
    Dim Conn As New SqlClient.SqlConnection("Server= DESKTOP-4K5GMDN\PROGRA;Database=MenuTTS; Integrated Security= true")


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Recuperar.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Boton para activar o desactivar el passwordChar y poder ver lo que dice el texto
        'UseSystemPasswordChar es la propiedad para que el texto se oculte con asteriscos

        If txtPass.UseSystemPasswordChar = True Then

            txtPass.UseSystemPasswordChar = False

        Else

            txtPass.UseSystemPasswordChar = True

        End If

    End Sub
End Class
