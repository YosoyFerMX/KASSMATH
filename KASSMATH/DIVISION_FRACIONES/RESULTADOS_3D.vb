Public Class RESULTADOS_3D

Private Sub RESULTADOS_3D_Load(sender As Object, e As EventArgs) Handles MyBase.Load
   Dim tipo_operacion As Integer = variables_globales.numero_tipo
'SI LA OPERACION FUE DE PROPIAS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
If (tipo_operacion = 1) Then
    'lbl_resultado_string.Text = variables_globales.resultado_string_propias
'>> PASOS PARA MOSTRAR PROCEDIMIENTO

    If (resultado_string_propias = "MUY BIEN") Then
    'AQUI SE PONEN TODOS LOS LABEL EN VACIO PARA QUE CUANDO LA RESPUESTA SEA CORRECTA NO SE MUESTRE EL PROCEDIMIENTO
        lbl_nume_1.Text = ""
        lbl_deno_1.Text = ""
        lbl_nume_2.Text = ""
        lbl_deno_2.Text = ""
        lbl_num_3.Text = ""
        lbl_den_3.Text = ""
        lbl_num_4.Text = ""
        lbl_den_4.Text = ""

        lbl_num_final.Text = ""
        lbl_den_final.Text = ""

        lbl_divisor_comun.Text = ""

        lbl_mcd_1.Text = ""
        lbl_mcd_2.Text = ""

       
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    'AQUI TODOS LOS OBJETOS DE PICTUREBOX SE PONEN EN OCULTOS PARA QUE CUANDO LA RESPUESTA SEA CORRECTA DESAPAREZCAN
        gbx_incorrecto.Visible = False
gbx_correcto.Visible = True

    Else '////////////////////////////////////////////////////////////////////////////////////////////////
'SE CAMBIAN LAS PROPIEDADES DE LOS PICTUREBOX CUANDO LA RESPUESTA ES INCORRECTA
  
    lbl_nume_1.Text = digitos_global_3digitos(0)
            lbl_deno_1.Text = digitos_global_3digitos(1)
            lbl_nume_2.Text = digitos_global_3digitos(2)
            lbl_deno_2.Text = digitos_global_3digitos(3)
            lbl_num_3.Text = digitos_global_3digitos(4)
            lbl_den_3.Text = digitos_global_3digitos(5)
            lbl_res_n.Text = digitos_global_3digitos(6)
            lbl_res_d.Text = digitos_global_3digitos(7)

            lbl_num_4.Text = digitos_global_3digitos(6)
            lbl_den_4.Text = digitos_global_3digitos(7)

            lbl_num_final.Text = variables_globales.num_resul_divi_propia
            lbl_den_final.Text = variables_globales.den_resul_divi_propia
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
gbx_incorrecto.Visible = True
gbx_correcto.Visible = False
    Dim divisor_comun As Integer = 1
    Dim divisor As Integer
    Dim vueltas As Integer = arreglo_comun_multiplo(0)
    Dim contador As Integer = 1
    Do While (contador < vueltas)
    divisor = arreglo_comun_multiplo(contador)
    divisor_comun = divisor_comun * divisor
    contador = contador + 1
    Loop

    lbl_divisor_comun.Text = divisor_comun

    lbl_mcd_1.Text = divisor_comun
    lbl_mcd_2.Text = divisor_comun

    End If
    '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

End If
'SI LA OPERACION FUE DE IMPROPIAS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
If (tipo_operacion = 2) Then
    lbl_resultado_string.Text = variables_globales.resultado_string_impropias
'>> PASOS PARA MOSTRAR PROCEDIMIENTO

End If
'++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
'SI LA OPERACION FUE DE MIXTAS
If (tipo_operacion = 3) Then
    lbl_resultado_string.Text = variables_globales.resultado_string_mixtas
'>> PASOS PARA MOSTRAR PROCEDIMIENTO

End If
End Sub





Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
  Dim frm_niveles_propias As New NIVELES_PROPIAS()
frm_niveles_propias.Show()
Me.Dispose()
End Sub

Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

End Sub

Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim frm_propias_3 As New EJERCICIO_PROPIAS_3()
        Dim frm_propias_4 As New EJERCICIO_PROPIAS_4()

        'PARA CUANDO SE TENGA QUE REGRESAR A LA VENTANA ANTERIOR DE PROPIAS

        If (nivel_regresar = 3) Then
                    frm_propias_3.Show()
                    Me.Dispose()
        End If
        If (nivel_regresar = 4) Then
                    frm_propias_4.Show()
                    Me.Dispose()
        End If
End Sub


Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim frm_propias_3 As New EJERCICIO_PROPIAS_3()
        Dim frm_propias_4 As New EJERCICIO_PROPIAS_4()

        'PARA CUANDO SE TENGA QUE REGRESAR A LA VENTANA ANTERIOR DE PROPIAS

        If (nivel_regresar = 3) Then
                    frm_propias_3.Show()
                    Me.Dispose()
        End If
        If (nivel_regresar = 4) Then
                    frm_propias_4.Show()
                    Me.Dispose()
        End If
End Sub

Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
    Dim frm_niveles_propias As New NIVELES_PROPIAS()
frm_niveles_propias.Show()
Me.Dispose()
End Sub
End Class