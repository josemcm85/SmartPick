Public Class FormReport
    Private Sub FormReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MenuTTSDataSet.customerSatisfaction' table. You can move, or remove it, as needed.
        Me.customerSatisfactionTableAdapter.Fill(Me.MenuTTSDataSet.customerSatisfaction)
        'TODO: This line of code loads data into the 'MenuTTSDataSet.Orden' table. You can move, or remove it, as needed.
        Me.OrdenTableAdapter.Fill(Me.MenuTTSDataSet.Orden)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub BtnClose3_Click(sender As Object, e As EventArgs) Handles BtnClose3.Click

        Me.Close()


    End Sub

End Class