Public Class dbLHDThanhToan
    Inherits dbMyClass
    Public Sub ThemHoaDonMoi(ByVal MaHD As Long, ByVal TenKHang As String, ByVal DiaChiKHang As String, ByVal TriGia As Double)
        Dim strSQL As String
        strSQL = "Insert into HOADON(MaHoaDon, TenKhachHang,DiaChiKHang, TriGia) values " & MaHD & ", " & TenKHang & ", " & DiaChiKHang & ", " & TriGia & ""
        ExecuteUpdateSQL(strSQL)
    End Sub
    Public Sub CapNhatHoaDon(ByVal MaHD As Long, ByVal TenKHang As String, ByVal DiaChiKHang As String, ByVal TriGia As Double)
        Dim strSQL As String
        strSQL = "Update HOADON set MaHoaDon = " & MaHD & ", TenKhachHang = " & TenKHang & ", DiaChiKHang = " & DiaChiKHang & ", TriGia =" & TriGia & ""
        ExecuteUpdateSQL(strSQL)
    End Sub
    Public Sub XoaHoaDon(ByVal MaHD As Long)
        Dim strSQL As String
        strSQL = "Delete from HOADON where MaHoaDon = " & MaHD & ""
        ExecuteUpdateSQL(strSQL)
    End Sub
    Public Function LayDSHDon() As DataSet
    End Function

End Class
