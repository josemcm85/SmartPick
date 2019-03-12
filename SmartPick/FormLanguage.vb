Public Class FormLanguage
    Private Sub ButtonSpaMenu_Click(sender As Object, e As EventArgs) Handles ButtonSpaMenu.Click
        Me.Close()
        FormMenu.Show()
        FormMenu.lblleng.Text = "1"
        FormMenu.LabelOrder.Text = "Su orden:"

    End Sub

    Private Sub ButtonEngMenu_Click(sender As Object, e As EventArgs) Handles ButtonEngMenu.Click

        Me.Close()
        FormMenu.Show()

        FormMenu.LabelOrder.Text = "Your order:"

        FormMenu.ButtonAppetizer.Text = "Appetizers"
        FormMenu.ButtonMainDish.Text = "Main Dish"
        FormMenu.ButtonDrinks.Text = "Drinks"
        FormMenu.ButtonDessert.Text = "Desserts"
        FormMenu.ButtonToShare.Text = "To Share"
        FormMenu.lblTitulo.Text = "Filter: "
        FormMenu.lblleng.Text = "2"
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

    Private Sub FormLanguage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class