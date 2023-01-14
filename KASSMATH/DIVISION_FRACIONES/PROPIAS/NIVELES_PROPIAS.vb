Public Class NIVELES_PROPIAS



Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
  Dim inicio_principal As New TIPO_FRACCIONES()
    inicio_principal.Show()
    Me.Dispose()
End Sub

Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
    Dim inicio As New INICIO
inicio.Show()
Me.Dispose()
End Sub

Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
  Dim nivel_1 As New EJERCICIO_PROPIAS_1()
nivel_1.Show()
 Me.Dispose()
End Sub

Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
      Dim nivel_2 As New EJERCICIO_PROPIAS_2()
    nivel_2.Show()
    Me.Dispose()
End Sub

Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
      Dim nivel_3 As New EJERCICIO_PROPIAS_3()
    nivel_3.Show()
    Me.Dispose()
End Sub

Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
      Dim nivel_4 As New EJERCICIO_PROPIAS_4()
    nivel_4.Show()
    Me.Dispose()
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

Private Sub NIVELES_PROPIAS_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
 Dim direccion_final As String
  direccion_final = Mid(variables_globales.direccion, 1, variables_globales.direccion_1 + 9) + "VIDEOS_TUTO\DIVISION_PROPIAS.mp4"

    wm_video.URL = (direccion_final)
End Sub
End Class