<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splashscreen
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
        Me.progSplashScreen = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'progSplashScreen
        '
        Me.progSplashScreen.BackColor = System.Drawing.Color.Black
        Me.progSplashScreen.Location = New System.Drawing.Point(12, 226)
        Me.progSplashScreen.Name = "progSplashScreen"
        Me.progSplashScreen.Size = New System.Drawing.Size(460, 23)
        Me.progSplashScreen.TabIndex = 1
        '
        'Splashscreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Video_Game_Tracker.My.Resources.Resources.splash
        Me.ClientSize = New System.Drawing.Size(484, 261)
        Me.Controls.Add(Me.progSplashScreen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Splashscreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Splashscreen"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents progSplashScreen As System.Windows.Forms.ProgressBar
End Class
