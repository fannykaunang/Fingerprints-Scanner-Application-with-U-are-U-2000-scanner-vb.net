<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaptureForm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso components IsNot Nothing Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
        Dim StatusLabel As System.Windows.Forms.Label
        Dim PromptLabel As System.Windows.Forms.Label
        Dim label1 As System.Windows.Forms.Label
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.StatusLine = New System.Windows.Forms.Label()
        Me.StatusText = New System.Windows.Forms.TextBox()
        Me.Prompt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTNPM = New System.Windows.Forms.TextBox()
        Me.TXTNAMA = New System.Windows.Forms.TextBox()
        Me.CBJK = New System.Windows.Forms.ComboBox()
        Me.CBFAKULTAS = New MTGCComboBox()
        Me.CBJURUSAN = New MTGCComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CBSEMESTER = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTJK = New System.Windows.Forms.TextBox()
        Me.TXTFAKULTAS = New System.Windows.Forms.TextBox()
        Me.TXTJURUSAN = New System.Windows.Forms.TextBox()
        Me.TXTSEMESTER = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LBPath = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNamaMHS = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNPM2 = New System.Windows.Forms.Label()
        Me.txtMataKuliah = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbMataKuliah = New MTGCComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtKodeMatKul = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.Label()
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.TXTCount = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        PromptLabel = New System.Windows.Forms.Label()
        label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(106, 83)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 10
        StatusLabel.Text = "Status:"
        '
        'PromptLabel
        '
        PromptLabel.AutoSize = True
        PromptLabel.Location = New System.Drawing.Point(106, 35)
        PromptLabel.Name = "PromptLabel"
        PromptLabel.Size = New System.Drawing.Size(43, 13)
        PromptLabel.TabIndex = 8
        PromptLabel.Text = "Prompt:"
        '
        'label1
        '
        label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        label1.ForeColor = System.Drawing.Color.White
        label1.Location = New System.Drawing.Point(12, 187)
        label1.Name = "label1"
        label1.Size = New System.Drawing.Size(462, 4)
        label1.TabIndex = 14
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseButton.Location = New System.Drawing.Point(403, 415)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 13
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'StatusLine
        '
        Me.StatusLine.AutoSize = True
        Me.StatusLine.Location = New System.Drawing.Point(9, 169)
        Me.StatusLine.Name = "StatusLine"
        Me.StatusLine.Size = New System.Drawing.Size(62, 13)
        Me.StatusLine.TabIndex = 12
        Me.StatusLine.Text = "[Status line]"
        '
        'StatusText
        '
        Me.StatusText.BackColor = System.Drawing.SystemColors.Window
        Me.StatusText.Location = New System.Drawing.Point(109, 99)
        Me.StatusText.Multiline = True
        Me.StatusText.Name = "StatusText"
        Me.StatusText.ReadOnly = True
        Me.StatusText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.StatusText.Size = New System.Drawing.Size(365, 65)
        Me.StatusText.TabIndex = 11
        Me.StatusText.Text = "Silahkan masukkan Input Data terlebih dahulu."
        '
        'Prompt
        '
        Me.Prompt.Location = New System.Drawing.Point(109, 51)
        Me.Prompt.Name = "Prompt"
        Me.Prompt.ReadOnly = True
        Me.Prompt.Size = New System.Drawing.Size(365, 20)
        Me.Prompt.TabIndex = 9
        Me.Prompt.Text = "Fingerprint reader is not ready for scan your finger."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Finger Data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Input Data"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "NPM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Nama Mahasiswa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Jenis Kelamin"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Fakultas"
        '
        'TXTNPM
        '
        Me.TXTNPM.Location = New System.Drawing.Point(105, 42)
        Me.TXTNPM.Name = "TXTNPM"
        Me.TXTNPM.Size = New System.Drawing.Size(365, 20)
        Me.TXTNPM.TabIndex = 21
        '
        'TXTNAMA
        '
        Me.TXTNAMA.Location = New System.Drawing.Point(105, 67)
        Me.TXTNAMA.Name = "TXTNAMA"
        Me.TXTNAMA.Size = New System.Drawing.Size(365, 20)
        Me.TXTNAMA.TabIndex = 22
        '
        'CBJK
        '
        Me.CBJK.Items.AddRange(New Object() {"-- PILIH --", "LAKI LAKI", "PEREMPUAN"})
        Me.CBJK.Location = New System.Drawing.Point(105, 93)
        Me.CBJK.Name = "CBJK"
        Me.CBJK.Size = New System.Drawing.Size(365, 21)
        Me.CBJK.TabIndex = 23
        Me.CBJK.Text = "-- PILIH --"
        '
        'CBFAKULTAS
        '
        Me.CBFAKULTAS.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.CBFAKULTAS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CBFAKULTAS.ColumnNum = 2
        Me.CBFAKULTAS.ColumnWidth = "120; 120"
        Me.CBFAKULTAS.DisplayMember = "Text"
        Me.CBFAKULTAS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBFAKULTAS.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.CBFAKULTAS.DropDownForeColor = System.Drawing.Color.Black
        Me.CBFAKULTAS.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.CBFAKULTAS.DropDownWidth = 400
        Me.CBFAKULTAS.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBFAKULTAS.GridLineColor = System.Drawing.Color.LightGray
        Me.CBFAKULTAS.GridLineHorizontal = False
        Me.CBFAKULTAS.GridLineVertical = True
        Me.CBFAKULTAS.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.CBFAKULTAS.Location = New System.Drawing.Point(105, 120)
        Me.CBFAKULTAS.ManagingFastMouseMoving = True
        Me.CBFAKULTAS.ManagingFastMouseMovingInterval = 30
        Me.CBFAKULTAS.MaxDropDownItems = 10
        Me.CBFAKULTAS.Name = "CBFAKULTAS"
        Me.CBFAKULTAS.Size = New System.Drawing.Size(365, 23)
        Me.CBFAKULTAS.TabIndex = 186
        Me.CBFAKULTAS.Text = "-- PILIH --"
        '
        'CBJURUSAN
        '
        Me.CBJURUSAN.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.CBJURUSAN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CBJURUSAN.ColumnNum = 2
        Me.CBJURUSAN.ColumnWidth = "120; 120"
        Me.CBJURUSAN.DisplayMember = "Text"
        Me.CBJURUSAN.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBJURUSAN.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.CBJURUSAN.DropDownForeColor = System.Drawing.Color.Black
        Me.CBJURUSAN.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.CBJURUSAN.DropDownWidth = 400
        Me.CBJURUSAN.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBJURUSAN.GridLineColor = System.Drawing.Color.LightGray
        Me.CBJURUSAN.GridLineHorizontal = False
        Me.CBJURUSAN.GridLineVertical = True
        Me.CBJURUSAN.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.CBJURUSAN.Location = New System.Drawing.Point(105, 149)
        Me.CBJURUSAN.ManagingFastMouseMoving = True
        Me.CBJURUSAN.ManagingFastMouseMovingInterval = 30
        Me.CBJURUSAN.MaxDropDownItems = 10
        Me.CBJURUSAN.Name = "CBJURUSAN"
        Me.CBJURUSAN.Size = New System.Drawing.Size(365, 23)
        Me.CBJURUSAN.TabIndex = 187
        Me.CBJURUSAN.Text = "-- PILIH --"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 188
        Me.Label8.Text = "Jurusan"
        '
        'CBSEMESTER
        '
        Me.CBSEMESTER.FormattingEnabled = True
        Me.CBSEMESTER.Items.AddRange(New Object() {"-- PILIH --", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.CBSEMESTER.Location = New System.Drawing.Point(105, 178)
        Me.CBSEMESTER.Name = "CBSEMESTER"
        Me.CBSEMESTER.Size = New System.Drawing.Size(365, 21)
        Me.CBSEMESTER.TabIndex = 189
        Me.CBSEMESTER.Text = "-- PILIH --"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 181)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 190
        Me.Label9.Text = "Semester"
        '
        'TXTJK
        '
        Me.TXTJK.Location = New System.Drawing.Point(138, 99)
        Me.TXTJK.Multiline = True
        Me.TXTJK.Name = "TXTJK"
        Me.TXTJK.Size = New System.Drawing.Size(90, 10)
        Me.TXTJK.TabIndex = 191
        '
        'TXTFAKULTAS
        '
        Me.TXTFAKULTAS.Location = New System.Drawing.Point(168, 126)
        Me.TXTFAKULTAS.Multiline = True
        Me.TXTFAKULTAS.Name = "TXTFAKULTAS"
        Me.TXTFAKULTAS.Size = New System.Drawing.Size(90, 10)
        Me.TXTFAKULTAS.TabIndex = 192
        '
        'TXTJURUSAN
        '
        Me.TXTJURUSAN.Location = New System.Drawing.Point(153, 152)
        Me.TXTJURUSAN.Multiline = True
        Me.TXTJURUSAN.Name = "TXTJURUSAN"
        Me.TXTJURUSAN.Size = New System.Drawing.Size(90, 17)
        Me.TXTJURUSAN.TabIndex = 193
        '
        'TXTSEMESTER
        '
        Me.TXTSEMESTER.Location = New System.Drawing.Point(153, 178)
        Me.TXTSEMESTER.Multiline = True
        Me.TXTSEMESTER.Name = "TXTSEMESTER"
        Me.TXTSEMESTER.Size = New System.Drawing.Size(90, 18)
        Me.TXTSEMESTER.TabIndex = 194
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CBSEMESTER)
        Me.Panel1.Controls.Add(Me.CBJURUSAN)
        Me.Panel1.Controls.Add(Me.CBFAKULTAS)
        Me.Panel1.Controls.Add(Me.CBJK)
        Me.Panel1.Controls.Add(Me.TXTNPM)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TXTSEMESTER)
        Me.Panel1.Controls.Add(Me.TXTJURUSAN)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TXTFAKULTAS)
        Me.Panel1.Controls.Add(Me.TXTJK)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TXTNAMA)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(3, 202)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(475, 205)
        Me.Panel1.TabIndex = 195
        '
        'LBPath
        '
        Me.LBPath.AutoSize = True
        Me.LBPath.Location = New System.Drawing.Point(9, 443)
        Me.LBPath.Name = "LBPath"
        Me.LBPath.Size = New System.Drawing.Size(31, 13)
        Me.LBPath.TabIndex = 196
        Me.LBPath.Text = "NPM"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 419)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(179, 13)
        Me.Label10.TabIndex = 197
        Me.Label10.Text = "Initial Directory to save template file :"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.txtNamaMHS)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txtNPM2)
        Me.Panel2.Controls.Add(Me.txtMataKuliah)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.cbMataKuliah)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txtKodeMatKul)
        Me.Panel2.Controls.Add(Me.TXTCount)
        Me.Panel2.Location = New System.Drawing.Point(6, 199)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(472, 149)
        Me.Panel2.TabIndex = 198
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(147, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 13)
        Me.Label15.TabIndex = 204
        Me.Label15.Text = "Mata Kuliah"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 122)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 202
        Me.Label14.Text = "NPM"
        '
        'txtNamaMHS
        '
        Me.txtNamaMHS.AutoSize = True
        Me.txtNamaMHS.Location = New System.Drawing.Point(87, 99)
        Me.txtNamaMHS.Name = "txtNamaMHS"
        Me.txtNamaMHS.Size = New System.Drawing.Size(58, 13)
        Me.txtNamaMHS.TabIndex = 201
        Me.txtNamaMHS.Text = "Nama Mhs"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 13)
        Me.Label13.TabIndex = 200
        Me.Label13.Text = "Nama Mhs"
        '
        'txtNPM2
        '
        Me.txtNPM2.AutoSize = True
        Me.txtNPM2.Location = New System.Drawing.Point(87, 122)
        Me.txtNPM2.Name = "txtNPM2"
        Me.txtNPM2.Size = New System.Drawing.Size(31, 13)
        Me.txtNPM2.TabIndex = 199
        Me.txtNPM2.Text = "NPM"
        '
        'txtMataKuliah
        '
        Me.txtMataKuliah.AutoSize = True
        Me.txtMataKuliah.Location = New System.Drawing.Point(87, 74)
        Me.txtMataKuliah.Name = "txtMataKuliah"
        Me.txtMataKuliah.Size = New System.Drawing.Size(63, 13)
        Me.txtMataKuliah.TabIndex = 190
        Me.txtMataKuliah.Text = "Mata Kuliah"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 189
        Me.Label12.Text = "Mata Kuliah"
        '
        'cbMataKuliah
        '
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
        Me.cbMataKuliah.GridLineColor = System.Drawing.Color.LightGray
        Me.cbMataKuliah.GridLineHorizontal = False
        Me.cbMataKuliah.GridLineVertical = True
        Me.cbMataKuliah.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cbMataKuliah.Location = New System.Drawing.Point(90, 39)
        Me.cbMataKuliah.ManagingFastMouseMoving = True
        Me.cbMataKuliah.ManagingFastMouseMovingInterval = 30
        Me.cbMataKuliah.MaxDropDownItems = 10
        Me.cbMataKuliah.Name = "cbMataKuliah"
        Me.cbMataKuliah.Size = New System.Drawing.Size(365, 23)
        Me.cbMataKuliah.TabIndex = 187
        Me.cbMataKuliah.Text = "-- PILIH --"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 17)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Mata Kuliah"
        '
        'txtKodeMatKul
        '
        Me.txtKodeMatKul.AutoSize = True
        Me.txtKodeMatKul.Location = New System.Drawing.Point(132, 44)
        Me.txtKodeMatKul.Name = "txtKodeMatKul"
        Me.txtKodeMatKul.Size = New System.Drawing.Size(63, 13)
        Me.txtKodeMatKul.TabIndex = 203
        Me.txtKodeMatKul.Text = "Mata Kuliah"
        '
        'txtID
        '
        Me.txtID.AutoSize = True
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(123, 9)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(0, 17)
        Me.txtID.TabIndex = 199
        '
        'Picture
        '
        Me.Picture.BackColor = System.Drawing.SystemColors.Window
        Me.Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picture.Location = New System.Drawing.Point(12, 39)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(91, 125)
        Me.Picture.TabIndex = 7
        Me.Picture.TabStop = False
        '
        'TXTCount
        '
        Me.TXTCount.AutoSize = True
        Me.TXTCount.Location = New System.Drawing.Point(381, 9)
        Me.TXTCount.Name = "TXTCount"
        Me.TXTCount.Size = New System.Drawing.Size(31, 13)
        Me.TXTCount.TabIndex = 200
        Me.TXTCount.Text = "NPM"
        '
        'CaptureForm
        '
        Me.AcceptButton = Me.CloseButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CloseButton
        Me.ClientSize = New System.Drawing.Size(488, 465)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LBPath)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(label1)
        Me.Controls.Add(Me.StatusLine)
        Me.Controls.Add(Me.StatusText)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.Prompt)
        Me.Controls.Add(PromptLabel)
        Me.Controls.Add(Me.Picture)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(400, 300)
        Me.Name = "CaptureForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fingerprint Enrollment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents CloseButton As System.Windows.Forms.Button
    Private WithEvents StatusLine As System.Windows.Forms.Label
    Private WithEvents StatusText As System.Windows.Forms.TextBox
    Private WithEvents Prompt As System.Windows.Forms.TextBox
    Private WithEvents Picture As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXTNPM As System.Windows.Forms.TextBox
    Friend WithEvents TXTNAMA As System.Windows.Forms.TextBox
    Friend WithEvents CBJK As System.Windows.Forms.ComboBox
    Public WithEvents CBFAKULTAS As MTGCComboBox
    Public WithEvents CBJURUSAN As MTGCComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CBSEMESTER As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TXTJK As System.Windows.Forms.TextBox
    Friend WithEvents TXTFAKULTAS As System.Windows.Forms.TextBox
    Friend WithEvents TXTJURUSAN As System.Windows.Forms.TextBox
    Friend WithEvents TXTSEMESTER As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LBPath As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtMataKuliah As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents cbMataKuliah As MTGCComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNPM2 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNamaMHS As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.Label
    Friend WithEvents txtKodeMatKul As System.Windows.Forms.Label
    Friend WithEvents TXTCount As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
