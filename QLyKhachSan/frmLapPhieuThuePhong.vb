Public Class frmLapPhieuThuePhong
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
    Friend WithEvents txtPhong As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePickerNgayThue As System.Windows.Forms.DateTimePicker
    Friend WithEvents grdPhieuThue As System.Windows.Forms.DataGrid
    Friend WithEvents btTaoPhieu As System.Windows.Forms.Button
    Friend WithEvents btThoat As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPhong = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.DateTimePickerNgayThue = New System.Windows.Forms.DateTimePicker
        Me.grdPhieuThue = New System.Windows.Forms.DataGrid
        Me.btTaoPhieu = New System.Windows.Forms.Button
        Me.btThoat = New System.Windows.Forms.Button
        CType(Me.grdPhieuThue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(56, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " Phòng"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 23)
        Me.Label2.TabIndex = 1
        '
        'txtPhong
        '
        Me.txtPhong.Location = New System.Drawing.Point(184, 16)
        Me.txtPhong.Name = "txtPhong"
        Me.txtPhong.Size = New System.Drawing.Size(144, 25)
        Me.txtPhong.TabIndex = 2
        Me.txtPhong.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ngay Bắt Đầu Thuê"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePickerNgayThue
        '
        Me.DateTimePickerNgayThue.Location = New System.Drawing.Point(184, 64)
        Me.DateTimePickerNgayThue.Name = "DateTimePickerNgayThue"
        Me.DateTimePickerNgayThue.Size = New System.Drawing.Size(144, 25)
        Me.DateTimePickerNgayThue.TabIndex = 5
        '
        'grdPhieuThue
        '
        Me.grdPhieuThue.AllowDrop = True
        Me.grdPhieuThue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPhieuThue.DataMember = ""
        Me.grdPhieuThue.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdPhieuThue.Location = New System.Drawing.Point(8, 128)
        Me.grdPhieuThue.Name = "grdPhieuThue"
        Me.grdPhieuThue.Size = New System.Drawing.Size(488, 240)
        Me.grdPhieuThue.TabIndex = 6
        '
        'btTaoPhieu
        '
        Me.btTaoPhieu.Location = New System.Drawing.Point(384, 64)
        Me.btTaoPhieu.Name = "btTaoPhieu"
        Me.btTaoPhieu.Size = New System.Drawing.Size(80, 24)
        Me.btTaoPhieu.TabIndex = 7
        Me.btTaoPhieu.Text = "Tạo Phiếu"
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(384, 16)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.TabIndex = 8
        Me.btThoat.Text = "Thoát"
        '
        'frmLapPhieuThuePhong
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 18)
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(504, 374)
        Me.Controls.Add(Me.btThoat)
        Me.Controls.Add(Me.btTaoPhieu)
        Me.Controls.Add(Me.grdPhieuThue)
        Me.Controls.Add(Me.DateTimePickerNgayThue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPhong)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmLapPhieuThuePhong"
        Me.Text = "Lap Phieu Thue Phong"
        CType(Me.grdPhieuThue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub btThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btThoat.Click
        Me.Close()
    End Sub

    Private Sub btTaoPhieu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTaoPhieu.Click

    End Sub
End Class
