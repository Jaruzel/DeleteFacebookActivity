<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
    Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
    Me.TextBox1 = New System.Windows.Forms.TextBox()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.Button2 = New System.Windows.Forms.Button()
    Me.TextBox2 = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.btnStop = New System.Windows.Forms.Button()
    Me.Button3 = New System.Windows.Forms.Button()
    Me.Button4 = New System.Windows.Forms.Button()
    Me.Button5 = New System.Windows.Forms.Button()
    Me.Button6 = New System.Windows.Forms.Button()
    Me.CheckBox1 = New System.Windows.Forms.CheckBox()
    Me.PictureBox1 = New System.Windows.Forms.PictureBox()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'WebBrowser1
    '
    Me.WebBrowser1.Location = New System.Drawing.Point(12, 145)
    Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
    Me.WebBrowser1.Name = "WebBrowser1"
    Me.WebBrowser1.Size = New System.Drawing.Size(581, 590)
    Me.WebBrowser1.TabIndex = 0
    '
    'TextBox1
    '
    Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.TextBox1.Location = New System.Drawing.Point(602, 35)
    Me.TextBox1.Multiline = True
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
    Me.TextBox1.Size = New System.Drawing.Size(570, 700)
    Me.TextBox1.TabIndex = 1
    Me.TextBox1.WordWrap = False
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(15, 47)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(75, 23)
    Me.Button1.TabIndex = 2
    Me.Button1.Text = "Comments"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'Button2
    '
    Me.Button2.Location = New System.Drawing.Point(96, 47)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(75, 23)
    Me.Button2.TabIndex = 3
    Me.Button2.Text = "Likes"
    Me.Button2.UseVisualStyleBackColor = True
    '
    'TextBox2
    '
    Me.TextBox2.BackColor = System.Drawing.Color.White
    Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.TextBox2.ForeColor = System.Drawing.SystemColors.InfoText
    Me.TextBox2.Location = New System.Drawing.Point(0, 741)
    Me.TextBox2.Multiline = True
    Me.TextBox2.Name = "TextBox2"
    Me.TextBox2.ReadOnly = True
    Me.TextBox2.Size = New System.Drawing.Size(1183, 23)
    Me.TextBox2.TabIndex = 0
    '
    'Label1
    '
    Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = System.Drawing.Color.White
    Me.Label1.Location = New System.Drawing.Point(12, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(581, 23)
    Me.Label1.TabIndex = 4
    Me.Label1.Text = "Select Activity to Start Erasing"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label2
    '
    Me.Label2.BackColor = System.Drawing.SystemColors.AppWorkspace
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.ForeColor = System.Drawing.Color.White
    Me.Label2.Location = New System.Drawing.Point(12, 119)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(581, 23)
    Me.Label2.TabIndex = 5
    Me.Label2.Text = "Web View"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label3
    '
    Me.Label3.BackColor = System.Drawing.SystemColors.AppWorkspace
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.ForeColor = System.Drawing.Color.White
    Me.Label3.Location = New System.Drawing.Point(602, 9)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(570, 23)
    Me.Label3.TabIndex = 6
    Me.Label3.Text = "Log Output"
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'btnStop
    '
    Me.btnStop.Location = New System.Drawing.Point(518, 82)
    Me.btnStop.Name = "btnStop"
    Me.btnStop.Size = New System.Drawing.Size(75, 23)
    Me.btnStop.TabIndex = 7
    Me.btnStop.Text = "STOP"
    Me.btnStop.UseVisualStyleBackColor = True
    '
    'Button3
    '
    Me.Button3.Location = New System.Drawing.Point(177, 47)
    Me.Button3.Name = "Button3"
    Me.Button3.Size = New System.Drawing.Size(75, 23)
    Me.Button3.TabIndex = 8
    Me.Button3.Text = "Posts"
    Me.Button3.UseVisualStyleBackColor = True
    '
    'Button4
    '
    Me.Button4.Location = New System.Drawing.Point(258, 47)
    Me.Button4.Name = "Button4"
    Me.Button4.Size = New System.Drawing.Size(75, 23)
    Me.Button4.TabIndex = 9
    Me.Button4.Text = "Friends"
    Me.Button4.UseVisualStyleBackColor = True
    '
    'Button5
    '
    Me.Button5.Location = New System.Drawing.Point(339, 47)
    Me.Button5.Name = "Button5"
    Me.Button5.Size = New System.Drawing.Size(75, 23)
    Me.Button5.TabIndex = 10
    Me.Button5.Text = "Life Events"
    Me.Button5.UseVisualStyleBackColor = True
    '
    'Button6
    '
    Me.Button6.Location = New System.Drawing.Point(420, 47)
    Me.Button6.Name = "Button6"
    Me.Button6.Size = New System.Drawing.Size(75, 23)
    Me.Button6.TabIndex = 11
    Me.Button6.Text = "OTHER"
    Me.Button6.UseVisualStyleBackColor = True
    '
    'CheckBox1
    '
    Me.CheckBox1.AutoSize = True
    Me.CheckBox1.Location = New System.Drawing.Point(15, 86)
    Me.CheckBox1.Name = "CheckBox1"
    Me.CheckBox1.Size = New System.Drawing.Size(431, 17)
    Me.CheckBox1.TabIndex = 12
    Me.CheckBox1.Text = "Keep going until nothing is left to erase under the selected activity, or I click" &
    " on STOP."
    Me.CheckBox1.UseVisualStyleBackColor = True
    '
    'PictureBox1
    '
    Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
    Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
    Me.PictureBox1.Image = Global.DeleteFacebookActivity.My.Resources.Resources.happy
    Me.PictureBox1.Location = New System.Drawing.Point(543, 44)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
    Me.PictureBox1.TabIndex = 13
    Me.PictureBox1.TabStop = False
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1184, 765)
    Me.Controls.Add(Me.PictureBox1)
    Me.Controls.Add(Me.CheckBox1)
    Me.Controls.Add(Me.Button6)
    Me.Controls.Add(Me.Button5)
    Me.Controls.Add(Me.Button4)
    Me.Controls.Add(Me.Button3)
    Me.Controls.Add(Me.btnStop)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Button2)
    Me.Controls.Add(Me.TextBox2)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.TextBox1)
    Me.Controls.Add(Me.WebBrowser1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.Name = "Form1"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Facebook Activity Erase Tool"
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents WebBrowser1 As WebBrowser
  Friend WithEvents TextBox1 As TextBox
  Friend WithEvents Button1 As Button
  Friend WithEvents Button2 As Button
  Friend WithEvents TextBox2 As TextBox
  Friend WithEvents Label1 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents btnStop As Button
  Friend WithEvents Button3 As Button
  Friend WithEvents Button4 As Button
  Friend WithEvents Button5 As Button
  Friend WithEvents Button6 As Button
  Friend WithEvents CheckBox1 As CheckBox
  Friend WithEvents PictureBox1 As PictureBox
End Class
