SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROCEDURE [dbo].[ADD_InsertPosicion]
	@idTemporada  int,
	@idCircuito  int,
	@idPiloto  int,
	@idllegada  int,
	@Pllegada  int
AS


insert into SYS_Posicion 

(idTemporada,idCircuito,idPiloto,Posllegada,Ptsllegada,InsertedFecha,ModifyFecha)

values 

(@idtemporada,@idCircuito,@idPiloto,@idllegada,@Pllegada,GETDATE(),NULL)


GO
