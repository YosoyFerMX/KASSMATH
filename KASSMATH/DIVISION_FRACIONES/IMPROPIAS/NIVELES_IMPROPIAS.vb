Public Class NIVELES_IMPROPIAS

Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    Dim nivel_1 As New EJERCICIO_IMPROPIAS_1()
nivel_1.Show()
 Me.Dispose()
End Sub

Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    Dim inicio_principal As New TIPO_FRACCIONES()
    inicio_principal.Show()
    Me.Dispose()
End Sub

Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
  Dim inicio As New INICIO
inicio.Show()
Me.Dispose()
End Sub

Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
    Dim nivel_2 As New EJERCICIO_IMPROPIAS_2()
nivel_2.Show()
 Me.Dispose()
End Sub

Private Sub NIVELES_IMPROPIAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
Dim direccion_final As String
  direccion_final = Mid(variables_globales.direccion, 1, variables_globales.direccion_1 + 9) + "VIDEOS_TUTO\DIVISION_PROPIAS.mp4"

    wm_video.URL = (direccion_final)
End Sub

Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    wm_video.Ctlcontrols.play()
End Sub

Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
    wm_video.Ctlcontrols.pause()
End Sub

Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
    wm_video.Ctlcontrols.stop()
End Sub
End Class