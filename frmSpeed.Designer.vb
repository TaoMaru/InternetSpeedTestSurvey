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
        Me.btnSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSpeed.Location = New System.Drawing.Point(323, 90)
        Me.btnSpeed.Name = "btnSpeed"
        Me.btnSpeed.Size = New System.Drawing.Size(333, 46)
        Me.btnSpeed.TabIndex = 0
        Me.btnSpeed.Text = "Enter Internet Speed"
        Me.btnSpeed.UseVisualStyleBackColor = True
        '
        'lstSpeeds
        '
        Me.lstSpeeds.FormattingEnabled = True
        Me.lstSpeeds.ItemHeight = 16
        Me.lstSpeeds.Location = New System.Drawing.Point(677, 90)
        Me.lstSpeeds.Name = "lstSpeeds"
        Me.lstSpeeds.Size = New System.Drawing.Size(140, 196)
        Me.lstSpeeds.TabIndex = 1
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(662, 355)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(129, 46)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Button2"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblAverage
        '
        Me.lblAverage.Location = New System.Drawing.Point(418, 467)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(344, 51)
        Me.lblAverage.TabIndex = 3
        Me.lblAverage.Text = "Average Internet Speed:"
        '
        'lblHeading
        '
        Me.lblHeading.Location = New System.Drawing.Point(305, 30)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(425, 57)
        Me.lblHeading.TabIndex = 4
        Me.lblHeading.Text = "Internet Speed Test Survey"
        '
        'frmSpeed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(829, 559)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lstSpeeds)
        Me.Controls.Add(Me.btnSpeed)
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
