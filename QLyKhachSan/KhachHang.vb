Public Class KhachHang
    Inherits dbKhachHang
    Public Sub ThemKH(ByVal MaKH As Long, ByVal TenKH As String, ByVal MaLoaiKH As Long, ByVal CMND As String, ByVal DiaChi As String)
        Dim dbKH As New dbKhachHang
        dbKH.ThemKhachHang(MaKH, TenKH, MaLoaiKH, CMND, DiaChi)
        dbKH = Nothing
    End Sub
    Public Sub CapNhatTTKH(ByVal MaKH As Long, ByVal TenKH As String, ByVal MaLoaiKH As Long, ByVal CMND As String, ByVal DiaChi As String)
        Dim dbKH As New dbKhachHang
        dbKH.CapNhatTTinKH(MaKH, TenKH, MaLoaiKH, CMND, DiaChi)
        dbKH = Nothing
    End Sub
    Public Sub XoaKH(ByVal MaKH As Long)
        Dim dbKH As New dbKhachHang
        dbKH.XoaKhachHang(MaKH)
        dbKH = Nothing
    End Sub
    Public Function LayDSKHang() As DataSet
        Dim dbKH As New dbKhachHang
        dbKH.LayDanhSachKHang()
        dbKH = Nothing
    End Function

End Class
