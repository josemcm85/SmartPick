﻿Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class Recuperar

    Dim Conn As New SqlClient.SqlConnection("Data Source=Desktop-Kbtk5sb;Initial Catalog=MenuTTS;Integrated Security=True")
    Dim user As String
    Dim pass As String
    Dim Correo As String
    Dim Linea As String

    Private Sub Recuperar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click

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
            e_mail.From = New MailAddress(lblcorreo.Text)
            e_mail.To.Add(txtto.Text)
            e_mail.Subject = lblcorreo.Text
            e_mail.IsBodyHtml = False
            e_mail.Body = Linea
            Smtp_Server.Send(e_mail)
            MsgBox("Mail Sent")



        Catch error_t As Exception
            MsgBox(error_t.ToString)

            ''!!!!!!En caso de que de error ir a este video https://www.youtube.com/watch?v=y3cotIr41PQ!!!!!!!!!!'
        End Try

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Me.Close()
    End Sub
End Class