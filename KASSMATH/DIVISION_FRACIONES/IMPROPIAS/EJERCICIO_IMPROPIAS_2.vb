Public Class EJERCICIO_IMPROPIAS_2

Private Sub EJERCICIO_IMPROPIAS_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim numero_random As New Random


Dim numerador_1 As Integer = numero_random.Next(10, 30)
Dim divisor_1 As Integer = numero_random.Next(2, 20)
Dim numerador_2 As Integer = numero_random.Next(10, 30)
Dim divisor_2 As Integer = numero_random.Next(2, 20)


'>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

'CICLO PARA DEJAR LOS NUMERADORES MAS CHICOS QUE LO DENOMINADORES
Do While (numerador_1 <= divisor_1 Or numerador_2 <= divisor_2 Or divisor_1 = divisor_2)
'Or divisor_1 = divisor_2

If (numerador_1 <= divisor_1) Then
numerador_1 = numero_random.Next(10, 30)
End If

If (numerador_2 <= divisor_2) Then
numerador_2 = numero_random.Next(10, 30)
End If
If (divisor_1 = divisor_2) Then
divisor_1 = numero_random.Next(2, 20)

End If
Loop

    lbl_n1.Text = numerador_1
    lbl_d1.Text = divisor_1
    lbl_n2.Text = numerador_2
    lbl_d2.Text = divisor_2
'ARREGLO GLOBAL PARA GUARDAR LOS DIGITOS DE LAS FRACCIONES Y MOSTRARLAS DESPUES EN EL FORM RESULTADO
    digitos_global_2digitos(0) = numerador_1
    digitos_global_2digitos(1) = divisor_1
    digitos_global_2digitos(2) = numerador_2
    digitos_global_2digitos(3) = divisor_2

'AQUI COMIENZA EL PROCESO PARA RESOLVER LA DIVISION}
Dim numerador_resultado As Integer = numerador_1 * divisor_2
Dim denominador_resultado As Integer = divisor_1 * numerador_2

digitos_global_2digitos(4) = numerador_resultado
digitos_global_2digitos(5) = denominador_resultado


'CICLO PARA SABER SI LA FRACCIÓN SE PUEDE SIMPLIFICAR>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
Dim numerador_resultado_2 As Integer = numerador_resultado
Dim denominador_resultado_2 As Integer = denominador_resultado

'CONDICIONAL PARA SABER SI TENEMOS QUE MOSTRAR LA PARTE DE CONVERSION A MIXTA
If (numerador_resultado <= denominador_resultado Or numerador_resultado Mod denominador_resultado = 0) Then
gbx_mixta.Visible = False

End If


'>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

Dim interruptor As Integer = 1
Dim contador_vueltas = 1
Do While (interruptor = 1)
'>>>>>>>>>>>>> FALTA SACAR EL MINIMO COMUN MULTIPLO PARA DESPUES GUARDARLO Y MOSTRARLO EN EL FORM DE RESULTADOS
    If (numerador_resultado_2 Mod 2 = 0 And denominador_resultado_2 Mod 2 = 0 Or numerador_resultado_2 Mod 3 = 0 And denominador_resultado_2 Mod 3 = 0 Or numerador_resultado_2 Mod 5 = 0 And denominador_resultado_2 Mod 5 = 0 Or numerador_resultado_2 Mod 7 = 0 And denominador_resultado_2 Mod 7 = 0 Or numerador_resultado_2 Mod 9 = 0 And denominador_resultado_2 Mod 9 = 0) Then
        'SI ES MULTIPLO DE 9
        If (numerador_resultado_2 Mod 9 = 0 And denominador_resultado_2 Mod 9 = 0) Then
            numerador_resultado_2 = numerador_resultado_2 / 9
            denominador_resultado_2 = denominador_resultado_2 / 9
            'SE GUARDA EL NUMERO POR EL CUAL FUE DIVIDO PARA DESPUES MULTIPLICARLO
            arreglo_comun_multiplo(contador_vueltas) = 9
            contador_vueltas = contador_vueltas + 1
        End If
        'SI ES MULTIPLO DE 7
        If (numerador_resultado_2 Mod 7 = 0 And denominador_resultado_2 Mod 7 = 0) Then
            numerador_resultado_2 = numerador_resultado_2 / 7
            denominador_resultado_2 = denominador_resultado_2 / 7
            'SE GUARDA EL NUMERO POR EL CUAL FUE DIVIDO PARA DESPUES MULTIPLICARLO
            arreglo_comun_multiplo(contador_vueltas) = 7
            contador_vueltas = contador_vueltas + 1
        End If
        'SI ES MULTIPLO DE 5
        If (numerador_resultado_2 Mod 5 = 0 And denominador_resultado_2 Mod 5 = 0) Then
            numerador_resultado_2 = numerador_resultado_2 / 5
            denominador_resultado_2 = denominador_resultado_2 / 5
            'SE GUARDA EL NUMERO POR EL CUAL FUE DIVIDO PARA DESPUES MULTIPLICARLO
            arreglo_comun_multiplo(contador_vueltas) = 5
            contador_vueltas = contador_vueltas + 1
        End If
        'SI ES MULTIPLO DE 3
        If (numerador_resultado_2 Mod 3 = 0 And denominador_resultado_2 Mod 3 = 0) Then
            numerador_resultado_2 = numerador_resultado_2 / 3
            denominador_resultado_2 = denominador_resultado_2 / 3
            'SE GUARDA EL NUMERO POR EL CUAL FUE DIVIDO PARA DESPUES MULTIPLICARLO
            arreglo_comun_multiplo(contador_vueltas) = 3
            contador_vueltas = contador_vueltas + 1
        End If
        'SI ES MULTIPLO DE 2
        If (numerador_resultado_2 Mod 2 = 0 And denominador_resultado_2 Mod 2 = 0) Then
            numerador_resultado_2 = numerador_resultado_2 / 2
            denominador_resultado_2 = denominador_resultado_2 / 2
            'SE GUARDA EL NUMERO POR EL CUAL FUE DIVIDO PARA DESPUES MULTIPLICARLO
            arreglo_comun_multiplo(contador_vueltas) = 2
            contador_vueltas = contador_vueltas + 1
        End If
    Else
    interruptor = 0
    End If

Loop
arreglo_comun_multiplo(contador_vueltas + 1) = numerador_resultado_2
arreglo_comun_multiplo(contador_vueltas + 2) = denominador_resultado_2
'EN LA PRIMERA POCISION SE GUARDA EN CONTADOR DE VUELTAS, PARA USAR ESE PARAMETRO DESPUES EN UN CICLO
arreglo_comun_multiplo(0) = contador_vueltas
nivel_regresar = 6

'>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
'AQUI SE GUARDAN LAS CIFRAS DE LA FRACCIÓN SIMPLIFICADA EN VARIABLES GLOBALES
variables_globales.num_resul_divi_impropia = numerador_resultado
variables_globales.den_resul_divi_impropia = denominador_resultado


'>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
End Sub

Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
   Dim numerador_ingresado As Double = tbx_numerador.Text
Dim denominador_ingresado As Double = tbx_denominador.Text

Dim numerador_2 As Double = digitos_global_2digitos(4)
    Dim denominador_2 As Double = digitos_global_2digitos(5)

Dim division_fraccion_mixta As Double = 0


'FRACCION MIXTA
If numerador_2 > denominador_2 Then
    numerador_2 = tbx_numerador_2.Text
    denominador_2 = tbx_denominador_2.Text
entero = tbx_entero.Text

division_fraccion_mixta = entero * denominador_2 + numerador_2
division_fraccion_mixta = division_fraccion_mixta / denominador_2

Else
     numerador_2 = 1
    denominador_2 = 1
End If
''
'<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
Dim numerador_guardado As Double = Double.Parse(variables_globales.num_resul_divi_impropia)
Dim denominador_guardado As Double = Double.Parse(variables_globales.den_resul_divi_impropia)

Dim division_fraccion_1 As Double = numerador_guardado / denominador_guardado
Dim division_fraccion_2 As Double = numerador_ingresado / denominador_ingresado


If (numerador_guardado > denominador_guardado) Then
    Dim entero As Double = tbx_entero.Text

    If (division_fraccion_1 = division_fraccion_2 And division_fraccion_1 = division_fraccion_mixta) Then
        variables_globales.resultado_string_impropias = "MUY BIEN"
    Else
        variables_globales.resultado_string_impropias = "RESPUESTA INCORRECTA"
    End If
Else
If (division_fraccion_1 = division_fraccion_2) Then
        variables_globales.resultado_string_impropias = "MUY BIEN"
    Else
        variables_globales.resultado_string_impropias = "RESPUESTA INCORRECTA"
    End If

End If

Dim tipo As Integer = 2
variables_globales.numero_tipo = tipo


Dim frm_resultado As New RESULTADOS()
frm_resultado.Show()
Me.Dispose()
End Sub

Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
     Dim niveles_impropias As New NIVELES_IMPROPIAS()
    niveles_impropias.Show()
    Me.Dispose()
End Sub

Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    Dim inicio As New INICIO()
inicio.Show()
Me.Dispose()
End Sub
End Class