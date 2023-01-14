Public Class tipos_suma

 

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim frmPropias As New Impropias
        frmPropias.Show()
        Me.Dispose()


    End Sub



Private Sub btn_impropias_divi_Click(sender As Object, e As EventArgs) Handles btn_impropias_divi.Click
   Dim frmImPropias As New Impropias_Niveles
        frmImPropias.Show()
        Me.Dispose()
End Sub

Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
  Dim inicio As New INICIO()
inicio.Show()
Me.Dispose()
End Sub

Private Sub btn_propias_divi_Click(sender As Object, e As EventArgs)

End Sub

Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
  Dim frm_niveles_propias_suma As New Frm_NivelesPropias()
frm_niveles_propias_suma.Show()
Me.Dispose()
End Sub

Private Sub Button2_Click_1(sender As Object, e As EventArgs)
  Dim frm_examen_1 As New Frm_Propias1()
    frm_examen_1.Show()
    Me.Dispose()
End Sub

Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    Dim frm_mixtas As New Mixtas_Niveles
        frm_mixtas.Show()
        Me.Dispose()
End Sub

Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

VariablesGlob.exa_si_no = 1


    Dim frm_pregunta_1 As New Impropias()
    frm_pregunta_1.Show()
    Me.Dispose()

End Sub
End Class
