Public Class PhieuThuePhong
    Inherits dbPhieuThuePhong
    Public Sub ThemPTMoi(ByVal MaPT As Long, ByVal MPhong As Long, ByVal NgayBatDauThue As Date)
        Dim dbPTPhong As New dbPhieuThuePhong
        dbPTPhong.LapPTPhongMoi(MaPT, MPhong, NgayBatDauThue)
        dbPTPhong = Nothing
    End Sub
    Public Sub CapNhatPT(ByVal MaPT As Long, ByVal MPhong As Long, ByVal NgayBatDauThue As Date)
        Dim dbPTPhong As New dbPhieuThuePhong
        dbPTPhong.CapNhatPThue(MaPT, MPhong, NgayBatDauThue)
        dbPTPhong = Nothing
    End Sub
    Public Sub XoaPTPhong(ByVal MaPT As Long)
        Dim dbPTPhong As New dbPhieuThuePhong
        dbPTPhong.XoaPhieuThuePhong(MaPT)
        dbPTPhong = Nothing
    End Sub

End Class
