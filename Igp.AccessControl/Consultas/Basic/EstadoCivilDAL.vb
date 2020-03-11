Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Igp.AccessControl.Entidades



Public NotInheritable Class EstadoCivilDAL

    Public Shared Function ObtenerTodos() As List(Of EstadoCivilEntity)

        Dim lista As New List(Of EstadoCivilEntity)()

        lista.Add(New EstadoCivilEntity(1, "Solero"))
        lista.Add(New EstadoCivilEntity(2, "Casado"))
        lista.Add(New EstadoCivilEntity(3, "Divorciado"))
        lista.Add(New EstadoCivilEntity(4, "Viudo"))

        Return lista

    End Function


End Class

