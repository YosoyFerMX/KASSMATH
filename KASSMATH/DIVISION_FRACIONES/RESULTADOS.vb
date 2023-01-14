Public Class RESULTADOS

Private Sub resultado_impropias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    Dim tipo_operacion As Integer = variables_globales.numero_tipo
'SI LA OPERACION FUE DE PROPIAS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
If (tipo_operacion = 1) Then
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
        gbx_incorrecto.Visible = False
        bx_correcto.Visible = True

    Else '////////////////////////////////////////////////////////////////////////////////////////////////
        gbx_incorrecto.Visible = True
        bx_correcto.Visible = False


    'SACANDO EL MINIMO COMUN DIVISOR
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

        lbl_nume_1.Text = digitos_global_2digitos(0)
        lbl_deno_1.Text = digitos_global_2digitos(1)
        lbl_nume_2.Text = digitos_global_2digitos(2)
        lbl_deno_2.Text = digitos_global_2digitos(3)
        lbl_num_3.Text = digitos_global_2digitos(4)
        lbl_den_3.Text = digitos_global_2digitos(5)
        lbl_num_4.Text = digitos_global_2digitos(4)
        lbl_den_4.Text = digitos_global_2digitos(5)

lbl_num_final.Text = (digitos_global_2digitos(4)) / divisor_comun
lbl_den_final.Text = (digitos_global_2digitos(5)) / divisor_comun
        'SACANDO LA FRACCION MIXTA
        lbl_num_5.Text = lbl_num_final.Text
        lbl_den_5.Text = lbl_den_final.Text

        Dim numerador As Integer = digitos_global_2digitos(4)
        Dim denominador As Integer = digitos_global_2digitos(5)
        Dim n_resultado, entero, residuo, suma_1 As Integer

        If (numerador >= denominador) Then
            n_resultado = numerador / denominador
            entero = n_resultado
            n_resultado = n_resultado * denominador

            If (n_resultado > numerador) Then
                entero = entero - 1
            End If
            suma_1 = entero * denominador

            residuo = numerador - suma_1
            lbl_entero.Text = entero
            lbl_residuo.Text = residuo
            lbl_entero_f.Text = entero
            lbl_num_6.Text = residuo
            lbl_den_6.Text = denominador
        Else
            gbx_mixta_1.Visible = False
            gbx_mixta_2.Visible = False



        End If

    End If
    '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

End If
'SI LA OPERACION FUE DE IMPROPIAS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
If (tipo_operacion = 2) Then

'>> PASOS PARA MOSTRAR PROCEDIMIENTO

'>> PASOS PARA MOSTRAR PROCEDIMIENTO

    If (resultado_string_impropias = "MUY BIEN") Then
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
        gbx_incorrecto.Visible = False
        bx_correcto.Visible = True

    Else '////////////////////////////////////////////////////////////////////////////////////////////////
        gbx_incorrecto.Visible = True
        bx_correcto.Visible = False


    'SACANDO EL MINIMO COMUN DIVISOR
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

        lbl_nume_1.Text = digitos_global_2digitos(0)
        lbl_deno_1.Text = digitos_global_2digitos(1)
        lbl_nume_2.Text = digitos_global_2digitos(2)
        lbl_deno_2.Text = digitos_global_2digitos(3)
        lbl_num_3.Text = digitos_global_2digitos(4)
        lbl_den_3.Text = digitos_global_2digitos(5)
        lbl_num_4.Text = digitos_global_2digitos(4)
        lbl_den_4.Text = digitos_global_2digitos(5)

lbl_num_final.Text = (digitos_global_2digitos(4)) / divisor_comun
lbl_den_final.Text = (digitos_global_2digitos(5)) / divisor_comun
        'SACANDO LA FRACCION MIXTA
        lbl_num_5.Text = lbl_num_final.Text
        lbl_den_5.Text = lbl_den_final.Text

        Dim numerador As Integer = digitos_global_2digitos(4)
        Dim denominador As Integer = digitos_global_2digitos(5)
        Dim n_resultado, entero, residuo, suma_1 As Integer

        If (numerador >= denominador) Then
            n_resultado = numerador / denominador
            entero = n_resultado
            n_resultado = n_resultado * denominador

            If (n_resultado > numerador) Then
                entero = entero - 1
            End If
            suma_1 = entero * denominador

            residuo = numerador - suma_1
            lbl_entero.Text = entero
            lbl_residuo.Text = residuo
            lbl_entero_f.Text = entero
            lbl_num_6.Text = residuo
            lbl_den_6.Text = denominador
        Else
            gbx_mixta_1.Visible = False
            gbx_mixta_2.Visible = False



        End If

    End If
End If
  
'++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
'SI LA OPERACION FUE DE MIXTAS
If (tipo_operacion = 3) Then

'>> PASOS PARA MOSTRAR PROCEDIMIENTO



End If
'++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
End Sub

Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button11.Click
  Dim frm_propias_1 As New EJERCICIO_PROPIAS_1()
        Dim frm_propias_2 As New EJERCICIO_PROPIAS_2()

        'PARA CUANDO SE TENGA QUE REGRESAR A LA VENTANA ANTERIOR DE PROPIAS
       If (nivel_regresar = 1) Then
            frm_propias_1.Show()
            Me.Dispose()
        End If
        If (nivel_regresar = 2) Then
            frm_propias_2.Show()
            Me.Dispose()
        End If

End Sub

Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button8.Click
     Dim frm_niveles_propias As New NIVELES_PROPIAS
frm_niveles_propias.Show()
Me.Dispose()
End Sub

Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
If (nivel_regresar = 1 Or nivel_regresar = 2) Then
    Dim frm_niveles_propias As New NIVELES_PROPIAS
    frm_niveles_propias.Show()
    Me.Dispose()

End If

If (nivel_regresar = 5 Or nivel_regresar = 6) Then
    Dim frm_niveles_impropias As New NIVELES_IMPROPIAS
    frm_niveles_impropias.Show()
    Me.Dispose()

End If


End Sub

Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
       'PARA REGRESAR A LOS NIVELES DE PROPIAS
        Dim frm_propias_1 As New EJERCICIO_PROPIAS_1()
        Dim frm_propias_2 As New EJERCICIO_PROPIAS_2()

        'PARA REGRESAR A LOS NIVELES DE IMPROPIAS
        Dim frm_propias_5 As New EJERCICIO_IMPROPIAS_1()
        Dim frm_propias_6 As New EJERCICIO_IMPROPIAS_2()


        'PARA CUANDO SE TENGA QUE REGRESAR A LA VENTANA ANTERIOR DE PROPIAS
       If (nivel_regresar = 1) Then
            frm_propias_1.Show()
            Me.Dispose()
        End If
        If (nivel_regresar = 2) Then
            frm_propias_2.Show()
            Me.Dispose()
        End If

        If (nivel_regresar = 5) Then
            frm_propias_5.Show()
            Me.Dispose()
        End If
        If (nivel_regresar = 6) Then
            frm_propias_6.Show()
            Me.Dispose()
        End If
End Sub

Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'COMO ES LA ULTIMA VENTANA TODAS LA VARIABLES GLOBALES SE DECLARAN EN 0 O "" RESPECTIVAMENTE
        variables_globales.den_resul_divi_propia = 0
        variables_globales.num_resul_divi_propia = 0
        variables_globales.resultado_string_impropias = ""
        variables_globales.num_resul_divi_impropia = 0
        variables_globales.den_resul_divi_impropia = 0

        'PARA REGRESAR A LOS NIVELES DE PROPIAS
        Dim frm_propias_1 As New EJERCICIO_PROPIAS_1()
        Dim frm_propias_2 As New EJERCICIO_PROPIAS_2()

        'PARA REGRESAR A LOS NIVELES DE IMPROPIAS
        Dim frm_propias_5 As New EJERCICIO_IMPROPIAS_1()
        Dim frm_propias_6 As New EJERCICIO_IMPROPIAS_2()


        'PARA CUANDO SE TENGA QUE REGRESAR A LA VENTANA ANTERIOR DE PROPIAS
       If (nivel_regresar = 1) Then
            frm_propias_1.Show()
            Me.Dispose()
        End If
        If (nivel_regresar = 2) Then
            frm_propias_2.Show()
            Me.Dispose()
        End If

        If (nivel_regresar = 5) Then
            frm_propias_5.Show()
            Me.Dispose()
        End If
        If (nivel_regresar = 6) Then
            frm_propias_6.Show()
            Me.Dispose()
        End If
End Sub

Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
If (nivel_regresar = 1 Or nivel_regresar = 2) Then
    Dim frm_niveles_propias As New NIVELES_PROPIAS
    frm_niveles_propias.Show()
    Me.Dispose()

End If

If (nivel_regresar = 5 Or nivel_regresar = 6) Then
    Dim frm_niveles_impropias As New NIVELES_IMPROPIAS
    frm_niveles_impropias.Show()
    Me.Dispose()

End If
End Sub

Private Sub gbx_incorrecto_Enter(sender As Object, e As EventArgs) Handles gbx_incorrecto.Enter

End Sub

Private Sub bx_correcto_Enter(sender As Object, e As EventArgs) Handles bx_correcto.Enter

End Sub
End Class