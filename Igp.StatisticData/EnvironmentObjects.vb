Public Class EnvironmentObjects

    Private Shared oApp As EWFramework

    Public Shared Property Framework() As EWFramework
        Get
            Return oApp
        End Get
        Set(ByVal Value As EWFramework)
            oApp = Value
            ' GlobalCaptions.LoadGlobalCaptionsConstants()
        End Set
    End Property

End Class
