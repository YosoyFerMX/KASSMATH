<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DIVISION_NATURALES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DIVISION_NATURALES))
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.wm_video = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnNivel1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.wm_video, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button10
        '
        Me.Button10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button10.AutoSize = True
        Me.Button10.BackColor = System.Drawing.Color.Transparent
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.ImageKey = "(ninguno)"
        Me.Button10.Location = New System.Drawing.Point(700, 558)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(49, 24)
        Me.Button10.TabIndex = 117
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button9.AutoSize = True
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.ImageKey = "(ninguno)"
        Me.Button9.Location = New System.Drawing.Point(538, 558)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(49, 24)
        Me.Button9.TabIndex = 116
        Me.Button9.UseVisualStyleBackColor = False
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
        Me.Button1.Location = New System.Drawing.Point(480, 558)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 24)
        Me.Button1.TabIndex = 115
        Me.Button1.UseVisualStyleBackColor = False
        '
        'wm_video
        '
        Me.wm_video.Enabled = True
        Me.wm_video.Location = New System.Drawing.Point(480, 128)
        Me.wm_video.Name = "wm_video"
        Me.wm_video.OcxState = CType(resources.GetObject("wm_video.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wm_video.Size = New System.Drawing.Size(670, 460)
        Me.wm_video.TabIndex = 114
        Me.wm_video.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB Demi", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(440, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(369, 27)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "< División de numeros naturales >"
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
        Me.Button5.Location = New System.Drawing.Point(12, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(202, 64)
        Me.Button5.TabIndex = 124
        Me.Button5.UseVisualStyleBackColor = False
        '
        'btnNivel1
        '
        Me.btnNivel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNivel1.AutoSize = True
        Me.btnNivel1.BackColor = System.Drawing.Color.Transparent
        Me.btnNivel1.BackgroundImage = CType(resources.GetObject("btnNivel1.BackgroundImage"), System.Drawing.Image)
        Me.btnNivel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNivel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNivel1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNivel1.FlatAppearance.BorderSize = 0
        Me.btnNivel1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNivel1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNivel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNivel1.ImageKey = "(ninguno)"
        Me.btnNivel1.Location = New System.Drawing.Point(91, 144)
        Me.btnNivel1.Name = "btnNivel1"
        Me.btnNivel1.Size = New System.Drawing.Size(273, 64)
        Me.btnNivel1.TabIndex = 127
        Me.btnNivel1.UseVisualStyleBackColor = False
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
        Me.Button2.Location = New System.Drawing.Point(91, 218)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(273, 64)
        Me.Button2.TabIndex = 128
        Me.Button2.UseVisualStyleBackColor = False
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
        Me.Button4.Location = New System.Drawing.Point(91, 291)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(273, 64)
        Me.Button4.TabIndex = 129
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button6.AutoSize = True
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ImageKey = "(ninguno)"
        Me.Button6.Location = New System.Drawing.Point(91, 368)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(273, 64)
        Me.Button6.TabIndex = 130
        Me.Button6.UseVisualStyleBackColor = False
        '
        'DIVISION_NATURALES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1200, 600)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnNivel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.wm_video)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DIVISION_NATURALES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DIVISION_NATURALES"
        CType(Me.wm_video, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

End Sub
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents wm_video As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btnNivel1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
