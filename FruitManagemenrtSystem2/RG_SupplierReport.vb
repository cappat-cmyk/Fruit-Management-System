Public Class RG_SupplierReport

    Private Sub RG_SupplierReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FMSDataSet1.SupplierDetails' table. You can move, or remove it, as needed.
        Me.SupplierDetailsTableAdapter.Fill(Me.FMSDataSet1.SupplierDetails)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class