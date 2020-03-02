Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace Entidades
    Public Class ParameterEntity

        Private m_npiloto As Integer

        Public Property npiloto As Integer
            Get
                Return m_npiloto
            End Get
            Set(value As Integer)
                m_npiloto = value
            End Set
        End Property
    End Class

End Namespace
