﻿Public Class Frm_Propias1

    Private Sub Frm_Propias1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'SE CONDICIONA PARA MOSTRAR EL BOTON DE CONTINUAR O NO

Dim mostrar_boton As Integer
mostrar_boton = VariablesGlob.exa_si_no

btn_continuar.Visible = False


If (mostrar_boton = 1) Then
btn_continuar.Visible = True
btn_verificar.Visible = False


End If


      Dim Numero_Azar As Integer
        Dim Random As New Random()

        'PRIMER NUMERO FRACCIONARIO'
        Numero_Azar = Random.Next(4, 10)

        Lbl_Den1.Text = Numero_Azar
        Do
            Numero_Azar = Random.Next(1, 5)

        Loop While [Lbl_Den1].Text <= Numero_Azar
        Lbl_Num1.Text = Numero_Azar

        'SEGUNDO NUMERO FRACCIONARIO'
        'PARA QUE LOS DENOMINADORES NO SEAN IGUALES'
        Do
            Numero_Azar = Random.Next(1, 10)

        Loop While [Lbl_Den1].Text = Numero_Azar

        Lbl_Den2.Text = Numero_Azar
        '******'
        Do
            Numero_Azar = Random.Next(1, 10)

        Loop While [Lbl_Den2].Text <= Numero_Azar

        Lbl_Num2.Text = Numero_Azar

        VariablesGlob.Num1 = Val(Lbl_Num1.Text)
        VariablesGlob.Num2 = Val(Lbl_Num2.Text)
        VariablesGlob.Den1 = Val(Lbl_Den1.Text)
        VariablesGlob.Den2 = Val(Lbl_Den2.Text)


        'MCM'''''''''''''''''''''''''''''''''''' Y EVALUAMOS SI TIENEN EL MISMO DENOMINADOR

        If VariablesGlob.Den1 = VariablesGlob.Den2 Then
            VariablesGlob.mcm = VariablesGlob.Den1

            VariablesGlob.ProcesoNum1 = VariablesGlob.Num1
            VariablesGlob.ProcesoNum2 = VariablesGlob.Num2
            VariablesGlob.ResultadoNum = VariablesGlob.ProcesoNum1 + VariablesGlob.ProcesoNum2

            VariablesGlob.MismoDen = 1
        Else
            VariablesGlob.mcm = VariablesGlob.Den1 * VariablesGlob.Den2

            VariablesGlob.ProcesoNum1 = VariablesGlob.Num1 * VariablesGlob.Den2
            VariablesGlob.ProcesoNum2 = VariablesGlob.Num2 * VariablesGlob.Den1
            VariablesGlob.ResultadoNum = VariablesGlob.ProcesoNum1 + VariablesGlob.ProcesoNum2

        End If



        'SIMPLIFICANDO'

        respDeno = VariablesGlob.mcm
        respNum = VariablesGlob.ResultadoNum



        Dim interruptor As Integer = 1
        Do While (interruptor = 1)
            If (respNum Mod 2 = 0 And respDeno Mod 2 = 0 Or respNum Mod 3 = 0 And respDeno Mod 3 = 0 Or respNum Mod 5 = 0 And respDeno Mod 5 = 0) Then
                'SI ES MULTIPLO DE 2
                If (respNum Mod 2 = 0 And respDeno Mod 2 = 0) Then
                    respNum = respNum / 2
                    respDeno = respDeno / 2
                End If
                'SI ES MULTIPLO DE 3
                If (respNum Mod 3 = 0 And respDeno Mod 3 = 0) Then
                    respNum = respNum / 3
                    respDeno = respDeno / 3
                End If
                'SI ES MULTIPLO DE 5
                If (respNum Mod 5 = 0 And respDeno Mod 5 = 0) Then
                    respNum = respNum / 5
                    respDeno = respDeno / 5
                End If
                'SI ES UN ENTERO
                If (respNum = respDeno) Then
                    respNum = 1
                    respDeno = 1
                End If
            Else
                interruptor = 0
            End If
        Loop

        VariablesGlob.RespNumSimpli = respNum
        VariablesGlob.ResDenSimpli = respDeno

        'conversion a MIXTO'

        VariablesGlob.comprobar = VariablesGlob.RespNumSimpli / VariablesGlob.ResDenSimpli
        If (VariablesGlob.comprobar = VariablesGlob.RespNumSimpli) Or (VariablesGlob.ResDenSimpli >= VariablesGlob.RespNumSimpli) Then
            Txt_DenMixto.Visible = False
            Txt_Entero.Visible = False
            Txt_NumMixto.Visible = False
            PictureBox8.Visible = False

            conversion = 1

        Else
            VariablesGlob.entero = VariablesGlob.RespNumSimpli / VariablesGlob.ResDenSimpli
            VariablesGlob.analizando = VariablesGlob.entero * VariablesGlob.ResDenSimpli
            If VariablesGlob.analizando > VariablesGlob.RespNumSimpli Then
                VariablesGlob.entero = VariablesGlob.entero - 1
            Else
                VariablesGlob.entero = VariablesGlob.entero
            End If
            VariablesGlob.residuo = VariablesGlob.RespNumSimpli Mod VariablesGlob.ResDenSimpli
            conversion = 2
            RespMixto = (VariablesGlob.entero * VariablesGlob.residuo) / VariablesGlob.ResDenSimpli
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_verificar.Click
        VariablesGlob.nivel = 3
            If VariablesGlob.conversion = 1 Then
                'ACEPTA CUALQUIER RESPUESTA SIMPLIFICADA'
                If Val(Txt_Respuesta_Num.Text) / (Val(Txt_Respuesta_Den.Text)) = VariablesGlob.ResultadoNum / VariablesGlob.mcm And VariablesGlob.ProcesoNum1 = Val(Txt_Num1.Text) And VariablesGlob.ProcesoNum2 = Val(Txt_Num2.Text) Then
                    VariablesGlob.Hacer = 1
                    VariablesGlob.resultado_string_suma_impropias = "MUY BIEN"
                Else
                    VariablesGlob.Hacer = 2
                    VariablesGlob.resultado_string_suma_impropias = ""
                End If
            Else
                'ACEPTA CUALQUIER RESPUESTA SIMPLIFICADA'
                RespMixtoEntrada = ((Val(Txt_Entero.Text) * Val(Txt_NumMixto.Text)) / Val(Txt_DenMixto.Text))
                If Val(Txt_Respuesta_Num.Text) / (Val(Txt_Respuesta_Den.Text)) = (VariablesGlob.ResultadoNum / VariablesGlob.mcm) And VariablesGlob.ProcesoNum1 = Val(Txt_Num1.Text) And VariablesGlob.ProcesoNum2 = Val(Txt_Num2.Text) And VariablesGlob.mcm = Val(Txt_Den.Text) And VariablesGlob.RespMixto = VariablesGlob.RespMixtoEntrada Then
                    VariablesGlob.Hacer = 1
                    VariablesGlob.resultado_string_suma_impropias = "MUY BIEN"
                Else
                    VariablesGlob.Hacer = 2
                    VariablesGlob.resultado_string_suma_impropias = ""
                End If
            End If

            Dim frmRespuestas As New respuestas
            frmRespuestas.Show()
            Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm_inicio As New INICIO
        frm_inicio.Show()
        Me.Dispose()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim frm_niveles_propias As New Frm_NivelesPropias
        frm_niveles_propias.Show()
        Me.Dispose()
    End Sub

Private Sub Button1_Click(sender As Object, e As EventArgs)

Dim frm_impropias_1 As New Impropias()
    frm_impropias_1.Show()
    Me.Dispose()
End Sub

Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_continuar.Click
   VariablesGlob.nivel = 3
            If VariablesGlob.conversion = 1 Then
                'ACEPTA CUALQUIER RESPUESTA SIMPLIFICADA'
                If Val(Txt_Respuesta_Num.Text) / (Val(Txt_Respuesta_Den.Text)) = VariablesGlob.ResultadoNum / VariablesGlob.mcm And VariablesGlob.ProcesoNum1 = Val(Txt_Num1.Text) And VariablesGlob.ProcesoNum2 = Val(Txt_Num2.Text) Then
                    VariablesGlob.Hacer = 1
                    VariablesGlob.resultado_string_suma_impropias = "MUY BIEN"
                     'EL RESULTADO SE GUARDA EN UNA VARIABLE GLOBAL PARA CONTABILIZARLA AL FINAL
                VariablesGlob.numero_correcta = 1 + VariablesGlob.numero_correcta
                Else
                    VariablesGlob.Hacer = 2
                    VariablesGlob.resultado_string_suma_impropias = ""
                    VariablesGlob.numero_incorrecta = 1 + VariablesGlob.numero_incorrecta
                End If
            Else
                'ACEPTA CUALQUIER RESPUESTA SIMPLIFICADA'
                RespMixtoEntrada = ((Val(Txt_Entero.Text) * Val(Txt_NumMixto.Text)) / Val(Txt_DenMixto.Text))
                If Val(Txt_Respuesta_Num.Text) / (Val(Txt_Respuesta_Den.Text)) = (VariablesGlob.ResultadoNum / VariablesGlob.mcm) And VariablesGlob.ProcesoNum1 = Val(Txt_Num1.Text) And VariablesGlob.ProcesoNum2 = Val(Txt_Num2.Text) And VariablesGlob.mcm = Val(Txt_Den.Text) And VariablesGlob.RespMixto = VariablesGlob.RespMixtoEntrada Then
                    VariablesGlob.Hacer = 1
                    VariablesGlob.resultado_string_suma_impropias = "MUY BIEN"
                     'EL RESULTADO SE GUARDA EN UNA VARIABLE GLOBAL PARA CONTABILIZARLA AL FINAL
                VariablesGlob.numero_correcta = 1 + VariablesGlob.numero_correcta
                Else
                    VariablesGlob.Hacer = 2
                    VariablesGlob.resultado_string_suma_impropias = ""
                     'EL RESULTADO SE GUARDA EN UNA VARIABLE GLOBAL PARA CONTABILIZARLA AL FINAL
                VariablesGlob.numero_incorrecta = 1 + VariablesGlob.numero_incorrecta
                End If
            End If

       'SE LE ASGINA UN 1 PARA QUE LA PROXIMA VEZ SE LE AÑADA 1 Y ENTONCES SERA 2, LO QUE ME PASARÁ A OTRA PANTALLA

        VariablesGlob.contador_propia = VariablesGlob.contador_propia + 1

        If (VariablesGlob.contador_propia = 1 Or VariablesGlob.contador_propia = 2) Then
            Dim frm_pregunta_2_4 As New Impropias()
            frm_pregunta_2_4.Show()
            Me.Dispose()
        End If

        If (VariablesGlob.contador_impropia = 2) Then
            Dim frm_pregunta_5 As New Frm_Mixtas1()
            frm_pregunta_5.Show()
            Me.Dispose()

        End If


End Sub
End Class