Public Class Impropias_Niveles

    Private Sub btn_nivel_1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_nivel_2_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub btn_nivel_3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_nivel_4_Click(sender As Object, e As EventArgs)

    End Sub

Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click




      Dim frmImPropiasI As New Impropias
        frmImPropiasI.Show()
        Me.Dispose()
End Sub

Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
          Dim frmImPropiasII As New Impropias2
        frmImPropiasII.Show()
        Me.Dispose()

End Sub

Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
          Dim frmImPropiasIII As New Impropias3
        frmImPropiasIII.Show()
        Me.Dispose()
End Sub

Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
          Dim frmImPropiasIV As New Impropias4
        frmImPropiasIV.Show()
        Me.Dispose()
End Sub

Private Sub btn_inicio_principal_Click(sender As Object, e As EventArgs)

End Sub

Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
  Dim frm_inicio As New INICIO()
frm_inicio.Show()
Me.Dispose()
End Sub

Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
  Dim frm_tipos_suma As New tipos_suma()
frm_tipos_suma.Show()
Me.Dispose()
End Sub

Private Sub Impropias_Niveles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
 Dim direccion_final As String
  direccion_final = Mid(variables_globales.direccion, 1, variables_globales.direccion_1 + 9) + "VIDEOS_TUTO\SUMA_FRACCIONES.mp4"

    wm_video.URL = (direccion_final)
End Sub

Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
  wm_video.Ctlcontrols.play()

End Sub

Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
  wm_video.Ctlcontrols.pause()

End Sub

Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
  wm_video.Ctlcontrols.stop()

End Sub
End Class