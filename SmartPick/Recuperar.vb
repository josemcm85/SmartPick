Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class Recuperar

    Dim Conn As New SqlClient.SqlConnection("Data Source=ulatina.database.windows.net;Initial Catalog=MenuTTS;User ID=josemcm85;Password=Pass1234 ")
    Dim user As String
    Dim pass As String
    Dim Correo As String
    Dim Linea As String

    Private Sub Recuperar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'El procedimiento extrae la informacion del usuario como: Correo, Nombre Usuario y password por medio del ID de empleado ingresado'
        Try
            Conn.Open()
            Dim menuTable As New DataTable
            Dim Command As New SqlCommand("Exec getinfo '" & txtID.Text & "';", Conn)
            Dim Adapter As New SqlDataAdapter(Command)
            Adapter.Fill(menuTable)

            If menuTable.Rows.Count <> 0 Then
                MsgBox("Usuario Encontrado")
                'La informacion se almacena en el datatable en el siguiente orden'
                'Se le asignan a las variables los valores de los espacios del Datatable'
                user = menuTable.Rows(0).Item(0)
                pass = menuTable.Rows(0).Item(1)
                Correo = menuTable.Rows(0).Item(2)

                txtto.Text = Correo
                'La infromacion se guarda en un string para luego ser usado'
                Linea = "Tu Usuario: " & user.ToString & " Tu password: " & pass.ToString

            Else
                MsgBox("Usuario incorrecto")

            End If

            Conn.Close()
        Catch ex As Exception

        End Try



        Try
            'Se levantan los servicios de envios de correo'
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("SmartPickCo@gmail.com", "SmartPick123") 'Se utiliza el correo de la empresa'
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com" 'Host especifico de Gmail'
            'Cuerpo del correo'
            e_mail = New MailMessage()
            e_mail.From = New MailAddress(lblCorreo.Text)
            e_mail.To.Add(txtto.Text)
            e_mail.Subject = lblasunto.Text
            e_mail.IsBodyHtml = False
            e_mail.Body = Linea
            Smtp_Server.Send(e_mail)
            MsgBox("Mail Sent")



        Catch error_t As Exception
            MsgBox(error_t.ToString)

            ''!!!!!!En caso de que de error ir a este video https://www.youtube.com/watch?v=y3cotIr41PQ!!!!!!!!!!'
        End Try
    End Sub
End Class