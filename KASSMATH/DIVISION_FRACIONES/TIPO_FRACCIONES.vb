Public Class TIPO_FRACCIONES



Private Sub Button4_Click(sender As Object, e As EventArgs)


End Sub

Private Sub Button5_Click(sender As Object, e As EventArgs)

End Sub
'EFECTOS DEL BOTON PROPIAS >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
Private Sub btn_propias_divi_MouseEnter(sender As Object, e As EventArgs) Handles btn_propias_divi.MouseEnter
    ' Me.btn_propias_divi.Height = 80
    'Me.btn_propias_divi.Width = 320
    'btn_propias_divi.Location = New Point(450, 210)
End Sub

Private Sub btn_propias_divi_MouseLeave(sender As Object, e As EventArgs) Handles btn_propias_divi.MouseLeave
    'Me.btn_propias_divi.Height = 78
    'Me.btn_propias_divi.Width = 289
    'btn_propias_divi.Location = New Point(469, 192)

End Sub
'>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
  Dim inicio As New INICIO()
inicio.Show()
Me.Dispose()
End Sub

Private Sub btn_propias_divi_Click(sender As Object, e As EventArgs) Handles btn_propias_divi.Click
  Dim frm_niveles_propias As New NIVELES_PROPIAS()
frm_niveles_propias.Show()
Me.Dispose()
End Sub

Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
  Dim frm_niveles_impropias As New NIVELES_IMPROPIAS()
frm_niveles_impropias.Show()
Me.Dispose()
End Sub
End Class
