Public Class Form1

    Private Sub ProductDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductDetailsToolStripMenuItem.Click
        ProductDetails.Show()
    End Sub

    Private Sub SupplierDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierDetailsToolStripMenuItem.Click
        SupplierDetails.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem.Click
        Qry_Product.Show()
    End Sub

    Private Sub PurchaseOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseOrderToolStripMenuItem.Click
        Tr_PurchaseOrder.Show()
    End Sub

    Private Sub SupplierTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierTransactionToolStripMenuItem.Click
        Tr_SupplierTransaction.Show()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        Qry_Supplier.Show()
    End Sub

    Private Sub PurhcaseOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurhcaseOrderToolStripMenuItem.Click
        Qry_PurchaseOrder.Show()
    End Sub

    Private Sub ProductReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductReportToolStripMenuItem.Click
        RG_ProductReport.Show()
    End Sub

    Private Sub PurchaseReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseReportToolStripMenuItem.Click
        RG_PurchaseReport.Show()
    End Sub

    Private Sub StockReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockReportToolStripMenuItem.Click
        RG_StockReport.Show()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SupplierReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierReportToolStripMenuItem.Click
        RG_SupplierReport.Show()
    End Sub
End Class
