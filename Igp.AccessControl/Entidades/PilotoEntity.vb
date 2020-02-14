Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Namespace Entidades
    Public Class PilotoEntity

        Public Sub New()

        End Sub

        Private m_nacion As Short
        Private m_id As Integer
        Private m_nombre As String
        Private m_imagen As Byte()

        Public Property nacion() As Short
            Get
                Return m_nacion
            End Get
            Set(value As Short)
                m_nacion = value
            End Set
        End Property

        Public Property id() As Integer
            Get
                Return m_id
            End Get
            Set(value As Integer)
                m_id = value
            End Set
        End Property

        Public Property nombre() As String
            Get
                Return m_nombre
            End Get
            Set(value As String)
                m_nombre = value
            End Set
        End Property

        Public Property imagen() As Byte()
            Get
                Return m_imagen
            End Get
            Set(value As Byte())
                m_imagen = value
            End Set
        End Property


    End Class

End Namespace
