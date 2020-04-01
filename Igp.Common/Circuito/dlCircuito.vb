Public Class dlCircuito
    Inherits System.ComponentModel.Component

    Public Sub New(ByVal Container As System.ComponentModel.IContainer)
        MyClass.New()

        Container.Add(Me)
    End Sub

    Public Sub New()
        MyBase.New()

        InitializeComponent()
    End Sub

    Private components As System.ComponentModel.IContainer

    Friend WithEvents adpParameter As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents adpParameterOption As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents adpParameterValues As System.Data.OleDb.OleDbDataAdapter

    Friend WithEvents selParameter As System.Data.OleDb.OleDbCommand
    Friend WithEvents selParameterOption As System.Data.OleDb.OleDbCommand
    Friend WithEvents selParameterValues As System.Data.OleDb.OleDbCommand

    Private Sub InitializeComponent()
        Me.selParameter = New System.Data.OleDb.OleDbCommand
        Me.selParameterOption = New System.Data.OleDb.OleDbCommand
        Me.selParameterValues = New System.Data.OleDb.OleDbCommand
        Me.adpParameter = New System.Data.OleDb.OleDbDataAdapter
        Me.adpParameterOption = New System.Data.OleDb.OleDbDataAdapter
        Me.adpParameterValues = New System.Data.OleDb.OleDbDataAdapter
        '
        '
        '
        Me.adpParameter.SelectCommand = Me.selParameter
        Me.adpParameter.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SYS_Circuito", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("nCircuito", "nCircuito")})})
        '
        '
        '
        Me.selParameter.CommandText = "Sys_SelectallCircuito"
        Me.selParameter.CommandType = CommandType.StoredProcedure

    End Sub

    Public Sub fillParameters(ByVal ds As dsCircuito)

        adpParameter.SelectCommand.Connection = EnvironmentObjects.Framework.Connection
        adpParameter.Fill(ds.SYS_Circuito)
    End Sub

End Class
