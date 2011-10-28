Public Class dbChiTietPT
    Inherits dbMyClass
    Public Sub ThemCTPhieuThue(ByVal MaCTPT As Long, ByVal MaPT As Long, ByVal MaKHang As Long)
        Dim strSQL As String
        strSQL = "Insert into CHITIETPHIEUTHUE(MaChiTietPT, MaPhieuThue, MaKhachHang) values " & MaCTPT & ", " & MaPT & "," & MaKHang & ""
        ExecuteUpdateSQL(strSQL)
    End Sub
    Public Sub CapNhatChiTietPT(ByVal MaCTPT As Long, ByVal MaPT As Long, ByVal MaKHang As Long)
        Dim strSQL As String
        strSQL = "Update CHITIETPHIEUTHUE set MaChiTietPT = " & MaCTPT & ", MaPhieuThue = " & MaPT & ", MaKhachHang = " & MaKHang & ""
        ExecuteUpdateSQL(strSQL)
    End Sub
    Public Sub XoaChiTietPT(ByVal MaCTPT As Long)
        Dim strSQL As String
        strSQL = "Delete from CHITIETPHIEUTHUE where MaChiTietPT = " & MaCTPT & ""
        ExecuteUpdateSQL(strSQL)
    End Sub
    Public Function LayDSChiTietPT(ByVal MaKHang As Long) As DataSet
        Dim ds As DataSet
        Dim strSQL As String
        If MaKHang = "" Then
            strSQL = "Select * from CHITIETPHIEUTHUE "
        Else
            strSQL = "Select * from CHITIETPHIEUTHUE where MaKhachHang = " & MaKHang & " "
        End If
        ds = OpenDataSet(strSQL)
        LayDSChiTietPT = ds
    End Function

End Class
