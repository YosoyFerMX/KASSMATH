Public Class FRM_RESULTADO_EXAMEN

Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

End Sub

Private Sub FRM_RESULTADO_EXAMEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    lbl_correctas.Text = VariablesGlob.numero_correcta
    lbl_incorrectas.Text = VariablesGlob.numero_incorrecta

Dim calificacion As Integer
Dim calificacion_porcentaje As String

calificacion = (100 / 5) * VariablesGlob.numero_correcta
calificacion_porcentaje = calificacion.ToString() + " %"
lbl_calificacion.Text = calificacion_porcentaje


End Sub

Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
  Dim frm_tipos_Suma As New tipos_suma()
frm_tipos_Suma.Show()
Me.Dispose()
End Sub
End Class