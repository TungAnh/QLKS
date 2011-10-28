Public Class frmBCaoDoanhThu
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
    Friend WithEvents btThoat As System.Windows.Forms.Button
    Friend WithEvents btBaoCaoLai As System.Windows.Forms.Button
    Friend WithEvents btBaoCao As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CbbLoaiPhong As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePickerThang As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btThoat = New System.Windows.Forms.Button
        Me.btBaoCaoLai = New System.Windows.Forms.Button
        Me.btBaoCao = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.CbbLoaiPhong = New System.Windows.Forms.ComboBox
        Me.DateTimePickerThang = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(256, 168)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(75, 32)
        Me.btThoat.TabIndex = 0
        Me.btThoat.Text = "Thoát"
        '
        'btBaoCaoLai
        '
        Me.btBaoCaoLai.Location = New System.Drawing.Point(120, 168)
        Me.btBaoCaoLai.Name = "btBaoCaoLai"
        Me.btBaoCaoLai.Size = New System.Drawing.Size(96, 32)
        Me.btBaoCaoLai.TabIndex = 1
        Me.btBaoCaoLai.Text = "Báo Cáo Lại"
        '
        'btBaoCao
        '
        Me.btBaoCao.Location = New System.Drawing.Point(8, 168)
        Me.btBaoCao.Name = "btBaoCao"
        Me.btBaoCao.Size = New System.Drawing.Size(75, 32)
        Me.btBaoCao.TabIndex = 2
        Me.btBaoCao.Text = "Báo Cáo"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tháng"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CbbLoaiPhong
        '
        Me.CbbLoaiPhong.Location = New System.Drawing.Point(128, 80)
        Me.CbbLoaiPhong.Name = "CbbLoaiPhong"
        Me.CbbLoaiPhong.Size = New System.Drawing.Size(144, 25)
        Me.CbbLoaiPhong.TabIndex = 6
        '
        'DateTimePickerThang
        '
        Me.DateTimePickerThang.Location = New System.Drawing.Point(128, 24)
        Me.DateTimePickerThang.Name = "DateTimePickerThang"
        Me.DateTimePickerThang.Size = New System.Drawing.Size(144, 25)
        Me.DateTimePickerThang.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Lọai Phòng"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBCaoDoanhThu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 18)
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(352, 266)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePickerThang)
        Me.Controls.Add(Me.CbbLoaiPhong)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btBaoCao)
        Me.Controls.Add(Me.btBaoCaoLai)
        Me.Controls.Add(Me.btThoat)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmBCaoDoanhThu"
        Me.Text = "Bao Cao Doanh Thu"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btThoat.Click
        Me.Close()
    End Sub

    Private Sub btBaoCaoLai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBaoCaoLai.Click
        DateTimePickerThang.Text = ""
        CbbLoaiPhong.Text = ""
    End Sub

    Private Sub btBaoCao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBaoCao.Click

    End Sub
End Class
