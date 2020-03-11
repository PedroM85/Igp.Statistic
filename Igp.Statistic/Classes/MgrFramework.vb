Public Class MgrFramework
    Inherits Igp.Common.EWFramework

#Region " Methods "

    Public Sub New()
        MyBase.New()
    End Sub


    'Public Function GetSalesDateInfo() As SalesDateInfo
    '    Dim oDataLayer As New ewave.DataLayer.SalesDateDataLayer
    '    Dim _SalesDateInfo As New SalesDateInfo

    '    With _SalesDateInfo
    '        oDataLayer.GetGeneralInfo(.SalesDateId, .OpeningDate, .BocSessionsOpened, .ComSessionsOpened, .UsersLoggedOn)
    '        .TrainingMode = (Parameters.GetValue("TRAINMODE") = "S")
    '    End With

    '    Return _SalesDateInfo

    'End Function

#End Region

End Class
