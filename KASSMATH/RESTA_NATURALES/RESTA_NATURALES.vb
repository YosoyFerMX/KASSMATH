Public Class RESTA_NATURALES

Private Sub RESTA_NATURALES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
     Dim direccion_final As String
  direccion_final = Mid(variables_globales.direccion, 1, variables_globales.direccion_1 + 9) + "VIDEOS_TUTO\RESTA_NATURALES.mp4"

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
  Dim frm_inicio As New INICIO
frm_inicio.Show()
Me.Dispose()

End Sub

Private Sub btnDigito1_Click(sender As Object, e As EventArgs) Handles btnDigito1.Click
  Dim frm_irNivel1 As New frmEJERCICIOS_RESTA_N1
frm_irNivel1.Show()
Me.Dispose()
End Sub

Private Sub btnDgto2_Click(sender As Object, e As EventArgs) Handles btnDgto2.Click
    Dim frm_irNivel2 As New frmEJERCICIOS_RESTA_N2
    frm_irNivel2.Show()
    Me.Dispose()
End Sub

Private Sub btnDgto3_Click(sender As Object, e As EventArgs) Handles btnDgto3.Click
      Dim frm_irNivel3 As New frmEJERCICIOS_RESTA_N3
    frm_irNivel3.Show()
    Me.Dispose()
End Sub

Private Sub btnDgt4_Click(sender As Object, e As EventArgs) Handles btnDgt4.Click
        Dim frm_irNivel4 As New frmEJERCICIOS_RESTA_N4
    frm_irNivel4.Show()
    Me.Dispose()
End Sub
End Class