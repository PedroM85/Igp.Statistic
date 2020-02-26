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
insert SYS_Posicion (idTemporada,idCircuito,idPiloto,Posllegada)

values (@idtemporada,@idCircuito,@idPiloto,@idllegada)
GO
