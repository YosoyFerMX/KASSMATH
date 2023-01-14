Public Class frmEJERCICIO_DIVISIONES_1

Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
  Dim inicio As New INICIO
inicio.Show()
Me.Close()
End Sub

Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
   Dim frm_regresar_niveles As New DIVISION_NATURALES()
frm_regresar_niveles.Show()
Me.Dispose()
End Sub
End Class