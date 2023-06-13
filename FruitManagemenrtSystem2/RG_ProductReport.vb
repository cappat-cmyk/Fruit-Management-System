Public Class RG_ProductReport


    Private Sub ProductReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FMSDataSet.ProductDetails' table. You can move, or remove it, as needed.
        Me.ProductDetailsTableAdapter.Fill(Me.FMSDataSet.ProductDetails)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class