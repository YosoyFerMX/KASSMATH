Public Class Frm_RespuestasSumaMixtos2

    Private Sub Frm_RespuestasSumaMixtos2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For x = 0 To VariablesGlob.TamañoMatriz
            Me.DataGridView1.Rows.Add(VariablesGlob.matriz1(x, 0), VariablesGlob.matriz1(x, 1), VariablesGlob.matriz1(x, 2), VariablesGlob.matriz1(x, 3))

        Next x

        Lbl_Ent1.Text = VariablesGlob.Ent1
        Lbl_Ent2.Text = VariablesGlob.Ent2
        Lbl_Ent3.Text = VariablesGlob.Ent3
        Lbl_Num1Mixto.Text = VariablesGlob.Num1Mixto
        Lbl_Num2Mixto.Text = VariablesGlob.Num2Mixto
        Lbl_Num3Mixto.Text = VariablesGlob.Num3Mixto
        Lbl_Den1Mixto.Text = VariablesGlob.Den1
        Lbl_Den2Mixto.Text = VariablesGlob.Den2
        Lbl_Den3Mixto.Text = VariablesGlob.Den3

        Lbl_ProcEnt1.Text = VariablesGlob.Ent1
        Lbl_ProcEnt2.Text = VariablesGlob.Ent2
        Lbl_ProcEnt3.Text = VariablesGlob.Ent3
        Lbl_ProcDen1.Text = VariablesGlob.Den1
        Lbl_ProcDen2.Text = VariablesGlob.Den2
        Lbl_ProcDen3.Text = VariablesGlob.Den3
        Lbl_ProcNum1.Text = VariablesGlob.Num1Mixto
        Lbl_ProcNum2.Text = VariablesGlob.Num2Mixto
        Lbl_ProcNum3.Text = VariablesGlob.Num3Mixto
        Lbl_ProcResp1.Text = VariablesGlob.Num1
        Lbl_ProcResp2.Text = VariablesGlob.Num2
        Lbl_ProcResp3.Text = VariablesGlob.Num3

        Lbl_Den1.Text = VariablesGlob.Den1
        Lbl_Den2.Text = VariablesGlob.Den2
        Lbl_Den3.Text = VariablesGlob.Den3
        Lbl_Num1.Text = VariablesGlob.Num1
        Lbl_Num2.Text = VariablesGlob.Num2
        Lbl_Num3.Text = VariablesGlob.Num3

        Lbl_Mcm.Text = VariablesGlob.mcm


        'PROCESO'
        LblA1.Text = VariablesGlob.mcm
        LblB1.Text = VariablesGlob.mcm
        LblC1.Text = VariablesGlob.mcm

        LblA2.Text = VariablesGlob.Den1
        LblB2.Text = VariablesGlob.Den2
        LblC2.Text = VariablesGlob.Den3

        LblA3.Text = VariablesGlob.mcm / VariablesGlob.Den1
        LblB3.Text = VariablesGlob.mcm / VariablesGlob.Den2
        LblC3.Text = VariablesGlob.mcm / VariablesGlob.Den3

        LblA4.Text = VariablesGlob.Num1
        LblB4.Text = VariablesGlob.Num2
        LblC4.Text = VariablesGlob.Num3

        LblA5.Text = VariablesGlob.Num1 * Val(LblA3.Text)
        LblB5.Text = VariablesGlob.Num2 * Val(LblB3.Text)
        LblC5.Text = VariablesGlob.Num3 * Val(LblC3.Text)


        Lbl_Proc_Den.Text = VariablesGlob.mcm
        Lbl_Proc_Num.Text = Val(LblA5.Text) & " + " & Val(LblB5.Text) & " + " & Val(LblC5.Text)

        Lbl_Respuesta_Den.Text = VariablesGlob.mcm
        Lbl_Respuesta_Num.Text = Val(LblA5.Text) + Val(LblB5.Text) + Val(LblC5.Text)




        If conversion = 1 Then

            lbl_DenMixtoRespuesta.Visible = False
            lbl_NumMixtoRespuesta.Visible = False
            lbl_EnteroMixtoRespuesta.Visible = False
            PictureBox19.Visible = False


            If VariablesGlob.MismoDen = 1 Then
                Label2.Visible = False
                LblA3.Visible = False
                LblB3.Visible = False
                LblA4.Visible = False
                LblA5.Visible = False
                LblB4.Visible = False
                LblB5.Visible = False
                pbx_x_2.Visible = False
                pbx_d_1.Visible = False
                pbx_igual_1.Visible = False
                PictureBox1.Visible = False
                PictureBox10.Visible = False
                PictureBox16.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox8.Visible = False
                PictureBox9.Visible = False
                PictureBox6.Visible = False
                PictureBox7.Visible = False


                Lbl_Proc_Num.Text = VariablesGlob.Num1 & "+" & VariablesGlob.Num2 & "+" & VariablesGlob.Num3
                Lbl_Proc_Den.Text = VariablesGlob.mcm
                Lbl_Respuesta_Num.Text = VariablesGlob.Num1 + VariablesGlob.Num2 + VariablesGlob.Num3
                Lbl_Respuesta_Den.Text = VariablesGlob.mcm

            End If

        Else
            lbl_DenMixtoRespuesta.Text = VariablesGlob.ResDenSimpli
            lbl_NumMixtoRespuesta.Text = VariablesGlob.residuo
            lbl_EnteroMixtoRespuesta.Text = VariablesGlob.entero

        End If

        Lbl_SimpNum.Text = VariablesGlob.RespNumSimpli
        Lbl_SimpDen.Text = VariablesGlob.ResDenSimpli

        If (VariablesGlob.resultado_string_suma_impropias = "MUY BIEN") Then
            gbx_correcto.Visible = True
            gbx_incorrecto.Visible = False
        Else
            gbx_incorrecto.Visible = True
            gbx_correcto.Visible = False
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If VariablesGlob.nivel = 3 Then

            Dim frmMixtasIII As New Frm_Mixtas3
            frmMixtasIII.Show()
            Me.Close()

        ElseIf VariablesGlob.nivel = 4 Then
            Dim frmMixtasIV As New Frm_Mixtas4
            frmMixtasIV.Show()
            Me.Close()

       

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frmMixtasNivFraccPropias As New Mixtas_Niveles
        frmMixtasNivFraccPropias.Show()
        Me.Dispose()
    End Sub
End Class