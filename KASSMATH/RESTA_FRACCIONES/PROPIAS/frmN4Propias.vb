Public Class frmN4Propias

    Private Sub frmN4Propias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim azarpro1, azarpro2, azarpro3, azarpro4, azarpro5, azarpro6 'Variables para fracciones propias'
        Dim fracc1, fracc2, fracc3, comparador As Double
        Dim n1, n2, n3, n4, n5, n6 As New Random
salida:

        'PARA OBTENER LA FRACCIÓN PROPIA
        azarpro1 = n1.Next(10, 20) 'Para el primer denominador
        azarpro2 = n2.Next(2, azarpro1 - 1) 'Para el primer numerador
        azarpro3 = n3.Next(10, 25) 'Para el segundo denominador
        azarpro4 = n4.Next(2, 10) 'Para el segundo numerador
        azarpro5 = n5.Next(15, 30) 'Para el tercer denominador
        azarpro6 = n6.Next(1, 8) 'Para el tercer numerador
        'HACIENDO OPERACIONES CON LAS FRACCIONES'
        fracc1 = azarpro2 / azarpro1
        fracc2 = azarpro4 / azarpro3
        fracc3 = azarpro6 / azarpro5
        comparador = fracc2 + fracc3
        If fracc1 < comparador Or fracc1 = comparador Then
            GoTo salida
        End If
        Me.lblPDen.Text = azarpro1
        Me.lblPNum.Text = azarpro2
        Me.lblPDen2.Text = azarpro3
        Me.lblPNum2.Text = azarpro4
        Me.lblPDen3.Text = azarpro5
        Me.lblPNum3.Text = azarpro6
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
          Dim nm1, nm2, nm3 As Integer 'NUMERADORES'
        Dim dn1, dn2, dn3 As Integer 'DENOMINADORES'
        Dim resnum1, resden1, numfin, denfin As Integer
        Dim comp, d1, d2, d3 As Integer
        Dim valorau, mcp, uno As Integer
        Dim rnumOrig, rdenOrig As Integer
        Dim resultado As New ReProN4
        'CALCULANDO LAS 2 PRIMERAS FRACCIONES
        nm1 = Me.lblPNum.Text
        nm2 = Me.lblPNum2.Text
        dn1 = Me.lblPDen.Text
        dn2 = Me.lblPDen2.Text
        nm3 = Me.lblPNum3.Text
        dn3 = Me.lblPDen3.Text
        resnum1 = (nm1 * dn2) - (dn1 * nm2)
        resden1 = dn1 * dn2
        'CALCULANDO LA ÚLTIMA FRACCIÓN
        numfin = (resnum1 * dn3) - (resden1 * nm3)
        denfin = resden1 * dn3

        rnumOrig = numfin
        rdenOrig = denfin
        comp = numfin
        'SIMPLIFICAR LA FRACCIÓN'
        Dim fsimple, fUsuario As Double
        While (comp > 0)
            If (numfin Mod comp = 0 And denfin Mod comp = 0) Then
                numfin = numfin / comp
                denfin = denfin / comp
                comp = 1 'ESTA ASIGNACIÓN ES IMPORTANTE
            End If
            comp = comp - 1  'RESTANDO DE 1 VALOR A MI VERIFICADOR
        End While
        fUsuario = txtReNum.Text / txtReDen.Text   'ES DECIR LA FRACCION INTRODUCIDA POR EL USUARIO'
        fsimple = numfin / denfin
        'DETERMINA SI ALGUNA DE LAS RESPUESTAS ES CORRECTA
        If fUsuario = fsimple Then
            VaGlobales.VerifN1 = 1
            resultado.Show()
            Me.Dispose()
        Else
            d1 = dn1
            d2 = dn2
            d3 = dn3
        'CICLO PARA OBTENER EL MÍNIMO COMÚN MÚLTIPLO'
            'ASIGNANDO VALORES AL ARREGLO GLOBAL
            VaGlobales.ArrNiv4(0) = nm1
            VaGlobales.ArrNiv4(1) = nm2
            VaGlobales.ArrNiv4(2) = nm3
            VaGlobales.ArrNiv4(3) = dn1
            VaGlobales.ArrNiv4(4) = dn2
            VaGlobales.ArrNiv4(5) = dn3
            valorau = 2  'VARIABLE QUE AUMENTA EL PRODUCTO
            uno = 0
            mcp = 1
            Do While dn1 <> 1 Or dn2 <> 1 Or dn3 <> 1
                If dn1 Mod valorau = 0 Then
                    dn1 = dn1 / valorau
                    uno = uno + 1
                End If
                If dn2 Mod valorau = 0 Then
                    dn2 = dn2 / valorau
                    uno = uno + 1
                End If
                If dn3 Mod valorau = 0 Then
                    dn3 = dn3 / valorau
                    uno = uno + 1
                End If
                'SI NO HUBO ALGUNA DIVISION'
                If uno = 0 Then
                    valorau = valorau + 1
                ElseIf uno > 0 Then
                    mcp = mcp * valorau
                End If
                uno = 0
            Loop
            VaGlobales.ArrNiv4(6) = mcp
            VaGlobales.VerifN1 = 0
            VaGlobales.ArrNiv4(7) = numfin
            VaGlobales.ArrNiv4(8) = denfin

            resultado.Show()
            Me.Dispose()
        End If
End Sub
End Class