Public Class LKhachHang
    Inherits dbLoaiKhachHang
    Public Sub ThemLoaiKH(ByVal MaLK As Long, ByVal TenLoaiKhach As String, ByVal Ghichu As String)
        Dim dbLoaiKH As New dbLoaiKhachHang
        dbLoaiKH.ThemLoaiKhach(MaLK, TenLoaiKhach, Ghichu)
        dbLoaiKH = Nothing
    End Sub
    Public Sub CapNhatLoaiKH(ByVal MaLK As Long, ByVal TenLoaiKhach As String, ByVal Ghichu As String)
        Dim dbLoaiKH As New dbLoaiKhachHang
        dbLoaiKH.CapNhatLKhach(MaLK, TenLoaiKhach, Ghichu)
        dbLoaiKH = Nothing
    End Sub
    Public Sub XoaLoaiKH(ByVal MaLK As Long)
        Dim dbLoaiKH As New dbLoaiKhachHang
        dbLoaiKH.XoaLoaiKhach(MaLK)
        dbLoaiKH = Nothing
    End Sub
    Public Function LayDSLoaiKH() As DataSet
        Dim ds As DataSet
        Dim dbLoaiKH As New dbLoaiKhachHang
        ds = dbLoaiKH.LayDanhSachLKhach()
        dbLoaiKH = Nothing
        LayDSLoaiKH = ds
    End Function

End Class
