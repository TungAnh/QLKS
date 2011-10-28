Public Class frmTiepNhanPhong
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMaPhong As System.Windows.Forms.TextBox
    Friend WithEvents txtTenPhong As System.Windows.Forms.TextBox
    Friend WithEvents txtDonGia As System.Windows.Forms.TextBox
    Friend WithEvents txtGhiChu As System.Windows.Forms.TextBox
    Friend WithEvents cbbLoaiPhong As System.Windows.Forms.ComboBox
    Friend WithEvents btCapNhatPhong As System.Windows.Forms.Button
    Friend WithEvents btThemPhong As System.Windows.Forms.Button
    Friend WithEvents btXoaPhong As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grdPhongMoi As System.Windows.Forms.DataGrid
    Friend WithEvents btThoat As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtMaPhong = New System.Windows.Forms.TextBox
        Me.txtTenPhong = New System.Windows.Forms.TextBox
        Me.txtDonGia = New System.Windows.Forms.TextBox
        Me.txtGhiChu = New System.Windows.Forms.TextBox
        Me.cbbLoaiPhong = New System.Windows.Forms.ComboBox
        Me.btCapNhatPhong = New System.Windows.Forms.Button
        Me.btThemPhong = New System.Windows.Forms.Button
        Me.btXoaPhong = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.grdPhongMoi = New System.Windows.Forms.DataGrid
        Me.btThoat = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdPhongMoi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(37, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Phòng"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(308, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Phòng"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(28, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Loại Phòng"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(308, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ðơn  Giá"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(19, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ghi Chú"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMaPhong
        '
        Me.txtMaPhong.Location = New System.Drawing.Point(159, 8)
        Me.txtMaPhong.Name = "txtMaPhong"
        Me.txtMaPhong.Size = New System.Drawing.Size(140, 25)
        Me.txtMaPhong.TabIndex = 5
        Me.txtMaPhong.Text = ""
        '
        'txtTenPhong
        '
        Me.txtTenPhong.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtTenPhong.Location = New System.Drawing.Point(429, 8)
        Me.txtTenPhong.Name = "txtTenPhong"
        Me.txtTenPhong.Size = New System.Drawing.Size(131, 25)
        Me.txtTenPhong.TabIndex = 6
        Me.txtTenPhong.Text = ""
        '
        'txtDonGia
        '
        Me.txtDonGia.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtDonGia.Location = New System.Drawing.Point(429, 64)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(131, 25)
        Me.txtDonGia.TabIndex = 7
        Me.txtDonGia.Text = ""
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(159, 120)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(140, 25)
        Me.txtGhiChu.TabIndex = 8
        Me.txtGhiChu.Text = ""
        '
        'cbbLoaiPhong
        '
        Me.cbbLoaiPhong.BackColor = System.Drawing.SystemColors.Menu
        Me.cbbLoaiPhong.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cbbLoaiPhong.Location = New System.Drawing.Point(159, 64)
        Me.cbbLoaiPhong.Name = "cbbLoaiPhong"
        Me.cbbLoaiPhong.Size = New System.Drawing.Size(141, 25)
        Me.cbbLoaiPhong.TabIndex = 9
        '
        'btCapNhatPhong
        '
        Me.btCapNhatPhong.BackColor = System.Drawing.SystemColors.Desktop
        Me.btCapNhatPhong.Location = New System.Drawing.Point(187, 168)
        Me.btCapNhatPhong.Name = "btCapNhatPhong"
        Me.btCapNhatPhong.Size = New System.Drawing.Size(93, 32)
        Me.btCapNhatPhong.TabIndex = 10
        Me.btCapNhatPhong.Text = "Cập Nhật"
        '
        'btThemPhong
        '
        Me.btThemPhong.Location = New System.Drawing.Point(37, 168)
        Me.btThemPhong.Name = "btThemPhong"
        Me.btThemPhong.Size = New System.Drawing.Size(94, 32)
        Me.btThemPhong.TabIndex = 11
        Me.btThemPhong.Text = "Thêm mới"
        '
        'btXoaPhong
        '
        Me.btXoaPhong.Location = New System.Drawing.Point(327, 168)
        Me.btXoaPhong.Name = "btXoaPhong"
        Me.btXoaPhong.Size = New System.Drawing.Size(87, 32)
        Me.btXoaPhong.TabIndex = 12
        Me.btXoaPhong.Text = "Xoá"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdPhongMoi)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 216)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 200)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Danh Sách các Phòng mới tiếp nhận"
        '
        'grdPhongMoi
        '
        Me.grdPhongMoi.AllowDrop = True
        Me.grdPhongMoi.DataMember = ""
        Me.grdPhongMoi.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdPhongMoi.Location = New System.Drawing.Point(9, 24)
        Me.grdPhongMoi.Name = "grdPhongMoi"
        Me.grdPhongMoi.ReadOnly = True
        Me.grdPhongMoi.Size = New System.Drawing.Size(532, 168)
        Me.grdPhongMoi.TabIndex = 0
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(467, 168)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(87, 32)
        Me.btThoat.TabIndex = 14
        Me.btThoat.Text = "Thoát"
        '
        'frmTiepNhanPhong
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 18)
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(585, 420)
        Me.Controls.Add(Me.btThoat)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btXoaPhong)
        Me.Controls.Add(Me.btThemPhong)
        Me.Controls.Add(Me.btCapNhatPhong)
        Me.Controls.Add(Me.cbbLoaiPhong)
        Me.Controls.Add(Me.txtGhiChu)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.txtTenPhong)
        Me.Controls.Add(Me.txtMaPhong)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmTiepNhanPhong"
        Me.Text = "Tiep Nhan Phong"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdPhongMoi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btThemPhong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btThemPhong.Click
        Dim TNPhong As New TiepNhanPhong


    End Sub

    Private Sub btCapNhatPhong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCapNhatPhong.Click
        Dim index As Integer
        index = grdPhongMoi.CurrentRowIndex
        txtMaPhong.Text = grdPhongMoi.Item(index, 0)
        txtTenPhong.Text = grdPhongMoi.Item(index, 1)
        cbbLoaiPhong.Text = grdPhongMoi.Item(index, 2)
        txtDonGia.Text = grdPhongMoi.Item(index, 3)
        txtGhiChu.Text = grdPhongMoi.Item(index, 4)
    End Sub

    Private Sub btXoaPhong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btXoaPhong.Click
        Dim index As Integer
        Dim MaPhong As Long
        index = grdPhongMoi.CurrentRowIndex
        MaPhong = grdPhongMoi.Item(index, 0)
        Dim TNPhong As New TiepNhanPhong
        TNPhong.XoaPhong(MaPhong)
        TNPhong = Nothing
    End Sub

    Private Sub grdPhongMoi_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grdPhongMoi.Navigate

    End Sub

    Private Sub btThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btThoat.Click
        Me.Close()
    End Sub

    Private Sub frmTiepNhanPhong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As DataSet
        Dim TNPhong As New TiepNhanPhong
        ds = TNPhong.LayDanhSachPhong()
        TNPhong = Nothing
        grdPhongMoi.DataSource = ds.Tables(0)
    End Sub
End Class
