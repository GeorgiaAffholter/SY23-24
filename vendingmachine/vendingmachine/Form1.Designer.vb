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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.totallabel = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Idtextbox = New System.Windows.Forms.TextBox()
        Me.quarterpb = New System.Windows.Forms.PictureBox()
        Me.nickelpb = New System.Windows.Forms.PictureBox()
        Me.dimepb = New System.Windows.Forms.PictureBox()
        Me.dollarpb = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Productpicture = New System.Windows.Forms.PictureBox()
        Me.Productcontrol16 = New vendingmachine.productcontrol()
        Me.Productcontrol15 = New vendingmachine.productcontrol()
        Me.Productcontrol14 = New vendingmachine.productcontrol()
        Me.Productcontrol13 = New vendingmachine.productcontrol()
        Me.Productcontrol12 = New vendingmachine.productcontrol()
        Me.Productcontrol11 = New vendingmachine.productcontrol()
        Me.Productcontrol10 = New vendingmachine.productcontrol()
        Me.Productcontrol9 = New vendingmachine.productcontrol()
        Me.Productcontrol8 = New vendingmachine.productcontrol()
        Me.Productcontrol7 = New vendingmachine.productcontrol()
        Me.Productcontrol6 = New vendingmachine.productcontrol()
        Me.Productcontrol5 = New vendingmachine.productcontrol()
        Me.Productcontrol4 = New vendingmachine.productcontrol()
        Me.Productcontrol3 = New vendingmachine.productcontrol()
        Me.Productcontrol2 = New vendingmachine.productcontrol()
        Me.Productcontrol1 = New vendingmachine.productcontrol()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        CType(Me.quarterpb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nickelpb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dimepb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dollarpb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Productpicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'totallabel
        '
        Me.totallabel.AutoSize = True
        Me.totallabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totallabel.Location = New System.Drawing.Point(238, 55)
        Me.totallabel.Name = "totallabel"
        Me.totallabel.Size = New System.Drawing.Size(71, 25)
        Me.totallabel.TabIndex = 4
        Me.totallabel.Text = "Label1"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(239, 83)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "coinreturn"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(171, 140)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 24
        Me.Button6.Text = "Buy"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Idtextbox
        '
        Me.Idtextbox.Location = New System.Drawing.Point(255, 141)
        Me.Idtextbox.Name = "Idtextbox"
        Me.Idtextbox.Size = New System.Drawing.Size(100, 22)
        Me.Idtextbox.TabIndex = 25
        '
        'quarterpb
        '
        Me.quarterpb.Image = Global.vendingmachine.My.Resources.Resources.quarters
        Me.quarterpb.Location = New System.Drawing.Point(243, 321)
        Me.quarterpb.Name = "quarterpb"
        Me.quarterpb.Size = New System.Drawing.Size(54, 71)
        Me.quarterpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.quarterpb.TabIndex = 9
        Me.quarterpb.TabStop = False
        '
        'nickelpb
        '
        Me.nickelpb.Image = Global.vendingmachine.My.Resources.Resources.nickels
        Me.nickelpb.Location = New System.Drawing.Point(181, 321)
        Me.nickelpb.Name = "nickelpb"
        Me.nickelpb.Size = New System.Drawing.Size(52, 71)
        Me.nickelpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.nickelpb.TabIndex = 8
        Me.nickelpb.TabStop = False
        '
        'dimepb
        '
        Me.dimepb.Image = Global.vendingmachine.My.Resources.Resources.dime1
        Me.dimepb.Location = New System.Drawing.Point(118, 321)
        Me.dimepb.Name = "dimepb"
        Me.dimepb.Size = New System.Drawing.Size(47, 71)
        Me.dimepb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dimepb.TabIndex = 7
        Me.dimepb.TabStop = False
        '
        'dollarpb
        '
        Me.dollarpb.Image = Global.vendingmachine.My.Resources.Resources.dollars1
        Me.dollarpb.Location = New System.Drawing.Point(28, 321)
        Me.dollarpb.Name = "dollarpb"
        Me.dollarpb.Size = New System.Drawing.Size(60, 71)
        Me.dollarpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dollarpb.TabIndex = 6
        Me.dollarpb.TabStop = False
        Me.dollarpb.Visible = False
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.vendingmachine.My.Resources.Resources.nickels
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(28, 208)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(60, 84)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.vendingmachine.My.Resources.Resources.dime1
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(106, 208)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(59, 84)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.vendingmachine.My.Resources.Resources.quarters
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(171, 208)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 84)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.vendingmachine.My.Resources.Resources.dollars
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(239, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 84)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Productpicture
        '
        Me.Productpicture.Location = New System.Drawing.Point(688, 377)
        Me.Productpicture.Name = "Productpicture"
        Me.Productpicture.Size = New System.Drawing.Size(100, 50)
        Me.Productpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Productpicture.TabIndex = 28
        Me.Productpicture.TabStop = False
        '
        'Productcontrol16
        '
        Me.Productcontrol16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol16.Location = New System.Drawing.Point(459, 351)
        Me.Productcontrol16.Name = "Productcontrol16"
        Me.Productcontrol16.productcount = 0
        Me.Productcontrol16.productid = "B6"
        Me.Productcontrol16.productpicture = Global.vendingmachine.My.Resources.Resources.granola
        Me.Productcontrol16.productprice = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Productcontrol16.Size = New System.Drawing.Size(59, 99)
        Me.Productcontrol16.TabIndex = 27
        '
        'Productcontrol15
        '
        Me.Productcontrol15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol15.Location = New System.Drawing.Point(613, 343)
        Me.Productcontrol15.Name = "Productcontrol15"
        Me.Productcontrol15.productcount = 0
        Me.Productcontrol15.productid = "B5"
        Me.Productcontrol15.productpicture = Global.vendingmachine.My.Resources.Resources.gummies
        Me.Productcontrol15.productprice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.Productcontrol15.Size = New System.Drawing.Size(55, 107)
        Me.Productcontrol15.TabIndex = 26
        '
        'Productcontrol14
        '
        Me.Productcontrol14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol14.Location = New System.Drawing.Point(533, 340)
        Me.Productcontrol14.Name = "Productcontrol14"
        Me.Productcontrol14.productcount = 0
        Me.Productcontrol14.productid = "B4"
        Me.Productcontrol14.productpicture = Global.vendingmachine.My.Resources.Resources.water
        Me.Productcontrol14.productprice = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Productcontrol14.Size = New System.Drawing.Size(66, 107)
        Me.Productcontrol14.TabIndex = 23
        '
        'Productcontrol13
        '
        Me.Productcontrol13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol13.Location = New System.Drawing.Point(380, 339)
        Me.Productcontrol13.Name = "Productcontrol13"
        Me.Productcontrol13.productcount = 0
        Me.Productcontrol13.productid = "B3"
        Me.Productcontrol13.productpicture = Global.vendingmachine.My.Resources.Resources.frootrollup
        Me.Productcontrol13.productprice = New Decimal(New Integer() {25, 0, 0, 65536})
        Me.Productcontrol13.Size = New System.Drawing.Size(67, 108)
        Me.Productcontrol13.TabIndex = 22
        '
        'Productcontrol12
        '
        Me.Productcontrol12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol12.Location = New System.Drawing.Point(605, 227)
        Me.Productcontrol12.Name = "Productcontrol12"
        Me.Productcontrol12.productcount = 0
        Me.Productcontrol12.productid = "B2"
        Me.Productcontrol12.productpicture = Global.vendingmachine.My.Resources.Resources.trailmix
        Me.Productcontrol12.productprice = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Productcontrol12.Size = New System.Drawing.Size(63, 107)
        Me.Productcontrol12.TabIndex = 21
        '
        'Productcontrol11
        '
        Me.Productcontrol11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol11.Location = New System.Drawing.Point(524, 237)
        Me.Productcontrol11.Name = "Productcontrol11"
        Me.Productcontrol11.productcount = 0
        Me.Productcontrol11.productid = "B1"
        Me.Productcontrol11.productpicture = Global.vendingmachine.My.Resources.Resources.goldfish1
        Me.Productcontrol11.productprice = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Productcontrol11.Size = New System.Drawing.Size(75, 108)
        Me.Productcontrol11.TabIndex = 20
        '
        'Productcontrol10
        '
        Me.Productcontrol10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol10.Location = New System.Drawing.Point(453, 240)
        Me.Productcontrol10.Name = "Productcontrol10"
        Me.Productcontrol10.productcount = 0
        Me.Productcontrol10.productid = "A10"
        Me.Productcontrol10.productpicture = Global.vendingmachine.My.Resources.Resources.kombucha
        Me.Productcontrol10.productprice = New Decimal(New Integer() {4, 0, 0, 0})
        Me.Productcontrol10.Size = New System.Drawing.Size(62, 105)
        Me.Productcontrol10.TabIndex = 19
        '
        'Productcontrol9
        '
        Me.Productcontrol9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol9.Location = New System.Drawing.Point(376, 229)
        Me.Productcontrol9.Name = "Productcontrol9"
        Me.Productcontrol9.productcount = 0
        Me.Productcontrol9.productid = "A9"
        Me.Productcontrol9.productpicture = Global.vendingmachine.My.Resources.Resources.beefstick
        Me.Productcontrol9.productprice = New Decimal(New Integer() {25, 0, 0, 65536})
        Me.Productcontrol9.Size = New System.Drawing.Size(71, 105)
        Me.Productcontrol9.TabIndex = 18
        '
        'Productcontrol8
        '
        Me.Productcontrol8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol8.Location = New System.Drawing.Point(613, 123)
        Me.Productcontrol8.Name = "Productcontrol8"
        Me.Productcontrol8.productcount = 0
        Me.Productcontrol8.productid = "A8"
        Me.Productcontrol8.productpicture = Global.vendingmachine.My.Resources.Resources.cookies
        Me.Productcontrol8.productprice = New Decimal(New Integer() {3, 0, 0, 0})
        Me.Productcontrol8.Size = New System.Drawing.Size(68, 105)
        Me.Productcontrol8.TabIndex = 17
        '
        'Productcontrol7
        '
        Me.Productcontrol7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol7.Location = New System.Drawing.Point(545, 123)
        Me.Productcontrol7.Name = "Productcontrol7"
        Me.Productcontrol7.productcount = 0
        Me.Productcontrol7.productid = "A7"
        Me.Productcontrol7.productpicture = Global.vendingmachine.My.Resources.Resources.lemomade
        Me.Productcontrol7.productprice = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Productcontrol7.Size = New System.Drawing.Size(62, 108)
        Me.Productcontrol7.TabIndex = 16
        '
        'Productcontrol6
        '
        Me.Productcontrol6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol6.Location = New System.Drawing.Point(453, 126)
        Me.Productcontrol6.Name = "Productcontrol6"
        Me.Productcontrol6.productcount = 0
        Me.Productcontrol6.productid = "A6"
        Me.Productcontrol6.productpicture = Global.vendingmachine.My.Resources.Resources.chews
        Me.Productcontrol6.productprice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.Productcontrol6.Size = New System.Drawing.Size(65, 108)
        Me.Productcontrol6.TabIndex = 15
        '
        'Productcontrol5
        '
        Me.Productcontrol5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol5.Location = New System.Drawing.Point(371, 126)
        Me.Productcontrol5.Name = "Productcontrol5"
        Me.Productcontrol5.productcount = 1
        Me.Productcontrol5.productid = "A5"
        Me.Productcontrol5.productpicture = Global.vendingmachine.My.Resources.Resources.chhezeits1
        Me.Productcontrol5.productprice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.Productcontrol5.Size = New System.Drawing.Size(76, 108)
        Me.Productcontrol5.TabIndex = 14
        '
        'Productcontrol4
        '
        Me.Productcontrol4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol4.Location = New System.Drawing.Point(600, 12)
        Me.Productcontrol4.Name = "Productcontrol4"
        Me.Productcontrol4.productcount = 1
        Me.Productcontrol4.productid = "A4"
        Me.Productcontrol4.productpicture = Global.vendingmachine.My.Resources.Resources.body_aromur
        Me.Productcontrol4.productprice = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Productcontrol4.Size = New System.Drawing.Size(58, 105)
        Me.Productcontrol4.TabIndex = 13
        '
        'Productcontrol3
        '
        Me.Productcontrol3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol3.Location = New System.Drawing.Point(530, 12)
        Me.Productcontrol3.Name = "Productcontrol3"
        Me.Productcontrol3.productcount = 0
        Me.Productcontrol3.productid = "A3"
        Me.Productcontrol3.productpicture = Global.vendingmachine.My.Resources.Resources.clifbar
        Me.Productcontrol3.productprice = New Decimal(New Integer() {125, 0, 0, 131072})
        Me.Productcontrol3.Size = New System.Drawing.Size(54, 108)
        Me.Productcontrol3.TabIndex = 12
        '
        'Productcontrol2
        '
        Me.Productcontrol2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol2.Location = New System.Drawing.Point(440, 12)
        Me.Productcontrol2.Name = "Productcontrol2"
        Me.Productcontrol2.productcount = 0
        Me.Productcontrol2.productid = "A2"
        Me.Productcontrol2.productpicture = Global.vendingmachine.My.Resources.Resources.takis1
        Me.Productcontrol2.productprice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.Productcontrol2.Size = New System.Drawing.Size(75, 108)
        Me.Productcontrol2.TabIndex = 11
        '
        'Productcontrol1
        '
        Me.Productcontrol1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol1.Location = New System.Drawing.Point(361, 12)
        Me.Productcontrol1.Name = "Productcontrol1"
        Me.Productcontrol1.productcount = 5
        Me.Productcontrol1.productid = "A1"
        Me.Productcontrol1.productpicture = Global.vendingmachine.My.Resources.Resources.munchies
        Me.Productcontrol1.productprice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.Productcontrol1.Size = New System.Drawing.Size(75, 108)
        Me.Productcontrol1.TabIndex = 10
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(800, 27)
        Me.BindingNavigator1.TabIndex = 29
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.Productpicture)
        Me.Controls.Add(Me.Productcontrol16)
        Me.Controls.Add(Me.Productcontrol15)
        Me.Controls.Add(Me.Idtextbox)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Productcontrol14)
        Me.Controls.Add(Me.Productcontrol13)
        Me.Controls.Add(Me.Productcontrol12)
        Me.Controls.Add(Me.Productcontrol11)
        Me.Controls.Add(Me.Productcontrol10)
        Me.Controls.Add(Me.Productcontrol9)
        Me.Controls.Add(Me.Productcontrol8)
        Me.Controls.Add(Me.Productcontrol7)
        Me.Controls.Add(Me.Productcontrol6)
        Me.Controls.Add(Me.Productcontrol5)
        Me.Controls.Add(Me.Productcontrol4)
        Me.Controls.Add(Me.Productcontrol3)
        Me.Controls.Add(Me.Productcontrol2)
        Me.Controls.Add(Me.Productcontrol1)
        Me.Controls.Add(Me.quarterpb)
        Me.Controls.Add(Me.nickelpb)
        Me.Controls.Add(Me.dimepb)
        Me.Controls.Add(Me.dollarpb)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.totallabel)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.quarterpb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nickelpb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dimepb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dollarpb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Productpicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents totallabel As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents dollarpb As PictureBox
    Friend WithEvents dimepb As PictureBox
    Friend WithEvents nickelpb As PictureBox
    Friend WithEvents quarterpb As PictureBox
    Friend WithEvents Productcontrol1 As productcontrol
    Friend WithEvents Productcontrol2 As productcontrol
    Friend WithEvents Productcontrol3 As productcontrol
    Friend WithEvents Productcontrol4 As productcontrol
    Friend WithEvents Productcontrol5 As productcontrol
    Friend WithEvents Productcontrol6 As productcontrol
    Friend WithEvents Productcontrol7 As productcontrol
    Friend WithEvents Productcontrol8 As productcontrol
    Friend WithEvents Productcontrol9 As productcontrol
    Friend WithEvents Productcontrol10 As productcontrol
    Friend WithEvents Productcontrol11 As productcontrol
    Friend WithEvents Productcontrol12 As productcontrol
    Friend WithEvents Productcontrol13 As productcontrol
    Friend WithEvents Productcontrol14 As productcontrol
    Friend WithEvents Button6 As Button
    Friend WithEvents Idtextbox As TextBox
    Friend WithEvents Productcontrol15 As productcontrol
    Friend WithEvents Productcontrol16 As productcontrol
    Friend WithEvents Productpicture As PictureBox
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
End Class
