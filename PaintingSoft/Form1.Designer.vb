<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chkDrb = New System.Windows.Forms.CheckBox()
        Me.CmbHatchStyle = New System.Windows.Forms.ComboBox()
        Me.BtnHatch = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.nudPenSize = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnColor2 = New System.Windows.Forms.Button()
        Me.BtnColor1 = New System.Windows.Forms.Button()
        Me.GBBrush = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnGradiant = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnTexture = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnSolid = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnEllipse = New System.Windows.Forms.Button()
        Me.BtnFillEllipse = New System.Windows.Forms.Button()
        Me.BtnFillRectangle = New System.Windows.Forms.Button()
        Me.BtnRectangle = New System.Windows.Forms.Button()
        Me.BtnLine = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnEraser = New System.Windows.Forms.Button()
        Me.BtnDraw = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudPenSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GBBrush.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1529, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(66, 26)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(76, 26)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.GroupBox6)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GBBrush)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1588, 216)
        Me.Panel1.TabIndex = 1
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.chkDrb)
        Me.GroupBox6.Controls.Add(Me.CmbHatchStyle)
        Me.GroupBox6.Controls.Add(Me.BtnHatch)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(1211, 17)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(216, 182)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Diseño de estilos"
        '
        'chkDrb
        '
        Me.chkDrb.AutoSize = True
        Me.chkDrb.Location = New System.Drawing.Point(64, 141)
        Me.chkDrb.Name = "chkDrb"
        Me.chkDrb.Size = New System.Drawing.Size(98, 26)
        Me.chkDrb.TabIndex = 0
        Me.chkDrb.Text = "Activar"
        Me.chkDrb.UseVisualStyleBackColor = True
        '
        'CmbHatchStyle
        '
        Me.CmbHatchStyle.FormattingEnabled = True
        Me.CmbHatchStyle.Location = New System.Drawing.Point(6, 100)
        Me.CmbHatchStyle.Name = "CmbHatchStyle"
        Me.CmbHatchStyle.Size = New System.Drawing.Size(199, 29)
        Me.CmbHatchStyle.TabIndex = 0
        '
        'BtnHatch
        '
        Me.BtnHatch.BackgroundImage = Global.PaintingSoft.My.Resources.Resources.axRecurso_7_100
        Me.BtnHatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnHatch.Location = New System.Drawing.Point(54, 27)
        Me.BtnHatch.Name = "BtnHatch"
        Me.BtnHatch.Size = New System.Drawing.Size(79, 67)
        Me.BtnHatch.TabIndex = 9
        Me.BtnHatch.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(139, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 22)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Estilos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.nudPenSize)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(410, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(154, 182)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tamaño"
        '
        'nudPenSize
        '
        Me.nudPenSize.Location = New System.Drawing.Point(6, 38)
        Me.nudPenSize.Name = "nudPenSize"
        Me.nudPenSize.Size = New System.Drawing.Size(140, 28)
        Me.nudPenSize.TabIndex = 0
        Me.nudPenSize.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.BtnColor2)
        Me.GroupBox3.Controls.Add(Me.BtnColor1)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(583, 17)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(214, 182)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Colores"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(121, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Color 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Color 1"
        '
        'BtnColor2
        '
        Me.BtnColor2.BackColor = System.Drawing.Color.White
        Me.BtnColor2.Location = New System.Drawing.Point(114, 38)
        Me.BtnColor2.Name = "BtnColor2"
        Me.BtnColor2.Size = New System.Drawing.Size(89, 75)
        Me.BtnColor2.TabIndex = 1
        Me.BtnColor2.UseVisualStyleBackColor = False
        '
        'BtnColor1
        '
        Me.BtnColor1.BackColor = System.Drawing.Color.Black
        Me.BtnColor1.Location = New System.Drawing.Point(8, 40)
        Me.BtnColor1.Name = "BtnColor1"
        Me.BtnColor1.Size = New System.Drawing.Size(91, 75)
        Me.BtnColor1.TabIndex = 0
        Me.BtnColor1.UseVisualStyleBackColor = False
        '
        'GBBrush
        '
        Me.GBBrush.Controls.Add(Me.Label6)
        Me.GBBrush.Controls.Add(Me.BtnGradiant)
        Me.GBBrush.Controls.Add(Me.Label5)
        Me.GBBrush.Controls.Add(Me.BtnTexture)
        Me.GBBrush.Controls.Add(Me.Label3)
        Me.GBBrush.Controls.Add(Me.BtnSolid)
        Me.GBBrush.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBBrush.Location = New System.Drawing.Point(814, 17)
        Me.GBBrush.Name = "GBBrush"
        Me.GBBrush.Size = New System.Drawing.Size(381, 182)
        Me.GBBrush.TabIndex = 1
        Me.GBBrush.TabStop = False
        Me.GBBrush.Text = "Diseño"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(258, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 22)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Degradado"
        '
        'BtnGradiant
        '
        Me.BtnGradiant.BackgroundImage = Global.PaintingSoft.My.Resources.Resources.axRecurso_9_100
        Me.BtnGradiant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGradiant.Location = New System.Drawing.Point(173, 106)
        Me.BtnGradiant.Name = "BtnGradiant"
        Me.BtnGradiant.Size = New System.Drawing.Size(79, 67)
        Me.BtnGradiant.TabIndex = 13
        Me.BtnGradiant.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 22)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Imágen"
        '
        'BtnTexture
        '
        Me.BtnTexture.BackgroundImage = Global.PaintingSoft.My.Resources.Resources.axzzRecurso_1_100
        Me.BtnTexture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnTexture.Location = New System.Drawing.Point(6, 109)
        Me.BtnTexture.Name = "BtnTexture"
        Me.BtnTexture.Size = New System.Drawing.Size(79, 67)
        Me.BtnTexture.TabIndex = 11
        Me.BtnTexture.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Solido"
        '
        'BtnSolid
        '
        Me.BtnSolid.BackgroundImage = Global.PaintingSoft.My.Resources.Resources.aRecurso_5_100
        Me.BtnSolid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSolid.Location = New System.Drawing.Point(6, 27)
        Me.BtnSolid.Name = "BtnSolid"
        Me.BtnSolid.Size = New System.Drawing.Size(79, 67)
        Me.BtnSolid.TabIndex = 8
        Me.BtnSolid.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnEllipse)
        Me.GroupBox1.Controls.Add(Me.BtnFillEllipse)
        Me.GroupBox1.Controls.Add(Me.BtnFillRectangle)
        Me.GroupBox1.Controls.Add(Me.BtnRectangle)
        Me.GroupBox1.Controls.Add(Me.BtnLine)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.BtnEraser)
        Me.GroupBox1.Controls.Add(Me.BtnDraw)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(43, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(351, 182)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Diseño"
        '
        'BtnEllipse
        '
        Me.BtnEllipse.BackgroundImage = Global.PaintingSoft.My.Resources.Resources.xRecurso_1_100
        Me.BtnEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEllipse.Location = New System.Drawing.Point(261, 27)
        Me.BtnEllipse.Name = "BtnEllipse"
        Me.BtnEllipse.Size = New System.Drawing.Size(79, 67)
        Me.BtnEllipse.TabIndex = 7
        Me.BtnEllipse.UseVisualStyleBackColor = True
        '
        'BtnFillEllipse
        '
        Me.BtnFillEllipse.BackgroundImage = Global.PaintingSoft.My.Resources.Resources.xxRecurso_2_100
        Me.BtnFillEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFillEllipse.Location = New System.Drawing.Point(261, 100)
        Me.BtnFillEllipse.Name = "BtnFillEllipse"
        Me.BtnFillEllipse.Size = New System.Drawing.Size(79, 67)
        Me.BtnFillEllipse.TabIndex = 6
        Me.BtnFillEllipse.UseVisualStyleBackColor = True
        '
        'BtnFillRectangle
        '
        Me.BtnFillRectangle.BackgroundImage = Global.PaintingSoft.My.Resources.Resources.xxxRecurso_3_100
        Me.BtnFillRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFillRectangle.Location = New System.Drawing.Point(176, 100)
        Me.BtnFillRectangle.Name = "BtnFillRectangle"
        Me.BtnFillRectangle.Size = New System.Drawing.Size(79, 67)
        Me.BtnFillRectangle.TabIndex = 5
        Me.BtnFillRectangle.UseVisualStyleBackColor = True
        '
        'BtnRectangle
        '
        Me.BtnRectangle.BackgroundImage = Global.PaintingSoft.My.Resources.Resources.rounded_rectangle
        Me.BtnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRectangle.Location = New System.Drawing.Point(176, 27)
        Me.BtnRectangle.Name = "BtnRectangle"
        Me.BtnRectangle.Size = New System.Drawing.Size(79, 67)
        Me.BtnRectangle.TabIndex = 4
        Me.BtnRectangle.UseVisualStyleBackColor = True
        '
        'BtnLine
        '
        Me.BtnLine.BackgroundImage = Global.PaintingSoft.My.Resources.Resources.minus_symbol
        Me.BtnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLine.Location = New System.Drawing.Point(91, 100)
        Me.BtnLine.Name = "BtnLine"
        Me.BtnLine.Size = New System.Drawing.Size(79, 67)
        Me.BtnLine.TabIndex = 3
        Me.BtnLine.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.PaintingSoft.My.Resources.Resources.axRecurso_2_100
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(91, 27)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 67)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BtnEraser
        '
        Me.BtnEraser.BackgroundImage = Global.PaintingSoft.My.Resources.Resources.eraser_xxx
        Me.BtnEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEraser.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnEraser.Location = New System.Drawing.Point(6, 100)
        Me.BtnEraser.Name = "BtnEraser"
        Me.BtnEraser.Size = New System.Drawing.Size(79, 67)
        Me.BtnEraser.TabIndex = 1
        Me.BtnEraser.UseVisualStyleBackColor = True
        '
        'BtnDraw
        '
        Me.BtnDraw.BackgroundImage = Global.PaintingSoft.My.Resources.Resources.xxpen
        Me.BtnDraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDraw.Location = New System.Drawing.Point(6, 27)
        Me.BtnDraw.Name = "BtnDraw"
        Me.BtnDraw.Size = New System.Drawing.Size(79, 67)
        Me.BtnDraw.TabIndex = 0
        Me.BtnDraw.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(12, 263)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1502, 529)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1529, 814)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PaintingSoft"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.nudPenSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GBBrush.ResumeLayout(False)
        Me.GBBrush.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GBBrush As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnDraw As Button
    Friend WithEvents BtnEraser As Button
    Friend WithEvents BtnLine As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnFillRectangle As Button
    Friend WithEvents BtnRectangle As Button
    Friend WithEvents BtnEllipse As Button
    Friend WithEvents BtnFillEllipse As Button
    Friend WithEvents nudPenSize As NumericUpDown
    Friend WithEvents BtnColor1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnColor2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSolid As Button
    Friend WithEvents BtnHatch As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnTexture As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnGradiant As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents CmbHatchStyle As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents chkDrb As CheckBox
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
End Class
