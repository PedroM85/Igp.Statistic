Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace Entidades
    Public Class ConfigEntity

        Public Sub New(id As String, desc As String, valor As String, type As String)
            Me.Id = id
            Me.Descripcion = desc
            Me.Valor = valor
            Me.type = type
        End Sub

        Public Sub New()
        End Sub
        Private m_type As String
        Private m_valor As String
        Private m_Id As String
        Private m_Descripcion As String

        Public Property Id() As String
            Get
                Return m_Id
            End Get
            Set(value As String)
                m_Id = value
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

        Public Property Valor As String
            Get
                Return m_valor
            End Get
            Set(value As String)
                m_valor = value
            End Set
        End Property

        Public Property type As String
            Get
                Return m_type
            End Get
            Set(value As String)
                m_type = value
            End Set
        End Property
    End Class


End Namespace

