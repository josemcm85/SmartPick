Imports System.Data.SqlClient
Imports System.IO

Public Class addMenu

    Dim Conn As New SqlClient.SqlConnection("Data Source=ulatina.database.windows.net;Initial Catalog=MenuTTS;User ID=josemcm85;Password=Pass1234 ")
    Dim ms As MemoryStream

    Private Sub BtnOkload_Click(sender As Object, e As EventArgs)

        'Procedimientos encargados de cargar el menu en ambos idiomas'

        If selecIdiom.SelectedItem.ToString = "Español" Then


            Conn.Open()
            Dim menuTable As New DataTable
            Dim Command As New SqlCommand("Exec loadMenuEsp;", Conn)
            Dim Adapter As New SqlDataAdapter(Command)
            Adapter.Fill(menuTable)
            DataGridMenu.DataSource = menuTable

            Conn.Close()
        ElseIf selecIdiom.SelectedItem.ToString = "Inglés" Then

            Conn.Open()
            Dim menuTable As New DataTable
            Dim Command As New SqlCommand("Exec loadMenuIng;", Conn)
            Dim Adapter As New SqlDataAdapter(Command)
            Adapter.Fill(menuTable)
            DataGridMenu.DataSource = menuTable

            Conn.Close()

        End If


    End Sub

    Private Sub addMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Carga el menu en el idioma Esp por default'
        Conn.Open()
        Dim menuTable As New DataTable
        Dim Command As New SqlCommand("Exec loadMenuGeneral;", Conn)
        Dim Adapter As New SqlDataAdapter(Command)
        Adapter.Fill(menuTable)
        DataGridMenu.DataSource = menuTable
        Conn.Close()


        Conn.Open()
        Dim menuTable2 As New DataTable
        Dim Command2 As New SqlCommand("Select CategorySpa from Categories;", Conn)
        Dim reader2 As SqlDataReader
        reader2 = Command2.ExecuteReader
        CombCate.Items.Clear()
        Do While reader2.Read
            CombCate.Items.Add(reader2.GetValue(0).ToString)
        Loop
        Conn.Close()


        Conn.Open()
        Dim menuTable3 As New DataTable
        Dim Command3 As New SqlCommand("Select TypeSpa from Types;", Conn)
        Dim reader3 As SqlDataReader
        reader3 = Command3.ExecuteReader
        CombComida.Items.Clear()
        Do While reader3.Read
            CombComida.Items.Add(reader3.GetValue(0).ToString)
        Loop
        Conn.Close()


    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs)
        'Busqueda y fija la imagen deseada para el picturebox
        Try
            'Filtros de busqeda en archivos
            With OpenFileDialog1.Filter = ("Images |*.png;*.bmp;*.jpg;*.jpeg;*.gif;*.ico;")

            End With

            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                PicBox.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs)

        Dim Salir As Integer

        Salir = 0

        'Verifica que ningun espacio este vacio
        If (txtrandom.Text = Nothing) Or txtNombre.Text = Nothing Or TxtDesEsp.Text = Nothing Or txtDesIng.Text = Nothing Or txtPrecio.Text = Nothing Or txtCal.Text = Nothing Or CombCate.SelectedItem.ToString = Nothing Or CombComida.SelectedItem.ToString = Nothing Or PicBox.Image Is Nothing Or txtNomENG.Text = Nothing Then

            MsgBox("Verifique que los espacios no esten vacíos!")
        Else

            Try

                'if para seguir el oreden logico de las consultas/Operaciones
                If Salir = 0 Then
                    Try
                        'Primero se inserta la informacion en la tabla MenuEsp que es la principal
                        'Luego, en la tabla MenuEng solo se ingresa la Descripcion en el idioma acorde. La tabla tiene la referencia de ID de la tabla MenuEsp, por ende ambas estan conectadas
                        Conn.Open()
                        Dim Table As New DataTable
                        Dim Command As New SqlCommand("Exec addPlato '" & txtrandom.Text & "','" & txtNombre.Text & "','" & TxtDesEsp.Text & "','" & CombCate.SelectedItem.ToString & "','" & CombComida.SelectedItem.ToString & "','" & txtPrecio.Text & "','" & txtCal.Text & "','" & txtDesIng.Text & "','" & txtNomENG.Text & "';", Conn)
                        Dim Adapter As New SqlDataAdapter(Command)
                        Adapter.Fill(Table)
                        DataGridMenu.DataSource = Table
                        Conn.Close()
                        Salir = Salir + 1

                    Catch ex As Exception

                        MsgBox("Error en almacenar el plato")

                    End Try

                End If

                If Salir = 1 Then

                    'Se realiza un comando aparte para insertar la imagen y los datos de esta 
                    'Las imagenes se tienen que pasar a formato de Bytes para que se puedan almacenar en la base de datos
                    Try
                        Dim Command As New SqlCommand("insert into FotosMenu(CodPlato,Name,Photo) values(@Cod,@Nom,@Foto)", Conn)
                        Dim ms As New MemoryStream
                        PicBox.Image.Save(ms, PicBox.Image.RawFormat)
                        Command.Parameters.Add("@Cod", SqlDbType.VarChar).Value = txtrandom.Text
                        Command.Parameters.Add("@Nom", SqlDbType.VarChar).Value = txtNombre.Text
                        Command.Parameters.Add("@Foto", SqlDbType.Image).Value = ms.ToArray()

                        Conn.Open()

                        If Command.ExecuteNonQuery() = 1 Then

                        Else
                            MsgBox("Error al guardar imagen")

                        End If

                        Conn.Close()


                    Catch ex As Exception

                    End Try

                End If

                MsgBox("Datos guardados con éxito!")

                'Refresca el Menu despues de ingresar un dato'
                Conn.Open()
                Dim menuTable2 As New DataTable
                Dim Command2 As New SqlCommand("Exec loadMenuEsp;", Conn)
                Dim Adapter2 As New SqlDataAdapter(Command2)
                Adapter2.Fill(menuTable2)
                DataGridMenu.DataSource = menuTable2
                Conn.Close()


            Catch ex As Exception

                MsgBox("Error en guardar los datos")

            End Try

        End If

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs)
        'Autogenera un texto random entre todas las letras y numeros del 1 al 9 con longitud de 5 caracteres
        Dim obj As New Random()

        Dim posibles As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"

        Dim longitud As Integer = posibles.Length

        Dim letra As Char
        Dim longitudnuevacadena As Integer = 5

        Dim nuevacadena As String = ""

        For i As Integer = 0 To longitudnuevacadena - 1

            letra = posibles(obj.[Next](longitud))

            nuevacadena += letra.ToString()
        Next

        txtrandom.Text = nuevacadena


    End Sub

    Private Sub BtnDespejar_Click(sender As Object, e As EventArgs)
        'Limpia los espacios para ingresar datos nuevos'
        txtrandom.Text = Nothing
        txtNombre.Text = Nothing
        TxtDesEsp.Text = Nothing
        txtDesIng.Text = Nothing
        txtPrecio.Text = Nothing
        txtCal.Text = Nothing
        CombCate.Text = ""
        CombComida.Text = ""
        PicBox.Image = Nothing
        txtNomENG.Text = Nothing
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuMetroTextbox1_OnValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtDesEsp_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtNomEng_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtDesEsp_OnValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtCal_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtNombre_OnValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub DataGridMenu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridMenu.CellContentClick

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BunifuSeparator1_Load(sender As Object, e As EventArgs) Handles BunifuSeparator1.Load

    End Sub

    Private Sub txtNombre_Click(sender As Object, e As EventArgs) Handles txtNombre.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtCal_Click(sender As Object, e As EventArgs) Handles txtCal.Click

    End Sub

    Private Sub TxtDesEsp_TextChanged_1(sender As Object, e As EventArgs) Handles TxtDesEsp.TextChanged

    End Sub

    Private Sub txtPrecio_Click(sender As Object, e As EventArgs) Handles txtPrecio.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub CombCate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CombCate.SelectedIndexChanged

    End Sub

    Private Sub txtrandom_Click(sender As Object, e As EventArgs) Handles txtrandom.Click

    End Sub

    Private Sub CombComida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CombComida.SelectedIndexChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnOkloadd_Click(sender As Object, e As EventArgs) Handles BtnOkload.Click
        'Procedimientos encargados de cargar el menu en ambos idiomas'

        If selecIdiom.SelectedItem.ToString = "Español" Then


            Conn.Open()
            Dim menuTable As New DataTable
            Dim Command As New SqlCommand("Exec loadMenuEsp;", Conn)
            Dim Adapter As New SqlDataAdapter(Command)
            Adapter.Fill(menuTable)
            DataGridMenu.DataSource = menuTable

            Conn.Close()
        ElseIf selecIdiom.SelectedItem.ToString = "Inglés" Then

            Conn.Open()
            Dim menuTable As New DataTable
            Dim Command As New SqlCommand("Exec loadMenuIng;", Conn)
            Dim Adapter As New SqlDataAdapter(Command)
            Adapter.Fill(menuTable)
            DataGridMenu.DataSource = menuTable

            Conn.Close()

        End If
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        'Autogenera un texto random entre todas las letras y numeros del 1 al 9 con longitud de 5 caracteres
        Dim obj As New Random()

        Dim posibles As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"

        Dim longitud As Integer = posibles.Length

        Dim letra As Char
        Dim longitudnuevacadena As Integer = 5

        Dim nuevacadena As String = ""

        For i As Integer = 0 To longitudnuevacadena - 1

            letra = posibles(obj.[Next](longitud))

            nuevacadena += letra.ToString()
        Next

        txtrandom.Text = nuevacadena
    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        'Busqueda y fija la imagen deseada para el picturebox
        Try
            'Filtros de busqeda en archivos
            With OpenFileDialog1.Filter = ("Images |*.png;*.bmp;*.jpg;*.jpeg;*.gif;*.ico;")

            End With

            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                PicBox.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BunifuThinButton21_Click_2(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim Salir As Integer

        Salir = 0

        'Verifica que ningun espacio este vacio
        If (txtrandom.Text = Nothing) Or txtNombre.Text = Nothing Or TxtDesEsp.Text = Nothing Or txtDesIng.Text = Nothing Or txtPrecio.Text = Nothing Or txtCal.Text = Nothing Or CombCate.SelectedItem.ToString = Nothing Or CombComida.SelectedItem.ToString = Nothing Or PicBox.Image Is Nothing Or txtNomENG.Text = Nothing Then

            MsgBox("Verifique que los espacios no esten vacíos!")
        Else

            Try

                'if para seguir el oreden logico de las consultas/Operaciones
                If Salir = 0 Then
                    Try
                        'Primero se inserta la informacion en la tabla MenuEsp que es la principal
                        'Luego, en la tabla MenuEng solo se ingresa la Descripcion en el idioma acorde. La tabla tiene la referencia de ID de la tabla MenuEsp, por ende ambas estan conectadas
                        Dim Cant As Integer = 1

                        Conn.Open()
                        Dim Table As New DataTable
                        Dim Command As New SqlCommand("Exec addPlato '" & txtrandom.Text & "','" & txtNombre.Text & "','" & TxtDesEsp.Text & "','" & CombCate.SelectedItem.ToString & "','" & CombComida.SelectedItem.ToString & "','" & txtPrecio.Text & "','" & txtCal.Text & "','" & txtDesIng.Text & "','" & txtNomENG.Text & "','" & Cant & "';", Conn)
                        Dim Adapter As New SqlDataAdapter(Command)
                        Adapter.Fill(Table)
                        DataGridMenu.DataSource = Table
                        Conn.Close()
                        Salir = Salir + 1

                    Catch ex As Exception

                        MsgBox("Error en almacenar el plato")

                    End Try

                End If

                If Salir = 1 Then

                    'Se realiza un comando aparte para insertar la imagen y los datos de esta 
                    'Las imagenes se tienen que pasar a formato de Bytes para que se puedan almacenar en la base de datos
                    Try
                        Dim Command As New SqlCommand("insert into FotosMenu(CodPlato,Name,Photo) values(@Cod,@Nom,@Foto)", Conn)
                        Dim ms As New MemoryStream
                        PicBox.Image.Save(ms, PicBox.Image.RawFormat)
                        Command.Parameters.Add("@Cod", SqlDbType.VarChar).Value = txtrandom.Text
                        Command.Parameters.Add("@Nom", SqlDbType.VarChar).Value = txtNombre.Text
                        Command.Parameters.Add("@Foto", SqlDbType.Image).Value = ms.ToArray()

                        Conn.Open()

                        If Command.ExecuteNonQuery() = 1 Then

                        Else
                            MsgBox("Error al guardar imagen")

                        End If

                        Conn.Close()


                    Catch ex As Exception

                    End Try

                End If

                MsgBox("Datos guardados con éxito!")

                'Refresca el Menu despues de ingresar un dato'
                Conn.Open()
                Dim menuTable2 As New DataTable
                Dim Command2 As New SqlCommand("Exec loadMenuEsp;", Conn)
                Dim Adapter2 As New SqlDataAdapter(Command2)
                Adapter2.Fill(menuTable2)
                DataGridMenu.DataSource = menuTable2
                Conn.Close()


            Catch ex As Exception

                MsgBox("Error en guardar los datos")

            End Try

        End If
        Conn.Close()
    End Sub

    Private Sub BunifuThinButton21_Click_3(sender As Object, e As EventArgs) Handles BtnDespejar.Click
        'Limpia los espacios para ingresar datos nuevos'
        txtrandom.Text = Nothing
        txtNombre.Text = Nothing
        TxtDesEsp.Text = Nothing
        txtDesIng.Text = Nothing
        txtPrecio.Text = Nothing
        txtCal.Text = Nothing
        CombCate.Text = ""
        CombComida.Text = ""
        PicBox.Image = Nothing
        txtNomENG.Text = Nothing
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub BunifuThinButton21_Click_4(sender As Object, e As EventArgs)
        Conn.Open()
        Dim menuTable As New DataTable
        Dim Command As New SqlCommand("Exec loadMenuGeneral;", Conn)
        Dim Adapter As New SqlDataAdapter(Command)
        Adapter.Fill(menuTable)
        DataGridMenu.DataSource = menuTable
        Conn.Close()


        Conn.Open()
        Dim menuTable2 As New DataTable
        Dim Command2 As New SqlCommand("Select CategorySpa from Categories;", Conn)
        Dim reader2 As SqlDataReader
        reader2 = Command2.ExecuteReader
        CombCate.Items.Clear()
        Do While reader2.Read
            CombCate.Items.Add(reader2.GetValue(0).ToString)
        Loop
        Conn.Close()


        Conn.Open()
        Dim menuTable3 As New DataTable
        Dim Command3 As New SqlCommand("Select TypeSpa from Types;", Conn)
        Dim reader3 As SqlDataReader
        reader3 = Command3.ExecuteReader
        CombComida.Items.Clear()
        Do While reader3.Read
            CombComida.Items.Add(reader3.GetValue(0).ToString)
        Loop
        Conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Carga el menu en el idioma Esp por default'
        Conn.Open()
        Dim menuTable As New DataTable
        Dim Command As New SqlCommand("Exec loadMenuGeneral;", Conn)
        Dim Adapter As New SqlDataAdapter(Command)
        Adapter.Fill(menuTable)
        DataGridMenu.DataSource = menuTable
        Conn.Close()


        Conn.Open()
        Dim menuTable2 As New DataTable
        Dim Command2 As New SqlCommand("Select CategorySpa from Categories;", Conn)
        Dim reader2 As SqlDataReader
        reader2 = Command2.ExecuteReader
        CombCate.Items.Clear()
        Do While reader2.Read
            CombCate.Items.Add(reader2.GetValue(0).ToString)
        Loop
        Conn.Close()


        Conn.Open()
        Dim menuTable3 As New DataTable
        Dim Command3 As New SqlCommand("Select TypeSpa from Types;", Conn)
        Dim reader3 As SqlDataReader
        reader3 = Command3.ExecuteReader
        CombComida.Items.Clear()
        Do While reader3.Read
            CombComida.Items.Add(reader3.GetValue(0).ToString)
        Loop
        Conn.Close()

    End Sub
End Class
