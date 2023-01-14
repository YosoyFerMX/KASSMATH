<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TIPOS_RESTA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TIPOS_RESTA))
        Me.btn_propias_divi = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_propias_divi
        '
        Me.btn_propias_divi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_propias_divi.AutoSize = True
        Me.btn_propias_divi.BackColor = System.Drawing.Color.Transparent
        Me.btn_propias_divi.BackgroundImage = CType(resources.GetObject("btn_propias_divi.BackgroundImage"), System.Drawing.Image)
        Me.btn_propias_divi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_propias_divi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_propias_divi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_propias_divi.FlatAppearance.BorderSize = 0
        Me.btn_propias_divi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_propias_divi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_propias_divi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_propias_divi.ImageKey = "(ninguno)"
        Me.btn_propias_divi.Location = New System.Drawing.Point(456, 150)
        Me.btn_propias_divi.Name = "btn_propias_divi"
        Me.btn_propias_divi.Size = New System.Drawing.Size(289, 78)
        Me.btn_propias_divi.TabIndex = 9
        Me.btn_propias_divi.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ImageKey = "(ninguno)"
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(202, 64)
        Me.Button1.TabIndex = 12
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB Demi", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(473, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(249, 27)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "< Resta de fracciones >"
        '
        'TIPOS_RESTA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1200, 600)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_propias_divi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TIPOS_RESTA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resta de Fracciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

End Sub
    Friend WithEvents btn_propias_divi As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
