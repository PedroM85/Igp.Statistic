Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace Entidades
    Public Class CircuitoEntity

        Public Sub New(id As Integer, desc As String)
            Me.Id = id
            Me.Circuito = desc
        End Sub

        Public Sub New()
        End Sub

        Private m_IdNacion As Integer
        Private m_Descripcion As String

        Public Property Id() As Integer
            Get
                Return m_IdNacion
            End Get
            Set(value As Integer)
                m_IdNacion = value
            End Set
        End Property

        Public Property Circuito As String
            Get
                Return m_Descripcion
            End Get
            Set(value As String)
                m_Descripcion = value
            End Set
        End Property

    End Class

End Namespace
