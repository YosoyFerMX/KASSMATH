Public Class TIPOS_RESTA

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnImpro_Click(sender As Object, e As EventArgs)

    End Sub

Private Sub btn_Inicio_Click(sender As Object, e As EventArgs)

End Sub



Private Sub btn_propias_divi_Click(sender As Object, e As EventArgs) Handles btn_propias_divi.Click
   Dim NivFraccPropiasPro As New NivFraccPropias
        NivFraccPropiasPro.Show()
        Me.Dispose()

End Sub

Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
  Dim inicio As New INICIO()
inicio.Show()
Me.Dispose()
End Sub

Private Sub btn_impropias_divi_Click(sender As Object, e As EventArgs)

End Sub

Private Sub btn_mixtas_divi_Click(sender As Object, e As EventArgs)

End Sub
End Class
