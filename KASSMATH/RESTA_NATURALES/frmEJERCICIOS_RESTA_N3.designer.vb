<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEJERCICIOS_RESTA_N3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEJERCICIOS_RESTA_N3))
        Me.btnVerificar_resta = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblNum_Menor = New System.Windows.Forms.Label()
        Me.lblNum_Mayor = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVerificar_resta
        '
        Me.btnVerificar_resta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnVerificar_resta.AutoSize = True
        Me.btnVerificar_resta.BackColor = System.Drawing.Color.Transparent
        Me.btnVerificar_resta.BackgroundImage = CType(resources.GetObject("btnVerificar_resta.BackgroundImage"), System.Drawing.Image)
        Me.btnVerificar_resta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVerificar_resta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerificar_resta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnVerificar_resta.FlatAppearance.BorderSize = 0
        Me.btnVerificar_resta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnVerificar_resta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnVerificar_resta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerificar_resta.ImageKey = "(ninguno)"
        Me.btnVerificar_resta.Location = New System.Drawing.Point(810, 502)
        Me.btnVerificar_resta.Name = "btnVerificar_resta"
        Me.btnVerificar_resta.Size = New System.Drawing.Size(151, 43)
        Me.btnVerificar_resta.TabIndex = 154
        Me.btnVerificar_resta.UseVisualStyleBackColor = False
        '
        'txtResultado
        '
        Me.txtResultado.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtResultado.Font = New System.Drawing.Font("Berlin Sans FB", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado.Location = New System.Drawing.Point(560, 368)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 43)
        Me.txtResultado.TabIndex = 153
        Me.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(669, 382)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(320, 26)
        Me.Label3.TabIndex = 152
        Me.Label3.Text = "<----- INGRESA EL RESULTADO"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(465, 287)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 151
        Me.PictureBox1.TabStop = False
        '
        'lblNum_Menor
        '
        Me.lblNum_Menor.AutoSize = True
        Me.lblNum_Menor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblNum_Menor.Font = New System.Drawing.Font("Berlin Sans FB", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum_Menor.Location = New System.Drawing.Point(569, 311)
        Me.lblNum_Menor.Name = "lblNum_Menor"
        Me.lblNum_Menor.Size = New System.Drawing.Size(109, 37)
        Me.lblNum_Menor.TabIndex = 149
        Me.lblNum_Menor.Text = "Label3"
        '
        'lblNum_Mayor
        '
        Me.lblNum_Mayor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNum_Mayor.AutoSize = True
        Me.lblNum_Mayor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblNum_Mayor.Cursor = System.Windows.Forms.Cursors.No
        Me.lblNum_Mayor.Font = New System.Drawing.Font("Berlin Sans FB", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum_Mayor.Location = New System.Drawing.Point(566, 265)
        Me.lblNum_Mayor.Name = "lblNum_Mayor"
        Me.lblNum_Mayor.Size = New System.Drawing.Size(110, 37)
        Me.lblNum_Mayor.TabIndex = 148
        Me.lblNum_Mayor.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(439, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(309, 26)
        Me.Label2.TabIndex = 147
        Me.Label2.Text = "INGRESA TU RESPUESTA AQUI"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(541, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 37)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "_________"
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
        Me.Button2.Location = New System.Drawing.Point(189, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 73)
        Me.Button2.TabIndex = 146
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
        Me.Button5.Location = New System.Drawing.Point(0, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(202, 64)
        Me.Button5.TabIndex = 145
        Me.Button5.UseVisualStyleBackColor = False
        '
        'frmEJERCICIOS_RESTA_N3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1200, 600)
        Me.Controls.Add(Me.btnVerificar_resta)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblNum_Menor)
        Me.Controls.Add(Me.lblNum_Mayor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEJERCICIOS_RESTA_N3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEJERCICIOS_RESTA_N3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

End Sub
    Friend WithEvents btnVerificar_resta As System.Windows.Forms.Button
    Friend WithEvents txtResultado As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblNum_Menor As System.Windows.Forms.Label
    Friend WithEvents lblNum_Mayor As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
