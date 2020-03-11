Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace Entidades
    Public Class TempoEntity

        Public Sub New(id As Integer, desc As String, isactive As String, nveces As Integer)
            Me.Idtempo = id
            Me.Descripcion = desc
            Me.isactive = isactive
            Me.nveces = nveces
        End Sub

        Public Sub New()
        End Sub
        Private m_nveces As Integer
        Private m_Idtempo As Integer
        Private m_Descripcion As String
        Private m_isactive As String


        Public Property nveces As Integer
            Get
                Return m_nveces
            End Get
            Set(value As Integer)
                m_nveces = value
            End Set
        End Property
        Public Property isactive As String
            Get
                Return m_isactive
            End Get
            Set(value As String)
                m_isactive = value
            End Set
        End Property


        Public Property Idtempo() As Integer
            Get
                Return m_Idtempo
            End Get
            Set(value As Integer)
                m_Idtempo = value
            End Set
        End Property

        Public Property Descripcion As String
            Get
                Return m_Descripcion
            End Get
            Set(value As String)
                m_Descripcion = value
            End Set
        End Property

    End Class


End Namespace
