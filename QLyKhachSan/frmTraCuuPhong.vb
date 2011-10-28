Public Class frmTraCuuPhong
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTenPhong As System.Windows.Forms.TextBox
    Friend WithEvents txtDonGia As System.Windows.Forms.TextBox
    Friend WithEvents cbbMaPhong As System.Windows.Forms.ComboBox
    Friend WithEvents btTraCuu As System.Windows.Forms.Button
    Friend WithEvents btTraCuuTiep As System.Windows.Forms.Button
    Friend WithEvents btThoat As System.Windows.Forms.Button
    Friend WithEvents grdTraCuu As System.Windows.Forms.DataGrid
    Friend WithEvents cmbPhong As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTenPhong = New System.Windows.Forms.TextBox
        Me.txtDonGia = New System.Windows.Forms.TextBox
        Me.cbbMaPhong = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.grdTraCuu = New System.Windows.Forms.DataGrid
        Me.btTraCuu = New System.Windows.Forms.Button
        Me.btTraCuuTiep = New System.Windows.Forms.Button
        Me.btThoat = New System.Windows.Forms.Button
        Me.cmbPhong = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdTraCuu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Phòng"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(248, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Phòng"
        '
        'txtTenPhong
        '
        Me.txtTenPhong.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtTenPhong.Location = New System.Drawing.Point(328, 32)
        Me.txtTenPhong.Name = "txtTenPhong"
        Me.txtTenPhong.Size = New System.Drawing.Size(120, 25)
        Me.txtTenPhong.TabIndex = 3
        Me.txtTenPhong.Text = ""
        '
        'txtDonGia
        '
        Me.txtDonGia.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtDonGia.Location = New System.Drawing.Point(328, 80)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(120, 25)
        Me.txtDonGia.TabIndex = 4
        Me.txtDonGia.Text = ""
        '
        'cbbMaPhong
        '
        Me.cbbMaPhong.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.cbbMaPhong.Location = New System.Drawing.Point(104, 80)
        Me.cbbMaPhong.Name = "cbbMaPhong"
        Me.cbbMaPhong.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Lo?i Phòng"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(248, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ðon Giá"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdTraCuu)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 208)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kết Quả Tra Cứu"
        '
        'grdTraCuu
        '
        Me.grdTraCuu.DataMember = ""
        Me.grdTraCuu.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdTraCuu.Location = New System.Drawing.Point(8, 24)
        Me.grdTraCuu.Name = "grdTraCuu"
        Me.grdTraCuu.Size = New System.Drawing.Size(464, 176)
        Me.grdTraCuu.TabIndex = 0
        '
        'btTraCuu
        '
        Me.btTraCuu.Location = New System.Drawing.Point(40, 136)
        Me.btTraCuu.Name = "btTraCuu"
        Me.btTraCuu.Size = New System.Drawing.Size(80, 24)
        Me.btTraCuu.TabIndex = 9
        Me.btTraCuu.Text = "Tra Cứu"
        '
        'btTraCuuTiep
        '
        Me.btTraCuuTiep.Location = New System.Drawing.Point(184, 136)
        Me.btTraCuuTiep.Name = "btTraCuuTiep"
        Me.btTraCuuTiep.Size = New System.Drawing.Size(104, 24)
        Me.btTraCuuTiep.TabIndex = 10
        Me.btTraCuuTiep.Text = "Tra Cứu Tiêp1"
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(352, 136)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.TabIndex = 11
        Me.btThoat.Text = "Thoát"
        '
        'cmbPhong
        '
        Me.cmbPhong.Location = New System.Drawing.Point(104, 24)
        Me.cmbPhong.Name = "cmbPhong"
        Me.cmbPhong.TabIndex = 12
        '
        'frmTraCuuPhong
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 18)
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(496, 390)
        Me.Controls.Add(Me.cmbPhong)
        Me.Controls.Add(Me.btThoat)
        Me.Controls.Add(Me.btTraCuuTiep)
        Me.Controls.Add(Me.btTraCuu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbbMaPhong)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.txtTenPhong)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "frmTraCuuPhong"
        Me.Text = "Tra Cuu Phong"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdTraCuu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    
    Private Sub btTraCuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTraCuu.Click

    End Sub

    Private Sub btTraCuuTiep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTraCuuTiep.Click

    End Sub

    Private Sub btThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btThoat.Click
        Me.Close()
    End Sub
End Class
