<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.val1 = New System.Windows.Forms.TextBox()
        Me.bal1 = New System.Windows.Forms.TextBox()
        Me.bal2 = New System.Windows.Forms.TextBox()
        Me.val2 = New System.Windows.Forms.TextBox()
        Me.val3 = New System.Windows.Forms.ComboBox()
        Me.bal3 = New System.Windows.Forms.ComboBox()
        Me.bal5 = New System.Windows.Forms.TextBox()
        Me.val5 = New System.Windows.Forms.TextBox()
        Me.bal4 = New System.Windows.Forms.TextBox()
        Me.val4 = New System.Windows.Forms.TextBox()
        Me.val6 = New System.Windows.Forms.Label()
        Me.bal6 = New System.Windows.Forms.Label()
        Me.bal7 = New System.Windows.Forms.TextBox()
        Me.val7 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1358, 50)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(133, 46)
        Me.ToolStripMenuItem1.Text = "     HELP     "
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(148, 46)
        Me.ToolStripMenuItem2.Text = "     ABOUT     "
        '
        'val1
        '
        Me.val1.Font = New System.Drawing.Font("Elephant", 30.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.val1.Location = New System.Drawing.Point(314, 108)
        Me.val1.MaxLength = 3
        Me.val1.Multiline = True
        Me.val1.Name = "val1"
        Me.val1.Size = New System.Drawing.Size(119, 62)
        Me.val1.TabIndex = 12
        Me.val1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bal1
        '
        Me.bal1.Font = New System.Drawing.Font("Elephant", 30.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bal1.Location = New System.Drawing.Point(314, 212)
        Me.bal1.MaxLength = 3
        Me.bal1.Multiline = True
        Me.bal1.Name = "bal1"
        Me.bal1.Size = New System.Drawing.Size(119, 62)
        Me.bal1.TabIndex = 13
        Me.bal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bal2
        '
        Me.bal2.Font = New System.Drawing.Font("Elephant", 30.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bal2.Location = New System.Drawing.Point(452, 212)
        Me.bal2.MaxLength = 1
        Me.bal2.Multiline = True
        Me.bal2.Name = "bal2"
        Me.bal2.Size = New System.Drawing.Size(51, 61)
        Me.bal2.TabIndex = 15
        Me.bal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'val2
        '
        Me.val2.Font = New System.Drawing.Font("Elephant", 30.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.val2.Location = New System.Drawing.Point(452, 108)
        Me.val2.MaxLength = 1
        Me.val2.Multiline = True
        Me.val2.Name = "val2"
        Me.val2.Size = New System.Drawing.Size(51, 62)
        Me.val2.TabIndex = 14
        Me.val2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'val3
        '
        Me.val3.Font = New System.Drawing.Font("Elephant", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.val3.FormattingEnabled = True
        Me.val3.Items.AddRange(New Object() {"+", "-"})
        Me.val3.Location = New System.Drawing.Point(524, 110)
        Me.val3.MaxLength = 1
        Me.val3.Name = "val3"
        Me.val3.Size = New System.Drawing.Size(71, 59)
        Me.val3.TabIndex = 16
        Me.val3.Text = "+"
        '
        'bal3
        '
        Me.bal3.Font = New System.Drawing.Font("Elephant", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bal3.FormattingEnabled = True
        Me.bal3.Items.AddRange(New Object() {"+", "-"})
        Me.bal3.Location = New System.Drawing.Point(524, 213)
        Me.bal3.MaxLength = 1
        Me.bal3.Name = "bal3"
        Me.bal3.Size = New System.Drawing.Size(71, 59)
        Me.bal3.TabIndex = 17
        Me.bal3.Text = "+"
        '
        'bal5
        '
        Me.bal5.Font = New System.Drawing.Font("Elephant", 30.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bal5.Location = New System.Drawing.Point(763, 212)
        Me.bal5.MaxLength = 1
        Me.bal5.Multiline = True
        Me.bal5.Name = "bal5"
        Me.bal5.Size = New System.Drawing.Size(51, 61)
        Me.bal5.TabIndex = 21
        Me.bal5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'val5
        '
        Me.val5.Font = New System.Drawing.Font("Elephant", 30.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.val5.Location = New System.Drawing.Point(763, 108)
        Me.val5.MaxLength = 1
        Me.val5.Multiline = True
        Me.val5.Name = "val5"
        Me.val5.Size = New System.Drawing.Size(51, 62)
        Me.val5.TabIndex = 20
        Me.val5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bal4
        '
        Me.bal4.Font = New System.Drawing.Font("Elephant", 30.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bal4.Location = New System.Drawing.Point(618, 212)
        Me.bal4.MaxLength = 3
        Me.bal4.Multiline = True
        Me.bal4.Name = "bal4"
        Me.bal4.Size = New System.Drawing.Size(123, 62)
        Me.bal4.TabIndex = 19
        Me.bal4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'val4
        '
        Me.val4.Font = New System.Drawing.Font("Elephant", 30.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.val4.Location = New System.Drawing.Point(618, 109)
        Me.val4.MaxLength = 3
        Me.val4.Multiline = True
        Me.val4.Name = "val4"
        Me.val4.Size = New System.Drawing.Size(123, 62)
        Me.val4.TabIndex = 18
        Me.val4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'val6
        '
        Me.val6.Font = New System.Drawing.Font("Elephant", 30.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.val6.Location = New System.Drawing.Point(862, 108)
        Me.val6.Name = "val6"
        Me.val6.Size = New System.Drawing.Size(70, 63)
        Me.val6.TabIndex = 22
        Me.val6.Text = "="
        Me.val6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bal6
        '
        Me.bal6.Font = New System.Drawing.Font("Elephant", 30.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bal6.Location = New System.Drawing.Point(862, 212)
        Me.bal6.Name = "bal6"
        Me.bal6.Size = New System.Drawing.Size(70, 62)
        Me.bal6.TabIndex = 23
        Me.bal6.Text = "="
        Me.bal6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bal7
        '
        Me.bal7.Font = New System.Drawing.Font("Elephant", 30.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bal7.Location = New System.Drawing.Point(976, 212)
        Me.bal7.MaxLength = 4
        Me.bal7.Multiline = True
        Me.bal7.Name = "bal7"
        Me.bal7.Size = New System.Drawing.Size(148, 62)
        Me.bal7.TabIndex = 25
        '
        'val7
        '
        Me.val7.Font = New System.Drawing.Font("Elephant", 30.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.val7.Location = New System.Drawing.Point(976, 110)
        Me.val7.MaxLength = 4
        Me.val7.Multiline = True
        Me.val7.Name = "val7"
        Me.val7.Size = New System.Drawing.Size(148, 62)
        Me.val7.TabIndex = 24
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Britannic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 36
        Me.ListBox1.Location = New System.Drawing.Point(242, 302)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(882, 328)
        Me.ListBox1.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(110, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 49)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "CLEAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1145, 302)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 49)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "SOLVE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AcceptButton = Me.Button2
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(1358, 737)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.bal7)
        Me.Controls.Add(Me.val7)
        Me.Controls.Add(Me.bal6)
        Me.Controls.Add(Me.val6)
        Me.Controls.Add(Me.bal5)
        Me.Controls.Add(Me.val5)
        Me.Controls.Add(Me.bal4)
        Me.Controls.Add(Me.val4)
        Me.Controls.Add(Me.bal3)
        Me.Controls.Add(Me.val3)
        Me.Controls.Add(Me.bal2)
        Me.Controls.Add(Me.val2)
        Me.Controls.Add(Me.bal1)
        Me.Controls.Add(Me.val1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "Simultaneous Equations"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents val1 As System.Windows.Forms.TextBox
    Friend WithEvents bal1 As System.Windows.Forms.TextBox
    Friend WithEvents bal2 As System.Windows.Forms.TextBox
    Friend WithEvents val2 As System.Windows.Forms.TextBox
    Friend WithEvents val3 As System.Windows.Forms.ComboBox
    Friend WithEvents bal3 As System.Windows.Forms.ComboBox
    Friend WithEvents bal5 As System.Windows.Forms.TextBox
    Friend WithEvents val5 As System.Windows.Forms.TextBox
    Friend WithEvents bal4 As System.Windows.Forms.TextBox
    Friend WithEvents val4 As System.Windows.Forms.TextBox
    Friend WithEvents val6 As System.Windows.Forms.Label
    Friend WithEvents bal6 As System.Windows.Forms.Label
    Friend WithEvents bal7 As System.Windows.Forms.TextBox
    Friend WithEvents val7 As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
