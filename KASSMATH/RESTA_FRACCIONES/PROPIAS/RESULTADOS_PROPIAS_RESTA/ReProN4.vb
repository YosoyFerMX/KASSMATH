Public Class ReProN4

    Private Sub ReProN4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If VaGlobales.VerifN1 = 0 Then
            'MOSTRANDO EL PASO 1
            PNu1.Text = VaGlobales.ArrNiv4(0)
            PN2.Text = VaGlobales.ArrNiv4(1)
            PN3.Text = VaGlobales.ArrNiv4(2)
            PD1.Text = VaGlobales.ArrNiv4(3)
            PD2.Text = VaGlobales.ArrNiv4(4)
            PD3.Text = VaGlobales.ArrNiv4(5)
            lblMC.Text = VaGlobales.ArrNiv4(6)


            'MOSTRANDO EL PASO 2
            lblMCD1.Text = VaGlobales.ArrNiv4(6)
            lblMCD2.Text = VaGlobales.ArrNiv4(6)
            lblMCD3.Text = VaGlobales.ArrNiv4(6)
            'DENOMINADORES
            D1Pa2.Text = VaGlobales.ArrNiv4(3)
            D2Pa2.Text = VaGlobales.ArrNiv4(4)
            D3Pa2.Text = VaGlobales.ArrNiv4(5)
            'NUMERADORES
            N1Pa2.Text = VaGlobales.ArrNiv4(0)
            N2Pa2.Text = VaGlobales.ArrNiv4(1)
            N3Pa2.Text = VaGlobales.ArrNiv4(2)

            Div1.Text = VaGlobales.ArrNiv4(6) / VaGlobales.ArrNiv4(3)
            Div2.Text = VaGlobales.ArrNiv4(6) / VaGlobales.ArrNiv4(4)
            Div3.Text = VaGlobales.ArrNiv4(6) / VaGlobales.ArrNiv4(5)

            R1Pa2.Text = Div1.Text * N1Pa2.Text
            R2Pa2.Text = Div2.Text * N2Pa2.Text
            R3Pa2.Text = Div3.Text * N3Pa2.Text

            'MOSTRANDO PASO 3
            lblR1.Text = R1Pa2.Text
            lblR2.Text = R2Pa2.Text
            lblR3.Text = R3Pa2.Text
            lblMCM.Text = VaGlobales.ArrNiv4(6)
            lblNu.Text = R1Pa2.Text - R2Pa2.Text - R3Pa2.Text
            lblDe.Text = VaGlobales.ArrNiv4(6)

            'MOSTRANDO PASO 4
            lblNN.Text = lblNu.Text
            lblDN.Text = lblDe.Text
            lblNS.Text = VaGlobales.ArrNiv4(7)
            lblDS.Text = VaGlobales.ArrNiv4(8)

            gbIncorrecto.Visible = True
            gbx_correcto.Visible = False
        Else
            gbx_correcto.Visible = True
            gbIncorrecto.Visible = False
        End If
    End Sub


Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
          Dim nivel4 As New frmN4Propias
        nivel4.Show()
        Me.Dispose()
End Sub

Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
          Dim NivFraccPropias As New NivFraccPropias
        NivFraccPropias.Show()
        Me.Dispose()
End Sub

Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
          Dim NivFraccPropias As New NivFraccPropias
        NivFraccPropias.Show()
        Me.Dispose()
End Sub

Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim nivel4 As New frmN4Propias
        nivel4.Show()
        Me.Dispose()
End Sub
End Class