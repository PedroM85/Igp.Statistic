Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace Entidades

    Public Class PosicionEntity

        Public Sub New()

        End Sub
        Private m_id As Integer
        Private m_Temporada As String
        Private m_Circuito As Integer
        Private m_piloto As String
        Private m_llegada As Integer

        Public Property id As Integer
            Get
                Return m_id
            End Get
            Set(value As Integer)
                m_id = value
            End Set
        End Property
        Public Property Temporada As String
            Get
                Return m_Temporada
            End Get
            Set(value As String)
                m_Temporada = value
            End Set
        End Property

        Public Property Circuito As Integer
            Get
                Return m_Circuito
            End Get
            Set(value As Integer)
                m_Circuito = value
            End Set
        End Property

        Public Property Piloto As String
            Get
                Return m_piloto
            End Get
            Set(value As String)
                m_piloto = value
            End Set
        End Property

        Public Property llegada As Integer
            Get
                Return m_llegada
            End Get
            Set(value As Integer)
                m_llegada = value
            End Set
        End Property
    End Class

End Namespace

