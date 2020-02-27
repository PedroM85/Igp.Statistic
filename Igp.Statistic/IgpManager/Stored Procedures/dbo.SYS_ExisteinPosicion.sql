SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[SYS_ExisteinPosicion]( 
	
	@idTemporada  nchar(30),
	@idCircuito  int,
	@idpiloto  nchar(40)
	)
AS

--if (select count(idcircuito) from sys_posicion where idpiloto = 7 and idcircuito = 4 and idtemporada = 29 )>0
if (select count(idcircuito) from sys_posicion where idpiloto = @idpiloto and idcircuito = @idCircuito and idTemporada = @idTemporada )>0
     Select 1 [Exists]
else
        Select 0 [Exists]

		begin
		declare @id int 
--	 select id from sys_posicion where idpiloto = 1 and idcircuito = 2 and idTemporada = 29

	 select @id = id from sys_posicion where idpiloto = @idpiloto and idcircuito = @idCircuito and idTemporada = @idTemporada
	 	return @id
	 end
GO
