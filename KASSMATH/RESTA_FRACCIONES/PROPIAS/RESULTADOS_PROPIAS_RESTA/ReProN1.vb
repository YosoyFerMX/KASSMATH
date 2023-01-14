Public Class ReProN1

    Private Sub ReProN1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If VaGlobales.VerifN1 = 1 Then
            gbx_correcto.Visible = True
            gbx_incorrecto.Visible = False

        End If
        If VaGlobales.VerifN1 = 0 Then
            gbx_incorrecto.Visible = True
            numDemo1.Text = VaGlobales.ArrNiv1(0)
            denDemo1.Text = VaGlobales.ArrNiv1(1)
            numDemo2.Text = VaGlobales.ArrNiv1(2)
            denDemo2.Text = VaGlobales.ArrNiv1(3)
            mult1.Text = VaGlobales.ArrNiv1(4)
            mult2.Text = VaGlobales.ArrNiv1(5)
            mult3.Text = VaGlobales.ArrNiv1(6)
            resn.Text = VaGlobales.ArrNiv1(7)
            resd.Text = VaGlobales.ArrNiv1(8)
            numNormal.Text = VaGlobales.ArrNiv1(9)
            denNormal.Text = VaGlobales.ArrNiv1(10)
            numSimp.Text = VaGlobales.ArrNiv1(11)
            denSimp.Text = VaGlobales.ArrNiv1(12)
            gbx_correcto.Visible = False
            gbx_incorrecto.Visible = True

        End If
        
    End Sub

Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
          Dim nivel1 As New frmN1Propias
        nivel1.Show()
        Me.Close()
End Sub

Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
         Dim NivFraccPropias As New NivFraccPropias
        NivFraccPropias.Show()
        Me.Close()
End Sub

Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
         Dim nivel1 As New frmN1Propias
        nivel1.Show()
        Me.Close()
End Sub

Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
          Dim NivFraccPropias As New NivFraccPropias
        NivFraccPropias.Show()
        Me.Close()
End Sub
End Class