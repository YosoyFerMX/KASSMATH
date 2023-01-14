Public Class ReProN3

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub ReProN3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If VaGlobales.VerifN1 = 0 Then
            'MOSTRANDO EL PASO 1
            PNu1.Text = VaGlobales.ArrNiv3(0)
            PN2.Text = VaGlobales.ArrNiv3(1)
            PN3.Text = VaGlobales.ArrNiv3(2)
            PD1.Text = VaGlobales.ArrNiv3(3)
            PD2.Text = VaGlobales.ArrNiv3(4)
            PD3.Text = VaGlobales.ArrNiv3(5)
            lblMC.Text = VaGlobales.ArrNiv3(6)


            'MOSTRANDO EL PASO 2
            lblMCD1.Text = VaGlobales.ArrNiv3(6)
            lblMCD2.Text = VaGlobales.ArrNiv3(6)
            lblMCD3.Text = VaGlobales.ArrNiv3(6)
            'DENOMINADORES
            D1Pa2.Text = VaGlobales.ArrNiv3(3)
            D2Pa2.Text = VaGlobales.ArrNiv3(4)
            D3Pa2.Text = VaGlobales.ArrNiv3(5)
            'NUMERADORES
            N1Pa2.Text = VaGlobales.ArrNiv3(0)
            N2Pa2.Text = VaGlobales.ArrNiv3(1)
            N3Pa2.Text = VaGlobales.ArrNiv3(2)

            Div1.Text = VaGlobales.ArrNiv3(6) / VaGlobales.ArrNiv3(3)
            Div2.Text = VaGlobales.ArrNiv3(6) / VaGlobales.ArrNiv3(4)
            DIV3.Text = VaGlobales.ArrNiv3(6) / VaGlobales.ArrNiv3(5)

            R1Pa2.Text = Div1.Text * N1Pa2.Text
            R2Pa2.Text = Div2.Text * N2Pa2.Text
            R3Pa2.Text = DIV3.Text * N3Pa2.Text

            'MOSTRANDO PASO 3
            lblR1.Text = R1Pa2.Text
            lblR2.Text = R2Pa2.Text
            lblR3.Text = R3Pa2.Text
            lblMCM.Text = VaGlobales.ArrNiv3(6)
            lblNu.Text = R1Pa2.Text - R2Pa2.Text - R3Pa2.Text
            lblDe.Text = VaGlobales.ArrNiv3(6)

            'MOSTRANDO PASO 4
            lblNN.Text = lblNu.Text
            lblDN.Text = lblDe.Text
            lblNS.Text = VaGlobales.ArrNiv3(7)
            lblDS.Text = VaGlobales.ArrNiv3(8)

            gbIncorrecto.Visible = True
            gbx_correcto.Visible = False
        Else
            gbx_correcto.Visible = True
            gbIncorrecto.Visible = False
        End If
    End Sub


Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nivel3 As New frmN3Propias
        nivel3.Show()
        Me.Close()
End Sub

Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NivFraccPropias As New NivFraccPropias
        NivFraccPropias.Show()
        Me.Close()
End Sub

Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
          Dim nivel3 As New frmN3Propias
        nivel3.Show()
        Me.Close()
End Sub

Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim NivFraccPropias As New NivFraccPropias
        NivFraccPropias.Show()
        Me.Close()
End Sub
End Class