Module Metodo

    Sub llenarcombobox(ByVal cboPaises As ComboBox)
        Dim objDic As New Dictionary(Of String, String)()

        For Each ObjCultureInfo As Globalization.CultureInfo In Globalization.CultureInfo.GetCultures(Globalization.CultureTypes.SpecificCultures)
            Dim objRegioninfo As New Globalization.RegionInfo(ObjCultureInfo.Name)
            If Not objDic.ContainsKey(objRegioninfo.DisplayName) Then
                objDic.Add(objRegioninfo.DisplayName, objRegioninfo.TwoLetterISORegionName.ToLower())
            End If
        Next

        Dim obj = objDic.OrderBy(Function(p) p.Key)
        For Each val As KeyValuePair(Of String, String) In obj
            cboPaises.Items.Add(val.Key)
        Next

        cboPaises.SelectedIndex = 0

    End Sub

    Sub LimpiarCampos(ByRef Contenedor As Control.ControlCollection)
        Dim tmp As Control
        For Each tmp In Contenedor
            If tmp.GetType Is GetType(TabControl) Then
                LimpiarCampos(DirectCast(tmp, TabControl).Controls)
            ElseIf tmp.GetType Is GetType(TabPage) Then
                LimpiarCampos(DirectCast(tmp, TabPage).Controls)
            ElseIf tmp.GetType Is GetType(GroupBox) Then
                LimpiarCampos(DirectCast(tmp, GroupBox).Controls)
            Else
                If TypeOf tmp Is TextBox Then
                    DirectCast(tmp, TextBox).Clear()
                ElseIf TypeOf tmp Is MaskedTextBox Then
                    DirectCast(tmp, MaskedTextBox).Clear()
                End If
            End If
        Next
    End Sub
End Module
