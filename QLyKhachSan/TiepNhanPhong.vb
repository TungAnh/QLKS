Public Class TiepNhanPhong
    Inherits dbTiepNhanPhong
    Public Function KiemTra(ByVal MPhong As Long, ByVal MLPhong As Long, ByVal TenPhong As String) As Boolean
        KiemTra = True
    End Function
    Public Sub ThemPhong(ByVal MPhong As Long, ByVal TenPhong As String, ByVal LPhong As Long, ByVal TTPhong As String, ByVal Ghichu As String)
        If KiemTra(MPhong, LPhong, TenPhong) Then
            Dim dbPhong As New dbTiepNhanPhong
            dbPhong.ThemPhongMoi(MPhong, TenPhong, LPhong, TTPhong, Ghichu)
            dbPhong = Nothing
        End If
    End Sub
    Public Sub CNhatPhong(ByVal MPhong As Long, ByVal TenPhong As String, ByVal LPhong As Long, ByVal TTPhong As String, ByVal Ghichu As String)
        If KiemTra(MPhong, LPhong, TenPhong) Then
            Dim dbPhong As New dbTiepNhanPhong
            dbPhong.CapNhatPhong(MPhong, TenPhong, LPhong, TTPhong, Ghichu)
            dbPhong = Nothing
        End If
    End Sub
    Public Sub XoaPhongDK(ByVal MPhong As Long)
        Dim dbPhong As New dbTiepNhanPhong
        dbPhong.XoaPhong(MPhong)
        dbPhong = Nothing
    End Sub
    Public Function LayDanhSachPhong() As DataSet
        Dim dbPhong As New dbTiepNhanPhong
        Dim ds As DataSet
        ds = dbPhong.LayDSachPhong()
        dbPhong = Nothing
        LayDanhSachPhong = ds
    End Function
End Class
