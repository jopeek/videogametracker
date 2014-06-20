Public Class Splashscreen

    Public Delegate Sub SetProgressBarDelegate(ByVal max As Integer)
    Public Delegate Sub UpdateProgressBarDelegate(ByVal value As Integer)

    Public Sub BarLong(ByVal MemCount As Integer)
        If Me.InvokeRequired Then
            Me.Invoke(New SetProgressBarDelegate(AddressOf BarLong), MemCount)
        Else
            Me.progSplashScreen.Maximum = MemCount
        End If
    End Sub

    Public Sub ShowBar(ByVal SoFar As Integer)
        If Me.InvokeRequired Then
            Me.Invoke(New UpdateProgressBarDelegate(AddressOf ShowBar), SoFar)
        Else
            Me.progSplashScreen.Value = SoFar
        End If
    End Sub

End Class