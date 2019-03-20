Imports System.Data.SqlClient
Imports System.IO

Public Class FormMenu

    Dim item As String
    Dim connectionString As String = "Data Source=ulatina.database.windows.net;Initial Catalog=MenuTTS;User ID=josemcm85;Password=Pass1234 "
    Dim connection As SqlConnection
    Dim Filtro As Integer
    Public Property IsRepeated As Boolean










    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Filtro = 0


        'Makes labels to show nothing for now.

        lblSec.Text = ""
        LblTitle.Text = ""





    End Sub

    Private Sub PictureBoxClose_Click(sender As Object, e As EventArgs) Handles PictureBoxClose.Click

        'Close the Application

        Me.Close()
        FormLogin.Close()

    End Sub

    Private Sub PictureBoxMinimize_Click(sender As Object, e As EventArgs) Handles PictureBoxMinimize.Click

        'Minimize the Application

        Me.WindowState = FormWindowState.Minimized


    End Sub

    Private Sub ButtonAppetizer_Click(sender As Object, e As EventArgs) Handles ButtonAppetizer.Click
        ComboFiltro.Text = ""
        ComboFiltro.Items.Clear()
        Filtro = 2
        LblFiltro.Text = "2"

        If ButtonAppetizer.Text.Equals("Appetizers") Then
            If LblFiltro.Text = 2 Then
                lblTitulo.Visible = True
                Btnfiltrar.Visible = True
                ComboFiltro.Visible = True
                Try
                    connection = New SqlConnection(connectionString)
                    connection.Open()

                    Dim Filtro As New DataTable
                    Dim commandFilter As New SqlCommand("Exec FiltrosEng '" & LblFiltro.Text & "';", connection)
                    Dim Reader As SqlDataReader = commandFilter.ExecuteReader()

                    While Reader.Read()

                        ComboFiltro.Items.Add(Reader.GetString(0))

                    End While

                    connection.Close()


                Catch ex As Exception

                    MsgBox(ex.Message)
                End Try

            End If
        Else
            If LblFiltro.Text = 2 Then
                lblTitulo.Visible = True
                Btnfiltrar.Visible = True
                ComboFiltro.Visible = True
                Try
                    connection = New SqlConnection(connectionString)
                    connection.Open()

                    Dim Filtro As New DataTable
                    Dim commandFilter As New SqlCommand("Exec FiltrosEsp '" & LblFiltro.Text & "';", connection)
                    Dim Reader As SqlDataReader = commandFilter.ExecuteReader()

                    While Reader.Read()

                        ComboFiltro.Items.Add(Reader.GetString(0))

                    End While

                    connection.Close()


                Catch ex As Exception

                    MsgBox(ex.Message)
                End Try

            End If

        End If


        'Checks Which Language was selected
        If ButtonAppetizer.Text.Equals("Appetizers") Then
            'ENGLISH was selected
            lblSec.Text = "Our section of: "
            LblTitle.Text = "Appetizers"
            DataGridViewDescription.DataSource = Nothing
            PictureBoxItem.Image = Nothing
            'Shows the Appetizer Menu



            connection = New SqlConnection(connectionString)

            Dim menuTable As New DataTable
            Dim commandSelect As New SqlCommand("SELECT t.TypeEng 'Type',e.Name 'Name' ,m.Price 'Price ¢',m.Calories 'Calories Kcal',m.Quantity 'Quantity', f.Photo FROM MenuEsp m, FotosMenu f, MenuEng e, Types t WHERE m.CodPlato = f.CodPlato AND m.CodPlato = e.NoPlato AND m.TypeFood = t.TypeSpa AND Categories = 'Entrada'", connection)

            Dim dataAdapter As New SqlDataAdapter(commandSelect)
            dataAdapter.Fill(menuTable)

            DataGridViewMenu.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(4, 172, 209)

            DataGridViewMenu.DataSource = menuTable

            ButtonAppetizer.BackColor = Color.FromArgb(4, 172, 209)
            ButtonMainDish.BackColor = Color.White
            ButtonDrinks.BackColor = Color.White
            ButtonDessert.BackColor = Color.White
            ButtonToShare.BackColor = Color.White

            'Hides Column with Picture information.

            DataGridViewMenu.Columns("Photo").Visible = False

        Else
            'Spanish was selected
            lblSec.Text = "Nuestra sección de: "
            LblTitle.Text = "Entradas"
            DataGridViewDescription.DataSource = Nothing
            PictureBoxItem.Image = Nothing
            'Shows the Appetizer Menu



            connection = New SqlConnection(connectionString)

            Dim menuTable As New DataTable
            Dim commandSelect As New SqlCommand("SELECT m.TypeFood 'Tipo',m.Name ,m.Price 'Precio ¢' ,m.Calories 'Calorías Kcal',m.Quantity 'Cantidad', f.Photo FROM MenuEsp m, FotosMenu f WHERE m.CodPlato = f.CodPlato AND Categories = 'Entrada'", connection)

            Dim dataAdapter As New SqlDataAdapter(commandSelect)
            dataAdapter.Fill(menuTable)

            DataGridViewMenu.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(4, 172, 209)

            DataGridViewMenu.DataSource = menuTable

            ButtonAppetizer.BackColor = Color.FromArgb(4, 172, 209)
            ButtonMainDish.BackColor = Color.White
            ButtonDrinks.BackColor = Color.White
            ButtonDessert.BackColor = Color.White
            ButtonToShare.BackColor = Color.White

            'Hides Column with Picture information

            DataGridViewMenu.Columns("Photo").Visible = False

        End If

    End Sub

    Private Sub ButtonMainDish_Click(sender As Object, e As EventArgs) Handles ButtonMainDish.Click
        ComboFiltro.Text = ""
        ComboFiltro.Items.Clear()
        Filtro = 1
        LblFiltro.Text = "1"

        If ButtonAppetizer.Text.Equals("Appetizers") Then
            If LblFiltro.Text = 1 Then
                lblTitulo.Visible = True
                Btnfiltrar.Visible = True
                ComboFiltro.Visible = True
                Try

                    connection = New SqlConnection(connectionString)
                    connection.Open()
                    Dim Filtro As New DataTable
                    Dim commandFilter As New SqlCommand("Exec FiltrosEng '" & LblFiltro.Text & "';", connection)
                    Dim Reader As SqlDataReader = commandFilter.ExecuteReader()

                    While Reader.Read()

                        ComboFiltro.Items.Add(Reader.GetString(0))

                    End While
                    connection.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If
        Else
            If LblFiltro.Text = 1 Then
                lblTitulo.Visible = True
                Btnfiltrar.Visible = True
                ComboFiltro.Visible = True
                Try
                    connection = New SqlConnection(connectionString)
                    connection.Open()

                    Dim Filtro As New DataTable
                    Dim commandFilter As New SqlCommand("Exec FiltrosEsp '" & LblFiltro.Text & "';", connection)
                    Dim Reader As SqlDataReader = commandFilter.ExecuteReader()

                    While Reader.Read()

                        ComboFiltro.Items.Add(Reader.GetString(0))

                    End While

                    connection.Close()


                Catch ex As Exception

                    MsgBox(ex.Message)
                End Try

            End If

        End If



        'Checks Which Language was selected
        If ButtonMainDish.Text.Equals("Main Dish") Then
            'ENGLISH was selected

            lblSec.Text = "Our section of: "
            LblTitle.Text = "Main Dishes"
            DataGridViewDescription.DataSource = Nothing
            PictureBoxItem.Image = Nothing
            'Shows the Main Dish Menu

            connection = New SqlConnection(connectionString)

            Dim menuTable As New DataTable
            Dim commandSelect As New SqlCommand("SELECT t.TypeEng 'Type',e.Name 'Name' ,m.Price 'Price ¢',m.Calories 'Calories Kcal',m.Quantity 'Quantity', f.Photo FROM MenuEsp m, FotosMenu f, MenuEng e, Types t WHERE m.CodPlato = f.CodPlato AND m.CodPlato = e.NoPlato AND m.TypeFood = t.TypeSpa AND Categories = 'Plato Fuerte'", connection)

            Dim dataAdapter As New SqlDataAdapter(commandSelect)
            dataAdapter.Fill(menuTable)

            DataGridViewMenu.DataSource = menuTable

            ButtonAppetizer.BackColor = Color.White
            ButtonMainDish.BackColor = Color.FromArgb(247, 198, 17)
            ButtonDrinks.BackColor = Color.White
            ButtonDessert.BackColor = Color.White
            ButtonToShare.BackColor = Color.White

            'Hides Column with Picture information

            DataGridViewMenu.Columns("Photo").Visible = False


        Else
            'Spanish was selected
            lblSec.Text = "Nuestra sección de: "
            LblTitle.Text = "Platos Principales"
            DataGridViewDescription.DataSource = Nothing
            PictureBoxItem.Image = Nothing
            'Shows the Main Dish Menu

            connection = New SqlConnection(connectionString)

            Dim menuTable As New DataTable
            Dim commandSelect As New SqlCommand("SELECT m.TypeFood 'Tipo',m.Name ,m.Price 'Precio ¢' ,m.Calories 'Calorías Kcal',m.Quantity 'Cantidad', f.Photo FROM MenuEsp m, FotosMenu f WHERE m.CodPlato = f.CodPlato AND Categories = 'Plato Fuerte'", connection)

            Dim dataAdapter As New SqlDataAdapter(commandSelect)
            dataAdapter.Fill(menuTable)

            DataGridViewMenu.DataSource = menuTable

            ButtonAppetizer.BackColor = Color.White
            ButtonMainDish.BackColor = Color.FromArgb(247, 198, 17)
            ButtonDrinks.BackColor = Color.White
            ButtonDessert.BackColor = Color.White
            ButtonToShare.BackColor = Color.White

            'Hides Column with Picture information

            DataGridViewMenu.Columns("Photo").Visible = False



        End If


    End Sub

    Private Sub ButtonDrinks_Click(sender As Object, e As EventArgs) Handles ButtonDrinks.Click
        ComboFiltro.Text = ""
        ComboFiltro.Items.Clear()
        Filtro = 3
        LblFiltro.Text = "3"


        If ButtonAppetizer.Text.Equals("Appetizers") Then
            If LblFiltro.Text = 3 Then
                lblTitulo.Visible = True
                Btnfiltrar.Visible = True
                ComboFiltro.Visible = True
                Try

                    connection = New SqlConnection(connectionString)
                    connection.Open()
                    Dim Filtro As New DataTable
                    Dim commandFilter As New SqlCommand("Exec FiltrosEng '" & LblFiltro.Text & "';", connection)
                    Dim Reader As SqlDataReader = commandFilter.ExecuteReader()

                    While Reader.Read()

                        ComboFiltro.Items.Add(Reader.GetString(0))

                    End While
                    connection.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If
        Else
            If LblFiltro.Text = 3 Then
                lblTitulo.Visible = True
                Btnfiltrar.Visible = True
                ComboFiltro.Visible = True
                Try
                    connection = New SqlConnection(connectionString)
                    connection.Open()

                    Dim Filtro As New DataTable
                    Dim commandFilter As New SqlCommand("Exec FiltrosEsp '" & LblFiltro.Text & "';", connection)
                    Dim Reader As SqlDataReader = commandFilter.ExecuteReader()

                    While Reader.Read()

                        ComboFiltro.Items.Add(Reader.GetString(0))

                    End While

                    connection.Close()


                Catch ex As Exception

                    MsgBox(ex.Message)
                End Try

            End If

        End If


        'Checks Which Language was selected
        If ButtonDrinks.Text.Equals("Drinks") Then
            'ENGLISH was selected

            lblSec.Text = "Our section of: "
            LblTitle.Text = "Drinks"
            DataGridViewDescription.DataSource = Nothing
            PictureBoxItem.Image = Nothing
            'Shows the Drinks Menu

            connection = New SqlConnection(connectionString)

            Dim menuTable As New DataTable
            Dim commandSelect As New SqlCommand("SELECT t.TypeEng 'Type',e.Name 'Name' ,m.Price 'Price ¢',m.Calories 'Calories Kcal',m.Quantity 'Quantity', f.Photo FROM MenuEsp m, FotosMenu f, MenuEng e, Types t WHERE m.CodPlato = f.CodPlato AND m.CodPlato = e.NoPlato AND m.TypeFood = t.TypeSpa AND Categories = 'Bebidas'", connection)

            Dim dataAdapter As New SqlDataAdapter(commandSelect)
            dataAdapter.Fill(menuTable)

            DataGridViewMenu.DataSource = menuTable

            ButtonAppetizer.BackColor = Color.White
            ButtonMainDish.BackColor = Color.White
            ButtonDrinks.BackColor = Color.FromArgb(24, 68, 219)
            ButtonDessert.BackColor = Color.White
            ButtonToShare.BackColor = Color.White

            'Hides Column with Picture information

            DataGridViewMenu.Columns("Photo").Visible = False



        Else
            'Spanish was selected
            lblSec.Text = "Nuestra sección de: "
            LblTitle.Text = "Bebidas"
            DataGridViewDescription.DataSource = Nothing
            PictureBoxItem.Image = Nothing
            'Shows the Drinks Menu

            connection = New SqlConnection(connectionString)

            Dim menuTable As New DataTable
            Dim commandSelect As New SqlCommand("SELECT m.TypeFood 'Tipo',m.Name ,m.Price 'Precio ¢' ,m.Calories 'Calorías Kcal',m.Quantity 'Cantidad', f.Photo FROM MenuEsp m, FotosMenu f WHERE m.CodPlato = f.CodPlato AND Categories = 'Bebidas'", connection)

            Dim dataAdapter As New SqlDataAdapter(commandSelect)
            dataAdapter.Fill(menuTable)

            DataGridViewMenu.DataSource = menuTable

            ButtonAppetizer.BackColor = Color.White
            ButtonMainDish.BackColor = Color.White
            ButtonDrinks.BackColor = Color.FromArgb(24, 68, 219)
            ButtonDessert.BackColor = Color.White
            ButtonToShare.BackColor = Color.White

            'Hides Column with Picture information

            DataGridViewMenu.Columns("Photo").Visible = False


        End If

    End Sub


    Private Sub ButtonDessert_Click(sender As Object, e As EventArgs) Handles ButtonDessert.Click
        ComboFiltro.Text = ""
        ComboFiltro.Items.Clear()
        Filtro = 4
        LblFiltro.Text = "4"

        'Verifica para comenzar las opeaciones de filtro'

        If ButtonAppetizer.Text.Equals("Appetizers") Then
            If LblFiltro.Text = 4 Then
                lblTitulo.Visible = True
                Btnfiltrar.Visible = True
                ComboFiltro.Visible = True
                Try

                    connection = New SqlConnection(connectionString)
                    connection.Open()
                    Dim Filtro As New DataTable
                    Dim commandFilter As New SqlCommand("Exec FiltrosEng '" & LblFiltro.Text & "';", connection)
                    Dim Reader As SqlDataReader = commandFilter.ExecuteReader()

                    While Reader.Read()

                        ComboFiltro.Items.Add(Reader.GetString(0))

                    End While
                    connection.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If
        Else
            If LblFiltro.Text = 4 Then
                lblTitulo.Visible = True
                Btnfiltrar.Visible = True
                ComboFiltro.Visible = True
                Try
                    connection = New SqlConnection(connectionString)
                    connection.Open()

                    Dim Filtro As New DataTable
                    Dim commandFilter As New SqlCommand("Exec FiltrosEsp '" & LblFiltro.Text & "';", connection)
                    Dim Reader As SqlDataReader = commandFilter.ExecuteReader()

                    While Reader.Read()

                        ComboFiltro.Items.Add(Reader.GetString(0))

                    End While

                    connection.Close()


                Catch ex As Exception

                    MsgBox(ex.Message)
                End Try

            End If

        End If

        'Checks Which Language was selected
        If ButtonDessert.Text.Equals("Desserts") Then
            'ENGLISH was selected


            lblSec.Text = "Our section of: "
            LblTitle.Text = "Desserts"
            DataGridViewDescription.DataSource = Nothing
            PictureBoxItem.Image = Nothing
            'Shows the Desserts Menu
            connection = New SqlConnection(connectionString)

            Dim menuTable As New DataTable
            Dim commandSelect As New SqlCommand("SELECT t.TypeEng 'Type',e.Name 'Name' ,m.Price 'Price ¢',m.Calories 'Calories Kcal',m.Quantity 'Quantity', f.Photo FROM MenuEsp m, FotosMenu f, MenuEng e, Types t WHERE m.CodPlato = f.CodPlato AND m.CodPlato = e.NoPlato AND m.TypeFood = t.TypeSpa AND Categories = 'Postres'", connection)

            Dim dataAdapter As New SqlDataAdapter(commandSelect)
            dataAdapter.Fill(menuTable)

            DataGridViewMenu.DataSource = menuTable

            ButtonAppetizer.BackColor = Color.White
            ButtonMainDish.BackColor = Color.White
            ButtonDrinks.BackColor = Color.White
            ButtonDessert.BackColor = Color.FromArgb(207, 27, 162)
            ButtonToShare.BackColor = Color.White

            'Hides Column with Picture information

            DataGridViewMenu.Columns("Photo").Visible = False

        Else
            'Spanish was selected
            lblSec.Text = "Nuestra sección de: "
            LblTitle.Text = "Postres"
            DataGridViewDescription.DataSource = Nothing
            PictureBoxItem.Image = Nothing
            'Shows the Desserts Menu
            connection = New SqlConnection(connectionString)

            Dim menuTable As New DataTable
            Dim commandSelect As New SqlCommand("SELECT m.TypeFood 'Tipo',m.Name ,m.Price 'Precio ¢' ,m.Calories 'Calorías Kcal',m.Quantity 'Cantidad', f.Photo FROM MenuEsp m, FotosMenu f WHERE m.CodPlato = f.CodPlato AND Categories ='Postres'", connection)

            Dim dataAdapter As New SqlDataAdapter(commandSelect)
            dataAdapter.Fill(menuTable)

            DataGridViewMenu.DataSource = menuTable

            ButtonAppetizer.BackColor = Color.White
            ButtonMainDish.BackColor = Color.White
            ButtonDrinks.BackColor = Color.White
            ButtonDessert.BackColor = Color.FromArgb(207, 27, 162)
            ButtonToShare.BackColor = Color.White

            'Hides Column with Picture information

            DataGridViewMenu.Columns("Photo").Visible = False


        End If


    End Sub

    Private Sub ButtonToShare_Click(sender As Object, e As EventArgs) Handles ButtonToShare.Click
        ComboFiltro.Text = ""
        ComboFiltro.Items.Clear()
        Filtro = 5
        LblFiltro.Text = "5"


        If ButtonAppetizer.Text.Equals("Appetizers") Then
            If LblFiltro.Text = 5 Then
                lblTitulo.Visible = True
                Btnfiltrar.Visible = True
                ComboFiltro.Visible = True
                Try

                    connection = New SqlConnection(connectionString)
                    connection.Open()
                    Dim Filtro As New DataTable
                    Dim commandFilter As New SqlCommand("Exec FiltrosEng '" & LblFiltro.Text & "';", connection)
                    Dim Reader As SqlDataReader = commandFilter.ExecuteReader()

                    While Reader.Read()

                        ComboFiltro.Items.Add(Reader.GetString(0))

                    End While
                    connection.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If
        Else
            If LblFiltro.Text = 5 Then
                lblTitulo.Visible = True
                Btnfiltrar.Visible = True
                ComboFiltro.Visible = True
                Try
                    connection = New SqlConnection(connectionString)
                    connection.Open()

                    Dim Filtro As New DataTable
                    Dim commandFilter As New SqlCommand("Exec FiltrosEsp '" & LblFiltro.Text & "';", connection)
                    Dim Reader As SqlDataReader = commandFilter.ExecuteReader()

                    While Reader.Read()

                        ComboFiltro.Items.Add(Reader.GetString(0))

                    End While

                    connection.Close()


                Catch ex As Exception

                    MsgBox(ex.Message)
                End Try

            End If

        End If

        'Checks Which Language was selected
        If ButtonToShare.Text.Equals("To Share") Then
            'ENGLISH was selected



            lblSec.Text = "Our section of: "
            LblTitle.Text = "To Share"
            DataGridViewDescription.DataSource = Nothing
            PictureBoxItem.Image = Nothing
            'Shows the "To Share" Menu

            connection = New SqlConnection(connectionString)

            Dim menuTable As New DataTable
            Dim commandSelect As New SqlCommand("SELECT t.TypeEng 'Type',e.Name 'Name' ,m.Price 'Price ¢',m.Calories 'Calories Kcal',m.Quantity 'Quantity', f.Photo FROM MenuEsp m, FotosMenu f, MenuEng e, Types t WHERE m.CodPlato = f.CodPlato AND m.CodPlato = e.NoPlato AND m.TypeFood = t.TypeSpa AND Categories = 'Para Compartir'", connection)

            Dim dataAdapter As New SqlDataAdapter(commandSelect)
            dataAdapter.Fill(menuTable)

            DataGridViewMenu.DataSource = menuTable

            ButtonAppetizer.BackColor = Color.White
            ButtonMainDish.BackColor = Color.White
            ButtonDrinks.BackColor = Color.White
            ButtonDessert.BackColor = Color.White
            ButtonToShare.BackColor = Color.FromArgb(153, 255, 78)

            'Hides Column with Picture information

            DataGridViewMenu.Columns("Photo").Visible = False


        Else
            'Spanish was selected
            lblSec.Text = "Nuestra sección de: "
            LblTitle.Text = "Para compartir"
            DataGridViewDescription.DataSource = Nothing
            PictureBoxItem.Image = Nothing
            'Shows the "To Share" Menu

            connection = New SqlConnection(connectionString)

            Dim menuTable As New DataTable
            Dim commandSelect As New SqlCommand("SELECT m.TypeFood 'Tipo',m.Name ,m.Price 'Precio ¢',m.Calories 'Calorías Kcal',m.Quantity 'Cantidad', f.Photo FROM MenuEsp m, FotosMenu f WHERE m.CodPlato = f.CodPlato AND Categories = 'Para Compartir'", connection)

            Dim dataAdapter As New SqlDataAdapter(commandSelect)
            dataAdapter.Fill(menuTable)

            DataGridViewMenu.DataSource = menuTable

            ButtonAppetizer.BackColor = Color.White
            ButtonMainDish.BackColor = Color.White
            ButtonDrinks.BackColor = Color.White
            ButtonDessert.BackColor = Color.White
            ButtonToShare.BackColor = Color.FromArgb(153, 255, 78)

            'Hides Column with Picture information

            DataGridViewMenu.Columns("Photo").Visible = False

        End If


    End Sub

    Private Sub DataGridViewMenu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMenu.CellClick


        'Checks Which Language was selected, Button Appetizer was used only to reference the language selected.
        If ButtonAppetizer.Text.Equals("Appetizers") Then
            'ENGLISH was selected

            'Gives description of item selected.

            Dim rowIndexMenu As Integer
            rowIndexMenu = e.RowIndex

            Dim rowMenu As DataGridViewRow = DataGridViewMenu.Rows(rowIndexMenu)
            item = rowMenu.Cells(1).Value

            connection = New SqlConnection(connectionString)

            Dim menuDescriptionTable As New DataTable
            Dim commandSelect As New SqlCommand("SELECT e.Description FROM MenuEng e,MenuEsp m WHERE e.NoPlato = m.CodPlato AND e.Name = '" & item & "'", connection)

            Dim dataAdapter As New SqlDataAdapter(commandSelect)
            dataAdapter.Fill(menuDescriptionTable)


            DataGridViewDescription.DataSource = menuDescriptionTable

            'Pulls photo of item selected

            Dim Bytes As [Byte]() = rowMenu.Cells(5).Value
            Dim ms As New MemoryStream(Bytes)
            PictureBoxItem.Image = Image.FromStream(ms)

        Else
            'Spanish was selected
            'Gives description of item selected.

            Dim rowIndexMenu As Integer
            rowIndexMenu = e.RowIndex

            Dim rowMenu As DataGridViewRow = DataGridViewMenu.Rows(rowIndexMenu)
            item = rowMenu.Cells(1).Value

            connection = New SqlConnection(connectionString)

            Dim menuDescriptionTable As New DataTable
            Dim commandSelect As New SqlCommand("SELECT Description 'Descripción' FROM MenuEsp WHERE Name = '" & item & "'", connection)

            Dim dataAdapter As New SqlDataAdapter(commandSelect)
            dataAdapter.Fill(menuDescriptionTable)


            DataGridViewDescription.DataSource = menuDescriptionTable

            'Pulls photo of item selected

            Dim Bytes As [Byte]() = rowMenu.Cells(5).Value
            Dim ms As New MemoryStream(Bytes)
            PictureBoxItem.Image = Image.FromStream(ms)


        End If



    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click






        Dim quantity As Integer
        quantity = 0
        Do Until (quantity = BunifuDropdown3.selectedIndex + 1)

            quantity = quantity + 1
            If DataGridViewMenu.RowCount = 0 Or Nothing Then
            Else
                For Each cell As DataGridViewColumn In DataGridViewMenu.Columns
                    DataGridViewOrder.Columns.Add(DirectCast(cell.Clone, DataGridViewColumn))
                Next
                DataGridViewOrder.Columns(3).Visible = False 'calorias
                DataGridViewOrder.Columns(0).Visible = False 'tipo
                'DataGridViewOrder.Columns(1).Visible = False Nombre
                'DataGridViewOrder.Columns(2).Visible = False precio
                'DataGridViewOrder.Columns(4).Visible = False 'cantidad
                'Esconde columnas excepto las de precio y nombre del item..


                DataGridViewOrder.ColumnCount = 5
                DataGridViewOrder.Rows.Add(DataGridViewMenu.CurrentRow.Cells.Cast(Of DataGridViewCell).Select(Function(c) c.Value).ToArray)

            End If
        Loop

        'Lo suguiente combina los rows del datagrid.      Cells(2) = Precio        Cells(4) = Cantidad
        Dim t As Integer = 0

        Do While (t < DataGridViewOrder.RowCount - 1)


            Dim Row = DataGridViewOrder.Rows(t)
            Dim abc As String = (Row.Cells(0).Value.ToString + Row.Cells(3).Value.ToString.ToUpper)
            Dim j As Integer = (t + 1)

            Do While (j < DataGridViewOrder.RowCount)
                Dim Row2 = DataGridViewOrder.Rows(j)
                Dim def As String = (Row2.Cells(0).Value.ToString + Row2.Cells(3).Value.ToString.ToUpper)

                If (abc = def) Then
                    Row.Cells(4).Value = (CType(Row.Cells(4).Value, Integer) + CType(Row2.Cells(4).Value, Integer))
                    Row.Cells(2).Value = (CType(Row.Cells(2).Value, Integer) + CType(Row2.Cells(2).Value, Integer))
                    DataGridViewOrder.Rows.Remove(Row2)
                    j = (j - 1)
                End If

                j = (j + 1)
            Loop

            t = (t + 1)
        Loop

        'Suma y envío de precio total al textBox
        TextBoxSum.Text = (From rowA As DataGridViewRow In DataGridViewOrder.Rows
                           Where rowA.Cells(2).FormattedValue.ToString() <> String.Empty
                           Select Convert.ToInt32(rowA.Cells(2).FormattedValue)).Sum().ToString()

        ''suma total y lo manda al textbox
        'Dim sum As Double = 0
        'For i As Integer = 0 To DataGridViewOrder.Rows.Count() - 1 Step +1
        '    sum = sum + DataGridViewOrder.Rows(i).Cells(2).Value
        'Next
        'TextBoxSum.Text = sum.ToString()



    End Sub





    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click

        'resta al total y lo manda al textbox

        Dim substract As Double = CDbl(TextBoxSum.Text)
        substract = substract - (DataGridViewOrder.CurrentRow.Cells(2).Value / DataGridViewOrder.CurrentRow.Cells(4).Value)

        ' actualiza Cantidad y Precio en el datagrid
        DataGridViewOrder.CurrentRow.Cells(2).Value = DataGridViewOrder.CurrentRow.Cells(2).Value - (DataGridViewOrder.CurrentRow.Cells(2).Value / DataGridViewOrder.CurrentRow.Cells(4).Value)
        DataGridViewOrder.CurrentRow.Cells(4).Value = DataGridViewOrder.CurrentRow.Cells(4).Value - (DataGridViewOrder.CurrentRow.Cells(4).Value / DataGridViewOrder.CurrentRow.Cells(4).Value)
        TextBoxSum.Text = substract.ToString()

        If (DataGridViewOrder.CurrentRow.Cells(4).Value = 0) Then
            Dim index As Integer
            index = DataGridViewOrder.CurrentCell.RowIndex
            'borra fila seleccionada
            DataGridViewOrder.Rows.RemoveAt(index)
        End If


        'Dim index As Integer
        'index = DataGridViewOrder.CurrentCell.RowIndex
        ''borra fila seleccionada
        'DataGridViewOrder.Rows.RemoveAt(index)


        'DataGridViewOrder.Rows.Clear()
        'TextBoxSum.Text = 0


    End Sub

    Private Sub PictureBoxItem_Click(sender As Object, e As EventArgs) Handles PictureBoxItem.Click

    End Sub

    Private Sub DataGridViewMenu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMenu.CellContentClick

    End Sub

    Private Sub Btnfiltrar_Click(sender As Object, e As EventArgs) Handles Btnfiltrar.Click

        If lblleng.Text = "2" Then

            Try

                connection = New SqlConnection(connectionString)

                Dim menuTable As New DataTable
                Dim commandSelect As New SqlCommand("Exec searchEng '" & ComboFiltro.Text & "';", connection)

                Dim dataAdapter As New SqlDataAdapter(commandSelect)
                dataAdapter.Fill(menuTable)

                DataGridViewMenu.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(4, 172, 209)

                DataGridViewMenu.DataSource = menuTable

                ButtonAppetizer.BackColor = Color.FromArgb(4, 172, 209)
                ButtonMainDish.BackColor = Color.White
                ButtonDrinks.BackColor = Color.White
                ButtonDessert.BackColor = Color.White
                ButtonToShare.BackColor = Color.White

                'Hides Column with Picture information

                DataGridViewMenu.Columns("Photo").Visible = False
            Catch ex As Exception

                MsgBox("Error en filtro")
            End Try


        ElseIf lblleng.Text = "1" Then


            Try
                connection = New SqlConnection(connectionString)

                Dim menuTable As New DataTable
                Dim commandSelect As New SqlCommand("Exec SearchEsp '" & ComboFiltro.Text & "';", connection)

                Dim dataAdapter As New SqlDataAdapter(commandSelect)
                dataAdapter.Fill(menuTable)

                DataGridViewMenu.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(4, 172, 209)

                DataGridViewMenu.DataSource = menuTable

                ButtonAppetizer.BackColor = Color.FromArgb(4, 172, 209)
                ButtonMainDish.BackColor = Color.White
                ButtonDrinks.BackColor = Color.White
                ButtonDessert.BackColor = Color.White
                ButtonToShare.BackColor = Color.White

                'Hides Column with Picture information

                DataGridViewMenu.Columns("Photo").Visible = False


            Catch ex As Exception

                MsgBox("Error Filtro")
            End Try


        End If

        'If ButtonAppetizer.Text.Equals("Appetizers") Then
        '    Try

        '        connection = New SqlConnection(connectionString)

        '        Dim menuTable As New DataTable
        '        Dim commandSelect As New SqlCommand("Exec searchEng '" & ComboFiltro.Text & "';", connection)

        '        Dim dataAdapter As New SqlDataAdapter(commandSelect)
        '        dataAdapter.Fill(menuTable)

        '        DataGridViewMenu.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(4, 172, 209)

        '        DataGridViewMenu.DataSource = menuTable

        '        ButtonAppetizer.BackColor = Color.FromArgb(4, 172, 209)
        '        ButtonMainDish.BackColor = Color.White
        '        ButtonDrinks.BackColor = Color.White
        '        ButtonDessert.BackColor = Color.White
        '        ButtonToShare.BackColor = Color.White

        '        'Hides Column with Picture information

        '        DataGridViewMenu.Columns("Photo").Visible = False
        '    Catch ex As Exception

        '        MsgBox("Error en filtro")
        '    End Try


        'Else

        '    Try
        '        connection = New SqlConnection(connectionString)

        '        Dim menuTable As New DataTable
        '        Dim commandSelect As New SqlCommand("Exec SearchEsp '" & ComboFiltro.Text & "';", connection)

        '        Dim dataAdapter As New SqlDataAdapter(commandSelect)
        '        dataAdapter.Fill(menuTable)

        '        DataGridViewMenu.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(4, 172, 209)

        '        DataGridViewMenu.DataSource = menuTable

        '        ButtonAppetizer.BackColor = Color.FromArgb(4, 172, 209)
        '        ButtonMainDish.BackColor = Color.White
        '        ButtonDrinks.BackColor = Color.White
        '        ButtonDessert.BackColor = Color.White
        '        ButtonToShare.BackColor = Color.White

        '        'Hides Column with Picture information

        '        DataGridViewMenu.Columns("Photo").Visible = False


        '    Catch ex As Exception

        '        MsgBox("Error Filtro")
        '    End Try

        'End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'resta al total y lo manda al textbox
        Dim substract As Double = CDbl(TextBoxSum.Text)

        substract = substract - DataGridViewOrder.CurrentRow.Cells(2).Value

        TextBoxSum.Text = substract.ToString()


        Dim index As Integer
        index = DataGridViewOrder.CurrentCell.RowIndex
        'borra fila seleccionada
        DataGridViewOrder.Rows.RemoveAt(index)

    End Sub

    Private Sub btnWaiter_Click(sender As Object, e As EventArgs) Handles btnWaiter.Click
        FormTable.Show()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

        Try
            Dim sourceGrid As DataGridView = Me.DataGridViewOrder
            Dim targetGrid As DataGridView = Orden.DTGList


            Dim targetRows = New List(Of DataGridViewRow)

            For Each sourceRow As DataGridViewRow In sourceGrid.Rows

                If (Not sourceRow.IsNewRow) Then

                    Dim targetRow = CType(sourceRow.Clone(), DataGridViewRow)



                    For Each cell As DataGridViewCell In sourceRow.Cells
                        targetRow.Cells(cell.ColumnIndex).Value = cell.Value
                    Next

                    targetRows.Add(targetRow)

                End If

            Next



            targetGrid.Columns.Clear()

            For Each column As DataGridViewColumn In sourceGrid.Columns
                targetGrid.Columns.Add(CType(column.Clone(), DataGridViewColumn))
            Next



            targetGrid.Rows.AddRange(targetRows.ToArray())
            Orden.Show()


        Catch ex As Exception
            MsgBox("Verifica que seleccionaras contenidos!")
        End Try


    End Sub
End Class
