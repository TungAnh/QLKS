Public Class frmThemLoaiPhong
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
    Friend WithEvents txtTenLPhong As System.Windows.Forms.TextBox
    Friend WithEvents txtDonGia As System.Windows.Forms.TextBox
    Friend WithEvents btLưu As System.Windows.Forms.Button
    Friend WithEvents btCapNhat As System.Windows.Forms.Button
    Friend WithEvents btThoat As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTenLPhong = New System.Windows.Forms.TextBox
        Me.txtDonGia = New System.Windows.Forms.TextBox
        Me.btLưu = New System.Windows.Forms.Button
        Me.btCapNhat = New System.Windows.Forms.Button
        Me.btThoat = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên Loại Phòng"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Đơn Giá"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTenLPhong
        '
        Me.txtTenLPhong.Location = New System.Drawing.Point(144, 32)
        Me.txtTenLPhong.Name = "txtTenLPhong"
        Me.txtTenLPhong.Size = New System.Drawing.Size(152, 25)
        Me.txtTenLPhong.TabIndex = 2
        Me.txtTenLPhong.Text = ""
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(144, 88)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(152, 25)
        Me.txtDonGia.TabIndex = 3
        Me.txtDonGia.Text = ""
        '
        'btLưu
        '
        Me.btLưu.Location = New System.Drawing.Point(16, 160)
        Me.btLưu.Name = "btLưu"
        Me.btLưu.Size = New System.Drawing.Size(75, 32)
        Me.btLưu.TabIndex = 4
        Me.btLưu.Text = "Lưu"
        '
        'btCapNhat
        '
        Me.btCapNhat.Location = New System.Drawing.Point(128, 160)
        Me.btCapNhat.Name = "btCapNhat"
        Me.btCapNhat.Size = New System.Drawing.Size(75, 32)
        Me.btCapNhat.TabIndex = 5
        Me.btCapNhat.Text = "Cập nhật"
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(240, 160)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(75, 32)
        Me.btThoat.TabIndex = 6
        Me.btThoat.Text = "Thoát"
        '
        'frmThemLoaiPhong
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 18)
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(336, 222)
        Me.Controls.Add(Me.btThoat)
        Me.Controls.Add(Me.btCapNhat)
        Me.Controls.Add(Me.btLưu)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.txtTenLPhong)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmThemLoaiPhong"
        Me.Text = "Them Loai Phong"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btThoat.Click
        Me.Close()
    End Sub
End Class
