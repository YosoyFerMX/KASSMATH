Public Class frmN2Propias

    Private Sub frmN2Propias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim n1, n2, n3, n4 As New Random
        Dim fracc1, fracc2 As Double
        Dim azarpro1, azarpro2, azarpro3, azarpro4 'Variables para fracciones propias'
salida:
        azarpro1 = n1.Next(10, 35) 'Para el primer denominador
        azarpro2 = n2.Next(2, azarpro1 - 1) 'Para el primer numerador
        azarpro3 = n3.Next(11, 46) 'Para el segundo denominador
        azarpro4 = n4.Next(2, 9) 'Para el segundo numerador
        fracc1 = azarpro2 / azarpro1
        fracc2 = azarpro4 / azarpro3
        If fracc1 < fracc2 Or fracc1 = fracc2 Then
            GoTo salida
        End If

        Me.lblPDen.Text = azarpro1
        Me.lblPNum.Text = azarpro2
        Me.lblPDen2.Text = azarpro3
        Me.lblPNum2.Text = azarpro4
    End Sub


Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
          Dim NivFraccPropias As New NivFraccPropias
        NivFraccPropias.Show()
        Me.Close()
End Sub

Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
  Dim frm_inicio As New INICIO
frm_inicio.Show()
Me.Dispose()
End Sub

Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim nm1, nm2, dn1, dn2 As Integer 'NUMERADORES y DENOMINADORES'
        Dim resnum, resden, comp As Integer
        Dim rnumOrig, rdenOrig As Integer
        nm1 = Me.lblPNum.Text
        nm2 = Me.lblPNum2.Text
        dn1 = Me.lblPDen.Text
        dn2 = Me.lblPDen2.Text
        resnum = (nm1 * dn2) - (dn1 * nm2)
        resden = dn1 * dn2
        If Res1.Text <> "" And Res2.Text <> "" And MultDen.Text <> "" And txtReDen.Text <> "" And txtReNum.Text <> "" Then
            If IsNumeric(Res1.Text) And IsNumeric(Res2.Text) And IsNumeric(MultDen.Text) And IsNumeric(txtReDen.Text) And IsNumeric(txtReNum.Text) Then
                Dim Resta1 = nm1 * dn2 'PARA OBTENER LOS VALORES DE LOS PASOS'
                Dim Resta2 = nm2 * dn1
                Dim MDenominadores = dn1 * dn2
                rnumOrig = resnum 'ASIGNANDO LOS VALORES PARA VALIDAR SI SE PUEDE SIMPLIFICAR'
                rdenOrig = resden
                'PROCESO PARA SIMPLIFICAR LA FRACCION
                Dim fsimple, fUsuario As Double
                comp = resnum
                While (comp > 0)
                    If (resnum Mod comp = 0 And resden Mod comp = 0) Then
                        resnum = resnum / comp
                        resden = resden / comp
                        comp = 1 'ESTA ASIGNACIÓN ES IMPORTANTE
                    End If
                    comp = comp - 1  'RESTANDO DE 1 VALOR A MI VERIFICADOR
                End While
                fUsuario = txtReNum.Text / txtReDen.Text   'ES DECIR LA FRACCION INTRODUCIDA POR EL USUARIO'
                fsimple = resnum / resden
                Dim resultado As New ReProN2
                VaGlobales.ArrNiv1(0) = nm1
                VaGlobales.ArrNiv1(1) = dn1
                VaGlobales.ArrNiv1(2) = nm2
                VaGlobales.ArrNiv1(3) = dn2
                VaGlobales.ArrNiv1(4) = nm1 * dn2
                VaGlobales.ArrNiv1(5) = dn1 * nm2
                VaGlobales.ArrNiv1(6) = dn1 * dn2
                VaGlobales.ArrNiv1(7) = rnumOrig
                VaGlobales.ArrNiv1(8) = rdenOrig
                VaGlobales.ArrNiv1(9) = rnumOrig
                VaGlobales.ArrNiv1(10) = rdenOrig
                VaGlobales.ArrNiv1(11) = resnum
                VaGlobales.ArrNiv1(12) = resden
                'DETERMINA SI ALGUNA DE LAS RESPUESTAS ES CORRECTA
                If fUsuario = fsimple And Res1.Text = Resta1 And Res2.Text = Resta2 And MultDen.Text = MDenominadores Then
                    VaGlobales.VerifN1 = 1
                    resultado.Show()
                    Me.Hide()
                Else
                    If fUsuario <> fsimple Then
                        VaGlobales.RNivel2 = 1
                    Else
                        VaGlobales.RNivel2 = 0
                    End If
                    If Res1.Text <> Resta1 Or Res2.Text <> Resta2 Or MultDen.Text <> MDenominadores Then
                        VaGlobales.ProcNivel2 = 1
                    Else
                        VaGlobales.ProcNivel2 = 0
                    End If
                    VaGlobales.VerifN1 = 0
                    resultado.Show()
                    Me.Hide()
                End If
            Else
                MessageBox.Show("Los caracteres ingresados deben ser numeros, no letras")
            End If
        Else
            MessageBox.Show("Debes llenar todas las casillas.")
        End If
End Sub
End Class