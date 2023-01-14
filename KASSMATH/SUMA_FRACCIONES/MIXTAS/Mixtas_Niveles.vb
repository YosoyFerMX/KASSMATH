Public Class Mixtas_Niveles

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim frmMixtas1 As New Frm_Mixtas1
        frmMixtas1.Show()
        Me.Dispose()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim frmMixtas2 As New Frm_Mixtas2
        frmMixtas2.Show()
        Me.Dispose()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim frmMixtas3 As New Frm_Mixtas3
        frmMixtas3.Show()
        Me.Dispose()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim frmMixtas4 As New Frm_Mixtas4
        frmMixtas4.Show()
        Me.Dispose()
    End Sub

Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
  Dim FRM_TIPO_SUMA As New tipos_suma()
    FRM_TIPO_SUMA.Show()
    Me.Dispose()
End Sub

Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
  Dim frm_inicio As New INICIO()
    frm_inicio.Show()
    Me.Dispose()
End Sub

Private Sub Mixtas_Niveles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
  Dim direccion_final As String
  direccion_final = Mid(variables_globales.direccion, 1, variables_globales.direccion_1 + 9) + "VIDEOS_TUTO\SUMA_MIXTA.mp4"

    wm_video.URL = (direccion_final)
End Sub

Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
   wm_video.Ctlcontrols.play()
End Sub

Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
   wm_video.Ctlcontrols.pause()
End Sub

Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
   wm_video.Ctlcontrols.stop()
End Sub
End Class