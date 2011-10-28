Public Class dbTiepNhanPhong
    Inherits dbMyClass
    Public Sub ThemPhongMoi(ByVal MPhong As Long, ByVal TenPhong As String, ByVal LPhong As Long, ByVal TTPhong As String, ByVal Ghichu As String)
        Dim strSQL As String
        strSQL = "Insert into PHONG (MaPhong, TenPhong, MaLoaiPhong, TinhTrangPhong, GhiChu) value  ( " & MPhong & ", " & TenPhong & ", " & LPhong & "," & TTPhong & ", " & Ghichu & " ) "
        ExecuteUpdateSQL(strSQL)
    End Sub
    Public Sub CapNhatPhong(ByVal MPhong As Long, ByVal TenPhong As String, ByVal LPhong As Long, ByVal TTPhong As String, ByVal Ghichu As String)
        Dim strSQL As String
        strSQL = "Update PHONG set MaPhong = " & MPhong & ", TenPhong = " & TenPhong & ", MaLoaiPhong = " & LPhong & ", TinhTrangPhong = " & TTPhong & ", GhiChu = " & Ghichu & ""
        ExecuteUpdateSQL(strSQL)
    End Sub
    Public Sub XoaPhong(ByVal MPhong As Long)
        Dim strSQL As String
        strSQL = "Delete from PHONG where MaPhong = " & MPhong & ""
        ExecuteUpdateSQL(strSQL)
    End Sub
    Public Function LayDSachPhong() As DataSet ' Lay Danh Sach cac phong thoa TTPhong
        Dim strSQL As String
        Dim ds As DataSet
        strSQL = "Select * from PHONG "
        ds = OpenDataSet(strSQL)
        LayDSachPhong = ds
    End Function

End Class
