<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator_Nunez
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim OpNegative As System.Windows.Forms.Button
        Dim root3 As System.Windows.Forms.Button
        Me.OpEquals = New System.Windows.Forms.Button()
        Me.OpE = New System.Windows.Forms.Button()
        Me.OpSquared = New System.Windows.Forms.Button()
        Me.OpPi = New System.Windows.Forms.Button()
        Me.OpRoot = New System.Windows.Forms.Button()
        Me.OpLn = New System.Windows.Forms.Button()
        Me.Op1overX = New System.Windows.Forms.Button()
        Me.num7 = New System.Windows.Forms.Button()
        Me.num4 = New System.Windows.Forms.Button()
        Me.num1 = New System.Windows.Forms.Button()
        Me.num0 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.num5 = New System.Windows.Forms.Button()
        Me.num2 = New System.Windows.Forms.Button()
        Me.Dot = New System.Windows.Forms.Button()
        Me.num9 = New System.Windows.Forms.Button()
        Me.num6 = New System.Windows.Forms.Button()
        Me.num3 = New System.Windows.Forms.Button()
        Me.OpFact = New System.Windows.Forms.Button()
        Me.OpMultiply = New System.Windows.Forms.Button()
        Me.OpMinus = New System.Windows.Forms.Button()
        Me.OpPlus = New System.Windows.Forms.Button()
        Me.OpDel = New System.Windows.Forms.Button()
        Me.OpClear = New System.Windows.Forms.Button()
        Me.OpClearLeft = New System.Windows.Forms.Button()
        Me.num8 = New System.Windows.Forms.Button()
        Me.OpDivide = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.OpLog = New System.Windows.Forms.Button()
        Me.OpSin = New System.Windows.Forms.Button()
        Me.OpCos = New System.Windows.Forms.Button()
        Me.OpTan = New System.Windows.Forms.Button()
        Me.OpParenOpen = New System.Windows.Forms.Button()
        Me.OpParenClose = New System.Windows.Forms.Button()
        Me.output = New System.Windows.Forms.TextBox()
        Me.OpCubed = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Abs = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        OpNegative = New System.Windows.Forms.Button()
        root3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OpNegative
        '
        OpNegative.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        OpNegative.Location = New System.Drawing.Point(276, 120)
        OpNegative.Margin = New System.Windows.Forms.Padding(1)
        OpNegative.Name = "OpNegative"
        OpNegative.Size = New System.Drawing.Size(42, 46)
        OpNegative.TabIndex = 28
        OpNegative.Text = "(-)"
        OpNegative.UseVisualStyleBackColor = True
        '
        'root3
        '
        root3.BackColor = System.Drawing.Color.CornflowerBlue
        root3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        root3.Location = New System.Drawing.Point(56, 167)
        root3.Margin = New System.Windows.Forms.Padding(1)
        root3.Name = "root3"
        root3.Size = New System.Drawing.Size(42, 46)
        root3.TabIndex = 50
        root3.Text = "√x"
        root3.UseVisualStyleBackColor = False
        AddHandler root3.Click, AddressOf Me.root3_Click
        '
        'OpEquals
        '
        Me.OpEquals.BackColor = System.Drawing.Color.CornflowerBlue
        Me.OpEquals.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.OpEquals.Location = New System.Drawing.Point(12, 311)
        Me.OpEquals.Margin = New System.Windows.Forms.Padding(1)
        Me.OpEquals.Name = "OpEquals"
        Me.OpEquals.Size = New System.Drawing.Size(306, 46)
        Me.OpEquals.TabIndex = 0
        Me.OpEquals.Text = "="
        Me.OpEquals.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.OpEquals.UseVisualStyleBackColor = False
        '
        'OpE
        '
        Me.OpE.BackColor = System.Drawing.Color.CornflowerBlue
        Me.OpE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.OpE.Location = New System.Drawing.Point(12, 215)
        Me.OpE.Margin = New System.Windows.Forms.Padding(1)
        Me.OpE.Name = "OpE"
        Me.OpE.Size = New System.Drawing.Size(42, 46)
        Me.OpE.TabIndex = 2
        Me.OpE.Text = "e"
        Me.OpE.UseVisualStyleBackColor = False
        '
        'OpSquared
        '
        Me.OpSquared.BackColor = System.Drawing.Color.CornflowerBlue
        Me.OpSquared.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.OpSquared.Location = New System.Drawing.Point(12, 119)
        Me.OpSquared.Margin = New System.Windows.Forms.Padding(1)
        Me.OpSquared.Name = "OpSquared"
        Me.OpSquared.Size = New System.Drawing.Size(42, 46)
        Me.OpSquared.TabIndex = 3
        Me.OpSquared.Text = "x"
        Me.OpSquared.UseVisualStyleBackColor = False
        '
        'OpPi
        '
        Me.OpPi.BackColor = System.Drawing.Color.CornflowerBlue
        Me.OpPi.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpPi.Location = New System.Drawing.Point(231, 89)
        Me.OpPi.Margin = New System.Windows.Forms.Padding(1)
        Me.OpPi.Name = "OpPi"
        Me.OpPi.Size = New System.Drawing.Size(42, 29)
        Me.OpPi.TabIndex = 4
        Me.OpPi.Text = "π"
        Me.OpPi.UseVisualStyleBackColor = False
        '
        'OpRoot
        '
        Me.OpRoot.BackColor = System.Drawing.Color.CornflowerBlue
        Me.OpRoot.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.OpRoot.Location = New System.Drawing.Point(14, 167)
        Me.OpRoot.Margin = New System.Windows.Forms.Padding(1)
        Me.OpRoot.Name = "OpRoot"
        Me.OpRoot.Size = New System.Drawing.Size(42, 46)
        Me.OpRoot.TabIndex = 7
        Me.OpRoot.Text = "√x"
        Me.OpRoot.UseVisualStyleBackColor = False
        '
        'OpLn
        '
        Me.OpLn.BackColor = System.Drawing.Color.CornflowerBlue
        Me.OpLn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.OpLn.Location = New System.Drawing.Point(56, 215)
        Me.OpLn.Margin = New System.Windows.Forms.Padding(1)
        Me.OpLn.Name = "OpLn"
        Me.OpLn.Size = New System.Drawing.Size(42, 46)
        Me.OpLn.TabIndex = 6
        Me.OpLn.Text = "ln"
        Me.OpLn.UseVisualStyleBackColor = False
        '
        'Op1overX
        '
        Me.Op1overX.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Op1overX.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Op1overX.Location = New System.Drawing.Point(56, 263)
        Me.Op1overX.Margin = New System.Windows.Forms.Padding(1)
        Me.Op1overX.Name = "Op1overX"
        Me.Op1overX.Size = New System.Drawing.Size(42, 46)
        Me.Op1overX.TabIndex = 5
        Me.Op1overX.Text = "1/x"
        Me.Op1overX.UseVisualStyleBackColor = False
        '
        'num7
        '
        Me.num7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.num7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.num7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.num7.Location = New System.Drawing.Point(100, 118)
        Me.num7.Margin = New System.Windows.Forms.Padding(1)
        Me.num7.Name = "num7"
        Me.num7.Size = New System.Drawing.Size(42, 46)
        Me.num7.TabIndex = 12
        Me.num7.Text = "7"
        Me.num7.UseVisualStyleBackColor = False
        '
        'num4
        '
        Me.num4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.num4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.num4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.num4.Location = New System.Drawing.Point(100, 166)
        Me.num4.Margin = New System.Windows.Forms.Padding(1)
        Me.num4.Name = "num4"
        Me.num4.Size = New System.Drawing.Size(42, 46)
        Me.num4.TabIndex = 11
        Me.num4.Text = "4"
        Me.num4.UseVisualStyleBackColor = False
        '
        'num1
        '
        Me.num1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.num1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.num1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.num1.Location = New System.Drawing.Point(100, 214)
        Me.num1.Margin = New System.Windows.Forms.Padding(1)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(42, 46)
        Me.num1.TabIndex = 10
        Me.num1.Text = "1"
        Me.num1.UseVisualStyleBackColor = False
        '
        'num0
        '
        Me.num0.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.num0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.num0.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.num0.Location = New System.Drawing.Point(100, 263)
        Me.num0.Margin = New System.Windows.Forms.Padding(1)
        Me.num0.Name = "num0"
        Me.num0.Size = New System.Drawing.Size(42, 46)
        Me.num0.TabIndex = 9
        Me.num0.Text = "0"
        Me.num0.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Button14.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button14.Location = New System.Drawing.Point(144, 118)
        Me.Button14.Margin = New System.Windows.Forms.Padding(1)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(42, 46)
        Me.Button14.TabIndex = 16
        Me.Button14.Text = "8"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'num5
        '
        Me.num5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.num5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.num5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.num5.Location = New System.Drawing.Point(144, 166)
        Me.num5.Margin = New System.Windows.Forms.Padding(1)
        Me.num5.Name = "num5"
        Me.num5.Size = New System.Drawing.Size(42, 46)
        Me.num5.TabIndex = 15
        Me.num5.Text = "5"
        Me.num5.UseVisualStyleBackColor = False
        '
        'num2
        '
        Me.num2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.num2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.num2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.num2.Location = New System.Drawing.Point(144, 214)
        Me.num2.Margin = New System.Windows.Forms.Padding(1)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(42, 46)
        Me.num2.TabIndex = 14
        Me.num2.Text = "2"
        Me.num2.UseVisualStyleBackColor = False
        '
        'Dot
        '
        Me.Dot.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Dot.Location = New System.Drawing.Point(144, 262)
        Me.Dot.Margin = New System.Windows.Forms.Padding(1)
        Me.Dot.Name = "Dot"
        Me.Dot.Size = New System.Drawing.Size(42, 46)
        Me.Dot.TabIndex = 13
        Me.Dot.Text = "."
        Me.Dot.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Dot.UseVisualStyleBackColor = True
        '
        'num9
        '
        Me.num9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.num9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.num9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.num9.Location = New System.Drawing.Point(188, 118)
        Me.num9.Margin = New System.Windows.Forms.Padding(1)
        Me.num9.Name = "num9"
        Me.num9.Size = New System.Drawing.Size(42, 46)
        Me.num9.TabIndex = 20
        Me.num9.Text = "9"
        Me.num9.UseVisualStyleBackColor = False
        '
        'num6
        '
        Me.num6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.num6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.num6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.num6.Location = New System.Drawing.Point(188, 166)
        Me.num6.Margin = New System.Windows.Forms.Padding(1)
        Me.num6.Name = "num6"
        Me.num6.Size = New System.Drawing.Size(42, 46)
        Me.num6.TabIndex = 19
        Me.num6.Text = "6"
        Me.num6.UseVisualStyleBackColor = False
        '
        'num3
        '
        Me.num3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.num3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.num3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.num3.Location = New System.Drawing.Point(188, 214)
        Me.num3.Margin = New System.Windows.Forms.Padding(1)
        Me.num3.Name = "num3"
        Me.num3.Size = New System.Drawing.Size(42, 46)
        Me.num3.TabIndex = 18
        Me.num3.Text = "3"
        Me.num3.UseVisualStyleBackColor = False
        '
        'OpFact
        '
        Me.OpFact.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpFact.Location = New System.Drawing.Point(188, 262)
        Me.OpFact.Margin = New System.Windows.Forms.Padding(1)
        Me.OpFact.Name = "OpFact"
        Me.OpFact.Size = New System.Drawing.Size(42, 46)
        Me.OpFact.TabIndex = 17
        Me.OpFact.Text = "X!"
        Me.OpFact.UseVisualStyleBackColor = True
        '
        'OpMultiply
        '
        Me.OpMultiply.BackColor = System.Drawing.Color.DarkGray
        Me.OpMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.OpMultiply.Location = New System.Drawing.Point(232, 167)
        Me.OpMultiply.Margin = New System.Windows.Forms.Padding(1)
        Me.OpMultiply.Name = "OpMultiply"
        Me.OpMultiply.Size = New System.Drawing.Size(42, 46)
        Me.OpMultiply.TabIndex = 23
        Me.OpMultiply.Text = "x"
        Me.OpMultiply.UseVisualStyleBackColor = False
        '
        'OpMinus
        '
        Me.OpMinus.BackColor = System.Drawing.Color.DarkGray
        Me.OpMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.OpMinus.Location = New System.Drawing.Point(232, 215)
        Me.OpMinus.Margin = New System.Windows.Forms.Padding(1)
        Me.OpMinus.Name = "OpMinus"
        Me.OpMinus.Size = New System.Drawing.Size(42, 46)
        Me.OpMinus.TabIndex = 22
        Me.OpMinus.Text = "-"
        Me.OpMinus.UseVisualStyleBackColor = False
        '
        'OpPlus
        '
        Me.OpPlus.BackColor = System.Drawing.Color.DarkGray
        Me.OpPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.OpPlus.Location = New System.Drawing.Point(232, 261)
        Me.OpPlus.Margin = New System.Windows.Forms.Padding(1)
        Me.OpPlus.Name = "OpPlus"
        Me.OpPlus.Size = New System.Drawing.Size(42, 46)
        Me.OpPlus.TabIndex = 21
        Me.OpPlus.Text = "+"
        Me.OpPlus.UseVisualStyleBackColor = False
        '
        'OpDel
        '
        Me.OpDel.BackColor = System.Drawing.Color.IndianRed
        Me.OpDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpDel.Location = New System.Drawing.Point(276, 166)
        Me.OpDel.Margin = New System.Windows.Forms.Padding(1)
        Me.OpDel.Name = "OpDel"
        Me.OpDel.Size = New System.Drawing.Size(42, 46)
        Me.OpDel.TabIndex = 27
        Me.OpDel.Text = "CE"
        Me.OpDel.UseVisualStyleBackColor = False
        '
        'OpClear
        '
        Me.OpClear.BackColor = System.Drawing.Color.IndianRed
        Me.OpClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.OpClear.Location = New System.Drawing.Point(276, 214)
        Me.OpClear.Margin = New System.Windows.Forms.Padding(1)
        Me.OpClear.Name = "OpClear"
        Me.OpClear.Size = New System.Drawing.Size(42, 46)
        Me.OpClear.TabIndex = 26
        Me.OpClear.Text = "C"
        Me.OpClear.UseVisualStyleBackColor = False
        '
        'OpClearLeft
        '
        Me.OpClearLeft.BackColor = System.Drawing.Color.IndianRed
        Me.OpClearLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.OpClearLeft.Location = New System.Drawing.Point(276, 261)
        Me.OpClearLeft.Margin = New System.Windows.Forms.Padding(1)
        Me.OpClearLeft.Name = "OpClearLeft"
        Me.OpClearLeft.Size = New System.Drawing.Size(42, 46)
        Me.OpClearLeft.TabIndex = 25
        Me.OpClearLeft.Text = "◄"
        Me.OpClearLeft.UseVisualStyleBackColor = False
        '
        'num8
        '
        Me.num8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.num8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.num8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.num8.Location = New System.Drawing.Point(145, 118)
        Me.num8.Margin = New System.Windows.Forms.Padding(1)
        Me.num8.Name = "num8"
        Me.num8.Size = New System.Drawing.Size(42, 46)
        Me.num8.TabIndex = 29
        Me.num8.Text = "8"
        Me.num8.UseVisualStyleBackColor = False
        '
        'OpDivide
        '
        Me.OpDivide.BackColor = System.Drawing.Color.DarkGray
        Me.OpDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.OpDivide.Location = New System.Drawing.Point(232, 119)
        Me.OpDivide.Margin = New System.Windows.Forms.Padding(1)
        Me.OpDivide.Name = "OpDivide"
        Me.OpDivide.Size = New System.Drawing.Size(42, 46)
        Me.OpDivide.TabIndex = 30
        Me.OpDivide.Text = "÷"
        Me.OpDivide.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBox2.Location = New System.Drawing.Point(39, 124)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(1)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(10, 16)
        Me.TextBox2.TabIndex = 32
        Me.TextBox2.Text = "2"
        '
        'OpLog
        '
        Me.OpLog.BackColor = System.Drawing.Color.CornflowerBlue
        Me.OpLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.OpLog.Location = New System.Drawing.Point(12, 263)
        Me.OpLog.Margin = New System.Windows.Forms.Padding(1)
        Me.OpLog.Name = "OpLog"
        Me.OpLog.Size = New System.Drawing.Size(42, 46)
        Me.OpLog.TabIndex = 34
        Me.OpLog.Text = "log"
        Me.OpLog.UseVisualStyleBackColor = False
        '
        'OpSin
        '
        Me.OpSin.BackColor = System.Drawing.Color.CornflowerBlue
        Me.OpSin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold)
        Me.OpSin.Location = New System.Drawing.Point(12, 86)
        Me.OpSin.Margin = New System.Windows.Forms.Padding(1)
        Me.OpSin.Name = "OpSin"
        Me.OpSin.Size = New System.Drawing.Size(42, 30)
        Me.OpSin.TabIndex = 35
        Me.OpSin.Text = "sin"
        Me.OpSin.UseVisualStyleBackColor = False
        '
        'OpCos
        '
        Me.OpCos.BackColor = System.Drawing.Color.CornflowerBlue
        Me.OpCos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold)
        Me.OpCos.Location = New System.Drawing.Point(56, 86)
        Me.OpCos.Margin = New System.Windows.Forms.Padding(1)
        Me.OpCos.Name = "OpCos"
        Me.OpCos.Size = New System.Drawing.Size(42, 30)
        Me.OpCos.TabIndex = 36
        Me.OpCos.Text = "cos"
        Me.OpCos.UseVisualStyleBackColor = False
        '
        'OpTan
        '
        Me.OpTan.BackColor = System.Drawing.Color.CornflowerBlue
        Me.OpTan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold)
        Me.OpTan.Location = New System.Drawing.Point(100, 86)
        Me.OpTan.Margin = New System.Windows.Forms.Padding(1)
        Me.OpTan.Name = "OpTan"
        Me.OpTan.Size = New System.Drawing.Size(42, 30)
        Me.OpTan.TabIndex = 37
        Me.OpTan.Text = "tan"
        Me.OpTan.UseVisualStyleBackColor = False
        '
        'OpParenOpen
        '
        Me.OpParenOpen.BackColor = System.Drawing.Color.Lavender
        Me.OpParenOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold)
        Me.OpParenOpen.Location = New System.Drawing.Point(145, 86)
        Me.OpParenOpen.Margin = New System.Windows.Forms.Padding(1)
        Me.OpParenOpen.Name = "OpParenOpen"
        Me.OpParenOpen.Size = New System.Drawing.Size(42, 30)
        Me.OpParenOpen.TabIndex = 38
        Me.OpParenOpen.Text = "("
        Me.OpParenOpen.UseVisualStyleBackColor = False
        '
        'OpParenClose
        '
        Me.OpParenClose.BackColor = System.Drawing.Color.Lavender
        Me.OpParenClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold)
        Me.OpParenClose.Location = New System.Drawing.Point(187, 86)
        Me.OpParenClose.Margin = New System.Windows.Forms.Padding(1)
        Me.OpParenClose.Name = "OpParenClose"
        Me.OpParenClose.Size = New System.Drawing.Size(42, 30)
        Me.OpParenClose.TabIndex = 39
        Me.OpParenClose.Text = ")"
        Me.OpParenClose.UseVisualStyleBackColor = False
        '
        'output
        '
        Me.output.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.output.Location = New System.Drawing.Point(12, 26)
        Me.output.Multiline = True
        Me.output.Name = "output"
        Me.output.Size = New System.Drawing.Size(304, 40)
        Me.output.TabIndex = 42
        Me.output.Text = "0"
        Me.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'OpCubed
        '
        Me.OpCubed.BackColor = System.Drawing.Color.CornflowerBlue
        Me.OpCubed.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.OpCubed.Location = New System.Drawing.Point(56, 118)
        Me.OpCubed.Margin = New System.Windows.Forms.Padding(1)
        Me.OpCubed.Name = "OpCubed"
        Me.OpCubed.Size = New System.Drawing.Size(42, 46)
        Me.OpCubed.TabIndex = 45
        Me.OpCubed.Text = "x"
        Me.OpCubed.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBox1.Location = New System.Drawing.Point(81, 123)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(10, 16)
        Me.TextBox1.TabIndex = 46
        Me.TextBox1.Text = "3"
        '
        'Abs
        '
        Me.Abs.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Abs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Abs.Location = New System.Drawing.Point(276, 87)
        Me.Abs.Margin = New System.Windows.Forms.Padding(1)
        Me.Abs.Name = "Abs"
        Me.Abs.Size = New System.Drawing.Size(42, 30)
        Me.Abs.TabIndex = 49
        Me.Abs.Text = "Abs"
        Me.Abs.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(62, 178)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(1)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(10, 8)
        Me.TextBox3.TabIndex = 51
        Me.TextBox3.Text = "3"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Calculator_Nunez
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(328, 370)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(root3)
        Me.Controls.Add(Me.Abs)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.OpCubed)
        Me.Controls.Add(Me.output)
        Me.Controls.Add(Me.OpParenClose)
        Me.Controls.Add(Me.OpParenOpen)
        Me.Controls.Add(Me.OpTan)
        Me.Controls.Add(Me.OpCos)
        Me.Controls.Add(Me.OpSin)
        Me.Controls.Add(Me.OpLog)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.OpDivide)
        Me.Controls.Add(Me.num8)
        Me.Controls.Add(OpNegative)
        Me.Controls.Add(Me.OpDel)
        Me.Controls.Add(Me.OpClear)
        Me.Controls.Add(Me.OpClearLeft)
        Me.Controls.Add(Me.OpMultiply)
        Me.Controls.Add(Me.OpMinus)
        Me.Controls.Add(Me.OpPlus)
        Me.Controls.Add(Me.num9)
        Me.Controls.Add(Me.num6)
        Me.Controls.Add(Me.num3)
        Me.Controls.Add(Me.OpFact)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.num5)
        Me.Controls.Add(Me.num2)
        Me.Controls.Add(Me.Dot)
        Me.Controls.Add(Me.num7)
        Me.Controls.Add(Me.num4)
        Me.Controls.Add(Me.num1)
        Me.Controls.Add(Me.num0)
        Me.Controls.Add(Me.OpRoot)
        Me.Controls.Add(Me.OpLn)
        Me.Controls.Add(Me.Op1overX)
        Me.Controls.Add(Me.OpPi)
        Me.Controls.Add(Me.OpSquared)
        Me.Controls.Add(Me.OpE)
        Me.Controls.Add(Me.OpEquals)
        Me.Name = "Calculator_Nunez"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpEquals As Button
    Friend WithEvents OpE As Button
    Friend WithEvents OpSquared As Button
    Friend WithEvents OpPi As Button
    Friend WithEvents OpRoot As Button
    Friend WithEvents OpLn As Button
    Friend WithEvents Op1overX As Button
    Friend WithEvents num7 As Button
    Friend WithEvents num4 As Button
    Friend WithEvents num1 As Button
    Friend WithEvents num0 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents num5 As Button
    Friend WithEvents num2 As Button
    Friend WithEvents Dot As Button
    Friend WithEvents num9 As Button
    Friend WithEvents num6 As Button
    Friend WithEvents num3 As Button
    Friend WithEvents OpFact As Button
    Friend WithEvents OpMultiply As Button
    Friend WithEvents OpMinus As Button
    Friend WithEvents OpPlus As Button
    Friend WithEvents OpDel As Button
    Friend WithEvents OpClear As Button
    Friend WithEvents OpClearLeft As Button
    Friend WithEvents num8 As Button
    Friend WithEvents OpDivide As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents OpLog As Button
    Friend WithEvents OpSin As Button
    Friend WithEvents OpCos As Button
    Friend WithEvents OpTan As Button
    Friend WithEvents OpParenOpen As Button
    Friend WithEvents OpParenClose As Button
    Friend WithEvents OpCubed As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Abs As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents output As TextBox
End Class
