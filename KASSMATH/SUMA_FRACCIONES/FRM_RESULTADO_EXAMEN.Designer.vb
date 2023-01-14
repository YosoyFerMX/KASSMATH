<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_RESULTADO_EXAMEN
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_RESULTADO_EXAMEN))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_correctas = New System.Windows.Forms.Label()
        Me.lbl_incorrectas = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_calificacion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Berlin Sans FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(625, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(370, 34)
        Me.Label6.TabIndex = 146
        Me.Label6.Text = "RESPUESTAS INCORRECTAS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(190, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 34)
        Me.Label1.TabIndex = 147
        Me.Label1.Text = "RESPUESTAS CORRECTAS"
        '
        'lbl_correctas
        '
        Me.lbl_correctas.AutoSize = True
        Me.lbl_correctas.BackColor = System.Drawing.Color.Transparent
        Me.lbl_correctas.Font = New System.Drawing.Font("Berlin Sans FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_correctas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_correctas.Location = New System.Drawing.Point(341, 330)
        Me.lbl_correctas.Name = "lbl_correctas"
        Me.lbl_correctas.Size = New System.Drawing.Size(33, 34)
        Me.lbl_correctas.TabIndex = 148
        Me.lbl_correctas.Text = "0"
        '
        'lbl_incorrectas
        '
        Me.lbl_incorrectas.AutoSize = True
        Me.lbl_incorrectas.BackColor = System.Drawing.Color.Transparent
        Me.lbl_incorrectas.Font = New System.Drawing.Font("Berlin Sans FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_incorrectas.ForeColor = System.Drawing.Color.Red
        Me.lbl_incorrectas.Location = New System.Drawing.Point(796, 330)
        Me.lbl_incorrectas.Name = "lbl_incorrectas"
        Me.lbl_incorrectas.Size = New System.Drawing.Size(33, 34)
        Me.lbl_incorrectas.TabIndex = 149
        Me.lbl_incorrectas.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(340, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(518, 40)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "RESULTADO FINAL DEL EXAMEN"
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.AutoSize = True
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ImageKey = "(ninguno)"
        Me.Button4.Location = New System.Drawing.Point(509, 515)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(151, 43)
        Me.Button4.TabIndex = 151
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(469, 381)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 37)
        Me.Label3.TabIndex = 152
        Me.Label3.Text = "CALIFICACION"
        '
        'lbl_calificacion
        '
        Me.lbl_calificacion.AutoSize = True
        Me.lbl_calificacion.BackColor = System.Drawing.Color.Transparent
        Me.lbl_calificacion.Font = New System.Drawing.Font("Berlin Sans FB", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_calificacion.ForeColor = System.Drawing.Color.Teal
        Me.lbl_calificacion.Location = New System.Drawing.Point(542, 447)
        Me.lbl_calificacion.Name = "lbl_calificacion"
        Me.lbl_calificacion.Size = New System.Drawing.Size(66, 37)
        Me.lbl_calificacion.TabIndex = 153
        Me.lbl_calificacion.Text = "100"
        '
        'FRM_RESULTADO_EXAMEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1200, 600)
        Me.Controls.Add(Me.lbl_calificacion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_incorrectas)
        Me.Controls.Add(Me.lbl_correctas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_RESULTADO_EXAMEN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_RESULTADO_EXAMEN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_correctas As System.Windows.Forms.Label
    Friend WithEvents lbl_incorrectas As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_calificacion As System.Windows.Forms.Label
End Class
