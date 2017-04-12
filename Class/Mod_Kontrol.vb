Imports DevComponents.DotNetBar

Module Mod_Kontrol
    Public glow As eToastGlowColor = eToastGlowColor.Blue
    Public pos As eToastPosition = eToastPosition.BottomCenter

    Public Function HarusAngka(ByVal Key As String) As Boolean
        If (Key >= 48 And Key <= 57) Or Key = 8 Then
            HarusAngka = False
        Else
            HarusAngka = True
            MessageBoxEx.Show("Harap tidak diisi dengan Huruf..", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Function

    Public Sub SET_APP_STYLE(ByVal styleId As Integer)
        'If (styleId = 0) Then
        '    My.Settings.Style = DevComponents.DotNetBar.eStyle.Office2007Blue
        '    MyProject.Forms.MainForm.NavPane.Style = eDotNetBarStyle.Office2003
        'Else
        '    MyProject.Forms.MainForm.DotNetBarManager.Style = eDotNetBarStyle.Office2007
        '    MyProject.Forms.MainForm.NavPane.Style = eDotNetBarStyle.Office2007
        'End If
    End Sub


End Module
