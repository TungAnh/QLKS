Public Class dbLoaiKhachHang
    Inherits dbMyClass
    Public Sub ThemLoaiKhach(ByVal MaLKhach As Long, ByVal TenLoaiKhach As String, ByVal Ghichu As String)
        Dim strSQL As String
        strSQL = "Insert into LOAIKHACH(MaLoaiKhach, TenLoaiKhach, GhiChu) values (" & MaLKhach & ", " & TenLoaiKhach & ", " & Ghichu & ")"
        ExecuteUpdateSQL(strSQL)
    End Sub
    Public Sub CapNhatLKhach(ByVal MaLKhach As Long, ByVal TenLoaiKhach As String, ByVal Ghichu As String)
        Dim strSQL As String
        strSQL = " Update LOAIKHACH set MaLoaiKhach = " & MaLKhach & ", TenLoaiKhach = " & TenLoaiKhach & ", GhiChu = " & Ghichu & ""
        ExecuteUpdateSQL(strSQL)
    End Sub
    Public Sub XoaLoaiKhach(ByVal MaLKhach As Long)
        Dim strSQL As String
        strSQL = "Delete from LOAIKHACH where MaLoaiKhach = " & MaLKhach & ""
        ExecuteUpdateSQL(strSQL)
    End Sub
    Public Function LayDanhSachLKhach() As DataSet
        Dim strSQL As String
        Dim ds As DataSet
        strSQL = "Select * from LOAIKHACH "
        ds = OpenDataSet(strSQL)
        LayDanhSachLKhach = ds
    End Function
End Class
