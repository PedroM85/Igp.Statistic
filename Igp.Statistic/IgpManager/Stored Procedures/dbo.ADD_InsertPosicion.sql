SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROCEDURE [dbo].[ADD_InsertPosicion]
	@idTemporada as nchar(30),
	@idCircuito as int,
	@idPiloto as nchar(40),
	@idllegada as int
AS
begin
Declare @InsertedFecha as datetime

Set @InsertedFecha=GETDATE()
Select CONVERT(varchar,@InsertedFecha,21)


insert SYS_Posicion (idTemporada,idCircuito,idPiloto,Posllegada,InsertedFecha,ModifyFecha)

values (@idtemporada,@idCircuito,@idPiloto,@idllegada,@InsertedFecha,null)

end
GO
