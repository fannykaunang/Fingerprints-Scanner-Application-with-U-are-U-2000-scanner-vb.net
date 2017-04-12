<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanRekapitulasiAbsensiDosen
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
        Me.CRV_Master = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.TXTJURUSAN = New MTGCComboBox()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.TXTMATAKULIAH = New MTGCComboBox()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx2.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CRV_Master
        '
        Me.CRV_Master.ActiveViewIndex = -1
        Me.CRV_Master.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV_Master.CachedPageNumberPerDoc = 10
        Me.CRV_Master.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV_Master.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV_Master.ForeColor = System.Drawing.Color.White
        Me.CRV_Master.Location = New System.Drawing.Point(0, 0)
        Me.CRV_Master.Name = "CRV_Master"
        Me.CRV_Master.SelectionFormula = ""
        Me.CRV_Master.Size = New System.Drawing.Size(854, 263)
        Me.CRV_Master.TabIndex = 5
        Me.CRV_Master.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CRV_Master.ViewTimeSelectionFormula = ""
        '
        'PanelEx2
        '
        Me.PanelEx2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.PanelEx2.Controls.Add(Me.ButtonX2)
        Me.PanelEx2.Controls.Add(Me.TXTMATAKULIAH)
        Me.PanelEx2.Controls.Add(Me.ButtonX1)
        Me.PanelEx2.Controls.Add(Me.LabelX1)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Location = New System.Drawing.Point(-6, 11)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(854, 53)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 31
        '
        'TXTJURUSAN
        '
        Me.TXTJURUSAN.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
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
        Me.TXTJURUSAN.ForeColor = System.Drawing.Color.White
        Me.TXTJURUSAN.GridLineColor = System.Drawing.Color.LightGray
        Me.TXTJURUSAN.GridLineHorizontal = False
        Me.TXTJURUSAN.GridLineVertical = True
        Me.TXTJURUSAN.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.TXTJURUSAN.Location = New System.Drawing.Point(202, 137)
        Me.TXTJURUSAN.ManagingFastMouseMoving = True
        Me.TXTJURUSAN.ManagingFastMouseMovingInterval = 30
        Me.TXTJURUSAN.MaxDropDownItems = 10
        Me.TXTJURUSAN.Name = "TXTJURUSAN"
        Me.TXTJURUSAN.Size = New System.Drawing.Size(503, 23)
        Me.TXTJURUSAN.TabIndex = 187
        Me.TXTJURUSAN.Text = "-- PILIH --"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.White
        Me.LabelX2.Location = New System.Drawing.Point(114, 137)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(82, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "JURUSAN"
        '
        'TXTMATAKULIAH
        '
        Me.TXTMATAKULIAH.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TXTMATAKULIAH.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.TXTMATAKULIAH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTMATAKULIAH.ColumnNum = 2
        Me.TXTMATAKULIAH.ColumnWidth = "120; 120"
        Me.TXTMATAKULIAH.DisplayMember = "Text"
        Me.TXTMATAKULIAH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.TXTMATAKULIAH.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TXTMATAKULIAH.DropDownForeColor = System.Drawing.Color.Black
        Me.TXTMATAKULIAH.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.TXTMATAKULIAH.DropDownWidth = 400
        Me.TXTMATAKULIAH.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMATAKULIAH.ForeColor = System.Drawing.Color.White
        Me.TXTMATAKULIAH.GridLineColor = System.Drawing.Color.LightGray
        Me.TXTMATAKULIAH.GridLineHorizontal = False
        Me.TXTMATAKULIAH.GridLineVertical = True
        Me.TXTMATAKULIAH.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.TXTMATAKULIAH.Location = New System.Drawing.Point(102, 3)
        Me.TXTMATAKULIAH.ManagingFastMouseMoving = True
        Me.TXTMATAKULIAH.ManagingFastMouseMovingInterval = 30
        Me.TXTMATAKULIAH.MaxDropDownItems = 10
        Me.TXTMATAKULIAH.Name = "TXTMATAKULIAH"
        Me.TXTMATAKULIAH.Size = New System.Drawing.Size(503, 23)
        Me.TXTMATAKULIAH.TabIndex = 186
        Me.TXTMATAKULIAH.Text = "-- PILIH --"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(611, 3)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(113, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX1.TabIndex = 2
        Me.ButtonX1.Text = "TAMPILKAN"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.White
        Me.LabelX1.Location = New System.Drawing.Point(14, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(82, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "DOSEN"
        '
        'PanelEx1
        '
        Me.PanelEx1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.PanelEx1.Controls.Add(Me.CRV_Master)
        Me.PanelEx1.Controls.Add(Me.TXTJURUSAN)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Location = New System.Drawing.Point(-6, 70)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(854, 263)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 30
        '
        'BackgroundWorker1
        '
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(730, 3)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(113, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX2.TabIndex = 187
        Me.ButtonX2.Text = "TAMPILKAN SEMUA"
        '
        'FormLaporanRekapitulasiAbsensiDosen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 345)
        Me.Controls.Add(Me.PanelEx2)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormLaporanRekapitulasiAbsensiDosen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LAPORAN REKAPITULASI ABSENSI DOSEN"
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRV_Master As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Public WithEvents TXTJURUSAN As MTGCComboBox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Public WithEvents TXTMATAKULIAH As MTGCComboBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
End Class
