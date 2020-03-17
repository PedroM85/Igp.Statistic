Namespace CommonClasses
    Public Class Site
        Private mId As String
        Private mName As String

        Public Sub New(ByVal id As String, ByVal name As String)
            mId = id
            mName = name
        End Sub

        Public Property Id() As String
            Get
                Return mId
            End Get
            Set(ByVal value As String)
                mId = value
            End Set
        End Property
        Public Property Name() As String
            Get
                Return mName
            End Get
            Set(ByVal value As String)
                mName = value
            End Set
        End Property

    End Class
End Namespace

