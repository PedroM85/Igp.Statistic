Imports System.Security.Cryptography

Public Class ProtectData

    Public Shared Function EncryptData(ByVal sData As String, ByVal bKey() As Byte, ByVal bIV() As Byte) As String

        Dim oCryptProvider As New TripleDESCryptoServiceProvider

        Dim bInput() As Byte
        Dim bOutput() As Byte

        Dim oTransform As ICryptoTransform = oCryptProvider.CreateEncryptor(bKey, bIV)

        Dim b As New System.Text.ASCIIEncoding

        bInput = b.GetBytes(sData)

        bOutput = oTransform.TransformFinalBlock(bInput, 0, bInput.Length)

        Return System.Convert.ToBase64String(bOutput, 0, bOutput.Length)

    End Function

    Public Shared Function DecryptData(ByVal sData As String, ByVal bKey() As Byte, ByVal bIV() As Byte) As String

        Dim oCryptProvider As New TripleDESCryptoServiceProvider

        Dim bInput() As Byte

        Dim i As ICryptoTransform = oCryptProvider.CreateDecryptor(bKey, bIV)

        Dim b As New System.Text.ASCIIEncoding

        bInput = System.Convert.FromBase64String(sData)

        bInput = i.TransformFinalBlock(bInput, 0, bInput.Length)

        Return b.GetString(bInput)

    End Function
End Class
