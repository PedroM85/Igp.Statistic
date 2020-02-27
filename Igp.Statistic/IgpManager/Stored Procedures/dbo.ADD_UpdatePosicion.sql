SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ADD_UpdatePosicion]

	@id as int,
	@idTemporada as nchar(30),
	@idCircuito as int,
	@idPiloto as nchar(40),
	@Posllegada as int
	
AS

begin
Declare @ModifyFecha as datetime

Set @ModifyFecha=GETDATE()
Select CONVERT(varchar,@ModifyFecha,21)



UPDATE SYS_Posicion
SET idTemporada = @idTemporada, idCircuito = @idCircuito, idPiloto = @idPiloto, Posllegada = @Posllegada, ModifyFecha=@ModifyFecha
where ID= @id

end
GO
