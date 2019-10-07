<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkDrb = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nudPenSize = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnHatch = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CmbHatchStyle = New System.Windows.Forms.ComboBox()
        Me.BtnGradiant = New System.Windows.Forms.Button()
        Me.BtnDraw = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnTexture = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnColor2 = New System.Windows.Forms.Button()
        Me.BtnColor1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnSolid = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnColorBackground = New System.Windows.Forms.Button()
        Me.fontText = New System.Windows.Forms.Button()
        Me.BtnEllipse = New System.Windows.Forms.Button()
        Me.BtnFillEllipse = New System.Windows.Forms.Button()
        Me.BtnFillRectangle = New System.Windows.Forms.Button()
        Me.BtnRectangle = New System.Windows.Forms.Button()
        Me.BtnLine = New System.Windows.Forms.Button()
        Me.BtnEraser = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.nudPenSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1529, 31)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoToolStripMenuItem.Image = Global.PaintingSoft.My.Resources.Resources.icons8_add_list_50px
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(94, 27)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.chkDrb)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.nudPenSize)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.BtnHatch)
        Me.Panel1.Controls.Add(Me.GroupBox6)
        Me.Panel1.Controls.Add(Me.BtnGradiant)
        Me.Panel1.Controls.Add(Me.BtnDraw)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.BtnTexture)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.BtnSolid)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1861, 209)
        Me.Panel1.TabIndex = 1
        '
        'chkDrb
        '
        Me.chkDrb.AutoSize = True
        Me.chkDrb.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDrb.Location = New System.Drawing.Point(1049, 128)
        Me.chkDrb.Name = "chkDrb"
        Me.chkDrb.Size = New System.Drawing.Size(221, 24)
        Me.chkDrb.TabIndex = 0
        Me.chkDrb.Text = "Activar el estilo al lápiz"
        Me.chkDrb.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 28)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Tamaño"
        '
        'nudPenSize
        '
        Me.nudPenSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPenSize.Location = New System.Drawing.Point(23, 155)
        Me.nudPenSize.Name = "nudPenSize"
        Me.nudPenSize.Size = New System.Drawing.Size(89, 30)
        Me.nudPenSize.TabIndex = 0
        Me.nudPenSize.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(962, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Estilos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(793, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Degradado"
        '
        'BtnHatch
        '
        Me.BtnHatch.BackgroundImage = Global.PaintingSoft.My.Resources.Resources.axRecurso_7_100
        Me.BtnHatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnHatch.Location = New System.Drawing.Point(878, 110)
        Me.BtnHatch.Name = "BtnHatch"
        Me.BtnHatch.Size = New System.Drawing.Size(79, 67)
        Me.BtnHatch.TabIndex = 9
        Me.BtnHatch.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CmbHatchStyle)
        Me.GroupBox6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(1035, 48)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(216, 70)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Tipos de estilos"
        '
        'CmbHatchStyle
        '
        Me.CmbHatchStyle.FormattingEnabled = True
        Me.CmbHatchStyle.Location = New System.Drawing.Point(11, 31)
        Me.CmbHatchStyle.Name = "CmbHatchStyle"
        Me.CmbHatchStyle.Size = New System.Drawing.Size(199, 29)
        Me.CmbHatchStyle.TabIndex = 0
        '
        'BtnGradiant
        '
        Me.BtnGradiant.BackgroundImage = Global.PaintingSoft.My.Resources.Resources.axRecurso_9_100
        Me.BtnGradiant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGradiant.Location = New System.Drawing.Point(708, 110)
        Me.BtnGradiant.Name = "BtnGradiant"
        Me.BtnGradiant.Size = New System.Drawing.Size(79, 67)
        Me.BtnGradiant.TabIndex = 13
        Me.BtnGradiant.UseVisualStyleBackColor = True
        '
        'BtnDraw
        '
        Me.BtnDraw.BackgroundImage = Global.PaintingSoft.My.Resources.Resources.xxpen
        Me.BtnDraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDraw.Location = New System.Drawing.Point(23, 41)
        Me.BtnDraw.Name = "BtnDraw"
        Me.BtnDraw.Size = New System.Drawing.Size(89, 67)
        Me.BtnDraw.TabIndex = 0
        Me.BtnDraw.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(963, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Imágen"
        '
        'BtnTexture
        '
        Me.BtnTexture.BackgroundImage = Global.PaintingSoft.My.Resources.Resources.axzzRecurso_1_100
        Me.BtnTexture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnTexture.Location = New System.Drawing.Point(878, 30)
        Me.BtnTexture.Name = "BtnTexture"
        Me.BtnTexture.Size = New System.Drawing.Size(79, 67)
        Me.BtnTexture.TabIndex = 11
        Me.BtnTexture.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.BtnColor2)
        Me.GroupBox3.Controls.Add(Me.BtnColor1)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(496, 17)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(189, 182)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Colores"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Color 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Color 1"
        '
        'BtnColor2
        '
        Me.BtnColor2.BackColor = System.Drawing.Color.White
        Me.BtnColor2.Location = New System.Drawing.Point(96, 40)
        Me.BtnColor2.Name = "BtnColor2"
        Me.BtnColor2.Size = New System.Drawing.Size(82, 73)
        Me.BtnColor2.TabIndex = 1
        Me.BtnColor2.UseVisualStyleBackColor = False
        '
        'BtnColor1
        '
        Me.BtnColor1.BackColor = System.Drawing.Color.Black
        Me.BtnColor1.Location = New System.Drawing.Point(8, 40)
        Me.BtnColor1.Name = "BtnColor1"
        Me.BtnColor1.Size = New System.Drawing.Size(82, 73)
        Me.BtnColor1.TabIndex = 0
        Me.BtnColor1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(793, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Solido"
        '
        'BtnSolid
        '
        Me.BtnSolid.BackgroundImage = Global.PaintingSoft.My.Resources.Resources.aRecurso_5_100
        Me.BtnSolid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSolid.Location = New System.Drawing.Point(708, 30)
        Me.BtnSolid.Name = "BtnSolid"
        Me.BtnSolid.Size = New System.Drawing.Size(79, 67)
        Me.BtnSolid.TabIndex = 8
        Me.BtnSolid.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnColorBackground)
        Me.GroupBox1.Controls.Add(Me.fontText)
        Me.GroupBox1.Controls.Add(Me.BtnEllipse)
        Me.GroupBox1.Controls.Add(Me.BtnFillEllipse)
        Me.GroupBox1.Controls.Add(Me.BtnFillRectangle)
        Me.GroupBox1.Controls.Add(Me.BtnRectangle)
        Me.GroupBox1.Controls.Add(Me.BtnLine)
        Me.GroupBox1.Controls.Add(Me.BtnEraser)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(134, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 182)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Diseño"
        '
        'BtnColorBackground
        '
        Me.BtnColorBackground.BackColor = System.Drawing.Color.White
        Me.BtnColorBackground.BackgroundImage = Global.PaintingSoft.My.Resources.Resources.icons8_paint_basket_90px
        Me.BtnColorBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnColorBackground.Location = New System.Drawing.Point(7, 103)
        Me.BtnColorBackground.Name = "BtnColorBackground"
        Me.BtnColorBackground.Size = New System.Drawing.Size(79, 67)
        Me.BtnColorBackground.TabIndex = 8
        Me.BtnColorBackground.UseVisualStyleBackColor = False
        '
        'fontText
        '
        Me.fontText.BackgroundImage = Global.PaintingSoft.My.Resources.Resources.axRecurso_2_100
        Me.fontText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.fontText.Location = New System.Drawing.Point(7, 27)
        Me.fontText.Name = "fontText"
        Me.fontText.Size = New System.Drawing.Size(79, 67)
        Me.fontText.TabIndex = 2
        Me.fontText.UseVisualStyleBackColor = True
        '
        'BtnEllipse
        '
        Me.BtnEllipse.BackgroundImage = Global.PaintingSoft.My.Resources.Resources.xRecurso_1_100
        Me.BtnEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEllipse.Location = New System.Drawing.Point(262, 27)
        Me.BtnEllipse.Name = "BtnEllipse"
        Me.BtnEllipse.Size = New System.Drawing.Size(79, 70)
        Me.BtnEllipse.TabIndex = 7
        Me.BtnEllipse.UseVisualStyleBackColor = True
        '
        'BtnFillEllipse
        '
        Me.BtnFillEllipse.BackgroundImage = Global.PaintingSoft.My.Resources.Resources.xxRecurso_2_100
        Me.BtnFillEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFillEllipse.Location = New System.Drawing.Point(262, 103)
        Me.BtnFillEllipse.Name = "BtnFillEllipse"
        Me.BtnFillEllipse.Size = New System.Drawing.Size(79, 67)
        Me.BtnFillEllipse.TabIndex = 6
        Me.BtnFillEllipse.UseVisualStyleBackColor = True
        '
        'BtnFillRectangle
        '
        Me.BtnFillRectangle.BackgroundImage = Global.PaintingSoft.My.Resources.Resources.xxxRecurso_3_100
        Me.BtnFillRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFillRectangle.Location = New System.Drawing.Point(177, 103)
        Me.BtnFillRectangle.Name = "BtnFillRectangle"
        Me.BtnFillRectangle.Size = New System.Drawing.Size(79, 67)
        Me.BtnFillRectangle.TabIndex = 5
        Me.BtnFillRectangle.UseVisualStyleBackColor = True
        '
        'BtnRectangle
        '
        Me.BtnRectangle.BackgroundImage = Global.PaintingSoft.My.Resources.Resources.rounded_rectangle
        Me.BtnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRectangle.Location = New System.Drawing.Point(177, 27)
        Me.BtnRectangle.Name = "BtnRectangle"
        Me.BtnRectangle.Size = New System.Drawing.Size(79, 70)
        Me.BtnRectangle.TabIndex = 4
        Me.BtnRectangle.UseVisualStyleBackColor = True
        '
        'BtnLine
        '
        Me.BtnLine.BackColor = System.Drawing.Color.White
        Me.BtnLine.BackgroundImage = Global.PaintingSoft.My.Resources.Resources.icons8_line_50px1
        Me.BtnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLine.Location = New System.Drawing.Point(92, 103)
        Me.BtnLine.Name = "BtnLine"
        Me.BtnLine.Size = New System.Drawing.Size(79, 67)
        Me.BtnLine.TabIndex = 3
        Me.BtnLine.UseVisualStyleBackColor = False
        '
        'BtnEraser
        '
        Me.BtnEraser.BackgroundImage = Global.PaintingSoft.My.Resources.Resources.eraser_xxx
        Me.BtnEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEraser.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnEraser.Location = New System.Drawing.Point(92, 27)
        Me.BtnEraser.Name = "BtnEraser"
        Me.BtnEraser.Size = New System.Drawing.Size(79, 69)
        Me.BtnEraser.TabIndex = 1
        Me.BtnEraser.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(12, 263)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1502, 644)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1529, 919)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PaintingSoft"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nudPenSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnDraw As Button
    Friend WithEvents BtnEraser As Button
    Friend WithEvents BtnLine As Button
    Friend WithEvents fontText As Button
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
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents Label7 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents BtnColorBackground As Button
End Class
