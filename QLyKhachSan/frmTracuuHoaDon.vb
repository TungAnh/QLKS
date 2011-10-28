Public Class frmTracuuHoaDon
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
    Friend WithEvents btTraCuu As System.Windows.Forms.Button
    Friend WithEvents btTraCuuTiep As System.Windows.Forms.Button
    Friend WithEvents Thoat As System.Windows.Forms.Button
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents txtTriGia As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbKhachHang As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grdKQTraCuu As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btTraCuu = New System.Windows.Forms.Button
        Me.btTraCuuTiep = New System.Windows.Forms.Button
        Me.Thoat = New System.Windows.Forms.Button
        Me.txtDiaChi = New System.Windows.Forms.TextBox
        Me.txtTriGia = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbKhachHang = New System.Windows.Forms.ComboBox
        Me.grdKQTraCuu = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.grdKQTraCuu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Khách Hàng"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(208, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Địa Chỉ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btTraCuu
        '
        Me.btTraCuu.Location = New System.Drawing.Point(16, 112)
        Me.btTraCuu.Name = "btTraCuu"
        Me.btTraCuu.Size = New System.Drawing.Size(75, 32)
        Me.btTraCuu.TabIndex = 2
        Me.btTraCuu.Text = "Tra Cứu"
        '
        'btTraCuuTiep
        '
        Me.btTraCuuTiep.Location = New System.Drawing.Point(152, 112)
        Me.btTraCuuTiep.Name = "btTraCuuTiep"
        Me.btTraCuuTiep.Size = New System.Drawing.Size(104, 32)
        Me.btTraCuuTiep.TabIndex = 3
        Me.btTraCuuTiep.Text = "Tra Cứu Tiếp"
        '
        'Thoat
        '
        Me.Thoat.Location = New System.Drawing.Point(312, 112)
        Me.Thoat.Name = "Thoat"
        Me.Thoat.Size = New System.Drawing.Size(75, 32)
        Me.Thoat.TabIndex = 4
        Me.Thoat.Text = "Thoát"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(272, 16)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(120, 25)
        Me.txtDiaChi.TabIndex = 5
        Me.txtDiaChi.Text = ""
        '
        'txtTriGia
        '
        Me.txtTriGia.Location = New System.Drawing.Point(80, 64)
        Me.txtTriGia.Name = "txtTriGia"
        Me.txtTriGia.Size = New System.Drawing.Size(120, 25)
        Me.txtTriGia.TabIndex = 6
        Me.txtTriGia.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Trị Giá"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbKhachHang
        '
        Me.cmbKhachHang.Location = New System.Drawing.Point(80, 16)
        Me.cmbKhachHang.Name = "cmbKhachHang"
        Me.cmbKhachHang.TabIndex = 8
        '
        'grdKQTraCuu
        '
        Me.grdKQTraCuu.DataMember = ""
        Me.grdKQTraCuu.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdKQTraCuu.Location = New System.Drawing.Point(8, 16)
        Me.grdKQTraCuu.Name = "grdKQTraCuu"
        Me.grdKQTraCuu.Size = New System.Drawing.Size(392, 160)
        Me.grdKQTraCuu.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdKQTraCuu)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 184)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kết Quả Tra Cứu"
        '
        'frmTracuuHoaDon
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 18)
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(424, 350)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbKhachHang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTriGia)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.Thoat)
        Me.Controls.Add(Me.btTraCuuTiep)
        Me.Controls.Add(Me.btTraCuu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmTracuuHoaDon"
        Me.Text = "Tra cuu Hoa Don Thanh Toan"
        CType(Me.grdKQTraCuu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Thoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Thoat.Click

    End Sub

    Private Sub btTraCuuTiep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTraCuuTiep.Click

    End Sub

    Private Sub btTraCuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTraCuu.Click

    End Sub
End Class
