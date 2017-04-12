<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTRL_Jurusan
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.BackgroundWorkerSearch = New System.ComponentModel.BackgroundWorker()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.LBERROR = New DevComponents.DotNetBar.LabelX()
        Me.BTSIMPAN = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.TXTJURUSAN = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.TXTID = New DevComponents.DotNetBar.LabelX()
        Me.TXTTANGGAL = New DevComponents.DotNetBar.LabelX()
        Me.HAPUS = New DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTHAPUS = New DevComponents.DotNetBar.ButtonItem()
        Me.BTUBAH = New DevComponents.DotNetBar.ButtonItem()
        Me.BTTAMBAH = New DevComponents.DotNetBar.ButtonItem()
        Me.TXTSEARCH = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.BTKELUAR = New DevComponents.DotNetBar.ButtonX()
        Me.BTBATAL = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.PanelEx2.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
        '
        'BackgroundWorkerSearch
        '
        '
        'LabelX10
        '
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX10.ForeColor = System.Drawing.Color.White
        Me.LabelX10.Location = New System.Drawing.Point(46, 73)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(127, 23)
        Me.LabelX10.TabIndex = 79
        Me.LabelX10.Text = "KODE JURUSAN"
        '
        'LBERROR
        '
        Me.LBERROR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LBERROR.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LBERROR.Location = New System.Drawing.Point(46, 315)
        Me.LBERROR.Name = "LBERROR"
        Me.LBERROR.Size = New System.Drawing.Size(650, 23)
        Me.LBERROR.TabIndex = 78
        '
        'BTSIMPAN
        '
        Me.BTSIMPAN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTSIMPAN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTSIMPAN.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.BTSIMPAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTSIMPAN.Location = New System.Drawing.Point(46, 213)
        Me.BTSIMPAN.Name = "BTSIMPAN"
        Me.BTSIMPAN.Size = New System.Drawing.Size(117, 42)
        Me.BTSIMPAN.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.BTSIMPAN.TabIndex = 73
        Me.BTSIMPAN.Text = "SIMPAN"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.ForeColor = System.Drawing.Color.White
        Me.LabelX6.Location = New System.Drawing.Point(15, 20)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(270, 23)
        Me.LabelX6.Symbol = ""
        Me.LabelX6.TabIndex = 70
        Me.LabelX6.Text = "  MASTER DATA JURUSAN"
        '
        'TXTJURUSAN
        '
        Me.TXTJURUSAN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTJURUSAN.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.TXTJURUSAN.Border.Class = "TextBoxBorder"
        Me.TXTJURUSAN.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXTJURUSAN.DisabledBackColor = System.Drawing.Color.Black
        Me.TXTJURUSAN.ForeColor = System.Drawing.Color.White
        Me.TXTJURUSAN.Location = New System.Drawing.Point(193, 102)
        Me.TXTJURUSAN.Name = "TXTJURUSAN"
        Me.TXTJURUSAN.PreventEnterBeep = True
        Me.TXTJURUSAN.Size = New System.Drawing.Size(503, 20)
        Me.TXTJURUSAN.TabIndex = 66
        Me.TXTJURUSAN.WatermarkColor = System.Drawing.SystemColors.ControlDark
        Me.TXTJURUSAN.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTJURUSAN.WatermarkText = "JURUSAN..."
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.White
        Me.LabelX2.Location = New System.Drawing.Point(46, 99)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(98, 23)
        Me.LabelX2.TabIndex = 62
        Me.LabelX2.Text = "JURUSAN"
        '
        'TXTID
        '
        Me.TXTID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.TXTID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXTID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTID.ForeColor = System.Drawing.Color.White
        Me.TXTID.Location = New System.Drawing.Point(193, 73)
        Me.TXTID.Name = "TXTID"
        Me.TXTID.Size = New System.Drawing.Size(226, 23)
        Me.TXTID.TabIndex = 75
        Me.TXTID.Text = "KODE JURUSAN"
        '
        'TXTTANGGAL
        '
        Me.TXTTANGGAL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.TXTTANGGAL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXTTANGGAL.Location = New System.Drawing.Point(536, 20)
        Me.TXTTANGGAL.Name = "TXTTANGGAL"
        Me.TXTTANGGAL.Size = New System.Drawing.Size(208, 23)
        Me.TXTTANGGAL.TabIndex = 76
        Me.TXTTANGGAL.Text = "TANGGAL"
        Me.TXTTANGGAL.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'HAPUS
        '
        Me.HAPUS.Checked = True
        Me.HAPUS.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.HAPUS.CheckValue = "N"
        Me.HAPUS.HeaderText = "HAPUS"
        Me.HAPUS.Name = "HAPUS"
        Me.HAPUS.Width = 50
        '
        'PanelEx2
        '
        Me.PanelEx2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.PanelEx2.Controls.Add(Me.DataGridViewX1)
        Me.PanelEx2.Controls.Add(Me.LabelX10)
        Me.PanelEx2.Controls.Add(Me.LBERROR)
        Me.PanelEx2.Controls.Add(Me.PictureBox1)
        Me.PanelEx2.Controls.Add(Me.BTSIMPAN)
        Me.PanelEx2.Controls.Add(Me.LabelX6)
        Me.PanelEx2.Controls.Add(Me.TXTJURUSAN)
        Me.PanelEx2.Controls.Add(Me.LabelX2)
        Me.PanelEx2.Controls.Add(Me.TXTID)
        Me.PanelEx2.Controls.Add(Me.TXTTANGGAL)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Location = New System.Drawing.Point(2, 43)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(761, 341)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.Color = System.Drawing.Color.Silver
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 0
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.AllowUserToAddRows = False
        Me.DataGridViewX1.AllowUserToDeleteRows = False
        Me.DataGridViewX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewX1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewX1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewX1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HAPUS})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewX1.EnableHeadersVisualStyles = False
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(0, 3)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewX1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewX1.Size = New System.Drawing.Size(761, 335)
        Me.DataGridViewX1.TabIndex = 74
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(46, 270)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 77
        Me.PictureBox1.TabStop = False
        '
        'BTHAPUS
        '
        Me.BTHAPUS.Name = "BTHAPUS"
        Me.BTHAPUS.Symbol = ""
        Me.BTHAPUS.SymbolSize = 12.0!
        Me.BTHAPUS.Text = "HAPUS"
        '
        'BTUBAH
        '
        Me.BTUBAH.Name = "BTUBAH"
        Me.BTUBAH.Symbol = ""
        Me.BTUBAH.SymbolSize = 12.0!
        Me.BTUBAH.Text = "UBAH"
        '
        'BTTAMBAH
        '
        Me.BTTAMBAH.Name = "BTTAMBAH"
        Me.BTTAMBAH.Symbol = ""
        Me.BTTAMBAH.SymbolSize = 12.0!
        Me.BTTAMBAH.Text = "TAMBAH"
        '
        'TXTSEARCH
        '
        Me.TXTSEARCH.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.TXTSEARCH.Border.Class = "TextBoxBorder"
        Me.TXTSEARCH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXTSEARCH.DisabledBackColor = System.Drawing.Color.Black
        Me.TXTSEARCH.ForeColor = System.Drawing.Color.White
        Me.TXTSEARCH.Location = New System.Drawing.Point(63, 17)
        Me.TXTSEARCH.Name = "TXTSEARCH"
        Me.TXTSEARCH.PreventEnterBeep = True
        Me.TXTSEARCH.Size = New System.Drawing.Size(265, 20)
        Me.TXTSEARCH.TabIndex = 62
        Me.TXTSEARCH.WatermarkColor = System.Drawing.SystemColors.ControlDark
        Me.TXTSEARCH.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSEARCH.WatermarkText = "CARI JURUSAN..."
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.White
        Me.LabelX1.Location = New System.Drawing.Point(17, 14)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(39, 23)
        Me.LabelX1.TabIndex = 61
        Me.LabelX1.Text = "CARI"
        '
        'BTKELUAR
        '
        Me.BTKELUAR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTKELUAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTKELUAR.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTKELUAR.Location = New System.Drawing.Point(675, 8)
        Me.BTKELUAR.Name = "BTKELUAR"
        Me.BTKELUAR.Size = New System.Drawing.Size(88, 29)
        Me.BTKELUAR.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.BTKELUAR.TabIndex = 60
        Me.BTKELUAR.Text = "KELUAR"
        '
        'BTBATAL
        '
        Me.BTBATAL.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTBATAL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTBATAL.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTBATAL.Location = New System.Drawing.Point(581, 8)
        Me.BTBATAL.Name = "BTBATAL"
        Me.BTBATAL.Size = New System.Drawing.Size(88, 29)
        Me.BTBATAL.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.BTBATAL.TabIndex = 59
        Me.BTBATAL.Text = "BATAL"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX2.AutoExpandOnClick = True
        Me.ButtonX2.Location = New System.Drawing.Point(470, 8)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(105, 29)
        Me.ButtonX2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.BTTAMBAH, Me.BTUBAH, Me.BTHAPUS})
        Me.ButtonX2.TabIndex = 58
        Me.ButtonX2.Text = "MANIPULASI"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.PanelEx1.Controls.Add(Me.TXTSEARCH)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Controls.Add(Me.BTKELUAR)
        Me.PanelEx1.Controls.Add(Me.BTBATAL)
        Me.PanelEx1.Controls.Add(Me.ButtonX2)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(767, 387)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.Color = System.Drawing.Color.Silver
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 3
        '
        'BackgroundWorker
        '
        '
        'CTRL_Jurusan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelEx1)
        Me.Name = "CTRL_Jurusan"
        Me.Size = New System.Drawing.Size(767, 387)
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents BackgroundWorkerSearch As System.ComponentModel.BackgroundWorker
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBERROR As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BTSIMPAN As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TXTJURUSAN As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TXTID As DevComponents.DotNetBar.LabelX
    Friend WithEvents TXTTANGGAL As DevComponents.DotNetBar.LabelX
    Friend WithEvents HAPUS As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents BTHAPUS As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BTUBAH As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BTTAMBAH As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents TXTSEARCH As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BTKELUAR As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTBATAL As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker

End Class
