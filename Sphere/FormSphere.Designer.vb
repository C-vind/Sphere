<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSphere
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GBoxRad = New System.Windows.Forms.GroupBox()
        Me.BtnDecRad = New System.Windows.Forms.Button()
        Me.BtnResRad = New System.Windows.Forms.Button()
        Me.BtnIncRad = New System.Windows.Forms.Button()
        Me.TxtRad = New System.Windows.Forms.TextBox()
        Me.GBoxTrans = New System.Windows.Forms.GroupBox()
        Me.BtnResTrans = New System.Windows.Forms.Button()
        Me.BtnIncTz = New System.Windows.Forms.Button()
        Me.BtnIncTy = New System.Windows.Forms.Button()
        Me.BtnIncTx = New System.Windows.Forms.Button()
        Me.BtnDecTz = New System.Windows.Forms.Button()
        Me.BtnDecTy = New System.Windows.Forms.Button()
        Me.BtnDecTx = New System.Windows.Forms.Button()
        Me.BtnTrans = New System.Windows.Forms.Button()
        Me.TxtTz = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTx = New System.Windows.Forms.TextBox()
        Me.LblX = New System.Windows.Forms.Label()
        Me.TxtTy = New System.Windows.Forms.TextBox()
        Me.LblVx = New System.Windows.Forms.Label()
        Me.LblCenter = New System.Windows.Forms.Label()
        Me.PicBox = New System.Windows.Forms.PictureBox()
        Me.GBoxLong = New System.Windows.Forms.GroupBox()
        Me.BtnDecLon = New System.Windows.Forms.Button()
        Me.BtnResLon = New System.Windows.Forms.Button()
        Me.BtnIncLon = New System.Windows.Forms.Button()
        Me.TxtLon = New System.Windows.Forms.TextBox()
        Me.GBoxRot = New System.Windows.Forms.GroupBox()
        Me.BtnResRot = New System.Windows.Forms.Button()
        Me.BtnIncRz = New System.Windows.Forms.Button()
        Me.BtnIncRy = New System.Windows.Forms.Button()
        Me.BtnIncRx = New System.Windows.Forms.Button()
        Me.BtnDecRz = New System.Windows.Forms.Button()
        Me.BtnDecRy = New System.Windows.Forms.Button()
        Me.BtnDecRx = New System.Windows.Forms.Button()
        Me.TxtRz = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtRx = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtRy = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtLat = New System.Windows.Forms.TextBox()
        Me.BtnIncLat = New System.Windows.Forms.Button()
        Me.BtnResLat = New System.Windows.Forms.Button()
        Me.BtnDecLat = New System.Windows.Forms.Button()
        Me.GBoxLat = New System.Windows.Forms.GroupBox()
        Me.TimerDraw = New System.Windows.Forms.Timer(Me.components)
        Me.GBoxRad.SuspendLayout()
        Me.GBoxTrans.SuspendLayout()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBoxLong.SuspendLayout()
        Me.GBoxRot.SuspendLayout()
        Me.GBoxLat.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBoxRad
        '
        Me.GBoxRad.Controls.Add(Me.BtnDecRad)
        Me.GBoxRad.Controls.Add(Me.BtnResRad)
        Me.GBoxRad.Controls.Add(Me.BtnIncRad)
        Me.GBoxRad.Controls.Add(Me.TxtRad)
        Me.GBoxRad.ForeColor = System.Drawing.Color.White
        Me.GBoxRad.Location = New System.Drawing.Point(489, 291)
        Me.GBoxRad.Name = "GBoxRad"
        Me.GBoxRad.Size = New System.Drawing.Size(90, 74)
        Me.GBoxRad.TabIndex = 34
        Me.GBoxRad.TabStop = False
        Me.GBoxRad.Text = "Radius"
        '
        'BtnDecRad
        '
        Me.BtnDecRad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnDecRad.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnDecRad.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDecRad.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnDecRad.Location = New System.Drawing.Point(55, 42)
        Me.BtnDecRad.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnDecRad.Name = "BtnDecRad"
        Me.BtnDecRad.Size = New System.Drawing.Size(31, 25)
        Me.BtnDecRad.TabIndex = 24
        Me.BtnDecRad.Text = "-"
        Me.BtnDecRad.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDecRad.UseVisualStyleBackColor = False
        '
        'BtnResRad
        '
        Me.BtnResRad.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnResRad.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnResRad.Location = New System.Drawing.Point(5, 42)
        Me.BtnResRad.Name = "BtnResRad"
        Me.BtnResRad.Size = New System.Drawing.Size(48, 25)
        Me.BtnResRad.TabIndex = 25
        Me.BtnResRad.Text = "Reset"
        Me.BtnResRad.UseVisualStyleBackColor = False
        '
        'BtnIncRad
        '
        Me.BtnIncRad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnIncRad.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnIncRad.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIncRad.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnIncRad.Location = New System.Drawing.Point(55, 14)
        Me.BtnIncRad.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnIncRad.Name = "BtnIncRad"
        Me.BtnIncRad.Size = New System.Drawing.Size(31, 25)
        Me.BtnIncRad.TabIndex = 23
        Me.BtnIncRad.Text = "+"
        Me.BtnIncRad.UseVisualStyleBackColor = False
        '
        'TxtRad
        '
        Me.TxtRad.Enabled = False
        Me.TxtRad.Location = New System.Drawing.Point(6, 18)
        Me.TxtRad.Name = "TxtRad"
        Me.TxtRad.Size = New System.Drawing.Size(46, 20)
        Me.TxtRad.TabIndex = 11
        Me.TxtRad.Text = "1"
        '
        'GBoxTrans
        '
        Me.GBoxTrans.Controls.Add(Me.BtnResTrans)
        Me.GBoxTrans.Controls.Add(Me.BtnIncTz)
        Me.GBoxTrans.Controls.Add(Me.BtnIncTy)
        Me.GBoxTrans.Controls.Add(Me.BtnIncTx)
        Me.GBoxTrans.Controls.Add(Me.BtnDecTz)
        Me.GBoxTrans.Controls.Add(Me.BtnDecTy)
        Me.GBoxTrans.Controls.Add(Me.BtnDecTx)
        Me.GBoxTrans.Controls.Add(Me.BtnTrans)
        Me.GBoxTrans.Controls.Add(Me.TxtTz)
        Me.GBoxTrans.Controls.Add(Me.Label1)
        Me.GBoxTrans.Controls.Add(Me.TxtTx)
        Me.GBoxTrans.Controls.Add(Me.LblX)
        Me.GBoxTrans.Controls.Add(Me.TxtTy)
        Me.GBoxTrans.Controls.Add(Me.LblVx)
        Me.GBoxTrans.ForeColor = System.Drawing.Color.White
        Me.GBoxTrans.Location = New System.Drawing.Point(476, 89)
        Me.GBoxTrans.Name = "GBoxTrans"
        Me.GBoxTrans.Size = New System.Drawing.Size(156, 154)
        Me.GBoxTrans.TabIndex = 32
        Me.GBoxTrans.TabStop = False
        Me.GBoxTrans.Text = "Translate"
        '
        'BtnResTrans
        '
        Me.BtnResTrans.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnResTrans.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnResTrans.Location = New System.Drawing.Point(83, 117)
        Me.BtnResTrans.Name = "BtnResTrans"
        Me.BtnResTrans.Size = New System.Drawing.Size(66, 25)
        Me.BtnResTrans.TabIndex = 11
        Me.BtnResTrans.Text = "Reset"
        Me.BtnResTrans.UseVisualStyleBackColor = False
        '
        'BtnIncTz
        '
        Me.BtnIncTz.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnIncTz.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnIncTz.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIncTz.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnIncTz.Location = New System.Drawing.Point(118, 83)
        Me.BtnIncTz.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnIncTz.Name = "BtnIncTz"
        Me.BtnIncTz.Size = New System.Drawing.Size(31, 25)
        Me.BtnIncTz.TabIndex = 9
        Me.BtnIncTz.Text = "+"
        Me.BtnIncTz.UseVisualStyleBackColor = False
        '
        'BtnIncTy
        '
        Me.BtnIncTy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnIncTy.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnIncTy.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIncTy.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnIncTy.Location = New System.Drawing.Point(118, 50)
        Me.BtnIncTy.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnIncTy.Name = "BtnIncTy"
        Me.BtnIncTy.Size = New System.Drawing.Size(31, 25)
        Me.BtnIncTy.TabIndex = 6
        Me.BtnIncTy.Text = "+"
        Me.BtnIncTy.UseVisualStyleBackColor = False
        '
        'BtnIncTx
        '
        Me.BtnIncTx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnIncTx.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnIncTx.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIncTx.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnIncTx.Location = New System.Drawing.Point(118, 17)
        Me.BtnIncTx.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnIncTx.Name = "BtnIncTx"
        Me.BtnIncTx.Size = New System.Drawing.Size(31, 25)
        Me.BtnIncTx.TabIndex = 3
        Me.BtnIncTx.Text = "+"
        Me.BtnIncTx.UseVisualStyleBackColor = False
        '
        'BtnDecTz
        '
        Me.BtnDecTz.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnDecTz.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnDecTz.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDecTz.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnDecTz.Location = New System.Drawing.Point(83, 83)
        Me.BtnDecTz.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnDecTz.Name = "BtnDecTz"
        Me.BtnDecTz.Size = New System.Drawing.Size(31, 25)
        Me.BtnDecTz.TabIndex = 8
        Me.BtnDecTz.Text = "-"
        Me.BtnDecTz.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDecTz.UseVisualStyleBackColor = False
        '
        'BtnDecTy
        '
        Me.BtnDecTy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnDecTy.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnDecTy.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDecTy.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnDecTy.Location = New System.Drawing.Point(83, 50)
        Me.BtnDecTy.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnDecTy.Name = "BtnDecTy"
        Me.BtnDecTy.Size = New System.Drawing.Size(31, 25)
        Me.BtnDecTy.TabIndex = 5
        Me.BtnDecTy.Text = "-"
        Me.BtnDecTy.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDecTy.UseVisualStyleBackColor = False
        '
        'BtnDecTx
        '
        Me.BtnDecTx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnDecTx.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnDecTx.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDecTx.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnDecTx.Location = New System.Drawing.Point(83, 17)
        Me.BtnDecTx.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnDecTx.Name = "BtnDecTx"
        Me.BtnDecTx.Size = New System.Drawing.Size(31, 25)
        Me.BtnDecTx.TabIndex = 2
        Me.BtnDecTx.Text = "-"
        Me.BtnDecTx.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDecTx.UseVisualStyleBackColor = False
        '
        'BtnTrans
        '
        Me.BtnTrans.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnTrans.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnTrans.Location = New System.Drawing.Point(7, 117)
        Me.BtnTrans.Name = "BtnTrans"
        Me.BtnTrans.Size = New System.Drawing.Size(69, 25)
        Me.BtnTrans.TabIndex = 10
        Me.BtnTrans.Text = "Translate"
        Me.BtnTrans.UseVisualStyleBackColor = False
        '
        'TxtTz
        '
        Me.TxtTz.Location = New System.Drawing.Point(33, 86)
        Me.TxtTz.Name = "TxtTz"
        Me.TxtTz.Size = New System.Drawing.Size(40, 20)
        Me.TxtTz.TabIndex = 7
        Me.TxtTz.Text = "0.1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(7, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Z :"
        '
        'TxtTx
        '
        Me.TxtTx.Location = New System.Drawing.Point(33, 21)
        Me.TxtTx.Name = "TxtTx"
        Me.TxtTx.Size = New System.Drawing.Size(40, 20)
        Me.TxtTx.TabIndex = 1
        Me.TxtTx.Text = "0.1"
        '
        'LblX
        '
        Me.LblX.AutoSize = True
        Me.LblX.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.LblX.Location = New System.Drawing.Point(7, 24)
        Me.LblX.Name = "LblX"
        Me.LblX.Size = New System.Drawing.Size(20, 13)
        Me.LblX.TabIndex = 37
        Me.LblX.Text = "X :"
        '
        'TxtTy
        '
        Me.TxtTy.Location = New System.Drawing.Point(33, 53)
        Me.TxtTy.Name = "TxtTy"
        Me.TxtTy.Size = New System.Drawing.Size(40, 20)
        Me.TxtTy.TabIndex = 4
        Me.TxtTy.Text = "0.1"
        '
        'LblVx
        '
        Me.LblVx.AutoSize = True
        Me.LblVx.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.LblVx.Location = New System.Drawing.Point(7, 56)
        Me.LblVx.Name = "LblVx"
        Me.LblVx.Size = New System.Drawing.Size(20, 13)
        Me.LblVx.TabIndex = 38
        Me.LblVx.Text = "Y :"
        '
        'LblCenter
        '
        Me.LblCenter.AutoSize = True
        Me.LblCenter.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.LblCenter.Location = New System.Drawing.Point(8, 464)
        Me.LblCenter.Name = "LblCenter"
        Me.LblCenter.Size = New System.Drawing.Size(101, 13)
        Me.LblCenter.TabIndex = 43
        Me.LblCenter.Text = "Center Coordinate : "
        '
        'PicBox
        '
        Me.PicBox.BackColor = System.Drawing.Color.Black
        Me.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicBox.Location = New System.Drawing.Point(10, 13)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(444, 444)
        Me.PicBox.TabIndex = 15
        Me.PicBox.TabStop = False
        '
        'GBoxLong
        '
        Me.GBoxLong.Controls.Add(Me.BtnDecLon)
        Me.GBoxLong.Controls.Add(Me.BtnResLon)
        Me.GBoxLong.Controls.Add(Me.BtnIncLon)
        Me.GBoxLong.Controls.Add(Me.TxtLon)
        Me.GBoxLong.ForeColor = System.Drawing.Color.White
        Me.GBoxLong.Location = New System.Drawing.Point(698, 290)
        Me.GBoxLong.Name = "GBoxLong"
        Me.GBoxLong.Size = New System.Drawing.Size(90, 74)
        Me.GBoxLong.TabIndex = 36
        Me.GBoxLong.TabStop = False
        Me.GBoxLong.Text = "Longitude"
        '
        'BtnDecLon
        '
        Me.BtnDecLon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnDecLon.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnDecLon.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDecLon.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnDecLon.Location = New System.Drawing.Point(55, 42)
        Me.BtnDecLon.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnDecLon.Name = "BtnDecLon"
        Me.BtnDecLon.Size = New System.Drawing.Size(31, 25)
        Me.BtnDecLon.TabIndex = 30
        Me.BtnDecLon.Text = "-"
        Me.BtnDecLon.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDecLon.UseVisualStyleBackColor = False
        '
        'BtnResLon
        '
        Me.BtnResLon.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnResLon.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnResLon.Location = New System.Drawing.Point(5, 42)
        Me.BtnResLon.Name = "BtnResLon"
        Me.BtnResLon.Size = New System.Drawing.Size(48, 25)
        Me.BtnResLon.TabIndex = 31
        Me.BtnResLon.Text = "Reset"
        Me.BtnResLon.UseVisualStyleBackColor = False
        '
        'BtnIncLon
        '
        Me.BtnIncLon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnIncLon.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnIncLon.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIncLon.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnIncLon.Location = New System.Drawing.Point(55, 14)
        Me.BtnIncLon.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnIncLon.Name = "BtnIncLon"
        Me.BtnIncLon.Size = New System.Drawing.Size(31, 25)
        Me.BtnIncLon.TabIndex = 29
        Me.BtnIncLon.Text = "+"
        Me.BtnIncLon.UseVisualStyleBackColor = False
        '
        'TxtLon
        '
        Me.TxtLon.Enabled = False
        Me.TxtLon.Location = New System.Drawing.Point(6, 18)
        Me.TxtLon.Name = "TxtLon"
        Me.TxtLon.Size = New System.Drawing.Size(46, 20)
        Me.TxtLon.TabIndex = 11
        Me.TxtLon.Text = "20"
        '
        'GBoxRot
        '
        Me.GBoxRot.Controls.Add(Me.BtnResRot)
        Me.GBoxRot.Controls.Add(Me.BtnIncRz)
        Me.GBoxRot.Controls.Add(Me.BtnIncRy)
        Me.GBoxRot.Controls.Add(Me.BtnIncRx)
        Me.GBoxRot.Controls.Add(Me.BtnDecRz)
        Me.GBoxRot.Controls.Add(Me.BtnDecRy)
        Me.GBoxRot.Controls.Add(Me.BtnDecRx)
        Me.GBoxRot.Controls.Add(Me.TxtRz)
        Me.GBoxRot.Controls.Add(Me.Label5)
        Me.GBoxRot.Controls.Add(Me.TxtRx)
        Me.GBoxRot.Controls.Add(Me.Label6)
        Me.GBoxRot.Controls.Add(Me.TxtRy)
        Me.GBoxRot.Controls.Add(Me.Label7)
        Me.GBoxRot.ForeColor = System.Drawing.Color.White
        Me.GBoxRot.Location = New System.Drawing.Point(646, 89)
        Me.GBoxRot.Name = "GBoxRot"
        Me.GBoxRot.Size = New System.Drawing.Size(156, 154)
        Me.GBoxRot.TabIndex = 33
        Me.GBoxRot.TabStop = False
        Me.GBoxRot.Text = "Rotate"
        '
        'BtnResRot
        '
        Me.BtnResRot.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnResRot.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnResRot.Location = New System.Drawing.Point(10, 117)
        Me.BtnResRot.Name = "BtnResRot"
        Me.BtnResRot.Size = New System.Drawing.Size(139, 25)
        Me.BtnResRot.TabIndex = 22
        Me.BtnResRot.Text = "Reset"
        Me.BtnResRot.UseVisualStyleBackColor = False
        '
        'BtnIncRz
        '
        Me.BtnIncRz.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnIncRz.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnIncRz.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIncRz.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnIncRz.Location = New System.Drawing.Point(118, 83)
        Me.BtnIncRz.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnIncRz.Name = "BtnIncRz"
        Me.BtnIncRz.Size = New System.Drawing.Size(31, 25)
        Me.BtnIncRz.TabIndex = 20
        Me.BtnIncRz.Text = "+"
        Me.BtnIncRz.UseVisualStyleBackColor = False
        '
        'BtnIncRy
        '
        Me.BtnIncRy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnIncRy.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnIncRy.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIncRy.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnIncRy.Location = New System.Drawing.Point(118, 50)
        Me.BtnIncRy.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnIncRy.Name = "BtnIncRy"
        Me.BtnIncRy.Size = New System.Drawing.Size(31, 25)
        Me.BtnIncRy.TabIndex = 17
        Me.BtnIncRy.Text = "+"
        Me.BtnIncRy.UseVisualStyleBackColor = False
        '
        'BtnIncRx
        '
        Me.BtnIncRx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnIncRx.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnIncRx.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIncRx.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnIncRx.Location = New System.Drawing.Point(118, 17)
        Me.BtnIncRx.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnIncRx.Name = "BtnIncRx"
        Me.BtnIncRx.Size = New System.Drawing.Size(31, 25)
        Me.BtnIncRx.TabIndex = 14
        Me.BtnIncRx.Text = "+"
        Me.BtnIncRx.UseVisualStyleBackColor = False
        '
        'BtnDecRz
        '
        Me.BtnDecRz.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnDecRz.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnDecRz.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDecRz.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnDecRz.Location = New System.Drawing.Point(83, 83)
        Me.BtnDecRz.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnDecRz.Name = "BtnDecRz"
        Me.BtnDecRz.Size = New System.Drawing.Size(31, 25)
        Me.BtnDecRz.TabIndex = 19
        Me.BtnDecRz.Text = "-"
        Me.BtnDecRz.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDecRz.UseVisualStyleBackColor = False
        '
        'BtnDecRy
        '
        Me.BtnDecRy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnDecRy.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnDecRy.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDecRy.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnDecRy.Location = New System.Drawing.Point(83, 50)
        Me.BtnDecRy.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnDecRy.Name = "BtnDecRy"
        Me.BtnDecRy.Size = New System.Drawing.Size(31, 25)
        Me.BtnDecRy.TabIndex = 16
        Me.BtnDecRy.Text = "-"
        Me.BtnDecRy.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDecRy.UseVisualStyleBackColor = False
        '
        'BtnDecRx
        '
        Me.BtnDecRx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnDecRx.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnDecRx.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDecRx.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnDecRx.Location = New System.Drawing.Point(83, 17)
        Me.BtnDecRx.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnDecRx.Name = "BtnDecRx"
        Me.BtnDecRx.Size = New System.Drawing.Size(31, 25)
        Me.BtnDecRx.TabIndex = 13
        Me.BtnDecRx.Text = "-"
        Me.BtnDecRx.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDecRx.UseVisualStyleBackColor = False
        '
        'TxtRz
        '
        Me.TxtRz.Location = New System.Drawing.Point(33, 86)
        Me.TxtRz.Name = "TxtRz"
        Me.TxtRz.Size = New System.Drawing.Size(40, 20)
        Me.TxtRz.TabIndex = 18
        Me.TxtRz.Text = "10"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label5.Location = New System.Drawing.Point(7, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Z :"
        '
        'TxtRx
        '
        Me.TxtRx.Location = New System.Drawing.Point(33, 21)
        Me.TxtRx.Name = "TxtRx"
        Me.TxtRx.Size = New System.Drawing.Size(40, 20)
        Me.TxtRx.TabIndex = 12
        Me.TxtRx.Text = "10"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label6.Location = New System.Drawing.Point(7, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "X :"
        '
        'TxtRy
        '
        Me.TxtRy.Location = New System.Drawing.Point(33, 53)
        Me.TxtRy.Name = "TxtRy"
        Me.TxtRy.Size = New System.Drawing.Size(40, 20)
        Me.TxtRy.TabIndex = 15
        Me.TxtRy.Text = "10"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label7.Location = New System.Drawing.Point(7, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Y :"
        '
        'TxtLat
        '
        Me.TxtLat.Enabled = False
        Me.TxtLat.Location = New System.Drawing.Point(6, 18)
        Me.TxtLat.Name = "TxtLat"
        Me.TxtLat.Size = New System.Drawing.Size(46, 20)
        Me.TxtLat.TabIndex = 11
        Me.TxtLat.Text = "20"
        '
        'BtnIncLat
        '
        Me.BtnIncLat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnIncLat.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnIncLat.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIncLat.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnIncLat.Location = New System.Drawing.Point(55, 14)
        Me.BtnIncLat.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnIncLat.Name = "BtnIncLat"
        Me.BtnIncLat.Size = New System.Drawing.Size(31, 25)
        Me.BtnIncLat.TabIndex = 26
        Me.BtnIncLat.Text = "+"
        Me.BtnIncLat.UseVisualStyleBackColor = False
        '
        'BtnResLat
        '
        Me.BtnResLat.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnResLat.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnResLat.Location = New System.Drawing.Point(5, 42)
        Me.BtnResLat.Name = "BtnResLat"
        Me.BtnResLat.Size = New System.Drawing.Size(48, 25)
        Me.BtnResLat.TabIndex = 28
        Me.BtnResLat.Text = "Reset"
        Me.BtnResLat.UseVisualStyleBackColor = False
        '
        'BtnDecLat
        '
        Me.BtnDecLat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnDecLat.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnDecLat.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDecLat.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnDecLat.Location = New System.Drawing.Point(55, 42)
        Me.BtnDecLat.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnDecLat.Name = "BtnDecLat"
        Me.BtnDecLat.Size = New System.Drawing.Size(31, 25)
        Me.BtnDecLat.TabIndex = 27
        Me.BtnDecLat.Text = "-"
        Me.BtnDecLat.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDecLat.UseVisualStyleBackColor = False
        '
        'GBoxLat
        '
        Me.GBoxLat.Controls.Add(Me.BtnDecLat)
        Me.GBoxLat.Controls.Add(Me.BtnResLat)
        Me.GBoxLat.Controls.Add(Me.BtnIncLat)
        Me.GBoxLat.Controls.Add(Me.TxtLat)
        Me.GBoxLat.ForeColor = System.Drawing.Color.White
        Me.GBoxLat.Location = New System.Drawing.Point(594, 291)
        Me.GBoxLat.Name = "GBoxLat"
        Me.GBoxLat.Size = New System.Drawing.Size(90, 74)
        Me.GBoxLat.TabIndex = 35
        Me.GBoxLat.TabStop = False
        Me.GBoxLat.Text = "Latitude"
        '
        'TimerDraw
        '
        '
        'FormSphere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(824, 486)
        Me.Controls.Add(Me.GBoxRot)
        Me.Controls.Add(Me.GBoxLong)
        Me.Controls.Add(Me.GBoxLat)
        Me.Controls.Add(Me.GBoxRad)
        Me.Controls.Add(Me.GBoxTrans)
        Me.Controls.Add(Me.LblCenter)
        Me.Controls.Add(Me.PicBox)
        Me.Name = "FormSphere"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSphere"
        Me.GBoxRad.ResumeLayout(False)
        Me.GBoxRad.PerformLayout()
        Me.GBoxTrans.ResumeLayout(False)
        Me.GBoxTrans.PerformLayout()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBoxLong.ResumeLayout(False)
        Me.GBoxLong.PerformLayout()
        Me.GBoxRot.ResumeLayout(False)
        Me.GBoxRot.PerformLayout()
        Me.GBoxLat.ResumeLayout(False)
        Me.GBoxLat.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBoxRad As GroupBox
    Friend WithEvents BtnDecRad As Button
    Friend WithEvents BtnResRad As Button
    Friend WithEvents BtnIncRad As Button
    Friend WithEvents TxtRad As TextBox
    Friend WithEvents GBoxTrans As GroupBox
    Friend WithEvents TxtTx As TextBox
    Friend WithEvents LblX As Label
    Friend WithEvents TxtTy As TextBox
    Friend WithEvents LblVx As Label
    Friend WithEvents LblCenter As Label
    Friend WithEvents PicBox As PictureBox
    Friend WithEvents BtnTrans As Button
    Friend WithEvents TxtTz As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GBoxLong As GroupBox
    Friend WithEvents BtnDecLon As Button
    Friend WithEvents BtnResLon As Button
    Friend WithEvents BtnIncLon As Button
    Friend WithEvents TxtLon As TextBox
    Friend WithEvents BtnResTrans As Button
    Friend WithEvents BtnIncTz As Button
    Friend WithEvents BtnIncTy As Button
    Friend WithEvents BtnIncTx As Button
    Friend WithEvents BtnDecTz As Button
    Friend WithEvents BtnDecTy As Button
    Friend WithEvents BtnDecTx As Button
    Friend WithEvents GBoxRot As GroupBox
    Friend WithEvents BtnResRot As Button
    Friend WithEvents BtnIncRz As Button
    Friend WithEvents BtnIncRy As Button
    Friend WithEvents BtnIncRx As Button
    Friend WithEvents BtnDecRz As Button
    Friend WithEvents BtnDecRy As Button
    Friend WithEvents BtnDecRx As Button
    Friend WithEvents TxtRz As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtRx As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtRy As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtLat As TextBox
    Friend WithEvents BtnIncLat As Button
    Friend WithEvents BtnResLat As Button
    Friend WithEvents BtnDecLat As Button
    Friend WithEvents GBoxLat As GroupBox
    Friend WithEvents TimerDraw As Timer
End Class
