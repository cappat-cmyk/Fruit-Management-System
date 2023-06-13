Imports System.Data.OleDb
Public Class SupplierDetails
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

    Private Sub SupplierDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        bind_data()
        Dim rst As ADODB.Recordset
        rst = opentable("Select * from SupplierDetails", ADODB.CursorLocationEnum.adUseClient)
        With rst
            .MoveLast()
            TextBox1.Text = .Fields("SupplierID").Value + 1
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oForm As New SupplierDetails

        oForm.Show()

        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strsql As String

        strsql = "Insert into SupplierDetails(SupplierID,SupplierName,Email,PhoneNumber,Addresses)Values(@SupplierID,@SupplierName,@Email,@PhoneNumber,@Addresses)"
        Dim cmd2 As New OleDbCommand(strsql, conn)

        cmd2.Parameters.AddWithValue("@SupplierID", TextBox1.Text)
        cmd2.Parameters.AddWithValue("@SupplierName", TextBox2.Text)
        cmd2.Parameters.AddWithValue("@Email", TextBox3.Text)
        cmd2.Parameters.AddWithValue("@PhoneNumber", TextBox4.Text)
        cmd2.Parameters.AddWithValue("@Addresses", TextBox5.Text)
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

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cmd4 As New OleDbCommand("Update SupplierDetails set SupplierName='" & TextBox2.Text & "',Email='" & TextBox3.Text & "',PhoneNumber='" & TextBox4.Text & "',Addresses='" & TextBox5.Text & "' where SupplierID=" & TextBox1.Text & "", conn)

        conn.Open()

        cmd4.ExecuteNonQuery()

        conn.Close()

        bind_data()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cmd5 As New OleDbCommand("delete from SupplierDetails where SupplierID=@SupplierID", conn)

        cmd5.Parameters.AddWithValue("@SupplierID", TextBox1.Text)

        conn.Open()

        cmd5.ExecuteNonQuery()

        conn.Close()

        bind_data()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim viewproductnumber As String
        viewproductnumber = InputBox("Please Enter Supplier Number: ", "Search Product", 0)
        Dim cmd1 As New OleDbCommand("Select * from SupplierDetails where SupplierID = " +
        viewproductnumber + "", conn)

        cmd1.Parameters.AddWithValue("@SupplierID", viewproductnumber)

        Dim da As New OleDbDataAdapter

        da.SelectCommand = cmd1

        Dim SupplierDetails As New DataTable

        SupplierDetails.Clear()

        da.Fill(SupplierDetails)

        DataGridView1.DataSource = SupplierDetails
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
    End Sub
End Class