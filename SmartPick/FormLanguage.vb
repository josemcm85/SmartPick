﻿Public Class FormLanguage
    Private Sub ButtonSpaMenu_Click(sender As Object, e As EventArgs) Handles ButtonSpaMenu.Click
        Me.Close()
        FormMenu.Show()

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
End Class