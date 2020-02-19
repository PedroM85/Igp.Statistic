Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace Entidades
    Public Class ConfigEntity

        Public Sub New(idv As String, desc As String, valor As String, type As String, id As Int32)
            Me.Id = id
            Me.idv = idv
            Me.Descripcion = desc
            Me.Valor = valor
            Me.type = type
        End Sub

        Public Sub New()
        End Sub
        Private m_idv As String
        Private m_type As String
        Private m_valor As String
        Private m_Id As Int32
        Private m_Descripcion As String

        Public Property id As Int32
            Get
                Return m_Id
            End Get
            Set(value As Int32)
                m_Id = value
            End Set
        End Property
        Public Property Idv() As String
            Get
                Return m_idv
            End Get
            Set(value As String)
                m_idv = value
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

