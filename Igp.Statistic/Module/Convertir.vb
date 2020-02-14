Imports System.Drawing.Imaging
Imports System.IO
Module Convertir
    Public Function BytesAImagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen 
            If Not Imagen Is Nothing Then
                Dim Bin As New MemoryStream(Imagen) 'capturar array con memorystream hacia Bin 
                Dim Resultado As Image = Image.FromStream(Bin) 'con el método FroStream de Image obtenemos imagen 
                Return Resultado 'y la retornamos 
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Module
