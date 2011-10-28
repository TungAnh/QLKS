Public Class LHDThanhToan
    Inherits dbLHDThanhToan
    Public Sub ThemHoaDon(ByVal MaHD As Long, ByVal TenKH As String, ByVal DiaChiKH As String, ByVal TG As Double)
        Dim dbHoaDon As New dbLHDThanhToan
        dbHoaDon.ThemHoaDonMoi(MaHD, TenKH, DiaChiKH, TG)
        dbHoaDon = Nothing
    End Sub
    Public Sub CapNhatHD(ByVal MaHD As Long, ByVal TenKH As String, ByVal DiaChiKH As String, ByVal TG As Double)
        Dim dbHoaDon As New dbLHDThanhToan
        dbHoaDon.CapNhatHoaDon(MaHD, TenKH, DiaChiKH, TG)
        dbHoaDon = Nothing
    End Sub
    Public Sub XoaHD(ByVal MaHD As Long)
        Dim dbHoaDon As New dbLHDThanhToan
        dbHoaDon.XoaHoaDon(MaHD)
        dbHoaDon = Nothing
    End Sub
    Public Function LayDanhSachHD() As DataSet
        Dim dbHoaDon As New dbLHDThanhToan
        Dim ds As DataSet
        ds = dbHoaDon.LayDSHDon()
        dbHoaDon = Nothing
        LayDanhSachHD = ds
    End Function
End Class
