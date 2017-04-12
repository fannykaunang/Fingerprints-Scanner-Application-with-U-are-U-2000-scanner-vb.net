<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataDosen
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
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
        Dim StatusLabel As System.Windows.Forms.Label
        Dim PromptLabel As System.Windows.Forms.Label
        Me.BackgroundWorkerSearch = New System.ComponentModel.BackgroundWorker()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.LBNOMOROTO = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.txtKodeMatKul = New System.Windows.Forms.Label()
        Me.txtMataKuliah = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbMataKuliah = New MTGCComboBox()
        Me.LBALAMATDOSEN = New DevComponents.DotNetBar.LabelX()
        Me.LBNAMADOSEN = New DevComponents.DotNetBar.LabelX()
        Me.LBNIP = New DevComponents.DotNetBar.LabelX()
        Me.LBPATHDOSEN = New System.Windows.Forms.Label()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LBPath = New System.Windows.Forms.Label()
        Me.StatusLine = New System.Windows.Forms.Label()
        Me.StatusText = New System.Windows.Forms.TextBox()
        Me.Prompt = New System.Windows.Forms.TextBox()
        Me.TXTCount = New System.Windows.Forms.Label()
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.TXTID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.LBERROR = New DevComponents.DotNetBar.LabelX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTSIMPAN = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.TXTALAMAT = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TXTNAMADOSEN = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.TXTTANGGAL = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.BTKELUAR = New DevComponents.DotNetBar.ButtonX()
        Me.BTBATAL = New DevComponents.DotNetBar.ButtonX()
        StatusLabel = New System.Windows.Forms.Label()
        PromptLabel = New System.Windows.Forms.Label()
        Me.PanelEx2.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.ForeColor = System.Drawing.Color.White
        StatusLabel.Location = New System.Drawing.Point(147, 98)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(42, 13)
        StatusLabel.TabIndex = 203
        StatusLabel.Text = "Status:"
        '
        'PromptLabel
        '
        PromptLabel.AutoSize = True
        PromptLabel.ForeColor = System.Drawing.Color.White
        PromptLabel.Location = New System.Drawing.Point(147, 50)
        PromptLabel.Name = "PromptLabel"
        PromptLabel.Size = New System.Drawing.Size(47, 13)
        PromptLabel.TabIndex = 201
        PromptLabel.Text = "Prompt:"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
        '
        'PanelEx2
        '
        Me.PanelEx2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.PanelEx2.Controls.Add(Me.LBNOMOROTO)
        Me.PanelEx2.Controls.Add(Me.PanelEx3)
        Me.PanelEx2.Controls.Add(Me.LBPath)
        Me.PanelEx2.Controls.Add(Me.StatusLine)
        Me.PanelEx2.Controls.Add(Me.StatusText)
        Me.PanelEx2.Controls.Add(StatusLabel)
        Me.PanelEx2.Controls.Add(Me.Prompt)
        Me.PanelEx2.Controls.Add(PromptLabel)
        Me.PanelEx2.Controls.Add(Me.TXTCount)
        Me.PanelEx2.Controls.Add(Me.Picture)
        Me.PanelEx2.Controls.Add(Me.TXTID)
        Me.PanelEx2.Controls.Add(Me.LabelX10)
        Me.PanelEx2.Controls.Add(Me.LBERROR)
        Me.PanelEx2.Controls.Add(Me.PictureBox1)
        Me.PanelEx2.Controls.Add(Me.BTSIMPAN)
        Me.PanelEx2.Controls.Add(Me.LabelX6)
        Me.PanelEx2.Controls.Add(Me.TXTALAMAT)
        Me.PanelEx2.Controls.Add(Me.TXTNAMADOSEN)
        Me.PanelEx2.Controls.Add(Me.LabelX5)
        Me.PanelEx2.Controls.Add(Me.LabelX2)
        Me.PanelEx2.Controls.Add(Me.TXTTANGGAL)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Location = New System.Drawing.Point(2, 43)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(670, 459)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.Color = System.Drawing.Color.Silver
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 0
        '
        'LBNOMOROTO
        '
        '
        '
        '
        Me.LBNOMOROTO.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LBNOMOROTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBNOMOROTO.ForeColor = System.Drawing.Color.White
        Me.LBNOMOROTO.Location = New System.Drawing.Point(257, 22)
        Me.LBNOMOROTO.Name = "LBNOMOROTO"
        Me.LBNOMOROTO.Size = New System.Drawing.Size(234, 23)
        Me.LBNOMOROTO.TabIndex = 210
        Me.LBNOMOROTO.Text = "NOMOR"
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.PanelEx3.Controls.Add(Me.txtKodeMatKul)
        Me.PanelEx3.Controls.Add(Me.txtMataKuliah)
        Me.PanelEx3.Controls.Add(Me.Label12)
        Me.PanelEx3.Controls.Add(Me.cbMataKuliah)
        Me.PanelEx3.Controls.Add(Me.LBALAMATDOSEN)
        Me.PanelEx3.Controls.Add(Me.LBNAMADOSEN)
        Me.PanelEx3.Controls.Add(Me.LBNIP)
        Me.PanelEx3.Controls.Add(Me.LBPATHDOSEN)
        Me.PanelEx3.Controls.Add(Me.LabelX3)
        Me.PanelEx3.Controls.Add(Me.LabelX4)
        Me.PanelEx3.Controls.Add(Me.LabelX7)
        Me.PanelEx3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx3.Location = New System.Drawing.Point(46, 221)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(607, 161)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 208
        '
        'txtKodeMatKul
        '
        Me.txtKodeMatKul.AutoSize = True
        Me.txtKodeMatKul.ForeColor = System.Drawing.Color.White
        Me.txtKodeMatKul.Location = New System.Drawing.Point(153, 119)
        Me.txtKodeMatKul.Name = "txtKodeMatKul"
        Me.txtKodeMatKul.Size = New System.Drawing.Size(97, 13)
        Me.txtKodeMatKul.TabIndex = 215
        Me.txtKodeMatKul.Text = "Kode Mata Kuliah"
        '
        'txtMataKuliah
        '
        Me.txtMataKuliah.AutoSize = True
        Me.txtMataKuliah.ForeColor = System.Drawing.Color.White
        Me.txtMataKuliah.Location = New System.Drawing.Point(262, 119)
        Me.txtMataKuliah.Name = "txtMataKuliah"
        Me.txtMataKuliah.Size = New System.Drawing.Size(68, 13)
        Me.txtMataKuliah.TabIndex = 214
        Me.txtMataKuliah.Text = "Mata Kuliah"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(8, 92)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 213
        Me.Label12.Text = "MATA  KULIAH"
        '
        'cbMataKuliah
        '
        Me.cbMataKuliah.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.cbMataKuliah.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.cbMataKuliah.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbMataKuliah.ColumnNum = 2
        Me.cbMataKuliah.ColumnWidth = "120; 120"
        Me.cbMataKuliah.DisplayMember = "Text"
        Me.cbMataKuliah.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbMataKuliah.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cbMataKuliah.DropDownForeColor = System.Drawing.Color.Black
        Me.cbMataKuliah.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cbMataKuliah.DropDownWidth = 400
        Me.cbMataKuliah.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMataKuliah.ForeColor = System.Drawing.Color.White
        Me.cbMataKuliah.GridLineColor = System.Drawing.Color.LightGray
        Me.cbMataKuliah.GridLineHorizontal = False
        Me.cbMataKuliah.GridLineVertical = True
        Me.cbMataKuliah.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cbMataKuliah.Location = New System.Drawing.Point(156, 84)
        Me.cbMataKuliah.ManagingFastMouseMoving = True
        Me.cbMataKuliah.ManagingFastMouseMovingInterval = 30
        Me.cbMataKuliah.MaxDropDownItems = 10
        Me.cbMataKuliah.Name = "cbMataKuliah"
        Me.cbMataKuliah.Size = New System.Drawing.Size(444, 23)
        Me.cbMataKuliah.TabIndex = 212
        Me.cbMataKuliah.Text = "-- PILIH --"
        '
        'LBALAMATDOSEN
        '
        '
        '
        '
        Me.LBALAMATDOSEN.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LBALAMATDOSEN.ForeColor = System.Drawing.Color.White
        Me.LBALAMATDOSEN.Location = New System.Drawing.Point(156, 54)
        Me.LBALAMATDOSEN.Name = "LBALAMATDOSEN"
        Me.LBALAMATDOSEN.Size = New System.Drawing.Size(64, 23)
        Me.LBALAMATDOSEN.TabIndex = 211
        Me.LBALAMATDOSEN.Text = "ALAMAT"
        '
        'LBNAMADOSEN
        '
        '
        '
        '
        Me.LBNAMADOSEN.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LBNAMADOSEN.ForeColor = System.Drawing.Color.White
        Me.LBNAMADOSEN.Location = New System.Drawing.Point(156, 29)
        Me.LBNAMADOSEN.Name = "LBNAMADOSEN"
        Me.LBNAMADOSEN.Size = New System.Drawing.Size(75, 23)
        Me.LBNAMADOSEN.TabIndex = 210
        Me.LBNAMADOSEN.Text = "NAMA DOSEN"
        '
        'LBNIP
        '
        '
        '
        '
        Me.LBNIP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LBNIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBNIP.ForeColor = System.Drawing.Color.White
        Me.LBNIP.Location = New System.Drawing.Point(156, 3)
        Me.LBNIP.Name = "LBNIP"
        Me.LBNIP.Size = New System.Drawing.Size(87, 23)
        Me.LBNIP.TabIndex = 209
        Me.LBNIP.Text = "NIP/NIDN"
        '
        'LBPATHDOSEN
        '
        Me.LBPATHDOSEN.AutoSize = True
        Me.LBPATHDOSEN.ForeColor = System.Drawing.Color.White
        Me.LBPATHDOSEN.Location = New System.Drawing.Point(12, 146)
        Me.LBPATHDOSEN.Name = "LBPATHDOSEN"
        Me.LBPATHDOSEN.Size = New System.Drawing.Size(197, 13)
        Me.LBPATHDOSEN.TabIndex = 208
        Me.LBPATHDOSEN.Text = "Initial Directory to save template file :"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.White
        Me.LabelX3.Location = New System.Drawing.Point(11, 3)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(87, 23)
        Me.LabelX3.TabIndex = 82
        Me.LabelX3.Text = "NIP/NIDN"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.White
        Me.LabelX4.Location = New System.Drawing.Point(11, 55)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(64, 23)
        Me.LabelX4.TabIndex = 81
        Me.LabelX4.Text = "ALAMAT"
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.ForeColor = System.Drawing.Color.White
        Me.LabelX7.Location = New System.Drawing.Point(11, 29)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(75, 23)
        Me.LabelX7.TabIndex = 80
        Me.LabelX7.Text = "NAMA DOSEN"
        '
        'LBPath
        '
        Me.LBPath.AutoSize = True
        Me.LBPath.ForeColor = System.Drawing.Color.White
        Me.LBPath.Location = New System.Drawing.Point(147, 357)
        Me.LBPath.Name = "LBPath"
        Me.LBPath.Size = New System.Drawing.Size(197, 13)
        Me.LBPath.TabIndex = 207
        Me.LBPath.Text = "Initial Directory to save template file :"
        '
        'StatusLine
        '
        Me.StatusLine.AutoSize = True
        Me.StatusLine.ForeColor = System.Drawing.Color.White
        Me.StatusLine.Location = New System.Drawing.Point(43, 191)
        Me.StatusLine.Name = "StatusLine"
        Me.StatusLine.Size = New System.Drawing.Size(67, 13)
        Me.StatusLine.TabIndex = 205
        Me.StatusLine.Text = "[Status line]"
        '
        'StatusText
        '
        Me.StatusText.BackColor = System.Drawing.Color.Black
        Me.StatusText.ForeColor = System.Drawing.Color.White
        Me.StatusText.Location = New System.Drawing.Point(150, 114)
        Me.StatusText.Multiline = True
        Me.StatusText.Name = "StatusText"
        Me.StatusText.ReadOnly = True
        Me.StatusText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.StatusText.Size = New System.Drawing.Size(503, 65)
        Me.StatusText.TabIndex = 204
        Me.StatusText.Text = "Silahkan masukkan Input Data terlebih dahulu."
        '
        'Prompt
        '
        Me.Prompt.BackColor = System.Drawing.Color.Black
        Me.Prompt.ForeColor = System.Drawing.Color.White
        Me.Prompt.Location = New System.Drawing.Point(150, 66)
        Me.Prompt.Name = "Prompt"
        Me.Prompt.ReadOnly = True
        Me.Prompt.Size = New System.Drawing.Size(503, 22)
        Me.Prompt.TabIndex = 202
        Me.Prompt.Text = "Fingerprint reader is not ready for scan your finger."
        '
        'TXTCount
        '
        Me.TXTCount.AutoSize = True
        Me.TXTCount.ForeColor = System.Drawing.Color.White
        Me.TXTCount.Location = New System.Drawing.Point(485, 191)
        Me.TXTCount.Name = "TXTCount"
        Me.TXTCount.Size = New System.Drawing.Size(31, 13)
        Me.TXTCount.TabIndex = 206
        Me.TXTCount.Text = "NPM"
        '
        'Picture
        '
        Me.Picture.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picture.ForeColor = System.Drawing.Color.White
        Me.Picture.Location = New System.Drawing.Point(46, 54)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(98, 125)
        Me.Picture.TabIndex = 81
        Me.Picture.TabStop = False
        '
        'TXTID
        '
        Me.TXTID.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.TXTID.Border.Class = "TextBoxBorder"
        Me.TXTID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXTID.DisabledBackColor = System.Drawing.Color.Black
        Me.TXTID.ForeColor = System.Drawing.Color.White
        Me.TXTID.Location = New System.Drawing.Point(150, 231)
        Me.TXTID.Name = "TXTID"
        Me.TXTID.PreventEnterBeep = True
        Me.TXTID.Size = New System.Drawing.Size(503, 22)
        Me.TXTID.TabIndex = 1
        Me.TXTID.WatermarkColor = System.Drawing.SystemColors.ControlDark
        Me.TXTID.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTID.WatermarkText = "NIP / NIDN"
        '
        'LabelX10
        '
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX10.ForeColor = System.Drawing.Color.White
        Me.LabelX10.Location = New System.Drawing.Point(46, 231)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(87, 23)
        Me.LabelX10.TabIndex = 79
        Me.LabelX10.Text = "NIP/NIDN"
        '
        'LBERROR
        '
        Me.LBERROR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LBERROR.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LBERROR.ForeColor = System.Drawing.Color.White
        Me.LBERROR.Location = New System.Drawing.Point(46, 433)
        Me.LBERROR.Name = "LBERROR"
        Me.LBERROR.Size = New System.Drawing.Size(650, 23)
        Me.LBERROR.TabIndex = 78
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.ForeColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(46, 388)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 77
        Me.PictureBox1.TabStop = False
        '
        'BTSIMPAN
        '
        Me.BTSIMPAN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTSIMPAN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTSIMPAN.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.BTSIMPAN.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTSIMPAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTSIMPAN.Location = New System.Drawing.Point(488, 388)
        Me.BTSIMPAN.Name = "BTSIMPAN"
        Me.BTSIMPAN.Size = New System.Drawing.Size(117, 42)
        Me.BTSIMPAN.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.BTSIMPAN.TabIndex = 73
        Me.BTSIMPAN.Text = "OK"
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
        Me.LabelX6.Size = New System.Drawing.Size(226, 23)
        Me.LabelX6.Symbol = ""
        Me.LabelX6.TabIndex = 70
        Me.LabelX6.Text = "  MASTER DATA DOSEN"
        '
        'TXTALAMAT
        '
        Me.TXTALAMAT.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.TXTALAMAT.Border.Class = "TextBoxBorder"
        Me.TXTALAMAT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXTALAMAT.DisabledBackColor = System.Drawing.Color.Black
        Me.TXTALAMAT.ForeColor = System.Drawing.Color.White
        Me.TXTALAMAT.Location = New System.Drawing.Point(150, 288)
        Me.TXTALAMAT.Multiline = True
        Me.TXTALAMAT.Name = "TXTALAMAT"
        Me.TXTALAMAT.PreventEnterBeep = True
        Me.TXTALAMAT.Size = New System.Drawing.Size(503, 66)
        Me.TXTALAMAT.TabIndex = 69
        Me.TXTALAMAT.WatermarkColor = System.Drawing.SystemColors.ControlDark
        Me.TXTALAMAT.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTALAMAT.WatermarkText = "ALAMAT"
        '
        'TXTNAMADOSEN
        '
        Me.TXTNAMADOSEN.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.TXTNAMADOSEN.Border.Class = "TextBoxBorder"
        Me.TXTNAMADOSEN.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXTNAMADOSEN.DisabledBackColor = System.Drawing.Color.Black
        Me.TXTNAMADOSEN.ForeColor = System.Drawing.Color.White
        Me.TXTNAMADOSEN.Location = New System.Drawing.Point(150, 260)
        Me.TXTNAMADOSEN.Name = "TXTNAMADOSEN"
        Me.TXTNAMADOSEN.PreventEnterBeep = True
        Me.TXTNAMADOSEN.Size = New System.Drawing.Size(503, 22)
        Me.TXTNAMADOSEN.TabIndex = 66
        Me.TXTNAMADOSEN.WatermarkColor = System.Drawing.SystemColors.ControlDark
        Me.TXTNAMADOSEN.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNAMADOSEN.WatermarkText = "NAMA DOSEN"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.ForeColor = System.Drawing.Color.White
        Me.LabelX5.Location = New System.Drawing.Point(46, 285)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(64, 23)
        Me.LabelX5.TabIndex = 65
        Me.LabelX5.Text = "ALAMAT"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.White
        Me.LabelX2.Location = New System.Drawing.Point(46, 257)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 62
        Me.LabelX2.Text = "NAMA DOSEN"
        '
        'TXTTANGGAL
        '
        Me.TXTTANGGAL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.TXTTANGGAL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXTTANGGAL.ForeColor = System.Drawing.Color.White
        Me.TXTTANGGAL.Location = New System.Drawing.Point(445, 20)
        Me.TXTTANGGAL.Name = "TXTTANGGAL"
        Me.TXTTANGGAL.Size = New System.Drawing.Size(208, 23)
        Me.TXTTANGGAL.TabIndex = 76
        Me.TXTTANGGAL.Text = "TANGGAL"
        Me.TXTTANGGAL.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.PanelEx1.Controls.Add(Me.BTKELUAR)
        Me.PanelEx1.Controls.Add(Me.BTBATAL)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(676, 505)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.Color = System.Drawing.Color.Silver
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 1
        '
        'BTKELUAR
        '
        Me.BTKELUAR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTKELUAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTKELUAR.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTKELUAR.Location = New System.Drawing.Point(584, 8)
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
        Me.BTBATAL.Location = New System.Drawing.Point(490, 8)
        Me.BTBATAL.Name = "BTBATAL"
        Me.BTBATAL.Size = New System.Drawing.Size(88, 29)
        Me.BTBATAL.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.BTBATAL.TabIndex = 59
        Me.BTBATAL.Text = "BATAL"
        '
        'FormDataDosen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 505)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormDataDosen"
        Me.Text = "MASTER DATA DOSEN"
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx3.PerformLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackgroundWorkerSearch As System.ComponentModel.BackgroundWorker
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBERROR As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BTSIMPAN As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TXTALAMAT As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TXTNAMADOSEN As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TXTTANGGAL As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents BTKELUAR As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTBATAL As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TXTID As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents Picture As System.Windows.Forms.PictureBox
    Private WithEvents StatusLine As System.Windows.Forms.Label
    Private WithEvents StatusText As System.Windows.Forms.TextBox
    Private WithEvents Prompt As System.Windows.Forms.TextBox
    Friend WithEvents TXTCount As System.Windows.Forms.Label
    Friend WithEvents LBPath As System.Windows.Forms.Label
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LBALAMATDOSEN As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBNAMADOSEN As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBNIP As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBPATHDOSEN As System.Windows.Forms.Label
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtMataKuliah As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents cbMataKuliah As MTGCComboBox
    Friend WithEvents txtKodeMatKul As System.Windows.Forms.Label
    Friend WithEvents LBNOMOROTO As DevComponents.DotNetBar.LabelX
End Class
