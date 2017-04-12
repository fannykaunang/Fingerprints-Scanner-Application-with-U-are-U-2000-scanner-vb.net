<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTRL_Mata_Kuliah
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TXTSEARCH = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.BTBATAL = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.BTKELUAR = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.BTTAMBAH = New DevComponents.DotNetBar.ButtonItem()
        Me.BTUBAH = New DevComponents.DotNetBar.ButtonItem()
        Me.BTHAPUS = New DevComponents.DotNetBar.ButtonItem()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.HAPUS = New DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn()
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX()
        Me.TXTJUMLAHPERTEMUAN = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TXTTAHUNSAMPAI = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.TXTTAHUNMULAI = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.TXTSEMESTER = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.TXTJAMKELUAR = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.TXTJAMMASUK = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.TXTSKS = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.TXTMATAKULIAH = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.TXTID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TXTJURUSAN = New MTGCComboBox()
        Me.TXTDOSEN = New MTGCComboBox()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.TXTFAKULTAS = New MTGCComboBox()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.LBERROR = New DevComponents.DotNetBar.LabelX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTSIMPAN = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.TXTTANGGAL = New DevComponents.DotNetBar.LabelX()
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.BackgroundWorkerSearch = New System.ComponentModel.BackgroundWorker()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TXTSEARCH.WatermarkText = "CARI MATA KULIAH..."
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(17, 14)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(39, 23)
        Me.LabelX1.TabIndex = 61
        Me.LabelX1.Text = "CARI"
        '
        'BTBATAL
        '
        Me.BTBATAL.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTBATAL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTBATAL.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTBATAL.Location = New System.Drawing.Point(661, 8)
        Me.BTBATAL.Name = "BTBATAL"
        Me.BTBATAL.Size = New System.Drawing.Size(88, 29)
        Me.BTBATAL.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.BTBATAL.TabIndex = 59
        Me.BTBATAL.Text = "BATAL"
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
        Me.PanelEx1.Size = New System.Drawing.Size(847, 487)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.Color = System.Drawing.Color.Silver
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 4
        '
        'BTKELUAR
        '
        Me.BTKELUAR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTKELUAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTKELUAR.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTKELUAR.Location = New System.Drawing.Point(755, 8)
        Me.BTKELUAR.Name = "BTKELUAR"
        Me.BTKELUAR.Size = New System.Drawing.Size(88, 29)
        Me.BTKELUAR.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.BTKELUAR.TabIndex = 60
        Me.BTKELUAR.Text = "KELUAR"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX2.AutoExpandOnClick = True
        Me.ButtonX2.Location = New System.Drawing.Point(550, 8)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(105, 29)
        Me.ButtonX2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.BTTAMBAH, Me.BTUBAH, Me.BTHAPUS})
        Me.ButtonX2.TabIndex = 58
        Me.ButtonX2.Text = "MANIPULASI"
        '
        'BTTAMBAH
        '
        Me.BTTAMBAH.Name = "BTTAMBAH"
        Me.BTTAMBAH.Symbol = ""
        Me.BTTAMBAH.SymbolSize = 15.0!
        Me.BTTAMBAH.Text = "TAMBAH"
        '
        'BTUBAH
        '
        Me.BTUBAH.Name = "BTUBAH"
        Me.BTUBAH.Symbol = ""
        Me.BTUBAH.SymbolSize = 15.0!
        Me.BTUBAH.Text = "UBAH"
        '
        'BTHAPUS
        '
        Me.BTHAPUS.Name = "BTHAPUS"
        Me.BTHAPUS.Symbol = ""
        Me.BTHAPUS.SymbolSize = 15.0!
        Me.BTHAPUS.Text = "HAPUS"
        '
        'PanelEx2
        '
        Me.PanelEx2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.PanelEx2.Controls.Add(Me.DataGridViewX1)
        Me.PanelEx2.Controls.Add(Me.LabelX17)
        Me.PanelEx2.Controls.Add(Me.LabelX16)
        Me.PanelEx2.Controls.Add(Me.TXTJUMLAHPERTEMUAN)
        Me.PanelEx2.Controls.Add(Me.TXTTAHUNSAMPAI)
        Me.PanelEx2.Controls.Add(Me.TXTTAHUNMULAI)
        Me.PanelEx2.Controls.Add(Me.LabelX15)
        Me.PanelEx2.Controls.Add(Me.LabelX14)
        Me.PanelEx2.Controls.Add(Me.LabelX13)
        Me.PanelEx2.Controls.Add(Me.TXTSEMESTER)
        Me.PanelEx2.Controls.Add(Me.LabelX12)
        Me.PanelEx2.Controls.Add(Me.LabelX11)
        Me.PanelEx2.Controls.Add(Me.TXTJAMKELUAR)
        Me.PanelEx2.Controls.Add(Me.LabelX9)
        Me.PanelEx2.Controls.Add(Me.LabelX8)
        Me.PanelEx2.Controls.Add(Me.TXTJAMMASUK)
        Me.PanelEx2.Controls.Add(Me.TXTSKS)
        Me.PanelEx2.Controls.Add(Me.LabelX7)
        Me.PanelEx2.Controls.Add(Me.TXTMATAKULIAH)
        Me.PanelEx2.Controls.Add(Me.LabelX4)
        Me.PanelEx2.Controls.Add(Me.TXTID)
        Me.PanelEx2.Controls.Add(Me.TXTJURUSAN)
        Me.PanelEx2.Controls.Add(Me.TXTDOSEN)
        Me.PanelEx2.Controls.Add(Me.LabelX5)
        Me.PanelEx2.Controls.Add(Me.TXTFAKULTAS)
        Me.PanelEx2.Controls.Add(Me.LabelX10)
        Me.PanelEx2.Controls.Add(Me.LBERROR)
        Me.PanelEx2.Controls.Add(Me.PictureBox1)
        Me.PanelEx2.Controls.Add(Me.BTSIMPAN)
        Me.PanelEx2.Controls.Add(Me.LabelX6)
        Me.PanelEx2.Controls.Add(Me.LabelX3)
        Me.PanelEx2.Controls.Add(Me.LabelX2)
        Me.PanelEx2.Controls.Add(Me.TXTTANGGAL)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Location = New System.Drawing.Point(2, 43)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(841, 441)
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewX1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HAPUS})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewX1.EnableHeadersVisualStyles = False
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(0, 3)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewX1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewX1.Size = New System.Drawing.Size(838, 435)
        Me.DataGridViewX1.TabIndex = 74
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
        'LabelX17
        '
        '
        '
        '
        Me.LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX17.Location = New System.Drawing.Point(629, 131)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(42, 23)
        Me.LabelX17.TabIndex = 207
        Me.LabelX17.Text = "X (Kali)"
        '
        'LabelX16
        '
        '
        '
        '
        Me.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX16.Location = New System.Drawing.Point(325, 131)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(236, 23)
        Me.LabelX16.TabIndex = 206
        Me.LabelX16.Text = "JUMLAH PERTEMUAN DALAM 1 SEMESTER"
        '
        'TXTJUMLAHPERTEMUAN
        '
        Me.TXTJUMLAHPERTEMUAN.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.TXTJUMLAHPERTEMUAN.Border.Class = "TextBoxBorder"
        Me.TXTJUMLAHPERTEMUAN.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXTJUMLAHPERTEMUAN.DisabledBackColor = System.Drawing.Color.Black
        Me.TXTJUMLAHPERTEMUAN.ForeColor = System.Drawing.Color.White
        Me.TXTJUMLAHPERTEMUAN.Location = New System.Drawing.Point(567, 134)
        Me.TXTJUMLAHPERTEMUAN.Name = "TXTJUMLAHPERTEMUAN"
        Me.TXTJUMLAHPERTEMUAN.PreventEnterBeep = True
        Me.TXTJUMLAHPERTEMUAN.Size = New System.Drawing.Size(56, 20)
        Me.TXTJUMLAHPERTEMUAN.TabIndex = 205
        '
        'TXTTAHUNSAMPAI
        '
        '
        '
        '
        Me.TXTTAHUNSAMPAI.BackgroundStyle.Class = "TextBoxBorder"
        Me.TXTTAHUNSAMPAI.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXTTAHUNSAMPAI.ButtonClear.Visible = True
        Me.TXTTAHUNSAMPAI.Location = New System.Drawing.Point(472, 310)
        Me.TXTTAHUNSAMPAI.Mask = "0000"
        Me.TXTTAHUNSAMPAI.Name = "TXTTAHUNSAMPAI"
        Me.TXTTAHUNSAMPAI.Size = New System.Drawing.Size(75, 19)
        Me.TXTTAHUNSAMPAI.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.TXTTAHUNSAMPAI.TabIndex = 204
        Me.TXTTAHUNSAMPAI.Text = ""
        '
        'TXTTAHUNMULAI
        '
        '
        '
        '
        Me.TXTTAHUNMULAI.BackgroundStyle.Class = "TextBoxBorder"
        Me.TXTTAHUNMULAI.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXTTAHUNMULAI.ButtonClear.Visible = True
        Me.TXTTAHUNMULAI.Location = New System.Drawing.Point(317, 310)
        Me.TXTTAHUNMULAI.Mask = "0000"
        Me.TXTTAHUNMULAI.Name = "TXTTAHUNMULAI"
        Me.TXTTAHUNMULAI.Size = New System.Drawing.Size(75, 19)
        Me.TXTTAHUNMULAI.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.TXTTAHUNMULAI.TabIndex = 203
        Me.TXTTAHUNMULAI.Text = ""
        '
        'LabelX15
        '
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.Location = New System.Drawing.Point(408, 306)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(48, 23)
        Me.LabelX15.TabIndex = 202
        Me.LabelX15.Text = "SAMPAI :"
        '
        'LabelX14
        '
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Location = New System.Drawing.Point(263, 306)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(48, 23)
        Me.LabelX14.TabIndex = 200
        Me.LabelX14.Text = "MULAI :"
        '
        'LabelX13
        '
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Location = New System.Drawing.Point(46, 306)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(113, 23)
        Me.LabelX13.TabIndex = 198
        Me.LabelX13.Text = "TAHUN AKADEMIK"
        '
        'TXTSEMESTER
        '
        Me.TXTSEMESTER.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTSEMESTER.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.TXTSEMESTER.Border.Class = "TextBoxBorder"
        Me.TXTSEMESTER.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXTSEMESTER.DisabledBackColor = System.Drawing.Color.Black
        Me.TXTSEMESTER.ForeColor = System.Drawing.Color.White
        Me.TXTSEMESTER.Location = New System.Drawing.Point(263, 251)
        Me.TXTSEMESTER.Name = "TXTSEMESTER"
        Me.TXTSEMESTER.PreventEnterBeep = True
        Me.TXTSEMESTER.Size = New System.Drawing.Size(56, 20)
        Me.TXTSEMESTER.TabIndex = 197
        '
        'LabelX12
        '
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Location = New System.Drawing.Point(46, 248)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(98, 23)
        Me.LabelX12.TabIndex = 196
        Me.LabelX12.Text = "SEMESTER"
        '
        'LabelX11
        '
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Location = New System.Drawing.Point(408, 161)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(62, 23)
        Me.LabelX11.TabIndex = 195
        Me.LabelX11.Text = "KELUAR :"
        '
        'TXTJAMKELUAR
        '
        '
        '
        '
        Me.TXTJAMKELUAR.BackgroundStyle.Class = "TextBoxBorder"
        Me.TXTJAMKELUAR.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXTJAMKELUAR.ButtonClear.Visible = True
        Me.TXTJAMKELUAR.Location = New System.Drawing.Point(472, 162)
        Me.TXTJAMKELUAR.Mask = "00:00"
        Me.TXTJAMKELUAR.Name = "TXTJAMKELUAR"
        Me.TXTJAMKELUAR.Size = New System.Drawing.Size(75, 19)
        Me.TXTJAMKELUAR.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.TXTJAMKELUAR.TabIndex = 194
        Me.TXTJAMKELUAR.Text = ""
        Me.TXTJAMKELUAR.ValidatingType = GetType(Date)
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(263, 160)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(48, 23)
        Me.LabelX9.TabIndex = 193
        Me.LabelX9.Text = "MASUK :"
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(46, 160)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(48, 23)
        Me.LabelX8.TabIndex = 192
        Me.LabelX8.Text = "JAM"
        '
        'TXTJAMMASUK
        '
        '
        '
        '
        Me.TXTJAMMASUK.BackgroundStyle.Class = "TextBoxBorder"
        Me.TXTJAMMASUK.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXTJAMMASUK.ButtonClear.Visible = True
        Me.TXTJAMMASUK.Location = New System.Drawing.Point(317, 162)
        Me.TXTJAMMASUK.Mask = "00:00"
        Me.TXTJAMMASUK.Name = "TXTJAMMASUK"
        Me.TXTJAMMASUK.Size = New System.Drawing.Size(75, 19)
        Me.TXTJAMMASUK.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.TXTJAMMASUK.TabIndex = 191
        Me.TXTJAMMASUK.Text = ""
        Me.TXTJAMMASUK.ValidatingType = GetType(Date)
        '
        'TXTSKS
        '
        Me.TXTSKS.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.TXTSKS.Border.Class = "TextBoxBorder"
        Me.TXTSKS.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXTSKS.DisabledBackColor = System.Drawing.Color.Black
        Me.TXTSKS.ForeColor = System.Drawing.Color.White
        Me.TXTSKS.Location = New System.Drawing.Point(263, 134)
        Me.TXTSKS.Name = "TXTSKS"
        Me.TXTSKS.PreventEnterBeep = True
        Me.TXTSKS.Size = New System.Drawing.Size(56, 20)
        Me.TXTSKS.TabIndex = 190
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(46, 131)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(42, 23)
        Me.LabelX7.TabIndex = 189
        Me.LabelX7.Text = "SKS"
        '
        'TXTMATAKULIAH
        '
        Me.TXTMATAKULIAH.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTMATAKULIAH.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.TXTMATAKULIAH.Border.Class = "TextBoxBorder"
        Me.TXTMATAKULIAH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXTMATAKULIAH.DisabledBackColor = System.Drawing.Color.Black
        Me.TXTMATAKULIAH.ForeColor = System.Drawing.Color.White
        Me.TXTMATAKULIAH.Location = New System.Drawing.Point(263, 105)
        Me.TXTMATAKULIAH.Name = "TXTMATAKULIAH"
        Me.TXTMATAKULIAH.PreventEnterBeep = True
        Me.TXTMATAKULIAH.Size = New System.Drawing.Size(503, 20)
        Me.TXTMATAKULIAH.TabIndex = 188
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(46, 102)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(98, 23)
        Me.LabelX4.TabIndex = 187
        Me.LabelX4.Text = "MATA KULIAH"
        '
        'TXTID
        '
        Me.TXTID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTID.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.TXTID.Border.Class = "TextBoxBorder"
        Me.TXTID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXTID.DisabledBackColor = System.Drawing.Color.Black
        Me.TXTID.ForeColor = System.Drawing.Color.White
        Me.TXTID.Location = New System.Drawing.Point(263, 76)
        Me.TXTID.Name = "TXTID"
        Me.TXTID.PreventEnterBeep = True
        Me.TXTID.Size = New System.Drawing.Size(276, 20)
        Me.TXTID.TabIndex = 186
        '
        'TXTJURUSAN
        '
        Me.TXTJURUSAN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTJURUSAN.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.TXTJURUSAN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTJURUSAN.ColumnNum = 2
        Me.TXTJURUSAN.ColumnWidth = "120; 120"
        Me.TXTJURUSAN.DisplayMember = "Text"
        Me.TXTJURUSAN.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.TXTJURUSAN.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TXTJURUSAN.DropDownForeColor = System.Drawing.Color.Black
        Me.TXTJURUSAN.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.TXTJURUSAN.DropDownWidth = 400
        Me.TXTJURUSAN.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTJURUSAN.GridLineColor = System.Drawing.Color.LightGray
        Me.TXTJURUSAN.GridLineHorizontal = False
        Me.TXTJURUSAN.GridLineVertical = True
        Me.TXTJURUSAN.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.TXTJURUSAN.Location = New System.Drawing.Point(263, 190)
        Me.TXTJURUSAN.ManagingFastMouseMoving = True
        Me.TXTJURUSAN.ManagingFastMouseMovingInterval = 30
        Me.TXTJURUSAN.MaxDropDownItems = 10
        Me.TXTJURUSAN.Name = "TXTJURUSAN"
        Me.TXTJURUSAN.Size = New System.Drawing.Size(503, 23)
        Me.TXTJURUSAN.TabIndex = 185
        Me.TXTJURUSAN.Text = "-- PILIH --"
        '
        'TXTDOSEN
        '
        Me.TXTDOSEN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTDOSEN.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.TXTDOSEN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTDOSEN.ColumnNum = 2
        Me.TXTDOSEN.ColumnWidth = "120; 120"
        Me.TXTDOSEN.DisplayMember = "Text"
        Me.TXTDOSEN.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.TXTDOSEN.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TXTDOSEN.DropDownForeColor = System.Drawing.Color.Black
        Me.TXTDOSEN.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.TXTDOSEN.DropDownWidth = 400
        Me.TXTDOSEN.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDOSEN.GridLineColor = System.Drawing.Color.LightGray
        Me.TXTDOSEN.GridLineHorizontal = False
        Me.TXTDOSEN.GridLineVertical = True
        Me.TXTDOSEN.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.TXTDOSEN.Location = New System.Drawing.Point(263, 277)
        Me.TXTDOSEN.ManagingFastMouseMoving = True
        Me.TXTDOSEN.ManagingFastMouseMovingInterval = 30
        Me.TXTDOSEN.MaxDropDownItems = 10
        Me.TXTDOSEN.Name = "TXTDOSEN"
        Me.TXTDOSEN.Size = New System.Drawing.Size(503, 23)
        Me.TXTDOSEN.TabIndex = 184
        Me.TXTDOSEN.Text = "-- PILIH --"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(46, 277)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(113, 23)
        Me.LabelX5.TabIndex = 183
        Me.LabelX5.Text = "DOSEN PENGAJAR"
        '
        'TXTFAKULTAS
        '
        Me.TXTFAKULTAS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTFAKULTAS.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.TXTFAKULTAS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTFAKULTAS.ColumnNum = 2
        Me.TXTFAKULTAS.ColumnWidth = "120; 120"
        Me.TXTFAKULTAS.DisplayMember = "Text"
        Me.TXTFAKULTAS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.TXTFAKULTAS.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TXTFAKULTAS.DropDownForeColor = System.Drawing.Color.Black
        Me.TXTFAKULTAS.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.TXTFAKULTAS.DropDownWidth = 400
        Me.TXTFAKULTAS.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTFAKULTAS.GridLineColor = System.Drawing.Color.LightGray
        Me.TXTFAKULTAS.GridLineHorizontal = False
        Me.TXTFAKULTAS.GridLineVertical = True
        Me.TXTFAKULTAS.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.TXTFAKULTAS.Location = New System.Drawing.Point(263, 219)
        Me.TXTFAKULTAS.ManagingFastMouseMoving = True
        Me.TXTFAKULTAS.ManagingFastMouseMovingInterval = 30
        Me.TXTFAKULTAS.MaxDropDownItems = 10
        Me.TXTFAKULTAS.Name = "TXTFAKULTAS"
        Me.TXTFAKULTAS.Size = New System.Drawing.Size(503, 23)
        Me.TXTFAKULTAS.TabIndex = 182
        Me.TXTFAKULTAS.Text = "-- PILIH --"
        '
        'LabelX10
        '
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX10.Location = New System.Drawing.Point(46, 73)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(113, 23)
        Me.LabelX10.TabIndex = 79
        Me.LabelX10.Text = "KODE M. KULIAH"
        '
        'LBERROR
        '
        Me.LBERROR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LBERROR.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LBERROR.Location = New System.Drawing.Point(46, 415)
        Me.LBERROR.Name = "LBERROR"
        Me.LBERROR.Size = New System.Drawing.Size(650, 23)
        Me.LBERROR.TabIndex = 78
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(46, 370)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 77
        Me.PictureBox1.TabStop = False
        '
        'BTSIMPAN
        '
        Me.BTSIMPAN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTSIMPAN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTSIMPAN.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.BTSIMPAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTSIMPAN.Location = New System.Drawing.Point(46, 322)
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
        Me.LabelX6.Location = New System.Drawing.Point(15, 20)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(299, 23)
        Me.LabelX6.Symbol = ""
        Me.LabelX6.TabIndex = 70
        Me.LabelX6.Text = "  MASTER DATA MATA KULIAH"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(46, 219)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(98, 23)
        Me.LabelX3.TabIndex = 63
        Me.LabelX3.Text = "FAKULTAS"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(46, 190)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(137, 23)
        Me.LabelX2.TabIndex = 62
        Me.LabelX2.Text = "MATA KULIAH JURUSAN"
        '
        'TXTTANGGAL
        '
        Me.TXTTANGGAL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.TXTTANGGAL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXTTANGGAL.Location = New System.Drawing.Point(616, 20)
        Me.TXTTANGGAL.Name = "TXTTANGGAL"
        Me.TXTTANGGAL.Size = New System.Drawing.Size(208, 23)
        Me.TXTTANGGAL.TabIndex = 76
        Me.TXTTANGGAL.Text = "TANGGAL"
        Me.TXTTANGGAL.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'BackgroundWorker
        '
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
        '
        'BackgroundWorkerSearch
        '
        '
        'CTRL_Mata_Kuliah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelEx1)
        Me.Name = "CTRL_Mata_Kuliah"
        Me.Size = New System.Drawing.Size(847, 487)
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TXTSEARCH As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BTBATAL As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents BTKELUAR As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTTAMBAH As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BTUBAH As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BTHAPUS As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents HAPUS As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
    Public WithEvents TXTJURUSAN As MTGCComboBox
    Public WithEvents TXTDOSEN As MTGCComboBox
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Public WithEvents TXTFAKULTAS As MTGCComboBox
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBERROR As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BTSIMPAN As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TXTTANGGAL As DevComponents.DotNetBar.LabelX
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents BackgroundWorkerSearch As System.ComponentModel.BackgroundWorker
    Friend WithEvents TXTSKS As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TXTMATAKULIAH As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TXTID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TXTJAMKELUAR As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TXTJAMMASUK As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents TXTSEMESTER As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TXTTAHUNSAMPAI As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents TXTTAHUNMULAI As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TXTJUMLAHPERTEMUAN As DevComponents.DotNetBar.Controls.TextBoxX

End Class
