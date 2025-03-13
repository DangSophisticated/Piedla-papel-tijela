<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        btn_piedra = New Button()
        btn_papel = New Button()
        btn_tijera = New Button()
        PictureBox1 = New PictureBox()
        lbl_titulo = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Timer1 = New Timer(components)
        lbl_respuestacpu = New Label()
        lbl_racha = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(149, 257)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 0
        ' 
        ' btn_piedra
        ' 
        btn_piedra.Font = New Font("Comic Sans MS", 12F)
        btn_piedra.Location = New Point(108, 358)
        btn_piedra.Margin = New Padding(3, 2, 3, 2)
        btn_piedra.Name = "btn_piedra"
        btn_piedra.Size = New Size(126, 30)
        btn_piedra.TabIndex = 1
        btn_piedra.Text = "PIEDRA"
        btn_piedra.UseVisualStyleBackColor = True
        ' 
        ' btn_papel
        ' 
        btn_papel.Font = New Font("Comic Sans MS", 12F)
        btn_papel.Location = New Point(393, 358)
        btn_papel.Margin = New Padding(3, 2, 3, 2)
        btn_papel.Name = "btn_papel"
        btn_papel.Size = New Size(126, 30)
        btn_papel.TabIndex = 2
        btn_papel.Text = "PAPEL"
        btn_papel.UseVisualStyleBackColor = True
        ' 
        ' btn_tijera
        ' 
        btn_tijera.Font = New Font("Comic Sans MS", 12F)
        btn_tijera.Location = New Point(695, 358)
        btn_tijera.Margin = New Padding(3, 2, 3, 2)
        btn_tijera.Name = "btn_tijera"
        btn_tijera.Size = New Size(126, 30)
        btn_tijera.TabIndex = 3
        btn_tijera.Text = "TIJERA"
        btn_tijera.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ButtonHighlight
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(374, 266)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(161, 68)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' lbl_titulo
        ' 
        lbl_titulo.AutoSize = True
        lbl_titulo.Font = New Font("Comic Sans MS", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_titulo.ImageAlign = ContentAlignment.MiddleRight
        lbl_titulo.Location = New Point(185, 16)
        lbl_titulo.Name = "lbl_titulo"
        lbl_titulo.Size = New Size(485, 123)
        lbl_titulo.TabIndex = 5
        lbl_titulo.Text = "EL PIEDRA PAPEL O TIJERAS " & vbCrLf & "MAS VERGATARIO " & vbCrLf & "QUE USTED HA VISTO"
        lbl_titulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(700, 266)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(111, 68)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(125, 257)
        PictureBox3.Margin = New Padding(3, 2, 3, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(109, 80)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' Timer1
        ' 
        ' 
        ' lbl_respuestacpu
        ' 
        lbl_respuestacpu.AutoSize = True
        lbl_respuestacpu.Font = New Font("Comic Sans MS", 18F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lbl_respuestacpu.Location = New Point(291, 152)
        lbl_respuestacpu.Name = "lbl_respuestacpu"
        lbl_respuestacpu.Size = New Size(68, 33)
        lbl_respuestacpu.TabIndex = 8
        lbl_respuestacpu.Text = "Rival"
        lbl_respuestacpu.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl_racha
        ' 
        lbl_racha.AutoSize = True
        lbl_racha.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl_racha.Location = New Point(291, 192)
        lbl_racha.Name = "lbl_racha"
        lbl_racha.Size = New Size(197, 32)
        lbl_racha.TabIndex = 9
        lbl_racha.Text = "Racha de Ganadas"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(874, 463)
        Controls.Add(lbl_racha)
        Controls.Add(lbl_respuestacpu)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(lbl_titulo)
        Controls.Add(PictureBox1)
        Controls.Add(btn_tijera)
        Controls.Add(btn_papel)
        Controls.Add(btn_piedra)
        Controls.Add(Label1)
        DoubleBuffered = True
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "I <3 BEIJING"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_piedra As Button
    Friend WithEvents btn_papel As Button
    Friend WithEvents btn_tijera As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbl_respuestacpu As Label
    Friend WithEvents lbl_racha As Label

End Class
