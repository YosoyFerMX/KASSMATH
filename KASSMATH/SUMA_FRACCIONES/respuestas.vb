Public Class respuestas

    Private Sub respuestas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Lbl_Den1.Text = VariablesGlob.Den1
        Lbl_Den2.Text = VariablesGlob.Den2
        Lbl_Num1.Text = VariablesGlob.Num1
        Lbl_Num2.Text = VariablesGlob.Num2

        Lbl_Mcm.Text = VariablesGlob.mcm


        'PROCESO'
 
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

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim frmMenuSuma As New INICIO

        frmMenuSuma.Show()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub


Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
         Dim frmImPropiasNivFraccPropias As New Impropias_Niveles
        frmImPropiasNivFraccPropias.Show()
        Me.Dispose()
End Sub

Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
         Dim frmImPropiasNivFraccPropias As New Impropias_Niveles
        frmImPropiasNivFraccPropias.Show()
        Me.Dispose()
End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If VariablesGlob.nivel = True Then

            Dim frmImPropias As New Impropias
            frmImPropias.Show()
            Me.Close()

        Else
            Dim frmImPropiasI As New Impropias2
            frmImPropiasI.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If VariablesGlob.nivel = True Then

            Dim frmImPropias As New Impropias
            frmImPropias.Show()
            Me.Close()

        Else
            Dim frmImPropiasI As New Impropias2
            frmImPropiasI.Show()
            Me.Close()
        End If
    End Sub
End Class