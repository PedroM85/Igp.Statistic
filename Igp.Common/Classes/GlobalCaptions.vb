Public Class GlobalCaptions
    ' En esta clase cargamos una sola vez todas los strings globales _
    ' desde el archivo de recursos, para controles que, por su característica, _
    ' aparecen repetidamente en diferentes formularios. Externamente, actúan _
    ' como constantes, aunque internamente no lo sean.

    Private Shared m_BUTTON_OK As String = "Aceptar"
    Private Shared m_BUTTON_CANCEL As String = "Cancelar"
    Private Shared m_BUTTON_SELECT As String = "&Seleccionar"
    Private Shared m_BUTTON_FILTER As String = "Filtrar"
    Private Shared m_BUTTON_YES As String = "Si"
    Private Shared m_BUTTON_NO As String = "No"
    Private Shared m_BUTTON_CLOSE As String = "&Cerrar"

    Private Shared m_JANUS_GroupByBoxInfoText As String = "Arrastre..."
    Private Shared m_JANUS_StandardViewName As String = "Vista Estándar"

    Private Shared m_MESSAGE_ErrorRelations As String = "No se puede eliminar el registro seleccionado. Es posible que tenga relaciones."
    Private Shared m_MESSAGE_OperationNotComplete As String = "La operación no se pudo completar."
    Private Shared m_MESSAGE_EmptyField As String = "El campo no puede estar en blanco. Debe indicar un valor."
    Private Shared m_MESSAGE_CodeExist As String = "El código ingresado ya existe."
    Private Shared m_MESSAGE_ErrorPasswordComplex As String = "La contraseña debe contener letras y números."
    Private Shared m_MESSAGE_ErrorPasswordRepeat As String = "La contraseña ingresada ya fue utilizada anteriormente."
    Private Shared m_MESSAGE_SalesPeriodTimeOverlaps As String = "Ya existe una función que se superpone con los horarios que está fijando."
    Private Shared m_MESSAGE_SalesPeriodTimesNotEditable As String = "Ya existen funciones programadas, no se pueden editar los límites horarios"

    'Friend Shared Sub LoadGlobalCaptionsConstants()

    '    m_BUTTON_OK = EnvironmentObjects.Framework.GlobalResources.GetString("BUTTON_OK", "&Aceptar")
    '    m_BUTTON_CANCEL = EnvironmentObjects.Framework.GlobalResources.GetString("BUTTON_CANCEL", "&Cancelar")
    '    m_BUTTON_SELECT = EnvironmentObjects.Framework.GlobalResources.GetString("BUTTON_SELECT", "&Seleccionar")
    '    m_BUTTON_FILTER = EnvironmentObjects.Framework.GlobalResources.GetString("BUTTON_FILTER", "Filtrar")
    '    m_BUTTON_YES = EnvironmentObjects.Framework.GlobalResources.GetString("BUTTON_YES", "Si")
    '    m_BUTTON_NO = EnvironmentObjects.Framework.GlobalResources.GetString("BUTTON_NO", "No")
    '    m_BUTTON_CLOSE = EnvironmentObjects.Framework.GlobalResources.GetString("BUTTON_CLOSE", "&Cerrar")

    '    m_JANUS_GroupByBoxInfoText = EnvironmentObjects.Framework.GlobalResources.GetString("JANUSGroupByBoxInfoText", "Arrastre aqui la cabecera de la columna por la que desea agrupar.")
    '    m_JANUS_StandardViewName = EnvironmentObjects.Framework.GlobalResources.GetString("JANUSStandardViewName", "Vista Estándar")

    '    m_MESSAGE_ErrorRelations = EnvironmentObjects.Framework.GlobalResources.GetString("MESSAGE_ErrorRelations", "No se puede eliminar el registro seleccionado. Es posible que tenga relaciones.")
    '    m_MESSAGE_OperationNotComplete = EnvironmentObjects.Framework.GlobalResources.GetString("MESSAGE_ErrorRelations", "La operación no se pudo completar.")
    '    m_MESSAGE_SalesPeriodTimeOverlaps = EnvironmentObjects.Framework.GlobalResources.GetString("MESSAGE_SalesPeriodTimeOverlaps", "Ya existe una función que se superpone con los horarios que está fijando.")
    '    m_MESSAGE_SalesPeriodTimesNotEditable = EnvironmentObjects.Framework.GlobalResources.GetString("MESSAGE_SalesPeriodTimesNotEditable", "Ya existen funciones programadas, no se pueden editar los límites horarios")
    '    m_MESSAGE_EmptyField = "El campo no puede estar en blanco. Debe indicar un valor."
    '    m_MESSAGE_CodeExist = "El código ingresado ya existe."

    'End Sub

    Public Shared ReadOnly Property BUTTON_OK() As String
        Get
            Return m_BUTTON_OK
        End Get
    End Property

    Public Shared ReadOnly Property BUTTON_CANCEL() As String
        Get
            Return m_BUTTON_CANCEL
        End Get
    End Property

    Public Shared ReadOnly Property BUTTON_SELECT() As String
        Get
            Return m_BUTTON_SELECT
        End Get
    End Property

    Public Shared ReadOnly Property BUTTON_FILTER() As String
        Get
            Return m_BUTTON_FILTER
        End Get
    End Property

    Public Shared ReadOnly Property BUTTON_YES() As String
        Get
            Return m_BUTTON_YES
        End Get
    End Property

    Public Shared ReadOnly Property BUTTON_NO() As String
        Get
            Return m_BUTTON_NO
        End Get
    End Property

    Public Shared ReadOnly Property BUTTON_CLOSE() As String
        Get
            Return m_BUTTON_CLOSE
        End Get
    End Property

    Public Shared ReadOnly Property JANUS_GroupByBoxInfoText() As String
        Get
            Return m_JANUS_GroupByBoxInfoText
        End Get
    End Property

    Public Shared ReadOnly Property JANUS_StandardViewName() As String
        Get
            Return m_JANUS_StandardViewName
        End Get
    End Property

    Public Shared ReadOnly Property MESSAGE_ErrorRelations() As String
        Get
            Return m_MESSAGE_ErrorRelations
        End Get
    End Property

    Public Shared ReadOnly Property MESSAGE_OperationNotComplete() As String
        Get
            Return m_MESSAGE_OperationNotComplete
        End Get
    End Property

    Public Shared ReadOnly Property MESSAGE_EmptyField() As String
        Get
            Return m_MESSAGE_EmptyField
        End Get
    End Property

    Public Shared ReadOnly Property MESSAGE_CodeExist() As String
        Get
            Return m_MESSAGE_CodeExist
        End Get
    End Property

    Public Shared ReadOnly Property MESSAGE_SalesPeriodTimeOverlaps() As String
        Get
            Return m_MESSAGE_SalesPeriodTimeOverlaps
        End Get
    End Property
    Public Shared ReadOnly Property MESSAGE_SalesPeriodTimesNotEditable() As String
        Get
            Return m_MESSAGE_SalesPeriodTimesNotEditable
        End Get
    End Property
    Public Shared ReadOnly Property MESSAGE_ErrorPasswordComplex() As String
        Get
            Return m_MESSAGE_ErrorPasswordComplex
        End Get
    End Property

    Public Shared ReadOnly Property MESSAGE_ErrorPasswordRepeat() As String
        Get
            Return m_MESSAGE_ErrorPasswordRepeat
        End Get
    End Property

End Class
