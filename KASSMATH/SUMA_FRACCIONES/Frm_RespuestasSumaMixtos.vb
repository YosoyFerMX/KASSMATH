Public Class Frm_RespuestasSumaMixtos

    Private Sub Frm_RespuestasSumaMixtos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_Den1.Text = VariablesGlob.Den1
        Lbl_Den2.Text = VariablesGlob.Den2
        Lbl_Num1.Text = VariablesGlob.Num1
        Lbl_Num2.Text = VariablesGlob.Num2

        Lbl_Mcm.Text = VariablesGlob.mcm


        'PROCESO'

        Lbl_Den1Mixto.Text = VariablesGlob.Den1
        Lbl_Den2Mixto.Text = VariablesGlob.Den2
        Lbl_Entero1Mixto.Text = VariablesGlob.Ent1
        Lbl_Entero2Mixto.Text = VariablesGlob.Ent2
        Lbl_Num1Mixto.Text = VariablesGlob.Num1Mixto
        Lbl_Num2Mixto.Text = VariablesGlob.Num2Mixto

        Lbl_ProcEnt1.Text = VariablesGlob.Ent1
        Lbl_ProcEnt2.Text = VariablesGlob.Ent2
        Lbl_ProcDen1.Text = VariablesGlob.Den1
        Lbl_ProcDen2.Text = VariablesGlob.Den2
        Lbl_ProcNum1.Text = VariablesGlob.Num1Mixto
        Lbl_ProcNum2.Text = VariablesGlob.Num2Mixto
        Lbl_ProcResp1.Text = VariablesGlob.Num1
        Lbl_ProcResp2.Text = VariablesGlob.Num2


        LblA3.Text = VariablesGlob.Num1
        LblB3.Text = VariablesGlob.Num2

        LblA4.Text = VariablesGlob.Den2
        LblB4.Text = VariablesGlob.Den1

        LblA5.Text = VariablesGlob.ProcesoNum1
        LblB5.Text = VariablesGlob.ProcesoNum2


        Lbl_Proc_Den.Text = VariablesGlob.Den1 & " * " & VariablesGlob.Den2
        Lbl_Proc_Num.Text = VariablesGlob.ProcesoNum1 & " + " & VariablesGlob.ProcesoNum2

        Lbl_Respuesta_Den.Text = VariablesGlob.mcm
        Lbl_Respuesta_Num.Text = VariablesGlob.ProcesoNum1 + VariablesGlob.ProcesoNum2


        Lbl_SimpDen.Text = VariablesGlob.ResDenSimpli
        Lbl_SimpNum.Text = VariablesGlob.RespNumSimpli




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
                pbx_igual_1.Visible = False
                PictureBox1.Visible = False
                PictureBox2.Visible = False


                Lbl_Proc_Num.Text = VariablesGlob.Num1 & "+" & VariablesGlob.Num2
                Lbl_Proc_Den.Text = VariablesGlob.mcm
                Lbl_Respuesta_Num.Text = VariablesGlob.Num1 + VariablesGlob.Num2
                Lbl_Respuesta_Den.Text = VariablesGlob.mcm

            End If

        Else
            lbl_DenMixtoRespuesta.Text = VariablesGlob.ResDenSimpli
            lbl_NumMixtoRespuesta.Text = VariablesGlob.residuo
            lbl_EnteroMixtoRespuesta.Text = VariablesGlob.entero

        End If





        If (VariablesGlob.resultado_string_suma_impropias = "MUY BIEN") Then
            gbx_correcto.Visible = True
            gbx_incorrecto.Visible = False
        Else
            gbx_incorrecto.Visible = True
            gbx_correcto.Visible = False
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If VariablesGlob.nivel = 1 Then

            Dim frmMixtas As New Frm_Mixtas1
            frmMixtas.Show()
            Me.Close()

        ElseIf VariablesGlob.nivel = 2 Then
            Dim frmMixtasII As New Frm_Mixtas2
            frmMixtasII.Show()
            Me.Close()

        ElseIf VariablesGlob.nivel = 3 Then
            Dim frmMixtasIII As New Frm_Mixtas3
            frmMixtasIII.Show()
            Me.Close()

        ElseIf VariablesGlob.nivel = 4 Then
            Dim frmMixtasIV As New Frm_Mixtas4
            frmMixtasIV.Show()
            Me.Close()

        
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frmMixtasNivFraccPropias As New Mixtas_Niveles
        frmMixtasNivFraccPropias.Show()
        Me.Dispose()
    End Sub

    Private Sub gbx_incorrecto_Enter(sender As Object, e As EventArgs) Handles gbx_incorrecto.Enter

    End Sub
End Class