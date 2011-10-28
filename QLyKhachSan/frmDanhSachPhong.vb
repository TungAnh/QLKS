Public Class frmDanhSachPhong
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btThoat As System.Windows.Forms.Button
    Friend WithEvents grdDSPhong As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.grdDSPhong = New System.Windows.Forms.DataGrid
        Me.btThoat = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdDSPhong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdDSPhong)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 280)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Danh Sách Phòng Trong Khách  Sạn"
        '
        'grdDSPhong
        '
        Me.grdDSPhong.DataMember = ""
        Me.grdDSPhong.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdDSPhong.Location = New System.Drawing.Point(8, 24)
        Me.grdDSPhong.Name = "grdDSPhong"
        Me.grdDSPhong.Size = New System.Drawing.Size(448, 248)
        Me.grdDSPhong.TabIndex = 0
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(392, 312)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(75, 32)
        Me.btThoat.TabIndex = 1
        Me.btThoat.Text = "Thoát"
        '
        'frmDanhSachPhong
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 18)
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(480, 350)
        Me.Controls.Add(Me.btThoat)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmDanhSachPhong"
        Me.Text = "Danh Sach Phong"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdDSPhong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btThoat.Click
        Me.Close()

    End Sub

    Private Sub frmDanhSachPhong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DSPhong As New TiepNhanPhong
        Dim ds As DataSet
        Dim index As Integer
        index = grdDSPhong.CurrentRowIndex
        ds = DSPhong.LayDanhSachPhong()
        grdDSPhong.DataSource = ds.Tables(0)

    End Sub
End Class
