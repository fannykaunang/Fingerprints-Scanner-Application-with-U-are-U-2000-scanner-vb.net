<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.txtUser = New MetroFramework.Controls.MetroTextBox()
        Me.txtPassword = New MetroFramework.Controls.MetroTextBox()
        Me.btBatal = New MetroFramework.Controls.MetroButton()
        Me.btSimpan = New MetroFramework.Controls.MetroButton()
        Me.PanelEx4 = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtUser.ForeColor = System.Drawing.Color.White
        Me.txtUser.Location = New System.Drawing.Point(160, 83)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(272, 23)
        Me.txtUser.TabIndex = 56
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtPassword.ForeColor = System.Drawing.Color.White
        Me.txtPassword.Location = New System.Drawing.Point(160, 118)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Size = New System.Drawing.Size(272, 23)
        Me.txtPassword.TabIndex = 57
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btBatal
        '
        Me.btBatal.Location = New System.Drawing.Point(357, 158)
        Me.btBatal.Name = "btBatal"
        Me.btBatal.Size = New System.Drawing.Size(75, 23)
        Me.btBatal.TabIndex = 59
        Me.btBatal.Text = "Batal"
        '
        'btSimpan
        '
        Me.btSimpan.Location = New System.Drawing.Point(276, 158)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btSimpan.TabIndex = 58
        Me.btSimpan.Text = "Masuk"
        '
        'PanelEx4
        '
        Me.PanelEx4.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.PanelEx4.Controls.Add(Me.LabelX9)
        Me.PanelEx4.Controls.Add(Me.LabelX8)
        Me.PanelEx4.Controls.Add(Me.LabelX7)
        Me.PanelEx4.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx4.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx4.Name = "PanelEx4"
        Me.PanelEx4.Size = New System.Drawing.Size(472, 209)
        Me.PanelEx4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx4.Style.BackColor1.Color = System.Drawing.Color.White
        Me.PanelEx4.Style.BackColor2.Color = System.Drawing.Color.Black
        Me.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx4.Style.GradientAngle = 90
        Me.PanelEx4.TabIndex = 60
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.ForeColor = System.Drawing.Color.White
        Me.LabelX9.Location = New System.Drawing.Point(42, 118)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(94, 23)
        Me.LabelX9.TabIndex = 5
        Me.LabelX9.Text = "Password :"
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.ForeColor = System.Drawing.Color.White
        Me.LabelX8.Location = New System.Drawing.Point(42, 83)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(94, 23)
        Me.LabelX8.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.LabelX8.TabIndex = 4
        Me.LabelX8.Text = "Username :"
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.LabelX7.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.LabelX7.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.LabelX7.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.ForeColor = System.Drawing.Color.Black
        Me.LabelX7.Location = New System.Drawing.Point(3, 3)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(469, 34)
        Me.LabelX7.TabIndex = 3
        Me.LabelX7.Text = "<b>User Login</b>"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(472, 209)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btBatal)
        Me.Controls.Add(Me.btSimpan)
        Me.Controls.Add(Me.PanelEx4)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Form"
        Me.PanelEx4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents txtUser As MetroFramework.Controls.MetroTextBox
    Private WithEvents txtPassword As MetroFramework.Controls.MetroTextBox
    Private WithEvents btBatal As MetroFramework.Controls.MetroButton
    Private WithEvents btSimpan As MetroFramework.Controls.MetroButton
    Friend WithEvents PanelEx4 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
End Class
