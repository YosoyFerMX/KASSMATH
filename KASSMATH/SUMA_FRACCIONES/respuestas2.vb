Public Class respuestas2

    Private Sub respuestas2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For x = 0 To VariablesGlob.TamañoMatriz
            Me.DataGridView1.Rows.Add(VariablesGlob.matriz1(x, 0), VariablesGlob.matriz1(x, 1), VariablesGlob.matriz1(x, 2), VariablesGlob.matriz1(x, 3))

        Next x

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

        LblA5.Text = VariablesGlob.ProcesoNum1
        LblB5.Text = VariablesGlob.ProcesoNum2
        LblC5.Text = VariablesGlob.ProcesoNum3


        Lbl_Proc_Den.Text = VariablesGlob.mcm
        Lbl_Proc_Num.Text = VariablesGlob.ProcesoNum1 & " + " & VariablesGlob.ProcesoNum2 & " + " & VariablesGlob.ProcesoNum3

        Lbl_Respuesta_Den.Text = VariablesGlob.mcm
        Lbl_Respuesta_Num.Text = VariablesGlob.ProcesoNum1 + VariablesGlob.ProcesoNum2 + VariablesGlob.ProcesoNum3




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






Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
         Dim frmImPropiasNivFraccPropias As New Impropias_Niveles
        frmImPropiasNivFraccPropias.Show()
        Me.Dispose()
End Sub

Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim frmImPropiasNivFraccPropias As New Impropias_Niveles
        frmImPropiasNivFraccPropias.Show()
        Me.Dispose()
End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub gbx_incorrecto_Enter(sender As Object, e As EventArgs) Handles gbx_incorrecto.Enter

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If VariablesGlob.nivel = True Then

            Dim frm_ImPropiasIII As New Impropias3
            frm_ImPropiasIII.Show()
            Me.Close()

        Else
            Dim frm_ImPropiasIV As New Impropias4
            frm_ImPropiasIV.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If VariablesGlob.nivel = True Then

            Dim frmImPropiasIII As New Impropias3
            frmImPropiasIII.Show()
            Me.Close()

        Else
            Dim frmImPropiasIV As New Impropias4
            frmImPropiasIV.Show()
            Me.Close()
        End If
    End Sub
End Class