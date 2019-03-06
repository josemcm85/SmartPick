Imports System.Data.SqlClient

Public Class FormMenu

    Dim item As String
    Dim connectionString As String = "Server= DESKTOP-KBTK5SB; Database=MenuTTS ; Integrated Security= true"
    Dim connection As SqlConnection


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Add curves to the shape of the form

        Me.FormBorderStyle = FormBorderStyle.None
        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        p.AddLine(40, 0, Me.Width - 40, 0)
        p.AddArc(New Rectangle(Me.Width - 40, 0, 40, 40), -90, 90)
        p.AddLine(Me.Width, 40, Me.Width, Me.Height - 40)
        p.AddArc(New Rectangle(Me.Width - 40, Me.Height - 40, 40, 40), 0, 90)
        p.AddLine(Me.Width - 40, Me.Height, 40, Me.Height)
        p.AddArc(New Rectangle(0, Me.Height - 40, 40, 40), 90, 90)
        p.CloseFigure()
        Me.Region = New Region(p)




    End Sub

    Private Sub PictureBoxClose_Click(sender As Object, e As EventArgs) Handles PictureBoxClose.Click

        'Close the Application

        Me.Close()

    End Sub

    Private Sub PictureBoxMinimize_Click(sender As Object, e As EventArgs) Handles PictureBoxMinimize.Click

        'Minimize the Application

        Me.WindowState = FormWindowState.Minimized


    End Sub

    Private Sub ButtonAppetizer_Click(sender As Object, e As EventArgs) Handles ButtonAppetizer.Click

        'Shows the Appetizer Menu



        connection = New SqlConnection(connectionString)

        Dim menuTable As New DataTable
        Dim commandSelect As New SqlCommand("SELECT TipoComida 'Tipo',Nombre ,Precio ,Calorias 'Calorías Kcal' FROM MenuEsp WHERE Categoria = 'Entrada'", connection)

        Dim dataAdapter As New SqlDataAdapter(commandSelect)
        dataAdapter.Fill(menuTable)

        DataGridViewMenu.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(4, 172, 209)

        DataGridViewMenu.DataSource = menuTable

        ButtonAppetizer.BackColor = Color.FromArgb(4, 172, 209)
        ButtonMainDish.BackColor = Color.White
        ButtonDrinks.BackColor = Color.White
        ButtonDessert.BackColor = Color.White
        ButtonToShare.BackColor = Color.White



    End Sub

    Private Sub ButtonMainDish_Click(sender As Object, e As EventArgs) Handles ButtonMainDish.Click

        'Shows the Main Dish Menu

        connection = New SqlConnection(connectionString)

        Dim menuTable As New DataTable
        Dim commandSelect As New SqlCommand("SELECT TipoComida 'Tipo',Nombre ,Precio ,Calorias 'Calorías Kcal' FROM MenuEsp WHERE Categoria = 'Plato Fuerte'", connection)

        Dim dataAdapter As New SqlDataAdapter(commandSelect)
        dataAdapter.Fill(menuTable)

        DataGridViewMenu.DataSource = menuTable

        ButtonAppetizer.BackColor = Color.White
        ButtonMainDish.BackColor = Color.FromArgb(247, 198, 17)
        ButtonDrinks.BackColor = Color.White
        ButtonDessert.BackColor = Color.White
        ButtonToShare.BackColor = Color.White

    End Sub

    Private Sub ButtonDrinks_Click(sender As Object, e As EventArgs) Handles ButtonDrinks.Click

        'Shows the Drinks Menu

        connection = New SqlConnection(connectionString)

        Dim menuTable As New DataTable
        Dim commandSelect As New SqlCommand("SELECT TipoComida 'Tipo',Nombre ,Precio ,Calorias 'Calorías Kcal' FROM MenuEsp WHERE Categoria = 'Bebida'", connection)

        Dim dataAdapter As New SqlDataAdapter(commandSelect)
        dataAdapter.Fill(menuTable)

        DataGridViewMenu.DataSource = menuTable

        ButtonAppetizer.BackColor = Color.White
        ButtonMainDish.BackColor = Color.White
        ButtonDrinks.BackColor = Color.FromArgb(24, 68, 219)
        ButtonDessert.BackColor = Color.White
        ButtonToShare.BackColor = Color.White

    End Sub

    Private Sub ButtonDessert_Click(sender As Object, e As EventArgs) Handles ButtonDessert.Click

        'Shows the Desserts Menu

        connection = New SqlConnection(connectionString)

        Dim menuTable As New DataTable
        Dim commandSelect As New SqlCommand("SELECT TipoComida 'Tipo',Nombre ,Precio ,Calorias 'Calorías Kcal' FROM MenuEsp WHERE Categoria = 'Postre'", connection)

        Dim dataAdapter As New SqlDataAdapter(commandSelect)
        dataAdapter.Fill(menuTable)

        DataGridViewMenu.DataSource = menuTable

        ButtonAppetizer.BackColor = Color.White
        ButtonMainDish.BackColor = Color.White
        ButtonDrinks.BackColor = Color.White
        ButtonDessert.BackColor = Color.FromArgb(207, 27, 162)
        ButtonToShare.BackColor = Color.White

    End Sub

    Private Sub ButtonToShare_Click(sender As Object, e As EventArgs) Handles ButtonToShare.Click

        'Shows the "To Share" Menu

        connection = New SqlConnection(connectionString)

        Dim menuTable As New DataTable
        Dim commandSelect As New SqlCommand("SELECT TipoComida 'Tipo',Nombre ,Precio ,Calorias 'Calorías Kcal' FROM MenuEsp WHERE Categoria = 'Compartir'", connection)

        Dim dataAdapter As New SqlDataAdapter(commandSelect)
        dataAdapter.Fill(menuTable)

        DataGridViewMenu.DataSource = menuTable

        ButtonAppetizer.BackColor = Color.White
        ButtonMainDish.BackColor = Color.White
        ButtonDrinks.BackColor = Color.White
        ButtonDessert.BackColor = Color.White
        ButtonToShare.BackColor = Color.FromArgb(153, 255, 78)

    End Sub

    Private Sub DataGridViewMenu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMenu.CellClick

        'Gives description of item selected.

        Dim rowIndex As Integer
        rowIndex = e.RowIndex

        Dim row As DataGridViewRow = DataGridViewMenu.Rows(rowIndex)
        item = row.Cells(1).Value

        connection = New SqlConnection(connectionString)

        Dim menuDescriptionTable As New DataTable
        Dim commandSelect As New SqlCommand("SELECT Descripcion 'Descripción' FROM MenuEsp WHERE Nombre = '" & item & "'", connection)

        Dim dataAdapter As New SqlDataAdapter(commandSelect)
        dataAdapter.Fill(menuDescriptionTable)


        DataGridViewDescription.DataSource = menuDescriptionTable


    End Sub



End Class
