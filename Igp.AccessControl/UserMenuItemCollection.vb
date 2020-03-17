<CLSCompliant(True)>
Public Class UserMenuItemCollection
    Inherits CollectionBase

    Public Sub Add(ByVal menuitem As UserMenuItem)
        MyBase.List.Add(menuitem)
    End Sub

    Public Sub Remove(ByVal menuitem As UserMenuItem)
        MyBase.List.Remove(menuitem)
    End Sub

    Public ReadOnly Property Item(ByVal index As Integer) As UserMenuItem
        Get
            Return CType(MyBase.List(index), UserMenuItem)
        End Get
    End Property

    Public ReadOnly Property Item(ByVal key As String) As UserMenuItem
        Get
            Dim nI As Integer
            Dim oItem As UserMenuItem

            For nI = 0 To MyBase.List.Count - 1
                oItem = CType(MyBase.List(nI), UserMenuItem)

                If oItem.Key = key Then
                    Return oItem
                    Exit For
                End If
            Next
            Return Nothing
        End Get
    End Property

End Class

