Public Class frmRESULTADOS

Private Sub frmRESULTADOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
  If varGlobales_Resta.nivel_comple = 1 And tipo = 1 Then 'SI RESULTADO ES CORRECTO NIVEL 1
        gbx_correcto.Visible = True
        gbx_incorrecto.Visible = False

  End If

    If varGlobales_Resta.nivel_comple = 1 And tipo = 2 Then 'SI RESULTADO ES INCORRECTO NIVEL 1
        gbx_correcto.Visible = False
        gbx_incorrecto.Visible = True

            lblNum_Mayor.Text = num_May
            lblNum_Menor.Text = num_Men
            lblReultado.Text = result
    End If


End Sub

Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    Dim frm_irNivel1 As New frmEJERCICIOS_RESTA_N1
frm_irNivel1.Show()
Me.Dispose()
End Sub

Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
    Dim niveles_RESTA As New RESTA_NATURALES
niveles_RESTA.Show()
Me.Close()
End Sub

Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
      Dim frm_irNivel1 As New frmEJERCICIOS_RESTA_N1
frm_irNivel1.Show()
Me.Dispose()
End Sub

Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
      Dim niveles_RESTA As New RESTA_NATURALES
niveles_RESTA.Show()
Me.Close()
End Sub
End Class