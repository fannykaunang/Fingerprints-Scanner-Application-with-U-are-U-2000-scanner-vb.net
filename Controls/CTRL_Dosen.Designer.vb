<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTRL_Dosen
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
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.HAPUS = New DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.TXTTEMPATLAHIR = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.TXTNAMADOSEN = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.TXTID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.LBERROR = New DevComponents.DotNetBar.LabelX()
        Me.BTSIMPAN = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.TXTTANGGAL = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.CBPENDIDIKAN = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.ComboItem9 = New DevComponents.Editors.ComboItem()
        Me.ComboItem10 = New DevComponents.Editors.ComboItem()
        Me.ComboItem12 = New DevComponents.Editors.ComboItem()
        Me.ComboItem11 = New DevComponents.Editors.ComboItem()
        Me.ComboItem13 = New DevComponents.Editors.ComboItem()
        Me.ComboItem14 = New DevComponents.Editors.ComboItem()
        Me.CBSTATUS = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.CBJK = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.DTLAHIR = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTHAPUS = New DevComponents.DotNetBar.ButtonItem()
        Me.BTUBAH = New DevComponents.DotNetBar.ButtonItem()
        Me.BTTAMBAH = New DevComponents.DotNetBar.ButtonItem()
        Me.TXTSEARCH = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.BTKELUAR = New DevComponents.DotNetBar.ButtonX()
        Me.BTBATAL = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.BackgroundWorkerSearch = New System.ComponentModel.BackgroundWorker()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        CType(Me.DTLAHIR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
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
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewX1.EnableHeadersVisualStyles = False
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(1, 3)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewX1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewX1.Size = New System.Drawing.Size(841, 435)
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
        'LabelX12
        '
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Location = New System.Drawing.Point(46, 248)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(137, 23)
        Me.LabelX12.TabIndex = 196
        Me.LabelX12.Text = "PENDIDIKAN TERAKHIR"
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(46, 160)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(113, 23)
        Me.LabelX8.TabIndex = 192
        Me.LabelX8.Text = "TANGGAL LAHIR"
        '
        'TXTTEMPATLAHIR
        '
        Me.TXTTEMPATLAHIR.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTTEMPATLAHIR.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.TXTTEMPATLAHIR.Border.Class = "TextBoxBorder"
        Me.TXTTEMPATLAHIR.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXTTEMPATLAHIR.DisabledBackColor = System.Drawing.Color.Black
        Me.TXTTEMPATLAHIR.ForeColor = System.Drawing.Color.White
        Me.TXTTEMPATLAHIR.Location = New System.Drawing.Point(263, 134)
        Me.TXTTEMPATLAHIR.Name = "TXTTEMPATLAHIR"
        Me.TXTTEMPATLAHIR.PreventEnterBeep = True
        Me.TXTTEMPATLAHIR.Size = New System.Drawing.Size(503, 20)
        Me.TXTTEMPATLAHIR.TabIndex = 190
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(46, 131)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(98, 23)
        Me.LabelX7.TabIndex = 189
        Me.LabelX7.Text = "TEMPAT LAHIR"
        '
        'TXTNAMADOSEN
        '
        Me.TXTNAMADOSEN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTNAMADOSEN.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.TXTNAMADOSEN.Border.Class = "TextBoxBorder"
        Me.TXTNAMADOSEN.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXTNAMADOSEN.DisabledBackColor = System.Drawing.Color.Black
        Me.TXTNAMADOSEN.ForeColor = System.Drawing.Color.White
        Me.TXTNAMADOSEN.Location = New System.Drawing.Point(263, 105)
        Me.TXTNAMADOSEN.Name = "TXTNAMADOSEN"
        Me.TXTNAMADOSEN.PreventEnterBeep = True
        Me.TXTNAMADOSEN.Size = New System.Drawing.Size(503, 20)
        Me.TXTNAMADOSEN.TabIndex = 188
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
        Me.LabelX4.Text = "NAMA DOSEN"
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
        Me.TXTID.Size = New System.Drawing.Size(503, 20)
        Me.TXTID.TabIndex = 186
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
        Me.LabelX10.Text = "NIP / NIDN"
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
        Me.LabelX6.Symbol = ""
        Me.LabelX6.TabIndex = 70
        Me.LabelX6.Text = "  MASTER DATA DOSEN"
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
        Me.LabelX3.Text = "STATUS"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
        '
        'BackgroundWorker
        '
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
        Me.LabelX2.Text = "JENIS KELAMIN"
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
        'PanelEx2
        '
        Me.PanelEx2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.PanelEx2.Controls.Add(Me.DataGridViewX1)
        Me.PanelEx2.Controls.Add(Me.CBPENDIDIKAN)
        Me.PanelEx2.Controls.Add(Me.CBSTATUS)
        Me.PanelEx2.Controls.Add(Me.CBJK)
        Me.PanelEx2.Controls.Add(Me.DTLAHIR)
        Me.PanelEx2.Controls.Add(Me.LabelX12)
        Me.PanelEx2.Controls.Add(Me.LabelX8)
        Me.PanelEx2.Controls.Add(Me.TXTTEMPATLAHIR)
        Me.PanelEx2.Controls.Add(Me.LabelX7)
        Me.PanelEx2.Controls.Add(Me.TXTNAMADOSEN)
        Me.PanelEx2.Controls.Add(Me.LabelX4)
        Me.PanelEx2.Controls.Add(Me.TXTID)
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
        'CBPENDIDIKAN
        '
        Me.CBPENDIDIKAN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBPENDIDIKAN.DisplayMember = "Text"
        Me.CBPENDIDIKAN.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBPENDIDIKAN.FormattingEnabled = True
        Me.CBPENDIDIKAN.ItemHeight = 14
        Me.CBPENDIDIKAN.Items.AddRange(New Object() {Me.ComboItem7, Me.ComboItem8, Me.ComboItem9, Me.ComboItem10, Me.ComboItem12, Me.ComboItem11, Me.ComboItem13, Me.ComboItem14})
        Me.CBPENDIDIKAN.Location = New System.Drawing.Point(263, 251)
        Me.CBPENDIDIKAN.Name = "CBPENDIDIKAN"
        Me.CBPENDIDIKAN.Size = New System.Drawing.Size(503, 20)
        Me.CBPENDIDIKAN.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.CBPENDIDIKAN.TabIndex = 208
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "-- PILIH --"
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "SEKOLAH DASAR (SD)"
        '
        'ComboItem9
        '
        Me.ComboItem9.Text = "SEKOLAH MENENGAH PERTAMA (SMP)"
        '
        'ComboItem10
        '
        Me.ComboItem10.Text = "SEKOLAH MENENGAH ATAS (SMA)"
        '
        'ComboItem12
        '
        Me.ComboItem12.Text = "DIPLOMA III (D3)"
        '
        'ComboItem11
        '
        Me.ComboItem11.Text = "SARJANA (S1)"
        '
        'ComboItem13
        '
        Me.ComboItem13.Text = "MAGISTER (S2)"
        '
        'ComboItem14
        '
        Me.ComboItem14.Text = "DOKTORAL"
        '
        'CBSTATUS
        '
        Me.CBSTATUS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBSTATUS.DisplayMember = "Text"
        Me.CBSTATUS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBSTATUS.FormattingEnabled = True
        Me.CBSTATUS.ItemHeight = 14
        Me.CBSTATUS.Items.AddRange(New Object() {Me.ComboItem4, Me.ComboItem5, Me.ComboItem6})
        Me.CBSTATUS.Location = New System.Drawing.Point(263, 222)
        Me.CBSTATUS.Name = "CBSTATUS"
        Me.CBSTATUS.Size = New System.Drawing.Size(503, 20)
        Me.CBSTATUS.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.CBSTATUS.TabIndex = 207
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "-- PILIH --"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "DOSEN TETAP"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "DOSEN HONORER"
        '
        'CBJK
        '
        Me.CBJK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBJK.DisplayMember = "Text"
        Me.CBJK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBJK.FormattingEnabled = True
        Me.CBJK.ItemHeight = 14
        Me.CBJK.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3})
        Me.CBJK.Location = New System.Drawing.Point(263, 190)
        Me.CBJK.Name = "CBJK"
        Me.CBJK.Size = New System.Drawing.Size(503, 20)
        Me.CBJK.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.CBJK.TabIndex = 206
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "-- PILIH --"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "LAKI - LAKI"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "PEREMPUAN"
        '
        'DTLAHIR
        '
        Me.DTLAHIR.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.DTLAHIR.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DTLAHIR.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DTLAHIR.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DTLAHIR.ButtonDropDown.Visible = True
        Me.DTLAHIR.IsPopupCalendarOpen = False
        Me.DTLAHIR.Location = New System.Drawing.Point(263, 160)
        '
        '
        '
        Me.DTLAHIR.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DTLAHIR.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DTLAHIR.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DTLAHIR.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DTLAHIR.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DTLAHIR.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DTLAHIR.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DTLAHIR.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DTLAHIR.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DTLAHIR.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DTLAHIR.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DTLAHIR.MonthCalendar.DisplayMonth = New Date(2014, 7, 1, 0, 0, 0, 0)
        Me.DTLAHIR.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.DTLAHIR.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.DTLAHIR.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DTLAHIR.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DTLAHIR.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DTLAHIR.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DTLAHIR.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DTLAHIR.MonthCalendar.TodayButtonVisible = True
        Me.DTLAHIR.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.DTLAHIR.Name = "DTLAHIR"
        Me.DTLAHIR.Size = New System.Drawing.Size(503, 20)
        Me.DTLAHIR.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.DTLAHIR.TabIndex = 205
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
        'BTHAPUS
        '
        Me.BTHAPUS.Name = "BTHAPUS"
        Me.BTHAPUS.Symbol = ""
        Me.BTHAPUS.SymbolSize = 15.0!
        Me.BTHAPUS.Text = "HAPUS"
        '
        'BTUBAH
        '
        Me.BTUBAH.Name = "BTUBAH"
        Me.BTUBAH.Symbol = ""
        Me.BTUBAH.SymbolSize = 15.0!
        Me.BTUBAH.Text = "UBAH"
        '
        'BTTAMBAH
        '
        Me.BTTAMBAH.Name = "BTTAMBAH"
        Me.BTTAMBAH.Symbol = ""
        Me.BTTAMBAH.SymbolSize = 15.0!
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
        Me.TXTSEARCH.WatermarkText = "CARI DOSEN..."
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
        'BackgroundWorkerSearch
        '
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
        Me.PanelEx1.TabIndex = 5
        '
        'CTRL_Dosen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelEx1)
        Me.Name = "CTRL_Dosen"
        Me.Size = New System.Drawing.Size(847, 487)
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.DTLAHIR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents HAPUS As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TXTTEMPATLAHIR As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TXTNAMADOSEN As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TXTID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBERROR As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BTSIMPAN As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TXTTANGGAL As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents BTHAPUS As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BTUBAH As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BTTAMBAH As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents TXTSEARCH As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BTKELUAR As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTBATAL As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BackgroundWorkerSearch As System.ComponentModel.BackgroundWorker
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents DTLAHIR As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents CBPENDIDIKAN As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem10 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem12 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem11 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem13 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem14 As DevComponents.Editors.ComboItem
    Friend WithEvents CBSTATUS As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents CBJK As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem

End Class
