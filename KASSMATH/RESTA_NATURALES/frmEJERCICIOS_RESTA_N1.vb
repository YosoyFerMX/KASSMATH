Public Class frmEJERCICIOS_RESTA_N1
    Dim Num_aleatorios As New Random
    Dim num_Mayor As Integer
    Dim num_Menor As Integer
Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
      Dim frm_regresar_niveles As New RESTA_NATURALES
frm_regresar_niveles.Show()
Me.Dispose()
End Sub

Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVerificar_resta.Click

                'Comienza resta'
            Dim resultado_resta As Integer
                resultado_resta = num_Mayor - num_Menor

                If resultado_resta = txtResultado.Text Then '
                    varGlobales_Resta.tipo = 1 'Si es uno es correcto
                    varGlobales_Resta.nivel_comple = 1 'si es 1 manda el nivel 1

                    Else
                        varGlobales_Resta.tipo = 2
                        varGlobales_Resta.nivel_comple = 1
                        varGlobales_Resta.result = resultado_resta 'manda el resultado correcto
                End If
        Dim correcto_incorrecto As New frmRESULTADOS()
         correcto_incorrecto.Show()
Me.Dispose()
End Sub

Private Sub frmEJERCICIOS_RESTA_N1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
     '------------RESTA DE NUMEROS NATURALES>>>>>>> Agrega las crifras al abrir pantalla-------------------------'
        num_Mayor = Num_aleatorios.Next(4, 9)
        num_Menor = Num_aleatorios.Next(1, num_Mayor)

        lblNum_Mayor.Text = num_Mayor
        lblNum_Menor.Text = num_Menor
        varGlobales_Resta.num_May = num_Mayor
        varGlobales_Resta.num_Men = num_Menor


End Sub

Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
     Dim inicio As New INICIO
inicio.Show()
Me.Close()
End Sub
End Class