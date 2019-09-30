﻿Imports System.Drawing.Drawing2D
Imports System.Drawing.Brushes
Public Class Form1
    Dim g As Graphics

    'pen sttings
    Dim mypen, myeraser As Pen
    Dim pencolor, eraserColor As Color
    Dim pensize, erasersize As Integer

    'Brush Settings
    Dim sb As SolidBrush
    Dim hb As HatchBrush
    Dim hs As HatchStyle
    Dim lb As LinearGradientBrush
    Dim tb As TextureBrush
    Dim bs As String
    Dim brushcolor1, brushcolor2 As Color

    'shape Setting
    Dim r As Rectangle
    Dim p1, p2 As Point
    Dim pts() As Point
    Dim mp, totpoint As Integer

    Dim mb As Integer = 0
    Dim num As Integer = 0

    Dim shape As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        g = PictureBox1.CreateGraphics

        'Innitial Settings
        pencolor = Color.Black
        pensize = 2
        erasersize = 25
        eraserColor = Color.White
        brushcolor1 = Color.Black
        brushcolor1 = Color.Black
        bs = "Solid"
        hs = 0
        mp = 0
        totpoint = 0
    End Sub

    Private Sub BtnDraw_Click(sender As Object, e As EventArgs) Handles BtnDraw.Click
        shape = "Draw"
        PictureBox1.Cursor = New Cursor("C:\Users\gnava\source\repos\Paint-vb-2019\Paint-vb-2019\Pencil.cur")
    End Sub

    Private Sub BtnLine_Click(sender As Object, e As EventArgs) Handles BtnLine.Click
        shape = "Line"
        PictureBox1.Cursor = Cursors.Cross
    End Sub

    Private Sub BtnRectangle_Click(sender As Object, e As EventArgs) Handles BtnRectangle.Click
        shape = "Rectangle"
        PictureBox1.Cursor = Cursors.Cross
    End Sub

    Private Sub BtnEllipse_Click(sender As Object, e As EventArgs) Handles BtnEllipse.Click
        shape = "Ellipse"
        PictureBox1.Cursor = Cursors.Cross
    End Sub

    Private Sub CmbHatchStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbHatchStyle.SelectedIndexChanged
        hs = CmbHatchStyle.SelectedIndex
    End Sub

    Private Sub BtnTexture_Click(sender As Object, e As EventArgs) Handles BtnTexture.Click
        If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            bs = "Texture"
            PictureBox1.Load(OpenFileDialog1.FileName)

            For Each c In GBBrush.Controls
                If TypeOf c Is Button Then
                    If c.Text = "Texture" Then
                        c.ForeColor = Color.Red
                    Else
                        c.Forecolor = Color.White
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub BtnColor2_Click(sender As Object, e As EventArgs) Handles BtnColor2.Click
        ColorDialog1.ShowDialog()
        pencolor = ColorDialog1.Color
        brushcolor2 = ColorDialog1.Color
        BtnColor2.BackColor = ColorDialog1.Color
    End Sub

    Private Sub BtnColor1_Click(sender As Object, e As EventArgs) Handles BtnColor1.Click
        ColorDialog1.ShowDialog()
        pencolor = ColorDialog1.Color
        brushcolor1 = ColorDialog1.Color
        BtnColor1.BackColor = ColorDialog1.Color
    End Sub

    Private Sub BtnGradiant_Click(sender As Object, e As EventArgs) Handles BtnGradiant.Click
        bs = "Gradiant"
        PictureBox1.Cursor = Cursors.Cross
    End Sub

    Private Sub BtnHatch_Click(sender As Object, e As EventArgs) Handles BtnHatch.Click
        bs = "Hatch"
        CmbHatchStyle.Items.Clear()
        PictureBox1.Cursor = Cursors.Cross
        Dim i As Integer

        For i = 0 To 52
            hs = i
            CmbHatchStyle.Items.Add(hs)
        Next
        CmbHatchStyle.SelectedIndex = 0
        hs = 0
    End Sub

    Private Sub BtnSolid_Click(sender As Object, e As EventArgs) Handles BtnSolid.Click
        bs = "Solid"
    End Sub

    Private Sub BtnFillRectangle_Click(sender As Object, e As EventArgs) Handles BtnFillRectangle.Click
        shape = "fillRectangle"
        PictureBox1.Cursor = Cursors.Cross
    End Sub

    Private Sub NuevoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        MsgBox("¿Desea crear un nuevo archivo?")
        g.Clear(PictureBox1.BackColor)

    End Sub

    Private Sub Text_Click(sender As Object, e As EventArgs)
        Dim x As Integer = 100
        Dim y As Integer = 200
        'g.DrawString("Hello.", New Font("Arial", 12), Brushes.Black, x, y)
    End Sub

    Private Sub BtnFillEllipse_Click(sender As Object, e As EventArgs) Handles BtnFillEllipse.Click
        shape = "fillEllipse"
        PictureBox1.Cursor = Cursors.Cross
    End Sub

    Private Sub NudPenSize_ValueChanged(sender As Object, e As EventArgs) Handles nudPenSize.ValueChanged
        pensize = nudPenSize.Value
    End Sub

    Private Sub BtnEraser_Click(sender As Object, e As EventArgs) Handles BtnEraser.Click
        shape = "Eraser"
        PictureBox1.Cursor = New Cursor("C:\Users\gnava\source\repos\PaintingSoft\PaintingSoft\Eraser.cur")
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        mp = 1
        mb = 1
        p1 = New Point(e.X, e.Y)
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove

        If mp = 1 And shape = "Draw" Then
            ReDim Preserve pts(totpoint)
            pts(totpoint) = New Point(e.X, e.Y)

            If (totpoint > 1) Then
                If chkDrb.Checked = False Then
                    mypen = New Pen(pencolor, pensize)
                    g.DrawLines(mypen, pts)
                Else
                    Select Case bs
                        Case "Solid"
                            sb = New SolidBrush(brushcolor1)
                            mypen = New Pen(sb, pensize)
                            g.DrawLines(mypen, pts)
                        Case "Hatch"
                            hb = New HatchBrush(hs, brushcolor1, brushcolor2)
                            mypen = New Pen(hb, pensize)
                            g.DrawLines(mypen, pts)
                        Case "Gradiant"
                            lb = New LinearGradientBrush(r, brushcolor1, brushcolor2, 30)
                            mypen = New Pen(lb, pensize)
                            g.DrawLines(mypen, pts)
                        Case "texture"
                            tb = New TextureBrush(PictureBox1.Image)
                            mypen = New Pen(tb, pensize)
                            g.DrawLines(mypen, pts)
                    End Select
                End If
            End If
            totpoint += 1
        End If

        If mb = 1 And shape = "Eraser" Then
            ReDim Preserve pts(num)
            pts(num) = New Point(e.X, e.Y)

            If (num > 1) Then
                myeraser = New Pen(eraserColor, erasersize)
                g.DrawLines(myeraser, pts)
            End If
            num += 1
        End If

    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        mp = 0
        totpoint = 0
        p2 = New Point(e.X, e.Y)

        mb = 0
        num = 0

        Select Case shape
            Case "Line"
                mypen = New Pen(pencolor, pensize)
                g.DrawLine(mypen, p1, p2)
            Case "Rectangle"
                mypen = New Pen(pencolor, pensize)
                r = New Rectangle(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y), Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y))
                g.DrawRectangle(mypen, r)
            Case "Ellipse"
                mypen = New Pen(pencolor, pensize)
                r = New Rectangle(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y), Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y))
                g.DrawEllipse(mypen, r)
            'Case "Eraser"
            '    myeraser = New Pen(eraserColor, erasersize)
            '    g.DrawLine(myeraser, p1, p2)

            Case "fillRectangle"
                Select Case bs
                    Case "Solid"
                        sb = New SolidBrush(brushcolor1)
                        r = New Rectangle(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y), Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y))
                        g.FillRectangle(sb, r)
                    Case "Hatch"
                        hb = New HatchBrush(hs, brushcolor1, brushcolor2)
                        r = New Rectangle(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y), Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y))
                        g.FillRectangle(hb, r)
                    Case "Gradiant"
                        r = New Rectangle(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y), Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y))
                        lb = New LinearGradientBrush(r, brushcolor1, brushcolor2, 30)
                        g.FillRectangle(lb, r)
                    Case "Texture"
                        tb = New TextureBrush(PictureBox1.Image)
                        r = New Rectangle(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y), Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y))
                        g.FillRectangle(tb, r)
                End Select
            Case "fillEllipse"
                Select Case bs
                    Case "Solid"
                        sb = New SolidBrush(brushcolor1)
                        r = New Rectangle(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y), Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y))
                        g.FillEllipse(sb, r)
                    Case "Hatch"
                        hb = New HatchBrush(hs, brushcolor1, brushcolor2)
                        r = New Rectangle(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y), Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y))
                        g.FillEllipse(hb, r)
                    Case "Gradiant"
                        r = New Rectangle(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y), Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y))
                        lb = New LinearGradientBrush(r, brushcolor1, brushcolor2, 30)
                        g.FillEllipse(lb, r)
                    Case "Texture"
                        tb = New TextureBrush(PictureBox1.Image)
                        r = New Rectangle(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y), Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y))
                        g.FillEllipse(tb, r)
                End Select
        End Select
    End Sub

End Class
