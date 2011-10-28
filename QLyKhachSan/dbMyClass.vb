Imports System.Data.OleDb
Public Class dbMyClass
    Protected strConnectionString = _
        " Provider = Microsoft.Jet.OLEDB.4.0 ; DataSource = " _
        + System.Windows.Forms.Application.StartupPath + "\QuanLyKhachSan.mdb"
    Protected Sub ExecuteUpdateSQL(ByVal strSQL As String)
        Dim cn As OleDbConnection = New OleDbConnection(strConnectionString)
        Dim cmd As OleDbCommand = New OleDbCommand(strSQL, cn)
        cmd.CommandType = CommandType.Text
        cn.Open()
        cmd.ExecuteNonQuery() ' thuc thi cau lenh SQL ma khong nhan ket qua tra ve
        cn.Close()
    End Sub
    ' ham thuc hien cau lenh select de lay ve mot Dataset chua thong tin ma ta thu duoc tu cac cau truy van
    Protected Function OpenDataSet(ByVal strSQL As String) As DataSet
        Dim cn As OleDbConnection = New OleDbConnection(strConnectionString)
        cn.Open()
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(strSQL, cn)
        Dim ds As New DataSet
        da.Fill(ds) ' do du lieu vao
        cn.Close()
        OpenDataSet = ds ' gia tri tra ve
    End Function
End Class
