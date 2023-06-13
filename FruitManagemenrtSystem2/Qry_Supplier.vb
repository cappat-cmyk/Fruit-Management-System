Imports System.Data.OleDb
Public Class Qry_Supplier
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\client\OneDrive\Documents\FMS.mdb")
    Private Sub bind_data()

        Dim cmd1 As New OleDbCommand("Select * from SupplierDetails", conn)

        Dim da As New OleDbDataAdapter

        da.SelectCommand = cmd1

        Dim SupplierDetails As New DataTable

        SupplierDetails.Clear()

        da.Fill(SupplierDetails)

        DataGridView1.DataSource = SupplierDetails
    End Sub
    Private Sub Qry_Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bind_data()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim cmd1 As New OleDbCommand("Select * from SupplierDetails where SupplierName = " +
 TextBox1.Text + "", conn)

        cmd1.Parameters.AddWithValue("@SupplierName", TextBox1.Text)

        Dim da As New OleDbDataAdapter

        da.SelectCommand = cmd1

        Dim ProductDetails As New DataTable

        ProductDetails.Clear()

        da.Fill(ProductDetails)

        DataGridView1.DataSource = ProductDetails
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd1 As New OleDbCommand("Select * from SupplierDetails" + "", conn)



        Dim da As New OleDbDataAdapter

        da.SelectCommand = cmd1

        Dim ProductDetails As New DataTable

        ProductDetails.Clear()

        da.Fill(ProductDetails)

        DataGridView1.DataSource = ProductDetails
    End Sub
End Class