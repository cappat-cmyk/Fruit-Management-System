Public Class Tr_SupplierTransaction

    Private Sub SupplierTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = Format(Now, )

        Dim rst As ADODB.Recordset
        rst = opentable("Select * from Restocking", ADODB.CursorLocationEnum.adUseClient)
        With rst
            .MoveLast()
            TextBox1.Text = .Fields("StockOrderNo").Value + 1
        End With
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Then
            MsgBox("Please insert supplier number")
        Else
            Dim hanapinnatinsicustomer As ADODB.Recordset
            hanapinnatinsicustomer = opentable("Select * from SupplierDetails where SupplierID=" + TextBox2.Text + "", ADODB.CursorLocationEnum.adUseClient)
            With hanapinnatinsicustomer
                If .EOF And .BOF Then
                    MsgBox("customer not found, add it to customer file first")
                Else
                    Label9.Text = .Fields("SupplierName").Value

                End If
            End With
        End If
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Format(Now, )
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox3.Text = "" Then
            MsgBox("Please Enter Product ID")
        Else
            Dim hanapinnatinsiproduct As ADODB.Recordset
            hanapinnatinsiproduct = opentable("Select * from ProductDetails where ProductID= " + TextBox3.Text + "",
                                              ADODB.CursorLocationEnum.adUseClient)
            With hanapinnatinsiproduct
                If .BOF And .EOF Then
                    MsgBox("product code not found, check code")
                Else
                    Label10.Text = .Fields("ProductName").Value

                    TextBox4.Text = .Fields("Quantity").Value
                End If
            End With
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim isavesiorder As ADODB.Recordset
        isavesiorder = opentable("Select * from Restocking", ADODB.CursorLocationEnum.adUseServer)



        With isavesiorder
            .AddNew()
            .Fields("StockOrderNo").Value = TextBox1.Text
            .Fields("SupplierID").Value = TextBox2.Text
            .Fields("ProductID").Value = TextBox3.Text
            .Fields("StockAdded").Value = TextBox5.Text
            .Fields("PurchaseDate").Value = Format(Now, )
            .Update()
            MsgBox("Your order is successfully added")

            Dim rst As ADODB.Recordset
            rst = opentable("Select * from ProductDetails where ProductID= " + TextBox3.Text + "", ADODB.CursorLocationEnum.adUseServer)
            With rst

                If .BOF And .EOF Then
                    MsgBox("product code not found, check code")
                Else

                    rst.Fields("Quantity").Value = TextBox6.Text
                    .Update()



                End If
            End With
        End With
    End Sub

 

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged


        Dim num1 As Double
        Dim num2 As Double
        Dim num3 As Double
        num1 = Convert.ToDouble(TextBox4.Text)
        num2 = Convert.ToDouble(TextBox5.Text)
        num3 = num1 + num2
        TextBox6.Text = CStr(num3)
        Label11.Text = TextBox6.Text

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim oForm As New Tr_SupplierTransaction

        oForm.Show()

        Me.Hide()
    End Sub
End Class