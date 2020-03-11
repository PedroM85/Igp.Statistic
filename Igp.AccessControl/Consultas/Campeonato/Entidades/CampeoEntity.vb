Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace Entidades
    Public Class CampeoEntity

        Public Sub New(id As Integer, desc As String)
            Me.Id = id
            Me.Circuito = desc
        End Sub

        Public Sub New()
        End Sub

        Private m_id As Integer
        Private m_Temporada As String
        Private m_Circuito As String
        Private m_Piloto As String
        Private m_Posllegada As Integer
        Private m_Puntos As Integer
        Private m_byTem As String
        Private m_byCir As String


        Public Property bytem As String
            Get
                Return m_byTem
            End Get
            Set(value As String)
                m_byTem = value
            End Set
        End Property

        Public Property bycir As String
            Get
                Return m_byCir
            End Get
            Set(value As String)
                m_byCir = value
            End Set
        End Property
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

        Public Property Circuito As String
            Get
                Return m_Circuito
            End Get
            Set(value As String)
                m_Circuito = value
            End Set
        End Property

        Public Property Piloto As String
            Get
                Return m_Piloto
            End Get
            Set(value As String)
                m_Piloto = value
            End Set
        End Property

        Public Property Posllegada As Integer
            Get
                Return m_Posllegada
            End Get
            Set(value As Integer)
                m_Posllegada = value
            End Set
        End Property

        Public Property Puntos As Integer
            Get
                Return m_Puntos
            End Get
            Set(value As Integer)
                m_Puntos = value
            End Set
        End Property
    End Class


End Namespace
