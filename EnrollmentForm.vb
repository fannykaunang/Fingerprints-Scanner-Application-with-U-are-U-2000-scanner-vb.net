Imports System.Data.SqlClient

' NOTE: This form is inherited from the CaptureForm,
' so the VisualStudio Form Designer may not load this properly
' (at least until you build the project).
' If you want to make changes in the form layout - do it in the base CaptureForm.
' All changes in the CaptureForm will be reflected in all derived forms 
' (i.e. in the EnrollmentForm and in the VerificationForm)

Public Class EnrollmentForm
    Inherits CaptureForm

    Public Event OnTemplate(ByVal template)
    Public Event NPM(ByVal NPM As String)
    Public Event NAMA(ByVal NAMA As String)
    Public Event JK(ByVal JK)
    Public Event FAKULTAS(ByVal FAKULTAS)
    Public Event JURUSAN(ByVal JURUSAN)
    Public Event SEMESTER(ByVal SEMESTER)
    Public Event ALAMAT(ByVal ALAMAT)

    Private Enroller As DPFP.Processing.Enrollment

    Protected Overrides Sub Init()
        MyBase.Init()
        MyBase.Text = "Fingerprint Enrollments"
        Enroller = New DPFP.Processing.Enrollment()     ' Create an enrollment.
        UpdateStatus()
    End Sub

    Protected Overrides Sub Process(ByVal Sample As DPFP.Sample)
        MyBase.Process(Sample)

        Dim features As DPFP.FeatureSet = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment)

        If (Not features Is Nothing) Then
            Try
                MakeReport("The fingerprint feature set was created.")
                Enroller.AddFeatures(features)
            Finally
                UpdateStatus()

                ' Check if template has been created.
                Select Case Enroller.TemplateStatus
                    Case DPFP.Processing.Enrollment.Status.Ready    ' Report success and stop capturing
                        RaiseEvent OnTemplate(Enroller.Template)
                        RaiseEvent NPM(Me.TXTNPM.Text)
                        RaiseEvent NAMA(Me.TXTNAMA.Text)
                        RaiseEvent JK(Me.TXTJK.Text)
                        RaiseEvent FAKULTAS(Me.TXTFAKULTAS.Text)
                        RaiseEvent JURUSAN(Me.TXTJURUSAN.Text)
                        RaiseEvent SEMESTER(Me.TXTSEMESTER.Text)
                        RaiseEvent ALAMAT(Me.LBPath.Text)
                        SetPrompt("Click Close, and then click Fingerprint VerificationS.")
                        StopCapture()
                        'FormMenu.SaveData()

                    Case DPFP.Processing.Enrollment.Status.Failed   ' Report failure and restart capturing
                        Enroller.Clear()
                        StopCapture()
                        RaiseEvent OnTemplate(Nothing)
                        RaiseEvent NPM(Nothing)
                        RaiseEvent NAMA(Nothing)
                        RaiseEvent JK(Nothing)
                        RaiseEvent FAKULTAS(Nothing)
                        RaiseEvent JURUSAN(Nothing)
                        RaiseEvent SEMESTER(Nothing)
                        RaiseEvent ALAMAT(Nothing)
                        StartCapture()

                End Select
            End Try
        End If
    End Sub

    Protected Sub UpdateStatus()
        ' Show number of samples needed.
        SetStatus(String.Format("Jumlah tiap individu untuk di-scan diperlukan : {0} kali", Enroller.FeaturesNeeded))
    End Sub

    Private Template As DPFP.Template

End Class
