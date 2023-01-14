Public Class frmRESULTADOS_N3

Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
          Dim frm_irNivel3 As New frmEJERCICIOS_RESTA_N3
frm_irNivel3.Show()
Me.Dispose()
End Sub

Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
          Dim niveles_RESTA As New RESTA_NATURALES
niveles_RESTA.Show()
Me.Close()
End Sub

Private Sub frmRESULTADOS_N3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If varGlobales_Resta.tipo = 1 And nivel_comple = 3 Then 'CORRECTO
            gbx_correcto.Visible = True
            gbx_incorrecto.Visible = False
        End If

        If varGlobales_Resta.tipo = 2 And nivel_comple = 3 Then
              gbx_correcto.Visible = False
            gbx_incorrecto.Visible = True

            lblNum_Mayor.Text = num_May
            lblNum_Menor.Text = num_Men
            lblReultado.Text = result

            lblUnidad_arriba.Text = unidad_arriba
            lblUnidadAbajo.Text = unidad_abajo
            lblResultado_Unidad.Text = varGlobales_Resta.resta_unidad

            lblDecena_arriba.Text = decena_arriba
            lblDecena_abajo.Text = decena_abajo
            lblResta_decenas.Text = resta_decena

            lblCentena_arriba.Text = centena_arriba
            lblCentena_abajo.Text = centena_abajo
            lblResta_centenas.Text = resta_centena


        End If
End Sub

Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm_irNivel3 As New frmEJERCICIOS_RESTA_N3
frm_irNivel3.Show()
Me.Dispose()
End Sub

Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim niveles_RESTA As New RESTA_NATURALES
niveles_RESTA.Show()
Me.Close()
End Sub

Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

End Sub
End Class