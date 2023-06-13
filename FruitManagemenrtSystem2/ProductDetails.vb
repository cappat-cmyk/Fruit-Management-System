Imports System.Data.OleDb
Public Class ProductDetails
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\client\OneDrive\Documents\FMS.mdb")
    Private Sub bind_data()

        Dim cmd1 As New OleDbCommand("Select * from ProductDetails", conn)

        Dim da As New OleDbDataAdapter

        da.SelectCommand = cmd1

        Dim ProductDetails As New DataTable

        ProductDetails.Clear()

        da.Fill(ProductDetails)

        DataGridView1.DataSource = ProductDetails

    End Sub

    Private Sub ProductDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        bind_data()

        Dim rst As ADODB.Recordset
        rst = opentable("Select * from ProductDetails", ADODB.CursorLocationEnum.adUseClient)
        With rst
            .MoveLast()
            TextBox1.Text = .Fields("ProductID").Value + 1
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oForm As New ProductDetails

        oForm.Show()

        Me.Hide()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strsql As String

        strsql = "Insert into ProductDetails(ProductID,ProductName,DatePurchased,QualityDescription,Quantity,Price)Values(@ProductID,@ProductName,@DatePurchased,@QualityDescription,@Quantity,@Price)"
        Dim cmd2 As New OleDbCommand(strsql, conn)

        cmd2.Parameters.AddWithValue("@ProductID", TextBox1.Text)
        cmd2.Parameters.AddWithValue("@ProductName", TextBox2.Text)
        cmd2.Parameters.AddWithValue("@DatePurchased", TextBox3.Text)
        cmd2.Parameters.AddWithValue("@QualityDescription", TextBox4.Text)
        cmd2.Parameters.AddWithValue("@Quantity", TextBox5.Text)
        cmd2.Parameters.AddWithValue("@Price", TextBox6.Text)
        conn.Open()

        cmd2.ExecuteNonQuery()

        conn.Close()

        bind_data()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer

        index = e.RowIndex

        Dim selectedrow As DataGridViewRow = DataGridView1.Rows(index)

        TextBox1.Text = selectedrow.Cells(0).Value.ToString

        TextBox2.Text = selectedrow.Cells(1).Value.ToString

        TextBox3.Text = selectedrow.Cells(2).Value.ToString

        TextBox4.Text = selectedrow.Cells(3).Value.ToString

        TextBox5.Text = selectedrow.Cells(4).Value.ToString

        TextBox6.Text = selectedrow.Cells(5).Value.ToString

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cmd4 As New OleDbCommand("Update ProductDetails set ProductName='" & TextBox2.Text & "',DatePurchased='" & TextBox3.Text & "',QualityDescription='" & TextBox4.Text & "',Quantity='" & TextBox5.Text & "',Price=" & TextBox6.Text & " where ProductID=" & TextBox1.Text & "", conn)

        conn.Open()

        cmd4.ExecuteNonQuery()

        conn.Close()

        bind_data()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cmd5 As New OleDbCommand("delete from ProductDetails where ProductID=@ProductID", conn)

        cmd5.Parameters.AddWithValue("@ProductID", TextBox1.Text)

        conn.Open()

        cmd5.ExecuteNonQuery()

        conn.Close()

        bind_data()
    End Sub

   

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Dim viewproductnumber As String
        viewproductnumber = InputBox("Please Enter Product Number: ", "Search Product", 0)
        Dim cmd1 As New OleDbCommand("Select * from ProductDetails where Productid = " +
        viewproductnumber + "", conn)

        cmd1.Parameters.AddWithValue("@ProductID", viewproductnumber)

        Dim da As New OleDbDataAdapter

        da.SelectCommand = cmd1

        Dim ProductDetails As New DataTable

        ProductDetails.Clear()

        da.Fill(ProductDetails)

        DataGridView1.DataSource = ProductDetails
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class