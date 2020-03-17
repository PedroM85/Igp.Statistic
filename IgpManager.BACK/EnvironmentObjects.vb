Public Class EnvironmentObjects
    Private Shared mApp As IFrameworkBase

    Public Shared Property Fwk() As IFrameworkBase
        Get
            Return mApp
        End Get
        Set(ByVal Value As IFrameworkBase)
            mApp = Value
        End Set
    End Property


#Region " Global Resources "
    'dcofre 7/08: se asigna un valor por defecto al text de los botones
    'asi, si algo falla antes de que se cargen los recursos, 
    'por lo menos se lee algo en el boton
    Public Shared BUTTON_OK As String = "Ok"
    Public Shared BUTTON_CANCEL As String = "Cancel"
    Public Shared BUTTON_SELECT As String = "Select"
    Public Shared BUTTON_FILTER As String = "Filter"
    Public Shared BUTTON_YES As String = "Yes"
    Public Shared BUTTON_NO As String = "No"
    Public Shared BUTTON_CLOSE As String = "Close"
    Public Shared BUTTON_RETRY As String = "Retry"

    Public Shared JANUS_GroupByBoxInfoText As String
    Public Shared Msg_Tran_Cancelled As String
    Public Shared Msg_Tran_Error As String
    Public Shared Msg_Tran_Interrupt As String
    Public Shared Msg_Ref_Interrupt As String
    Public Shared Msg_Ref_Detail As String
    Public Shared Msg_Tran_Err_NoTicket As String
    Public Shared Msg_Registering_Ticket As String
    Public Shared Msg_Registering_SuppCharge As String
    Public Shared Today As String
    Public Shared Tomorrow As String
    Public Shared Future As String
    Public Shared Msg_Element_Not_Found As String
    Public Shared Msg_TrainMode As String
    Public Shared Msg_Calc_Not_Found As String
    Public Shared Msg_No_exit As String
    Public Shared Msg_On_transaction As String
    Public Shared Msg_Incorrect_Pass As String
    Public Shared Msg_Tran_Confirm As String
    Public Shared Msg_Tran_Max_Seats As String
    Public Shared Msg_Reserv_TimeLimit As String
    Public Shared Msg_Reserv_Disabled As String
    Public Shared Msg_Ref_NoTicket As String
    Public Shared Msg_DaySpan As String
    Public Shared Msg_Err_AuthError As String
    Public Shared Msg_ReturnValue As String
    Public Shared Msg_Tran_Max_ReservEditSeats As String


    Public Shared Sub LoadGlobalCaptions()

        'PrinterManager.LoadGlobalCaptions()

        Msg_Tran_Cancelled = EnvironmentObjects.Fwk.GlobalResources.GetString("Msg_Tran_Cancelled", "Error iniciando impresora, transacción cancelada.")
        Msg_Tran_Error = EnvironmentObjects.Fwk.GlobalResources.GetString("Msg_Tran_Error", "Error en la transacción")
        Msg_Tran_Interrupt = EnvironmentObjects.Fwk.GlobalResources.GetString("Msg_Tran_Interrupt", "La transacción ha sido interrumpida.")
        Msg_Ref_Interrupt = EnvironmentObjects.Fwk.GlobalResources.GetString("Msg_Ref_Interrupt", "La transacción ha sido interrumpida. Se han registrado {0} reembolsos entre tickets y cargos suplementarios")
        Msg_Ref_Detail = EnvironmentObjects.Fwk.GlobalResources.GetString("Msg_Ref_Detail", "Se han registrado los siguientes reembolsos:")
        Msg_Tran_Err_NoTicket = EnvironmentObjects.Fwk.GlobalResources.GetString("Msg_Tran_Err_NoTicket", "No se han procesado todos los tickets correctamente")
        Msg_Registering_Ticket = EnvironmentObjects.Fwk.GlobalResources.GetString("Msg_Registering_Ticket", "Registrando ticket")
        Msg_Registering_SuppCharge = EnvironmentObjects.Fwk.GlobalResources.GetString("Msg_Registering_SuppCharge", "Registrando cargo suplementario")
        Today = EnvironmentObjects.Fwk.GlobalResources.GetString("Today", "HOY")
        Tomorrow = EnvironmentObjects.Fwk.GlobalResources.GetString("Tomorrow", "MAÑANA")
        Future = EnvironmentObjects.Fwk.GlobalResources.GetString("Future", "FUTURO")
        Msg_Element_Not_Found = EnvironmentObjects.Fwk.GlobalResources.GetString("Msg_Element_Not_Found", "No se han encontrado coincidencias.")
        Msg_TrainMode = EnvironmentObjects.Fwk.GlobalResources.GetString("Msg_TrainMode", "Modo de entrenamiento")
        Msg_Calc_Not_Found = EnvironmentObjects.Fwk.GlobalResources.GetString("Msg_Calc_not_found", "No se puede ejecutar la calculadora de Windows.")
        Msg_No_exit = EnvironmentObjects.Fwk.GlobalResources.GetString("Msg_No_exit", "Para salir debe terminar o cancelar la transacción actual.")
        Msg_On_transaction = EnvironmentObjects.Fwk.GlobalResources.GetString("Msg_On_transaction", "Transacción en progreso")
        Msg_Incorrect_Pass = EnvironmentObjects.Fwk.GlobalResources.GetString("Msg_Incorrect_Pass", "La contraseña es incorrecta.")
        Msg_Tran_Confirm = EnvironmentObjects.Fwk.GlobalResources.GetString("Msg_Tran_Confirm", "¿Confirma la transacción?")
        Msg_Tran_Max_Seats = EnvironmentObjects.Fwk.GlobalResources.GetString("Msg_Tran_Max_Seats", "Puede seleccionar un máximo de {0} localidades por vez.")
        Msg_Reserv_TimeLimit = EnvironmentObjects.Fwk.GlobalResources.GetString("Msg_Reserv_TimeLimit", "No se pueden reservar las localidades seleccionadas debido al límite de tiempo de reserva.")
        Msg_Reserv_Disabled = EnvironmentObjects.Fwk.GlobalResources.GetString("Msg_Reserv_Disabled", "Las reservas están actualmente deshabilitadas.")
        Msg_Ref_NoTicket = EnvironmentObjects.Fwk.GlobalResources.GetString("Msg_Ref_NoTicket", "No se han encontrado tickets reembolsables.")
        Msg_DaySpan = EnvironmentObjects.Fwk.GlobalResources.GetString("Msg_DaySpan", "Del {0} al {1}")
        Msg_Err_AuthError = EnvironmentObjects.Fwk.GlobalResources.GetString("Msg_Err_AuthError", "Los datos para la autorización son incorrectos.")
        Msg_ReturnValue = EnvironmentObjects.Fwk.GlobalResources.GetString("Msg_ReturnValue", "Su vuelto es:")

        BUTTON_OK = EnvironmentObjects.Fwk.GlobalResources.GetString("BUTTON_OK", "&Aceptar")
        BUTTON_CANCEL = EnvironmentObjects.Fwk.GlobalResources.GetString("BUTTON_CANCEL", "&Cancelar")
        BUTTON_SELECT = EnvironmentObjects.Fwk.GlobalResources.GetString("BUTTON_SELECT", "&Seleccionar")
        BUTTON_FILTER = EnvironmentObjects.Fwk.GlobalResources.GetString("BUTTON_FILTER", "Filtrar")
        BUTTON_YES = EnvironmentObjects.Fwk.GlobalResources.GetString("BUTTON_YES", "Si")
        BUTTON_NO = EnvironmentObjects.Fwk.GlobalResources.GetString("BUTTON_NO", "No")
        BUTTON_CLOSE = EnvironmentObjects.Fwk.GlobalResources.GetString("BUTTON_CLOSE", "&Cerrar")
        BUTTON_RETRY = EnvironmentObjects.Fwk.GlobalResources.GetString("BUTTON_RETRY", "Reintentar")

        JANUS_GroupByBoxInfoText = EnvironmentObjects.Fwk.GlobalResources.GetString("GlobalCaptionsConstants.JANUS.GroupByBoxInfoText", "Arrastre aquí la cabecera de la columna por la que desea agrupar.")

        Msg_Tran_Max_ReservEditSeats = EnvironmentObjects.Fwk.GlobalResources.GetString("Msg_Tran_Max_ReservEditSeats", "No puede seleccionar más asientos que la reserva original.")

    End Sub

#End Region


End Class
