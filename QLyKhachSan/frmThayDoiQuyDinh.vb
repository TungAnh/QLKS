Public Class frmThayDoiQuyDinh
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
    Friend WithEvents cbbQuyDinh As System.Windows.Forms.ComboBox
    Friend WithEvents btThayDoi As System.Windows.Forms.Button
    Friend WithEvents btThayDoiTiep As System.Windows.Forms.Button
    Friend WithEvents btThoat As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGiaTri As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbbQuyDinh = New System.Windows.Forms.ComboBox
        Me.btThayDoi = New System.Windows.Forms.Button
        Me.btThayDoiTiep = New System.Windows.Forms.Button
        Me.btThoat = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtGiaTri = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Các Quy Ðịnh"
        '
        'cbbQuyDinh
        '
        Me.cbbQuyDinh.Location = New System.Drawing.Point(128, 40)
        Me.cbbQuyDinh.Name = "cbbQuyDinh"
        Me.cbbQuyDinh.Size = New System.Drawing.Size(136, 25)
        Me.cbbQuyDinh.TabIndex = 1
        '
        'btThayDoi
        '
        Me.btThayDoi.Location = New System.Drawing.Point(32, 136)
        Me.btThayDoi.Name = "btThayDoi"
        Me.btThayDoi.Size = New System.Drawing.Size(75, 32)
        Me.btThayDoi.TabIndex = 2
        Me.btThayDoi.Text = "Thay Ðổi"
        '
        'btThayDoiTiep
        '
        Me.btThayDoiTiep.Location = New System.Drawing.Point(136, 136)
        Me.btThayDoiTiep.Name = "btThayDoiTiep"
        Me.btThayDoiTiep.Size = New System.Drawing.Size(112, 32)
        Me.btThayDoiTiep.TabIndex = 3
        Me.btThayDoiTiep.Text = "Thay Ðổi Tiếp"
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(280, 136)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(75, 32)
        Me.btThoat.TabIndex = 4
        Me.btThoat.Text = "Thoát"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Giá Trị"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGiaTri
        '
        Me.txtGiaTri.Location = New System.Drawing.Point(128, 88)
        Me.txtGiaTri.Name = "txtGiaTri"
        Me.txtGiaTri.Size = New System.Drawing.Size(136, 25)
        Me.txtGiaTri.TabIndex = 6
        Me.txtGiaTri.Text = ""
        '
        'frmThayDoiQuyDinh
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 18)
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(376, 190)
        Me.Controls.Add(Me.txtGiaTri)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btThoat)
        Me.Controls.Add(Me.btThayDoiTiep)
        Me.Controls.Add(Me.btThayDoi)
        Me.Controls.Add(Me.cbbQuyDinh)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmThayDoiQuyDinh"
        Me.Text = "Thay Doi Quy Dinh"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btThoat.Click
        Me.Close()
    End Sub

    Private Sub btThayDoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btThayDoi.Click

    End Sub

    Private Sub btThayDoiTiep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btThayDoiTiep.Click

    End Sub
End Class
