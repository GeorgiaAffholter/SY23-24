<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MoneyAmountlabel = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.totallabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Reelcontrol4 = New slotmachine.Reelcontrol()
        Me.Reelcontrol3 = New slotmachine.Reelcontrol()
        Me.Reelcontrol2 = New slotmachine.Reelcontrol()
        Me.Reelcontrol1 = New slotmachine.Reelcontrol()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Spin"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "peach.PNG")
        Me.ImageList1.Images.SetKeyName(1, "banana.PNG")
        Me.ImageList1.Images.SetKeyName(2, "cherries.PNG")
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'MoneyAmountlabel
        '
        Me.MoneyAmountlabel.Location = New System.Drawing.Point(671, 229)
        Me.MoneyAmountlabel.Name = "MoneyAmountlabel"
        Me.MoneyAmountlabel.Size = New System.Drawing.Size(100, 22)
        Me.MoneyAmountlabel.TabIndex = 33
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(587, 228)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 32
        Me.Button6.Text = "Buy"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(655, 171)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 31
        Me.Button5.Text = "coinreturn"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'totallabel
        '
        Me.totallabel.AutoSize = True
        Me.totallabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totallabel.Location = New System.Drawing.Point(654, 143)
        Me.totallabel.Name = "totallabel"
        Me.totallabel.Size = New System.Drawing.Size(71, 25)
        Me.totallabel.TabIndex = 30
        Me.totallabel.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 271)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(237, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(438, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Label3"
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.slotmachine.My.Resources.Resources.dime
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(602, 296)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 84)
        Me.Button4.TabIndex = 29
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.slotmachine.My.Resources.Resources.quarters
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(506, 296)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 84)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.slotmachine.My.Resources.Resources.dollars
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(411, 296)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 84)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImage = Global.slotmachine.My.Resources.Resources.nickels
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.Location = New System.Drawing.Point(688, 296)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(67, 84)
        Me.Button7.TabIndex = 26
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Reelcontrol4
        '
        Me.Reelcontrol4.itemvalue = 2
        Me.Reelcontrol4.Location = New System.Drawing.Point(411, 101)
        Me.Reelcontrol4.Name = "Reelcontrol4"
        Me.Reelcontrol4.Size = New System.Drawing.Size(150, 150)
        Me.Reelcontrol4.spintime = 2000
        Me.Reelcontrol4.TabIndex = 37
        '
        'Reelcontrol3
        '
        Me.Reelcontrol3.itemvalue = 2
        Me.Reelcontrol3.Location = New System.Drawing.Point(52, 92)
        Me.Reelcontrol3.Name = "Reelcontrol3"
        Me.Reelcontrol3.Size = New System.Drawing.Size(150, 150)
        Me.Reelcontrol3.spintime = 2000
        Me.Reelcontrol3.TabIndex = 36
        '
        'Reelcontrol2
        '
        Me.Reelcontrol2.itemvalue = 2
        Me.Reelcontrol2.Location = New System.Drawing.Point(237, 92)
        Me.Reelcontrol2.Name = "Reelcontrol2"
        Me.Reelcontrol2.Size = New System.Drawing.Size(150, 150)
        Me.Reelcontrol2.spintime = 2000
        Me.Reelcontrol2.TabIndex = 35
        '
        'Reelcontrol1
        '
        Me.Reelcontrol1.itemvalue = 2
        Me.Reelcontrol1.Location = New System.Drawing.Point(32, 103)
        Me.Reelcontrol1.Name = "Reelcontrol1"
        Me.Reelcontrol1.Size = New System.Drawing.Size(150, 150)
        Me.Reelcontrol1.spintime = 2000
        Me.Reelcontrol1.TabIndex = 34
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Reelcontrol4)
        Me.Controls.Add(Me.Reelcontrol3)
        Me.Controls.Add(Me.Reelcontrol2)
        Me.Controls.Add(Me.Reelcontrol1)
        Me.Controls.Add(Me.MoneyAmountlabel)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.totallabel)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MoneyAmountlabel As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents totallabel As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Reelcontrol1 As Reelcontrol
    Friend WithEvents Reelcontrol2 As Reelcontrol
    Friend WithEvents Reelcontrol3 As Reelcontrol
    Friend WithEvents Reelcontrol4 As Reelcontrol
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
