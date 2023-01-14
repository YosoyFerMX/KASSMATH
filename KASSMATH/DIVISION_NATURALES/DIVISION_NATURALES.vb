Public Class DIVISION_NATURALES

Private Sub DIVISION_NATURALES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
   Dim direccion_final As String
  direccion_final = Mid(variables_globales.direccion, 1, variables_globales.direccion_1 + 9) + "VIDEOS_TUTO\DIVISION_NATURALES.mp4"

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

Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
  Dim frm_inicio As New INICIO()
frm_inicio.Show()
Me.Dispose()
End Sub

Private Sub btnNivel1_Click(sender As Object, e As EventArgs) Handles btnNivel1.Click
    Dim nivel_1 As New frmEJERCICIO_DIVISIONES_1()
nivel_1.Show()
 Me.Close()
End Sub
End Class