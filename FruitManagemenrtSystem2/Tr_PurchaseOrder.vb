Public Class Tr_PurchaseOrder


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Format(Now, )
    End Sub

    Private Sub t_order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = Format(Now, )

        Dim rst As ADODB.Recordset
        rst = opentable("Select * from purchaseorder", ADODB.CursorLocationEnum.adUseClient)
        With rst
            .MoveLast()
            TextBox1.Text = .Fields("purchaseordernumber").Value + 1
        End With

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
                    Label11.Text = .Fields("Price").Value
                    TextBox4.Text = .Fields("Price").Value
                    TextBox6.Text = .Fields("Quantity").Value
                End If
            End With
        End If


    End Sub



    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text = "" Then
            MsgBox("Enter Quantity")
        Else
            Label12.Text = (TextBox4.Text * TextBox5.Text)
            TextBox9.Text = Label12.Text
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox8.Text < TextBox9.Text Then
            MsgBox("Insufficient funds, Please input higher value")

        Else
            Dim num1 As Double
            Dim num2 As Double

            num1 = Convert.ToDouble(TextBox5.Text)
            num2 = Convert.ToDouble(TextBox6.Text)
            Dim isavesiorder As ADODB.Recordset
            isavesiorder = opentable("Select * from PurchaseOrder", ADODB.CursorLocationEnum.adUseServer)

            If (num1 > num2) Then
                MsgBox("Not enough stock")
            ElseIf (num1 <= num2) Then

                With isavesiorder
                    .AddNew()
                    .Fields("OrderDate").Value = Format(Now, )
                    .Fields("ProductID").Value = TextBox3.Text
                    .Fields("CustomerName").Value = TextBox2.Text
                    .Fields("Quantity").Value = TextBox5.Text
                    .Fields("PurchaseOrderNumber").Value = TextBox1.Text
                    .Update()
                    MsgBox("Your order is successfully added")


                    Dim rst As ADODB.Recordset
                    rst = opentable("Select * from ProductDetails where ProductID= " + TextBox3.Text + "", ADODB.CursorLocationEnum.adUseServer)
                    With rst

                        If .BOF And .EOF Then
                            MsgBox("product code not found, check code")
                        Else
                            TextBox7.Text = num2 - num1
                            rst.Fields("Quantity").Value = TextBox7.Text
                            .Update()
                            If (TextBox7.Text <= 10) Then
                                MsgBox("Running out of Stocks")
                            End If
                        End If
                    End With
                End With
            Else
                MsgBox("Invalid value")
            End If
        End If




    End Sub


    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

        If TextBox8.Text >= TextBox9.Text Then
            TextBox10.Text = TextBox8.Text - TextBox9.Text
            Label16.Text = TextBox10.Text
        ElseIf TextBox10.Text < TextBox9.Text Then
            Label16.Text = "Insufficient funds, Please Input higher value"

        ElseIf TextBox8.Text < TextBox9.Text Then
            Label16.Text = "Insufficient funds, Please Input higher value"
        Else
            MsgBox("Invalid Funds")
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oForm As New Tr_PurchaseOrder

        oForm.Show()

        Me.Hide()


    End Sub
End Class