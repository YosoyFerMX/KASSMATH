Public Class ReProN2

    Private Sub ReProN2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If VaGlobales.VerifN1 = 1 Then
            gbx_correcto.Visible = True
            gbx_incorrecto.Visible = False
        End If
        If VaGlobales.VerifN1 = 0 Then
            gbx_correcto.Visible = False
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
        End If
    End Sub

Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim nivel2 As New frmN2Propias
        nivel2.Show()
        Me.Close()
End Sub

Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
          Dim NivFraccPropias As New NivFraccPropias
        NivFraccPropias.Show()
        Me.Close()
End Sub

Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nivel2 As New frmN2Propias
        nivel2.Show()
        Me.Close()
End Sub

Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NivFraccPropias As New NivFraccPropias
        NivFraccPropias.Show()
        Me.Close()
End Sub
End Class