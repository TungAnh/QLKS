Public Class ChiTietPT
    Inherits dbChiTietPT
    Public Sub ThemCTPT(ByVal MaCTPT As Long, ByVal MaPT As Long, ByVal MaKHang As Long)
        Dim dbCTPT As New dbChiTietPT
        dbCTPT.ThemCTPhieuThue(MaCTPT, MaPT, MaKHang)
        dbCTPT = Nothing
    End Sub
    Public Sub CapNhatCTPT(ByVal MaCTPT As Long, ByVal MaPT As Long, ByVal MaKHang As Long)
        Dim dbCTPT As New dbChiTietPT
        dbCTPT.CapNhatChiTietPT(MaCTPT, MaPT, MaKHang)
        dbCTPT = Nothing
    End Sub
    Public Sub XoaCTPT(ByVal MaCTPT As Long)
        Dim dbCTPT As dbChiTietPT
        dbCTPT.XoaChiTietPT(MaCTPT)
        dbCTPT = Nothing
    End Sub
    Public Function LayDSCTPT(ByVal MaKHang As Long) As DataSet
        Dim dbCTPT As dbChiTietPT
        Dim ds As DataSet
        ds = dbCTPT.LayDSChiTietPT(MaKHang)
        dbCTPT = Nothing
        LayDSCTPT = ds
    End Function

End Class
