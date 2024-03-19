<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picGround = New System.Windows.Forms.PictureBox()
        Me.picAir = New System.Windows.Forms.PictureBox()
        Me.TimerRIght = New System.Windows.Forms.Timer(Me.components)
        Me.Timerleft = New System.Windows.Forms.Timer(Me.components)
        Me.Timerup = New System.Windows.Forms.Timer(Me.components)
        Me.timerGamelogic = New System.Windows.Forms.Timer(Me.components)
        Me.timerGravity = New System.Windows.Forms.Timer(Me.components)
        Me.mousePictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Scorepoints = New System.Windows.Forms.Label()
        Me.Scorelabel = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Mover1 = New platforminggame.mover()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mousePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.picPlayer.Location = New System.Drawing.Point(521, 330)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(102, 76)
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        '
        'picGround
        '
        Me.picGround.Location = New System.Drawing.Point(82, 361)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(788, 77)
        Me.picGround.TabIndex = 1
        Me.picGround.TabStop = False
        '
        'picAir
        '
        Me.picAir.Location = New System.Drawing.Point(13, 346)
        Me.picAir.Name = "picAir"
        Me.picAir.Size = New System.Drawing.Size(787, 34)
        Me.picAir.TabIndex = 2
        Me.picAir.TabStop = False
        '
        'TimerRIght
        '
        '
        'timerGravity
        '
        '
        'mousePictureBox
        '
        Me.mousePictureBox.Location = New System.Drawing.Point(13, 43)
        Me.mousePictureBox.Name = "mousePictureBox"
        Me.mousePictureBox.Size = New System.Drawing.Size(100, 50)
        Me.mousePictureBox.TabIndex = 3
        Me.mousePictureBox.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(171, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Fuchsia
        Me.PictureBox2.Location = New System.Drawing.Point(565, 33)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Scorepoints
        '
        Me.Scorepoints.AutoSize = True
        Me.Scorepoints.Location = New System.Drawing.Point(27, 145)
        Me.Scorepoints.Name = "Scorepoints"
        Me.Scorepoints.Size = New System.Drawing.Size(48, 16)
        Me.Scorepoints.TabIndex = 7
        Me.Scorepoints.Text = "Label1"
        '
        'Scorelabel
        '
        Me.Scorelabel.AutoSize = True
        Me.Scorelabel.Location = New System.Drawing.Point(27, 161)
        Me.Scorelabel.Name = "Scorelabel"
        Me.Scorelabel.Size = New System.Drawing.Size(48, 16)
        Me.Scorelabel.TabIndex = 8
        Me.Scorelabel.Text = "Label2"
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(13, 218)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "coin"
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(120, 218)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "coin"
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(227, 218)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox5.TabIndex = 11
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "coin"
        '
        'Mover1
        '
        Me.Mover1.BackColor = System.Drawing.Color.Transparent
        Me.Mover1.interval = 100
        Me.Mover1.Location = New System.Drawing.Point(355, 43)
        Me.Mover1.Name = "Mover1"
        Me.Mover1.Size = New System.Drawing.Size(219, 29)
        Me.Mover1.speed = 10
        Me.Mover1.sprite = Me.PictureBox2
        Me.Mover1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.platforminggame.My.Resources.Resources.Zuma
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Scorelabel)
        Me.Controls.Add(Me.Scorepoints)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Mover1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.mousePictureBox)
        Me.Controls.Add(Me.picAir)
        Me.Controls.Add(Me.picGround)
        Me.Controls.Add(Me.picPlayer)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mousePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents picGround As PictureBox
    Friend WithEvents picAir As PictureBox
    Friend WithEvents TimerRIght As Timer
    Friend WithEvents Timerleft As Timer
    Friend WithEvents Timerup As Timer
    Friend WithEvents timerGamelogic As Timer
    Friend WithEvents timerGravity As Timer
    Friend WithEvents mousePictureBox As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Mover1 As mover
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Scorepoints As Label
    Friend WithEvents Scorelabel As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
