Public Class frmRESULTADOS_N2

Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim frm_irNivel2 As New frmEJERCICIOS_RESTA_N2
frm_irNivel2.Show()
Me.Dispose()
End Sub

Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim niveles_RESTA As New RESTA_NATURALES
niveles_RESTA.Show()
Me.Close()
End Sub

Private Sub frmRESULTADOS_N2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
   If varGlobales_Resta.nivel_comple = 2 And tipo = 1 Then 'SI EL RESULTADO ES CORRECTO NIVEL 2
                gbx_correcto.Visible = True
                gbx_incorrecto.Visible = False
                gbx_Incorrecto3.Visible = False
    End If
     If varGlobales_Resta.nivel_comple = 2 And tipo = 2 And caso = 1 Then 'SI EL RESULTADO ES INCORRECTO NIVEL 2 EN EL CASO 1
                gbx_correcto.Visible = False
                gbx_incorrecto.Visible = False
                gbx_Incorrecto3.Visible = True

                lblNum_may.Text = num_May
                lblNum_men.Text = num_Men
                lblResultado.Text = result
     End If

    If varGlobales_Resta.nivel_comple = 2 And tipo = 2 And caso = 2 Then 'SI EL RESULTADO ES INCORRECTO NIVEL 2 EN EL CASO 2
            gbx_correcto.Visible = False
            gbx_incorrecto.Visible = True
            gbx_Incorrecto3.Visible = False
            lblNum_Mayor.Text = num_May
            lblNum_Menor.Text = num_Men
            lblReultado.Text = result
            lblUnidad_arriba.Text = varGlobales_Resta.unidad_arriba
            lblUnidadAbajo.Text = unidad_abajo
            lblResultado_Unidad.Text = unidad_arriba - unidad_abajo


            lblDecena_arriba.Text = decena_arriba
            lblDecena_abajo.Text = decena_abajo
            lblResta_decenas.Text = decena_arriba - decena_abajo
    End If
End Sub

Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
      Dim frm_irNivel2 As New frmEJERCICIOS_RESTA_N2
frm_irNivel2.Show()
Me.Dispose()
End Sub

Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
      Dim niveles_RESTA As New RESTA_NATURALES
niveles_RESTA.Show()
Me.Close()
End Sub

Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim frm_irNivel2 As New frmEJERCICIOS_RESTA_N2
frm_irNivel2.Show()
Me.Dispose()
End Sub

Private Sub gbx_Incorrecto3_Enter(sender As Object, e As EventArgs) Handles gbx_Incorrecto3.Enter

End Sub

Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim niveles_RESTA As New RESTA_NATURALES
niveles_RESTA.Show()
Me.Close()
End Sub
End Class