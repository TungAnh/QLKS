Public Class frmBCaoMatDo
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
    Friend WithEvents DateTimePickerThang As System.Windows.Forms.DateTimePicker
    Friend WithEvents btBaoCao As System.Windows.Forms.Button
    Friend WithEvents btBaoCaoTiep As System.Windows.Forms.Button
    Friend WithEvents btThoat As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTimePickerThang = New System.Windows.Forms.DateTimePicker
        Me.btBaoCao = New System.Windows.Forms.Button
        Me.btBaoCaoTiep = New System.Windows.Forms.Button
        Me.btThoat = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tháng"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePickerThang
        '
        Me.DateTimePickerThang.Location = New System.Drawing.Point(88, 40)
        Me.DateTimePickerThang.Name = "DateTimePickerThang"
        Me.DateTimePickerThang.TabIndex = 1
        '
        'btBaoCao
        '
        Me.btBaoCao.Location = New System.Drawing.Point(24, 120)
        Me.btBaoCao.Name = "btBaoCao"
        Me.btBaoCao.TabIndex = 2
        Me.btBaoCao.Text = "Báo Cáo"
        '
        'btBaoCaoTiep
        '
        Me.btBaoCaoTiep.Location = New System.Drawing.Point(128, 120)
        Me.btBaoCaoTiep.Name = "btBaoCaoTiep"
        Me.btBaoCaoTiep.Size = New System.Drawing.Size(96, 23)
        Me.btBaoCaoTiep.TabIndex = 3
        Me.btBaoCaoTiep.Text = "Báo cáo Tiếp"
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(248, 120)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.TabIndex = 4
        Me.btThoat.Text = "Thoát"
        '
        'frmBCaoMatDo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 18)
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(336, 198)
        Me.Controls.Add(Me.btThoat)
        Me.Controls.Add(Me.btBaoCaoTiep)
        Me.Controls.Add(Me.btBaoCao)
        Me.Controls.Add(Me.DateTimePickerThang)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmBCaoMatDo"
        Me.Text = "Bao Cao Mat do su dung phong"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btThoat.Click
        Me.Close()
    End Sub

    Private Sub btBaoCaoTiep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBaoCaoTiep.Click

    End Sub

    Private Sub btBaoCao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBaoCao.Click

    End Sub
End Class
