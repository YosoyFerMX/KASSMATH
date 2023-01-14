Public Class Frm_Mixtas2

    Private Sub Frm_Mixtas2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Numero_Azar As Integer
        Dim Random As New Random()

        'PRIMER NUMERO FRACCIONARIO'
        Numero_Azar = Random.Next(15, 35)

        Lbl_Den1.Text = Numero_Azar
        Do
            Numero_Azar = Random.Next(10, 20)

        Loop While [Lbl_Den1].Text <= Numero_Azar
        Lbl_Num1.Text = Numero_Azar

        'SEGUNDO NUMERO FRACCIONARIO'
        'PARA QUE LOS DENOMINADORES NO SEAN IGUALES'
        Do
            Numero_Azar = Random.Next(10, 20)

        Loop While [Lbl_Den1].Text = Numero_Azar

        Lbl_Den2.Text = Numero_Azar
        '******'
        Do
            Numero_Azar = Random.Next(10, 20)

        Loop While [Lbl_Den2].Text <= Numero_Azar

        Lbl_Num2.Text = Numero_Azar

        'NUMEROS ENTEROS'

        Numero_Azar = Random.Next(2, 10)
        Lbl_Entero1.Text = Numero_Azar
        Numero_Azar = Random.Next(2, 10)
        Lbl_Entero2.Text = Numero_Azar

        'Guardamos los enteros en variables Globales'
        VariablesGlob.Ent1 = Val(Lbl_Entero1.Text)
        VariablesGlob.Ent2 = Val(Lbl_Entero2.Text)
        VariablesGlob.Num1Mixto = Val(Lbl_Num1.Text)
        VariablesGlob.Num2Mixto = Val(Lbl_Num2.Text)

        'TRANSFORMAMOS MIXTO A FRACCION'
        


        VariablesGlob.Num1 = (Val(Lbl_Den1.Text) * Val(Lbl_Entero1.Text)) + Val(Lbl_Num1.Text)
        VariablesGlob.Num2 = (Val(Lbl_Den2.Text) * Val(Lbl_Entero2.Text)) + Val(Lbl_Num2.Text)
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        VariablesGlob.nivel = 2


        If VariablesGlob.conversion = 1 Then

            'ACEPTA CUALQUIER RESPUESTA SIMPLIFICADA'

            If Val(Txt_Respuesta_Num.Text) / (Val(Txt_Respuesta_Den.Text)) = VariablesGlob.ResultadoNum / VariablesGlob.mcm And VariablesGlob.ProcesoNum1 = Val(Txt_Num1.Text) And VariablesGlob.ProcesoNum2 = Val(Txt_Num2.Text) And Val(Txt_NumInicial1.Text) / Val(Txt_DenInicial1.Text) = (VariablesGlob.Num1 / VariablesGlob.Den1) And Val(Txt_NumInicial2.Text) / Val(Txt_DenInicial2.Text) = (VariablesGlob.Num2 / VariablesGlob.Den2) Then

                VariablesGlob.Hacer = 1
                VariablesGlob.resultado_string_suma_mixtas = "MUY BIEN"



            Else
                VariablesGlob.Hacer = 2
                VariablesGlob.resultado_string_suma_mixtas = ""


            End If

        Else
            'ACEPTA CUALQUIER RESPUESTA SIMPLIFICADA'
            RespMixtoEntrada = ((Val(Txt_Entero.Text) * Val(Txt_NumMixto.Text)) / Val(Txt_DenMixto.Text))

            If Val(Txt_Respuesta_Num.Text) / (Val(Txt_Respuesta_Den.Text)) = (VariablesGlob.ResultadoNum / VariablesGlob.mcm) And VariablesGlob.ProcesoNum1 = Val(Txt_Num1.Text) And VariablesGlob.ProcesoNum2 = Val(Txt_Num2.Text) And VariablesGlob.mcm = Val(Txt_Den.Text) And VariablesGlob.RespMixto = VariablesGlob.RespMixtoEntrada And Val(Txt_NumInicial1.Text) / Val(Txt_DenInicial1.Text) = (VariablesGlob.Num1 / VariablesGlob.Den1) And Val(Txt_NumInicial2.Text) / Val(Txt_DenInicial2.Text) = (VariablesGlob.Num2 / VariablesGlob.Den2) Then

                VariablesGlob.Hacer = 1
                VariablesGlob.resultado_string_suma_impropias = "MUY BIEN"



            Else
                VariablesGlob.Hacer = 2
                VariablesGlob.resultado_string_suma_impropias = ""


            End If



        End If

        Dim frm_MixtasRespuestas As New Frm_RespuestasSumaMixtos
        frm_MixtasRespuestas.Show()
        Me.Close()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim frm_niveles_Mixtas As New Mixtas_Niveles
        frm_niveles_Mixtas.Show()
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm_inicio As New INICIO()
        frm_inicio.Show()
        Me.Dispose()
    End Sub

Private Sub Button1_Click(sender As Object, e As EventArgs)

End Sub
End Class