Public Class dbPhieuThuePhong
    Inherits dbMyClass
    Public Sub LapPTPhongMoi(ByVal MaPT As Long, ByVal MPhong As Long, ByVal NgayBatDauThue As Date)
        Dim strSQL As String
        strSQL = "Insert into PHIEUTHUEPHONG(MaPhieuThue, MaPhong, NgayBatDauThue) value ( " & MaPT & ", " & MPhong & ", " & NgayBatDauThue.ToString & " )"
        ExecuteUpdateSQL(strSQL)
    End Sub
    Public Sub CapNhatPThue(ByVal MaPT As Long, ByVal MPhong As Long, ByVal NgayBatDauThue As Date)
        Dim strSQL As String
        strSQL = "Update PHIEUTHUEPHONG set MaPhieuThue = " & MaPT & ", MaPhong = " & MPhong & ", NgayBatDauThue = " & NgayBatDauThue.ToString & ""
        ExecuteUpdateSQL(strSQL)
    End Sub
    Public Sub XoaPhieuThuePhong(ByVal MaPT As Long)
        Dim strSQL As String
        strSQL = "Delete from PHIEUTHUEPHONG where MaPhieuThue = " & MaPT
        ExecuteUpdateSQL(strSQL)
    End Sub
End Class
