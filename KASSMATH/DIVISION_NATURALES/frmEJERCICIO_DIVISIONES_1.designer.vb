<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEJERCICIO_DIVISIONES_1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEJERCICIO_DIVISIONES_1))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtResiduo = New System.Windows.Forms.TextBox()
        Me.txtCociente = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDividendo = New System.Windows.Forms.Label()
        Me.lblDivisor = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ImageKey = "(ninguno)"
        Me.Button2.Location = New System.Drawing.Point(196, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 73)
        Me.Button2.TabIndex = 104
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button5.AutoSize = True
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ImageKey = "(ninguno)"
        Me.Button5.Location = New System.Drawing.Point(2, 16)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(202, 64)
        Me.Button5.TabIndex = 105
        Me.Button5.UseVisualStyleBackColor = False
        '
        'txtResiduo
        '
        Me.txtResiduo.Location = New System.Drawing.Point(559, 285)
        Me.txtResiduo.Name = "txtResiduo"
        Me.txtResiduo.Size = New System.Drawing.Size(100, 20)
        Me.txtResiduo.TabIndex = 108
        '
        'txtCociente
        '
        Me.txtCociente.Location = New System.Drawing.Point(559, 167)
        Me.txtCociente.Name = "txtCociente"
        Me.txtCociente.Size = New System.Drawing.Size(100, 20)
        Me.txtCociente.TabIndex = 107
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(559, 377)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(110, 56)
        Me.btnCalcular.TabIndex = 106
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(505, 167)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(190, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 109
        Me.PictureBox1.TabStop = False
        '
        'lblDividendo
        '
        Me.lblDividendo.AutoSize = True
        Me.lblDividendo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDividendo.Location = New System.Drawing.Point(552, 207)
        Me.lblDividendo.Name = "lblDividendo"
        Me.lblDividendo.Size = New System.Drawing.Size(72, 24)
        Me.lblDividendo.TabIndex = 111
        Me.lblDividendo.Text = "Label3"
        '
        'lblDivisor
        '
        Me.lblDivisor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDivisor.AutoSize = True
        Me.lblDivisor.Cursor = System.Windows.Forms.Cursors.No
        Me.lblDivisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivisor.Location = New System.Drawing.Point(462, 206)
        Me.lblDivisor.Name = "lblDivisor"
        Me.lblDivisor.Size = New System.Drawing.Size(72, 24)
        Me.lblDivisor.TabIndex = 110
        Me.lblDivisor.Text = "Label2"
        '
        'frmEJERCICIO_DIVISIONES_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1200, 600)
        Me.Controls.Add(Me.lblDividendo)
        Me.Controls.Add(Me.lblDivisor)
        Me.Controls.Add(Me.txtResiduo)
        Me.Controls.Add(Me.txtCociente)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEJERCICIO_DIVISIONES_1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEJERCICIO_DIVISIONES_1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txtResiduo As System.Windows.Forms.TextBox
    Friend WithEvents txtCociente As System.Windows.Forms.TextBox
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDividendo As System.Windows.Forms.Label
    Friend WithEvents lblDivisor As System.Windows.Forms.Label
End Class
