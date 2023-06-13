Module databaseconnection
    Public Function opentable(ByVal strn As String, ByVal loc As ADODB.CursorLocationEnum) As ADODB.Recordset
        Dim CONN As String
        opentable = New ADODB.Recordset
        CONN = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\client\OneDrive\Documents\FMS.mdb"

        opentable.CursorLocation = loc
        opentable.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        opentable.LockType = ADODB.LockTypeEnum.adLockOptimistic
        opentable.Open(strn, CONN, , , )
    End Function
End Module
