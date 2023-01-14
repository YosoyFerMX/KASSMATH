Public Class frmEJERCICIOS_RESTA_N2
    Dim Num_aleatorios As New Random
    Dim num_Mayor As Integer
    Dim num_Menor As Integer
Private Sub frmEJERCICIOS_RESTA_N2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
          num_Mayor = Num_aleatorios.Next(15, 99)
        num_Menor = Num_aleatorios.Next(2, num_Mayor)

        lblNum_Mayor.Text = num_Mayor
        lblNum_Menor.Text = num_Menor
        varGlobales_Resta.num_May = num_Mayor
        varGlobales_Resta.num_Men = num_Menor
End Sub

Private Sub btnVerificar_resta_Click(sender As Object, e As EventArgs) Handles btnVerificar_resta.Click
            'Comienza resta 2 DIGITOS'
            Dim longitud_digitos_arriba As Integer = Len(num_Mayor.ToString)
            Dim longitud_digitos_abajo As Integer = Len(num_Menor.ToString)
             Dim digito_verificador_numabajo As Integer '------'
            Dim digito_verificador_numarriba As Integer = num_Mayor.ToString.Substring(longitud_digitos_arriba - 1, longitud_digitos_arriba - 1)

            If longitud_digitos_abajo < 2 Then
                digito_verificador_numabajo = num_Menor.ToString.Substring(0, 1)
                Else : digito_verificador_numabajo = num_Menor.ToString.Substring(longitud_digitos_abajo - 1, longitud_digitos_abajo - 1)
            End If

            If digito_verificador_numarriba > digito_verificador_numabajo Then
                    Dim resultado_resta_facil As Integer = num_Mayor - num_Menor
                        If resultado_resta_facil = txtResultado.Text Then
                            varGlobales_Resta.tipo = 1 'Si es uno es correcto
                            varGlobales_Resta.nivel_comple = 2 'NIVEL 2
                                Else
                                    varGlobales_Resta.tipo = 2 'Si es uno es incorrecto
                                    varGlobales_Resta.nivel_comple = 2 'NIVEL 2
                                    varGlobales_Resta.caso = 1 'CASO UNO DONDE LA UNIDAD DE ARRIBA ES MAYOR'
                                    varGlobales_Resta.result = resultado_resta_facil
                    End If
            End If

             If digito_verificador_numarriba < digito_verificador_numabajo Then
                    varGlobales_Resta.unidad_abajo = digito_verificador_numabajo 'LLEVA LA UNIDAD DE ABAJO'
                    Dim resta_primer_digito As Integer
                    digito_verificador_numarriba = (1).ToString + digito_verificador_numarriba.ToString
                    varGlobales_Resta.unidad_arriba = digito_verificador_numarriba 'MANDA LA UNIDAD CON EL 1
                    resta_primer_digito = digito_verificador_numarriba - digito_verificador_numabajo

                Dim digito_verificador_numarriba2 As Integer = num_Mayor.ToString.Substring(0, 1)
                     Dim digito_verificador_numabajo2 As Integer
                    If longitud_digitos_abajo = 2 Then
                      digito_verificador_numabajo2 = num_Menor.ToString.Substring(0, 1)
                        Else : digito_verificador_numabajo2 = 0
                End If

                    varGlobales_Resta.decena_arriba = digito_verificador_numarriba2 'LLEVA LA DECENA DE ARRIBA'

                    Dim resta_segundo_digito As Integer
                    resta_segundo_digito = digito_verificador_numarriba2 - (1 + digito_verificador_numabajo2)
                    varGlobales_Resta.decena_abajo = 1 + digito_verificador_numabajo2
                Dim resultado_final As Integer = resta_segundo_digito.ToString + resta_primer_digito.ToString

                    If resultado_final = txtResultado.Text Then
                        varGlobales_Resta.tipo = 1
                        varGlobales_Resta.nivel_comple = 2

                            Else
                                varGlobales_Resta.tipo = 2 'INCORRECTO'
                                varGlobales_Resta.nivel_comple = 2
                                varGlobales_Resta.caso = 2 'CASO UNO DONDE LA UNIDAD DE ARRIBA ES MENOR'
                                varGlobales_Resta.result = resultado_final
                    End If
             End If



        Dim correcto_incorrecto As New frmRESULTADOS_N2()
         correcto_incorrecto.Show()
Me.Dispose()
End Sub

Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
       Dim frm_regresar_niveles As New RESTA_NATURALES
frm_regresar_niveles.Show()
Me.Dispose()
End Sub

Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
       Dim inicio As New INICIO
inicio.Show()
Me.Close()
End Sub
End Class