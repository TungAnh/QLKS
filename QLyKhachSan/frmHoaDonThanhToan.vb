Public Class frmHoaDonThanhToan
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
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents txtKhachHang As System.Windows.Forms.TextBox
    Friend WithEvents btLapHD As System.Windows.Forms.Button
    Friend WithEvents btLapTiep As System.Windows.Forms.Button
    Friend WithEvents btThoat As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDiaChi = New System.Windows.Forms.TextBox
        Me.txtKhachHang = New System.Windows.Forms.TextBox
        Me.btLapHD = New System.Windows.Forms.Button
        Me.btLapTiep = New System.Windows.Forms.Button
        Me.btThoat = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(40, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Khách Hàng"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(32, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ðiạ Chỉ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(160, 80)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.TabIndex = 2
        Me.txtDiaChi.Text = ""
        '
        'txtKhachHang
        '
        Me.txtKhachHang.Location = New System.Drawing.Point(160, 32)
        Me.txtKhachHang.Name = "txtKhachHang"
        Me.txtKhachHang.Size = New System.Drawing.Size(96, 25)
        Me.txtKhachHang.TabIndex = 3
        Me.txtKhachHang.Text = ""
        '
        'btLapHD
        '
        Me.btLapHD.Location = New System.Drawing.Point(16, 160)
        Me.btLapHD.Name = "btLapHD"
        Me.btLapHD.Size = New System.Drawing.Size(104, 32)
        Me.btLapHD.TabIndex = 4
        Me.btLapHD.Text = "Lập Hoá Ðon"
        '
        'btLapTiep
        '
        Me.btLapTiep.Location = New System.Drawing.Point(160, 160)
        Me.btLapTiep.Name = "btLapTiep"
        Me.btLapTiep.Size = New System.Drawing.Size(75, 32)
        Me.btLapTiep.TabIndex = 5
        Me.btLapTiep.Text = "Lập Tiếp"
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(280, 160)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(75, 32)
        Me.btThoat.TabIndex = 6
        Me.btThoat.Text = "Thoát"
        '
        'frmHoaDonThanhToan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 18)
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(368, 214)
        Me.Controls.Add(Me.btThoat)
        Me.Controls.Add(Me.btLapTiep)
        Me.Controls.Add(Me.btLapHD)
        Me.Controls.Add(Me.txtKhachHang)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "frmHoaDonThanhToan"
        Me.Text = "Hoa Don Thanh Toan"
        Me.ResumeLayout(False)

    End Sub

#End Region

  
    Private Sub btThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btThoat.Click
        Me.Close()
    End Sub
End Class
