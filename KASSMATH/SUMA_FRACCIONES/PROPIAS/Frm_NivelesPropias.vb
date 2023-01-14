Public Class Frm_NivelesPropias

    Private Sub Frm_NivelesPropias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim direccion_final As String
  direccion_final = Mid(variables_globales.direccion, 1, variables_globales.direccion_1 + 9) + "VIDEOS_TUTO\SUMA_PROPIAS.mp4"

    wm_video.URL = (direccion_final)
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim frmPropiasI As New Frm_Propias1
        frmPropiasI.Show()
        Me.Dispose()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim frmPropiasII As New Frm_Propias2
        frmPropiasII.Show()
        Me.Dispose()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim frmPropiasIII As New Frm_Propias3
        frmPropiasIII.Show()
        Me.Dispose()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim frmPropiasIV As New Frm_Propias4
        frmPropiasIV.Show()
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