Public Class NivFraccPropias

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

Private Sub btn_elegir_tipo_Click(sender As Object, e As EventArgs)

End Sub

Private Sub NivFraccPropias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
   Dim direccion_final As String
  direccion_final = Mid(variables_globales.direccion, 1, variables_globales.direccion_1 + 9) + "VIDEOS_TUTO\RESTA_PROPIAS.mp4"

    wm_video.URL = (direccion_final)
End Sub

Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
  Dim frm_inicio As New INICIO()
frm_inicio.Show()
Me.Dispose()
End Sub

Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
   Dim inicio_principal As New INICIO()
    inicio_principal.Show()
    Me.Dispose()
End Sub

Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
          Dim Nivel1 As New frmN1Propias
        Nivel1.Show()
        Me.Dispose()
End Sub

Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
          Dim nivel2 As New frmN2Propias
        nivel2.Show()
        Me.Dispose()
End Sub

Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
          Dim nivel3 As New frmN3Propias
        nivel3.Show()
        Me.Dispose()
End Sub

Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
          Dim nivel4 As New frmN4Propias
        nivel4.Show()
        Me.Dispose()
End Sub

Private Sub Button5_Click_1(sender As Object, e As EventArgs)

End Sub

Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

    wm_video.Ctlcontrols.play()
End Sub

Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

    wm_video.Ctlcontrols.pause()
End Sub

Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    wm_video.Ctlcontrols.stop()
End Sub
End Class