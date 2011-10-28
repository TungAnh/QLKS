Public Class frmMenu
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
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents Picture As System.Windows.Forms.PictureBox
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMenu))
        Me.MainMenu = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.Picture = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem7, Me.MenuItem12, Me.MenuItem17, Me.MenuItem20, Me.MenuItem23})
        Me.MainMenu.RightToLeft = CType(resources.GetObject("MainMenu.RightToLeft"), System.Windows.Forms.RightToLeft)
        '
        'MenuItem1
        '
        Me.MenuItem1.Enabled = CType(resources.GetObject("MenuItem1.Enabled"), Boolean)
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6})
        Me.MenuItem1.Shortcut = CType(resources.GetObject("MenuItem1.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem1.ShowShortcut = CType(resources.GetObject("MenuItem1.ShowShortcut"), Boolean)
        Me.MenuItem1.Text = resources.GetString("MenuItem1.Text")
        Me.MenuItem1.Visible = CType(resources.GetObject("MenuItem1.Visible"), Boolean)
        '
        'MenuItem2
        '
        Me.MenuItem2.Enabled = CType(resources.GetObject("MenuItem2.Enabled"), Boolean)
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Shortcut = CType(resources.GetObject("MenuItem2.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem2.ShowShortcut = CType(resources.GetObject("MenuItem2.ShowShortcut"), Boolean)
        Me.MenuItem2.Text = resources.GetString("MenuItem2.Text")
        Me.MenuItem2.Visible = CType(resources.GetObject("MenuItem2.Visible"), Boolean)
        '
        'MenuItem3
        '
        Me.MenuItem3.Enabled = CType(resources.GetObject("MenuItem3.Enabled"), Boolean)
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Shortcut = CType(resources.GetObject("MenuItem3.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem3.ShowShortcut = CType(resources.GetObject("MenuItem3.ShowShortcut"), Boolean)
        Me.MenuItem3.Text = resources.GetString("MenuItem3.Text")
        Me.MenuItem3.Visible = CType(resources.GetObject("MenuItem3.Visible"), Boolean)
        '
        'MenuItem4
        '
        Me.MenuItem4.Enabled = CType(resources.GetObject("MenuItem4.Enabled"), Boolean)
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Shortcut = CType(resources.GetObject("MenuItem4.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem4.ShowShortcut = CType(resources.GetObject("MenuItem4.ShowShortcut"), Boolean)
        Me.MenuItem4.Text = resources.GetString("MenuItem4.Text")
        Me.MenuItem4.Visible = CType(resources.GetObject("MenuItem4.Visible"), Boolean)
        '
        'MenuItem5
        '
        Me.MenuItem5.Enabled = CType(resources.GetObject("MenuItem5.Enabled"), Boolean)
        Me.MenuItem5.Index = 3
        Me.MenuItem5.Shortcut = CType(resources.GetObject("MenuItem5.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem5.ShowShortcut = CType(resources.GetObject("MenuItem5.ShowShortcut"), Boolean)
        Me.MenuItem5.Text = resources.GetString("MenuItem5.Text")
        Me.MenuItem5.Visible = CType(resources.GetObject("MenuItem5.Visible"), Boolean)
        '
        'MenuItem6
        '
        Me.MenuItem6.Enabled = CType(resources.GetObject("MenuItem6.Enabled"), Boolean)
        Me.MenuItem6.Index = 4
        Me.MenuItem6.Shortcut = CType(resources.GetObject("MenuItem6.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem6.ShowShortcut = CType(resources.GetObject("MenuItem6.ShowShortcut"), Boolean)
        Me.MenuItem6.Text = resources.GetString("MenuItem6.Text")
        Me.MenuItem6.Visible = CType(resources.GetObject("MenuItem6.Visible"), Boolean)
        '
        'MenuItem7
        '
        Me.MenuItem7.Enabled = CType(resources.GetObject("MenuItem7.Enabled"), Boolean)
        Me.MenuItem7.Index = 1
        Me.MenuItem7.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem8, Me.MenuItem13, Me.MenuItem9, Me.MenuItem11, Me.MenuItem10, Me.MenuItem25})
        Me.MenuItem7.Shortcut = CType(resources.GetObject("MenuItem7.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem7.ShowShortcut = CType(resources.GetObject("MenuItem7.ShowShortcut"), Boolean)
        Me.MenuItem7.Text = resources.GetString("MenuItem7.Text")
        Me.MenuItem7.Visible = CType(resources.GetObject("MenuItem7.Visible"), Boolean)
        '
        'MenuItem8
        '
        Me.MenuItem8.Enabled = CType(resources.GetObject("MenuItem8.Enabled"), Boolean)
        Me.MenuItem8.Index = 0
        Me.MenuItem8.Shortcut = CType(resources.GetObject("MenuItem8.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem8.ShowShortcut = CType(resources.GetObject("MenuItem8.ShowShortcut"), Boolean)
        Me.MenuItem8.Text = resources.GetString("MenuItem8.Text")
        Me.MenuItem8.Visible = CType(resources.GetObject("MenuItem8.Visible"), Boolean)
        '
        'MenuItem13
        '
        Me.MenuItem13.Enabled = CType(resources.GetObject("MenuItem13.Enabled"), Boolean)
        Me.MenuItem13.Index = 1
        Me.MenuItem13.Shortcut = CType(resources.GetObject("MenuItem13.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem13.ShowShortcut = CType(resources.GetObject("MenuItem13.ShowShortcut"), Boolean)
        Me.MenuItem13.Text = resources.GetString("MenuItem13.Text")
        Me.MenuItem13.Visible = CType(resources.GetObject("MenuItem13.Visible"), Boolean)
        '
        'MenuItem9
        '
        Me.MenuItem9.Enabled = CType(resources.GetObject("MenuItem9.Enabled"), Boolean)
        Me.MenuItem9.Index = 2
        Me.MenuItem9.Shortcut = CType(resources.GetObject("MenuItem9.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem9.ShowShortcut = CType(resources.GetObject("MenuItem9.ShowShortcut"), Boolean)
        Me.MenuItem9.Text = resources.GetString("MenuItem9.Text")
        Me.MenuItem9.Visible = CType(resources.GetObject("MenuItem9.Visible"), Boolean)
        '
        'MenuItem11
        '
        Me.MenuItem11.Enabled = CType(resources.GetObject("MenuItem11.Enabled"), Boolean)
        Me.MenuItem11.Index = 3
        Me.MenuItem11.Shortcut = CType(resources.GetObject("MenuItem11.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem11.ShowShortcut = CType(resources.GetObject("MenuItem11.ShowShortcut"), Boolean)
        Me.MenuItem11.Text = resources.GetString("MenuItem11.Text")
        Me.MenuItem11.Visible = CType(resources.GetObject("MenuItem11.Visible"), Boolean)
        '
        'MenuItem10
        '
        Me.MenuItem10.Enabled = CType(resources.GetObject("MenuItem10.Enabled"), Boolean)
        Me.MenuItem10.Index = 4
        Me.MenuItem10.Shortcut = CType(resources.GetObject("MenuItem10.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem10.ShowShortcut = CType(resources.GetObject("MenuItem10.ShowShortcut"), Boolean)
        Me.MenuItem10.Text = resources.GetString("MenuItem10.Text")
        Me.MenuItem10.Visible = CType(resources.GetObject("MenuItem10.Visible"), Boolean)
        '
        'MenuItem25
        '
        Me.MenuItem25.Enabled = CType(resources.GetObject("MenuItem25.Enabled"), Boolean)
        Me.MenuItem25.Index = 5
        Me.MenuItem25.Shortcut = CType(resources.GetObject("MenuItem25.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem25.ShowShortcut = CType(resources.GetObject("MenuItem25.ShowShortcut"), Boolean)
        Me.MenuItem25.Text = resources.GetString("MenuItem25.Text")
        Me.MenuItem25.Visible = CType(resources.GetObject("MenuItem25.Visible"), Boolean)
        '
        'MenuItem12
        '
        Me.MenuItem12.Enabled = CType(resources.GetObject("MenuItem12.Enabled"), Boolean)
        Me.MenuItem12.Index = 2
        Me.MenuItem12.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem14, Me.MenuItem15, Me.MenuItem16})
        Me.MenuItem12.Shortcut = CType(resources.GetObject("MenuItem12.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem12.ShowShortcut = CType(resources.GetObject("MenuItem12.ShowShortcut"), Boolean)
        Me.MenuItem12.Text = resources.GetString("MenuItem12.Text")
        Me.MenuItem12.Visible = CType(resources.GetObject("MenuItem12.Visible"), Boolean)
        '
        'MenuItem14
        '
        Me.MenuItem14.Enabled = CType(resources.GetObject("MenuItem14.Enabled"), Boolean)
        Me.MenuItem14.Index = 0
        Me.MenuItem14.Shortcut = CType(resources.GetObject("MenuItem14.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem14.ShowShortcut = CType(resources.GetObject("MenuItem14.ShowShortcut"), Boolean)
        Me.MenuItem14.Text = resources.GetString("MenuItem14.Text")
        Me.MenuItem14.Visible = CType(resources.GetObject("MenuItem14.Visible"), Boolean)
        '
        'MenuItem15
        '
        Me.MenuItem15.Enabled = CType(resources.GetObject("MenuItem15.Enabled"), Boolean)
        Me.MenuItem15.Index = 1
        Me.MenuItem15.Shortcut = CType(resources.GetObject("MenuItem15.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem15.ShowShortcut = CType(resources.GetObject("MenuItem15.ShowShortcut"), Boolean)
        Me.MenuItem15.Text = resources.GetString("MenuItem15.Text")
        Me.MenuItem15.Visible = CType(resources.GetObject("MenuItem15.Visible"), Boolean)
        '
        'MenuItem16
        '
        Me.MenuItem16.Enabled = CType(resources.GetObject("MenuItem16.Enabled"), Boolean)
        Me.MenuItem16.Index = 2
        Me.MenuItem16.Shortcut = CType(resources.GetObject("MenuItem16.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem16.ShowShortcut = CType(resources.GetObject("MenuItem16.ShowShortcut"), Boolean)
        Me.MenuItem16.Text = resources.GetString("MenuItem16.Text")
        Me.MenuItem16.Visible = CType(resources.GetObject("MenuItem16.Visible"), Boolean)
        '
        'MenuItem17
        '
        Me.MenuItem17.Enabled = CType(resources.GetObject("MenuItem17.Enabled"), Boolean)
        Me.MenuItem17.Index = 3
        Me.MenuItem17.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem18, Me.MenuItem19})
        Me.MenuItem17.Shortcut = CType(resources.GetObject("MenuItem17.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem17.ShowShortcut = CType(resources.GetObject("MenuItem17.ShowShortcut"), Boolean)
        Me.MenuItem17.Text = resources.GetString("MenuItem17.Text")
        Me.MenuItem17.Visible = CType(resources.GetObject("MenuItem17.Visible"), Boolean)
        '
        'MenuItem18
        '
        Me.MenuItem18.Enabled = CType(resources.GetObject("MenuItem18.Enabled"), Boolean)
        Me.MenuItem18.Index = 0
        Me.MenuItem18.Shortcut = CType(resources.GetObject("MenuItem18.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem18.ShowShortcut = CType(resources.GetObject("MenuItem18.ShowShortcut"), Boolean)
        Me.MenuItem18.Text = resources.GetString("MenuItem18.Text")
        Me.MenuItem18.Visible = CType(resources.GetObject("MenuItem18.Visible"), Boolean)
        '
        'MenuItem19
        '
        Me.MenuItem19.Enabled = CType(resources.GetObject("MenuItem19.Enabled"), Boolean)
        Me.MenuItem19.Index = 1
        Me.MenuItem19.Shortcut = CType(resources.GetObject("MenuItem19.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem19.ShowShortcut = CType(resources.GetObject("MenuItem19.ShowShortcut"), Boolean)
        Me.MenuItem19.Text = resources.GetString("MenuItem19.Text")
        Me.MenuItem19.Visible = CType(resources.GetObject("MenuItem19.Visible"), Boolean)
        '
        'MenuItem20
        '
        Me.MenuItem20.Enabled = CType(resources.GetObject("MenuItem20.Enabled"), Boolean)
        Me.MenuItem20.Index = 4
        Me.MenuItem20.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem21, Me.MenuItem22})
        Me.MenuItem20.Shortcut = CType(resources.GetObject("MenuItem20.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem20.ShowShortcut = CType(resources.GetObject("MenuItem20.ShowShortcut"), Boolean)
        Me.MenuItem20.Text = resources.GetString("MenuItem20.Text")
        Me.MenuItem20.Visible = CType(resources.GetObject("MenuItem20.Visible"), Boolean)
        '
        'MenuItem21
        '
        Me.MenuItem21.Enabled = CType(resources.GetObject("MenuItem21.Enabled"), Boolean)
        Me.MenuItem21.Index = 0
        Me.MenuItem21.Shortcut = CType(resources.GetObject("MenuItem21.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem21.ShowShortcut = CType(resources.GetObject("MenuItem21.ShowShortcut"), Boolean)
        Me.MenuItem21.Text = resources.GetString("MenuItem21.Text")
        Me.MenuItem21.Visible = CType(resources.GetObject("MenuItem21.Visible"), Boolean)
        '
        'MenuItem22
        '
        Me.MenuItem22.Enabled = CType(resources.GetObject("MenuItem22.Enabled"), Boolean)
        Me.MenuItem22.Index = 1
        Me.MenuItem22.Shortcut = CType(resources.GetObject("MenuItem22.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem22.ShowShortcut = CType(resources.GetObject("MenuItem22.ShowShortcut"), Boolean)
        Me.MenuItem22.Text = resources.GetString("MenuItem22.Text")
        Me.MenuItem22.Visible = CType(resources.GetObject("MenuItem22.Visible"), Boolean)
        '
        'MenuItem23
        '
        Me.MenuItem23.Enabled = CType(resources.GetObject("MenuItem23.Enabled"), Boolean)
        Me.MenuItem23.Index = 5
        Me.MenuItem23.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem24})
        Me.MenuItem23.Shortcut = CType(resources.GetObject("MenuItem23.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem23.ShowShortcut = CType(resources.GetObject("MenuItem23.ShowShortcut"), Boolean)
        Me.MenuItem23.Text = resources.GetString("MenuItem23.Text")
        Me.MenuItem23.Visible = CType(resources.GetObject("MenuItem23.Visible"), Boolean)
        '
        'MenuItem24
        '
        Me.MenuItem24.Enabled = CType(resources.GetObject("MenuItem24.Enabled"), Boolean)
        Me.MenuItem24.Index = 0
        Me.MenuItem24.Shortcut = CType(resources.GetObject("MenuItem24.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem24.ShowShortcut = CType(resources.GetObject("MenuItem24.ShowShortcut"), Boolean)
        Me.MenuItem24.Text = resources.GetString("MenuItem24.Text")
        Me.MenuItem24.Visible = CType(resources.GetObject("MenuItem24.Visible"), Boolean)
        '
        'Picture
        '
        Me.Picture.AccessibleDescription = resources.GetString("Picture.AccessibleDescription")
        Me.Picture.AccessibleName = resources.GetString("Picture.AccessibleName")
        Me.Picture.Anchor = CType(resources.GetObject("Picture.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Picture.BackgroundImage = CType(resources.GetObject("Picture.BackgroundImage"), System.Drawing.Image)
        Me.Picture.Dock = CType(resources.GetObject("Picture.Dock"), System.Windows.Forms.DockStyle)
        Me.Picture.Enabled = CType(resources.GetObject("Picture.Enabled"), Boolean)
        Me.Picture.Font = CType(resources.GetObject("Picture.Font"), System.Drawing.Font)
        Me.Picture.Image = CType(resources.GetObject("Picture.Image"), System.Drawing.Image)
        Me.Picture.ImeMode = CType(resources.GetObject("Picture.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Picture.Location = CType(resources.GetObject("Picture.Location"), System.Drawing.Point)
        Me.Picture.Name = "Picture"
        Me.Picture.RightToLeft = CType(resources.GetObject("Picture.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Picture.Size = CType(resources.GetObject("Picture.Size"), System.Drawing.Size)
        Me.Picture.SizeMode = CType(resources.GetObject("Picture.SizeMode"), System.Windows.Forms.PictureBoxSizeMode)
        Me.Picture.TabIndex = CType(resources.GetObject("Picture.TabIndex"), Integer)
        Me.Picture.TabStop = False
        Me.Picture.Text = resources.GetString("Picture.Text")
        Me.Picture.Visible = CType(resources.GetObject("Picture.Visible"), Boolean)
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = resources.GetString("Label1.AccessibleDescription")
        Me.Label1.AccessibleName = resources.GetString("Label1.AccessibleName")
        Me.Label1.Anchor = CType(resources.GetObject("Label1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = CType(resources.GetObject("Label1.AutoSize"), Boolean)
        Me.Label1.BackColor = System.Drawing.SystemColors.Info
        Me.Label1.Dock = CType(resources.GetObject("Label1.Dock"), System.Windows.Forms.DockStyle)
        Me.Label1.Enabled = CType(resources.GetObject("Label1.Enabled"), Boolean)
        Me.Label1.Font = CType(resources.GetObject("Label1.Font"), System.Drawing.Font)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = CType(resources.GetObject("Label1.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label1.ImageIndex = CType(resources.GetObject("Label1.ImageIndex"), Integer)
        Me.Label1.ImeMode = CType(resources.GetObject("Label1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label1.Location = CType(resources.GetObject("Label1.Location"), System.Drawing.Point)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = CType(resources.GetObject("Label1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label1.Size = CType(resources.GetObject("Label1.Size"), System.Drawing.Size)
        Me.Label1.TabIndex = CType(resources.GetObject("Label1.TabIndex"), Integer)
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = CType(resources.GetObject("Label1.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label1.Visible = CType(resources.GetObject("Label1.Visible"), Boolean)
        '
        'frmMenu
        '
        Me.AccessibleDescription = resources.GetString("$this.AccessibleDescription")
        Me.AccessibleName = resources.GetString("$this.AccessibleName")
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Picture)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.Menu = Me.MainMenu
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "frmMenu"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Dim frmLPhong As New frmThemLoaiPhong
        frmLPhong.ShowDialog()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Picture.Click

    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click

    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim frmLoaiKhach As New frmThemLoaiKhach
        frmLoaiKhach.ShowDialog()

    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click

    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        Dim frmTDQuyDinh As New frmThayDoiQuyDinh
        frmTDQuyDinh.ShowDialog()
        'frmTDQuyDinh = Nothing
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Dim frmTNPhong As New frmTiepNhanPhong
        frmTNPhong.ShowDialog()
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click

    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        Dim frmLapPTPhong As New frmLapPhieuThuePhong
        frmLapPTPhong.ShowDialog()

    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click

    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        Dim frmTrcuuPhong As New frmTraCuuPhong
        frmTrcuuPhong.ShowDialog()

    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click

    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click

    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click

    End Sub

    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        Dim frmHDThanhToan As New frmHoaDonThanhToan
        frmHDThanhToan.ShowDialog()

    End Sub

    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        Dim frmTTHoaDon As New frmTracuuHoaDon
        frmTTHoaDon.ShowDialog()
    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        Dim frmBCDThu As New frmBCaoDoanhThu
        frmBCDThu.ShowDialog()
    End Sub

    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        Dim frmBCMDo As New frmBCaoMatDo
        frmBCMDo.ShowDialog()
    End Sub

    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        Dim frmDSPhong As New frmDanhSachPhong
        frmDSPhong.ShowDialog()
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click

    End Sub

    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        Dim frmhlep As New frmHelp
        frmhlep.ShowDialog()
    End Sub
End Class
