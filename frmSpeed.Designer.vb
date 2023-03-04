<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpeed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSpeed))
        Me.btnSpeed = New System.Windows.Forms.Button()
        Me.lstSpeeds = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSpeed
        '
        Me.btnSpeed.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnSpeed.FlatAppearance.BorderColor = System.Drawing.Color.Khaki
        Me.btnSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSpeed.Font = New System.Drawing.Font("Lucida Sans", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpeed.Location = New System.Drawing.Point(390, 96)
        Me.btnSpeed.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSpeed.Name = "btnSpeed"
        Me.btnSpeed.Size = New System.Drawing.Size(342, 53)
        Me.btnSpeed.TabIndex = 0
        Me.btnSpeed.Text = "Enter Internet Speed"
        Me.btnSpeed.UseVisualStyleBackColor = False
        '
        'lstSpeeds
        '
        Me.lstSpeeds.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstSpeeds.Font = New System.Drawing.Font("Lucida Sans", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSpeeds.FormattingEnabled = True
        Me.lstSpeeds.ItemHeight = 26
        Me.lstSpeeds.Location = New System.Drawing.Point(765, 96)
        Me.lstSpeeds.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstSpeeds.Name = "lstSpeeds"
        Me.lstSpeeds.Size = New System.Drawing.Size(140, 186)
        Me.lstSpeeds.TabIndex = 1
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Gainsboro
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(771, 334)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(129, 43)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblAverage
        '
        Me.lblAverage.BackColor = System.Drawing.Color.Transparent
        Me.lblAverage.Font = New System.Drawing.Font("Lucida Sans", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverage.Location = New System.Drawing.Point(411, 486)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(494, 58)
        Me.lblAverage.TabIndex = 3
        Me.lblAverage.Text = "Average Internet Speed:"
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHeading
        '
        Me.lblHeading.Font = New System.Drawing.Font("Lucida Sans", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(305, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(512, 61)
        Me.lblHeading.TabIndex = 4
        Me.lblHeading.Text = "Internet Speed Test Survey"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSpeed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(917, 566)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lstSpeeds)
        Me.Controls.Add(Me.btnSpeed)
        Me.Font = New System.Drawing.Font("Lucida Sans", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmSpeed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Internet Speed Test Survey"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSpeed As Button
    Friend WithEvents lstSpeeds As ListBox
    Friend WithEvents btnClear As Button
    Friend WithEvents lblAverage As Label
    Friend WithEvents lblHeading As Label
End Class
