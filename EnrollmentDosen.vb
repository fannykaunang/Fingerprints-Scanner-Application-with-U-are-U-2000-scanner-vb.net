Public Class EnrollmentDosen
    Inherits FormDataDosen

    Public Event OnTemplateDOSEN(ByVal OnTemplateDOSEN)
    Public Event NIP(ByVal NIP As String)
    Public Event NAMADOSEN(ByVal NAMADOSEN As String)
    Public Event ALAMATDOSEN(ByVal ALAMATDOSEN As String)
    Public Event PATH_DOSEN(ByVal PATH)
    Private Enroller As DPFP.Processing.Enrollment

    Protected Overrides Sub Init()
        MyBase.Init()
        MyBase.Text = "Fingerprint Enrollments"
        Enroller = New DPFP.Processing.Enrollment()
        UpdateStatus()
    End Sub

    Protected Overrides Sub Process(ByVal Sample As DPFP.Sample)
        MyBase.Process(Sample)
        Dim features As DPFP.FeatureSet = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment)

        If (Not features Is Nothing) Then
            Try
                MakeReportDosen("The fingerprint feature set was created.")
                Enroller.AddFeatures(features)
            Finally
                UpdateStatus()

                Select Case Enroller.TemplateStatus
                    Case DPFP.Processing.Enrollment.Status.Ready
                        RaiseEvent OnTemplateDOSEN(Enroller.Template)
                        RaiseEvent NIP(Me.TXTID.Text)
                        RaiseEvent NAMADOSEN(Me.TXTNAMADOSEN.Text)
                        RaiseEvent ALAMATDOSEN(Me.TXTALAMAT.Text)
                        RaiseEvent PATH_DOSEN(Me.LBPath.Text)
                        SetPrompt("Click Close, and then click Fingerprint VerificationS.")
                        StopCapture()

                    Case DPFP.Processing.Enrollment.Status.Failed
                        Enroller.Clear()
                        StopCapture()
                        RaiseEvent OnTemplateDOSEN(Nothing)
                        RaiseEvent NIP(Nothing)
                        RaiseEvent NAMADOSEN(Nothing)
                        RaiseEvent ALAMATDOSEN(Nothing)
                        RaiseEvent PATH_DOSEN(Nothing)
                        StartCapture()

                End Select
            End Try
        End If
    End Sub

    Protected Sub UpdateStatus()
        SetStatus(String.Format("Jumlah tiap individu untuk di-scan diperlukan : {0} kali", Enroller.FeaturesNeeded))
    End Sub

    Private Template As DPFP.Template
End Class