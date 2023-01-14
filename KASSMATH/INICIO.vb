Public Class INICIO

Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
  Me.Close()
End Sub

Private Sub btnsuma_Fracciones_Click(sender As Object, e As EventArgs) Handles btnsuma_Fracciones.Click
      Dim suma_tipos As New tipos_suma
    suma_tipos.Show()
    Me.Hide()

End Sub

Private Sub btnresta_Fracciones_Click(sender As Object, e As EventArgs) Handles btnresta_Fracciones.Click
    Dim tipos_resta As New TIPOS_RESTA
tipos_resta.Show()
Me.Hide()
End Sub

Private Sub btndivision_Fracciones_Click(sender As Object, e As EventArgs) Handles btndivision_Fracciones.Click
    Dim division_tipos As New TIPO_FRACCIONES()
division_tipos.Show()
Me.Hide()
End Sub

Private Sub btndivision_Enteros_Click(sender As Object, e As EventArgs) Handles btndivision_Enteros.Click
    Dim frm_division_naturales As New DIVISION_NATURALES
frm_division_naturales.Show()
Me.Hide()
End Sub

Private Sub btnresta_Enteros_Click(sender As Object, e As EventArgs) Handles btnresta_Enteros.Click
    Dim frm_resta As New RESTA_NATURALES()
frm_resta.Show()
Me.Hide()

End Sub

Private Sub btnsuma_Fracciones_MouseEnter(sender As Object, e As EventArgs) Handles btnsuma_Fracciones.MouseEnter
          Me.btnsuma_Fracciones.Height = 80
Me.btnsuma_Fracciones.Width = 320
btnsuma_Fracciones.Location = New Point(150, 218)
End Sub

Private Sub btnsuma_Fracciones_MouseLeave(sender As Object, e As EventArgs) Handles btnsuma_Fracciones.MouseLeave
      Me.btnsuma_Fracciones.Height = 78
Me.btnsuma_Fracciones.Width = 289
btnsuma_Fracciones.Location = New Point(145, 218)
End Sub

Private Sub btnresta_Fracciones_MouseEnter(sender As Object, e As EventArgs) Handles btnresta_Fracciones.MouseEnter
    Me.btnresta_Fracciones.Height = 80
Me.btnresta_Fracciones.Width = 320
btnresta_Fracciones.Location = New Point(150, 295)
End Sub

Private Sub btnresta_Fracciones_MouseLeave(sender As Object, e As EventArgs) Handles btnresta_Fracciones.MouseLeave
 Me.btnresta_Fracciones.Height = 78
Me.btnresta_Fracciones.Width = 289
btnresta_Fracciones.Location = New Point(145, 295)
End Sub

Private Sub btnmultiplica_Fracciones_MouseEnter(sender As Object, e As EventArgs) Handles btnmultiplica_Fracciones.MouseEnter
       Me.btnmultiplica_Fracciones.Height = 80
    Me.btnmultiplica_Fracciones.Width = 320
    btnmultiplica_Fracciones.Location = New Point(150, 369)
End Sub

Private Sub btnmultiplica_Fracciones_MouseLeave(sender As Object, e As EventArgs) Handles btnmultiplica_Fracciones.MouseLeave
      Me.btnmultiplica_Fracciones.Height = 78
    Me.btnmultiplica_Fracciones.Width = 289
    btnmultiplica_Fracciones.Location = New Point(145, 369)
End Sub

Private Sub btndivision_Fracciones_MouseEnter(sender As Object, e As EventArgs) Handles btndivision_Fracciones.MouseEnter
     Me.btndivision_Fracciones.Height = 80
    Me.btndivision_Fracciones.Width = 320
    btndivision_Fracciones.Location = New Point(150, 440)
End Sub

Private Sub btndivision_Fracciones_MouseLeave(sender As Object, e As EventArgs) Handles btndivision_Fracciones.MouseLeave
     Me.btndivision_Fracciones.Height = 78
    Me.btndivision_Fracciones.Width = 289
    btndivision_Fracciones.Location = New Point(145, 440)
End Sub

Private Sub btndivision_Enteros_MouseEnter(sender As Object, e As EventArgs) Handles btndivision_Enteros.MouseEnter
    Me.btndivision_Enteros.Height = 80
    Me.btndivision_Enteros.Width = 320
    btndivision_Enteros.Location = New Point(750, 270)
End Sub

Private Sub btndivision_Enteros_MouseLeave(sender As Object, e As EventArgs) Handles btndivision_Enteros.MouseLeave
    Me.btndivision_Enteros.Height = 78
    Me.btndivision_Enteros.Width = 289
    btndivision_Enteros.Location = New Point(787, 270)
End Sub

Private Sub btnresta_Enteros_MouseEnter(sender As Object, e As EventArgs) Handles btnresta_Enteros.MouseEnter

    Me.btnresta_Enteros.Height = 80
    Me.btnresta_Enteros.Width = 320
    btnresta_Enteros.Location = New Point(755, 350)
End Sub

Private Sub btnresta_Enteros_MouseLeave(sender As Object, e As EventArgs) Handles btnresta_Enteros.MouseLeave
    Me.btnresta_Enteros.Height = 78
    Me.btnresta_Enteros.Width = 289
    btnresta_Enteros.Location = New Point(782, 350)
End Sub
End Class
