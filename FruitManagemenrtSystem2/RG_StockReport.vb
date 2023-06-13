Public Class RG_StockReport

    Private Sub RG_StockReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FMSDataSet1.Restocking' table. You can move, or remove it, as needed.
        Me.RestockingTableAdapter.Fill(Me.FMSDataSet1.Restocking)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class