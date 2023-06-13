Public Class RG_PurchaseReport

    Private Sub RG_PurchaseReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FMSDataSet1.PurchaseOrder' table. You can move, or remove it, as needed.
        Me.PurchaseOrderTableAdapter.Fill(Me.FMSDataSet1.PurchaseOrder)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class