Public Class frmThemLoaiKhach
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
    Friend WithEvents btLuu As System.Windows.Forms.Button
    Friend WithEvents btCapNhat As System.Windows.Forms.Button
    Friend WithEvents btThoat As System.Windows.Forms.Button
    Friend WithEvents txtTenLKhach As System.Windows.Forms.TextBox
    Friend WithEvents txtLoaiKhach As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTenLKhach = New System.Windows.Forms.TextBox
        Me.txtLoaiKhach = New System.Windows.Forms.TextBox
        Me.btLuu = New System.Windows.Forms.Button
        Me.btCapNhat = New System.Windows.Forms.Button
        Me.btThoat = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên Loại Khách"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hệ Số"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTenLKhach
        '
        Me.txtTenLKhach.Location = New System.Drawing.Point(144, 40)
        Me.txtTenLKhach.Name = "txtTenLKhach"
        Me.txtTenLKhach.Size = New System.Drawing.Size(144, 25)
        Me.txtTenLKhach.TabIndex = 2
        Me.txtTenLKhach.Text = ""
        '
        'txtLoaiKhach
        '
        Me.txtLoaiKhach.Location = New System.Drawing.Point(144, 104)
        Me.txtLoaiKhach.Name = "txtLoaiKhach"
        Me.txtLoaiKhach.Size = New System.Drawing.Size(144, 25)
        Me.txtLoaiKhach.TabIndex = 3
        Me.txtLoaiKhach.Text = ""
        '
        'btLuu
        '
        Me.btLuu.Location = New System.Drawing.Point(16, 176)
        Me.btLuu.Name = "btLuu"
        Me.btLuu.Size = New System.Drawing.Size(75, 32)
        Me.btLuu.TabIndex = 4
        Me.btLuu.Text = "Lưu"
        '
        'btCapNhat
        '
        Me.btCapNhat.Location = New System.Drawing.Point(136, 176)
        Me.btCapNhat.Name = "btCapNhat"
        Me.btCapNhat.Size = New System.Drawing.Size(75, 32)
        Me.btCapNhat.TabIndex = 5
        Me.btCapNhat.Text = "Cập nhật"
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(256, 176)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(75, 32)
        Me.btThoat.TabIndex = 6
        Me.btThoat.Text = "Thoát"
        '
        'frmThemLoaiKhach
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 18)
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(352, 246)
        Me.Controls.Add(Me.btThoat)
        Me.Controls.Add(Me.btCapNhat)
        Me.Controls.Add(Me.btLuu)
        Me.Controls.Add(Me.txtLoaiKhach)
        Me.Controls.Add(Me.txtTenLKhach)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmThemLoaiKhach"
        Me.Text = "Them Loai Khach"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btThoat.Click
        Me.Close()
    End Sub
End Class
