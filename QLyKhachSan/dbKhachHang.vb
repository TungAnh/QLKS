Public Class dbKhachHang
    Inherits dbMyClass
    Public Sub ThemKhachHang(ByVal MaKH As Long, ByVal TenKH As String, ByVal MaLoaiKh As Long, ByVal CMND As String, ByVal Diachi As String)
        Dim strSQL As String
        strSQL = "Insert into KHACHHANG(MaKhach, TenKhach, MaLoaiKhach, CMND, GhiChu) values (" & MaKH & "," & TenKH & "," & MaLoaiKh & ", " & CMND & ", " & Diachi & ")"
        ExecuteUpdateSQL(strSQL)
    End Sub
    Public Sub CapNhatTTinKH(ByVal MaKH As Long, ByVal TenKH As String, ByVal MaLoaiKh As Long, ByVal CMND As String, ByVal Diachi As String)
        Dim strSQL As String
        strSQL = "Update KHACHHANG set MaKhach = " & MaKH & ", TenKhach = " & TenKH & ", MaLoaiKhach = " & MaLoaiKh & ", CMND = " & CMND & ", DiaChi = " & Diachi & ""
        ExecuteUpdateSQL(strSQL)
    End Sub
    Public Sub XoaKhachHang(ByVal MaKH As Long)
        Dim strSQL As String
        strSQL = "Delete from KHACHHANG where MaKhach = " & MaKH & ""
        ExecuteUpdateSQL(strSQL)
    End Sub
    Public Function LayDanhSachKHang() As DataSet
        Dim strSQL As String
        Dim ds As DataSet
        strSQL = "Select * from KHACHHANG "
        ds = OpenDataSet(strSQL)
        LayDanhSachKHang = ds
    End Function
End Class
