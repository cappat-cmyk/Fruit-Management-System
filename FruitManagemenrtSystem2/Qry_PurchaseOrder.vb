Imports System.Data.OleDb
Public Class Qry_PurchaseOrder
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\client\OneDrive\Documents\FMS.mdb")
    Private Sub bind_data()

        Dim cmd1 As New OleDbCommand("Select * from PurchaseOrder", conn)

        Dim da As New OleDbDataAdapter

        da.SelectCommand = cmd1

        Dim PurchaseOrder As New DataTable

        PurchaseOrder.Clear()

        da.Fill(PurchaseOrder)

        DataGridView1.DataSource = PurchaseOrder

    End Sub
    Private Sub Qry_PurchaseOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bind_data()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim cmd1 As New OleDbCommand("Select * from PurchaseOrder where PurchaseOrderNumber = " +
  TextBox1.Text + "", conn)

        cmd1.Parameters.AddWithValue("@PurchaseOrderNumber", TextBox1.Text)

        Dim da As New OleDbDataAdapter

        da.SelectCommand = cmd1

        Dim ProductDetails As New DataTable

        ProductDetails.Clear()

        da.Fill(ProductDetails)

        DataGridView1.DataSource = ProductDetails
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd1 As New OleDbCommand("Select * from PurchaseOrder" + "", conn)



        Dim da As New OleDbDataAdapter

        da.SelectCommand = cmd1

        Dim ProductDetails As New DataTable

        ProductDetails.Clear()

        da.Fill(ProductDetails)

        DataGridView1.DataSource = ProductDetails
    End Sub
End Class