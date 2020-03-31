
Public Class CircuitoDataLayer
    Inherits System.ComponentModel.Component

    Friend WithEvents adpParameterValues As OleDb.OleDbDataAdapter
    Friend WithEvents adpParameter As OleDb.OleDbDataAdapter
    Friend WithEvents selParameter As OleDb.OleDbCommand
    Friend WithEvents updParameter As OleDb.OleDbCommand
    Friend WithEvents adpParameterOption As OleDb.OleDbDataAdapter
    Friend WithEvents selParameterOption As OleDb.OleDbCommand
    Friend WithEvents selParameterValues As OleDb.OleDbCommand

    Public Sub New(ByVal Container As System.ComponentModel.IContainer)
        MyClass.New()

        Container.Add(Me)
    End Sub


    Public Sub New()
        MyBase.New()

        'This call is required by the Component Designer.

        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Private Sub InitializeComponent()
        Me.adpParameterValues = New System.Data.OleDb.OleDbDataAdapter()
        Me.selParameterValues = New System.Data.OleDb.OleDbCommand()
        Me.adpParameter = New System.Data.OleDb.OleDbDataAdapter()
        Me.selParameter = New System.Data.OleDb.OleDbCommand()
        Me.updParameter = New System.Data.OleDb.OleDbCommand()
        Me.adpParameterOption = New System.Data.OleDb.OleDbDataAdapter()
        Me.selParameterOption = New System.Data.OleDb.OleDbCommand()
        '
        'adpParameterValues
        '
        Me.adpParameterValues.SelectCommand = Me.selParameterValues
        Me.adpParameterValues.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SYS_Parameter", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("PAR_Id", "PAR_Id"), New System.Data.Common.DataColumnMapping("PAR_Description", "PAR_Description"), New System.Data.Common.DataColumnMapping("PAR_Type", "PAR_Type"), New System.Data.Common.DataColumnMapping("PAR_DatetimeValue", "PAR_DatetimeValue"), New System.Data.Common.DataColumnMapping("PAR_StringValue", "PAR_StringValue"), New System.Data.Common.DataColumnMapping("PAR_NumericValue", "PAR_NumericValue"), New System.Data.Common.DataColumnMapping("PAR_Cacheable", "PAR_Cacheable"), New System.Data.Common.DataColumnMapping("PAR_ReadOnly", "PAR_ReadOnly")})})
        '
        'adpParameter
        '
        Me.adpParameter.SelectCommand = Me.selParameter
        Me.adpParameter.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SYS_Parameter", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("PAR_Id", "PAR_Id"), New System.Data.Common.DataColumnMapping("PAR_Description", "PAR_Description"), New System.Data.Common.DataColumnMapping("PAR_Type", "PAR_Type"), New System.Data.Common.DataColumnMapping("PAR_DatetimeValue", "PAR_DatetimeValue"), New System.Data.Common.DataColumnMapping("PAR_StringValue", "PAR_StringValue"), New System.Data.Common.DataColumnMapping("PAR_NumericValue", "PAR_NumericValue"), New System.Data.Common.DataColumnMapping("PAR_Cacheable", "PAR_Cacheable"), New System.Data.Common.DataColumnMapping("PAR_ReadOnly", "PAR_ReadOnly")})})
        '
        'selParameter
        '
        Me.selParameter.CommandText = "PAR_SelectUnion"
        Me.selParameter.CommandType = System.Data.CommandType.StoredProcedure
        '
        'updParameter
        '
        Me.updParameter.CommandText = "PAR_Update"
        Me.updParameter.CommandType = System.Data.CommandType.StoredProcedure
        Me.updParameter.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("@PAR_Id", System.Data.OleDb.OleDbType.[Char], 10), New System.Data.OleDb.OleDbParameter("@PAR_Type", System.Data.OleDb.OleDbType.[Char], 1), New System.Data.OleDb.OleDbParameter("@PAR_DatetimeValue", System.Data.OleDb.OleDbType.[Date]), New System.Data.OleDb.OleDbParameter("@PAR_StringValue", System.Data.OleDb.OleDbType.VarChar, 500), New System.Data.OleDb.OleDbParameter("@PAR_NumericValue", System.Data.OleDb.OleDbType.Numeric, 9, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(6, Byte), "", System.Data.DataRowVersion.Current, Nothing)})
        '
        'adpParameterOption
        '
        Me.adpParameterOption.SelectCommand = Me.selParameterOption
        Me.adpParameterOption.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SYS_Parameter", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("PAR_Id", "PAR_Id"), New System.Data.Common.DataColumnMapping("PAR_Description", "PAR_Description"), New System.Data.Common.DataColumnMapping("PAR_Type", "PAR_Type"), New System.Data.Common.DataColumnMapping("PAR_DatetimeValue", "PAR_DatetimeValue"), New System.Data.Common.DataColumnMapping("PAR_StringValue", "PAR_StringValue"), New System.Data.Common.DataColumnMapping("PAR_NumericValue", "PAR_NumericValue"), New System.Data.Common.DataColumnMapping("PAR_Cacheable", "PAR_Cacheable"), New System.Data.Common.DataColumnMapping("PAR_ReadOnly", "PAR_ReadOnly")})})
        '
        'selParameterOption
        '
        Me.selParameterOption.CommandText = "PAO_Select"
        Me.selParameterOption.CommandType = System.Data.CommandType.StoredProcedure
        Me.selParameterOption.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("@PAO_PAR_Id", System.Data.OleDb.OleDbType.[Char], 10)})

    End Sub

    Public Sub fillCircuito(ByVal ds As CircuitoDataSet)
        adpParameter.SelectCommand.Connection = EnvironmentObjects.Framework.Connection
        adpParameter.Fill(ds.SYS_Circuito)
    End Sub
End Class
