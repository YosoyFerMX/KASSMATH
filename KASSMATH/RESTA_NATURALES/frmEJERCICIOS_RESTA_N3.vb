﻿Public Class frmEJERCICIOS_RESTA_N3
    Dim Num_aleatorios As New Random
    Dim num_Mayor As Integer
    Dim num_Menor As Integer
Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
       Dim frm_regresar_niveles As New RESTA_NATURALES
frm_regresar_niveles.Show()
Me.Dispose()
End Sub

Private Sub frmEJERCICIOS_RESTA_N3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
  num_Mayor = Num_aleatorios.Next(115, 999)
        num_Menor = Num_aleatorios.Next(100, num_Mayor)

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

Private Sub btnVerificar_resta_Click(sender As Object, e As EventArgs) Handles btnVerificar_resta.Click
  Dim unidad_arriba, decena_arriba, centena_arriba As Integer
    Dim unidad_abajo, decena_abajo, centena_abajo As Integer
        centena_arriba = num_Mayor.ToString.Substring(0, 1)
        decena_arriba = num_Mayor.ToString.Substring(1, 1)
        unidad_arriba = num_Mayor.ToString.Substring(2, 1)


        centena_abajo = num_Menor.ToString.Substring(0, 1)
        decena_abajo = num_Menor.ToString.Substring(1, 1)
        unidad_abajo = num_Menor.ToString.Substring(2, 1)

'.........INICIA CODIGO PARA LA RESTA DE TRES CIFRAS'
            Dim resta_unidades, resta_decenas, resta_centenas, resultado_Final As Integer
            If unidad_arriba >= unidad_abajo Then
                resta_unidades = unidad_arriba - unidad_abajo
                Else

                    unidad_arriba = (1).ToString + unidad_arriba.ToString
                    resta_unidades = unidad_arriba - unidad_abajo
                    decena_abajo = 1 + decena_abajo
            End If
            varGlobales_Resta.unidad_arriba = unidad_arriba 'MANDA LA UNIDAD DE ARRIBA
            varGlobales_Resta.unidad_abajo = unidad_abajo
            varGlobales_Resta.resta_unidad = resta_unidades
            If decena_arriba >= decena_abajo Then
                resta_decenas = decena_arriba - decena_abajo

                    Else
                        decena_arriba = (1).ToString + decena_arriba.ToString
                        resta_decenas = decena_arriba - decena_abajo
                        centena_abajo = 1 + centena_abajo
            End If
                varGlobales_Resta.decena_arriba = decena_arriba
                varGlobales_Resta.decena_abajo = decena_abajo
                varGlobales_Resta.resta_decena = resta_decenas

                If centena_arriba >= centena_abajo Then
                    resta_centenas = centena_arriba - centena_abajo

                End If
                varGlobales_Resta.centena_arriba = centena_arriba
                varGlobales_Resta.centena_abajo = centena_abajo
                varGlobales_Resta.resta_centena = resta_centenas

                resultado_Final = resta_centenas.ToString + resta_decenas.ToString + resta_unidades.ToString
                If resultado_Final = txtResultado.Text Then
                    varGlobales_Resta.result = resultado_Final 'MANDA EL RESULTADO FINAL'
                    varGlobales_Resta.tipo = 1 'CORRECTO'
                    varGlobales_Resta.nivel_comple = 3 'NIVEL 3'
                        Else
                            varGlobales_Resta.result = resultado_Final 'MANDA EL RESULTADO FINAL'
                            varGlobales_Resta.tipo = 2 'INCORRECTO'
                            varGlobales_Resta.nivel_comple = 3 'NIVEL 3'
                End If

        Dim correcto_incorrecto As New frmRESULTADOS_N3()
         correcto_incorrecto.Show()
        Me.Dispose()

End Sub
End Class