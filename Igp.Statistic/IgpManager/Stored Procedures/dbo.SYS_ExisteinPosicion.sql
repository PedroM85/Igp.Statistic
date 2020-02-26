SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[SYS_ExisteinPosicion] 
	@idTemporada as nchar(30),
	@idCircuito as int,
	@idpiloto as nchar(40)
AS
--select count (*) idTemporada,idCircuito,idPiloto,posllegada from sys_posicion where idcircuito = 1 and idpiloto = 1 and idTemporada = 29
--group by idTemporada,idCircuito,idPiloto,posllegada

--if exists(select * from sys_posicion where idpiloto = @idpiloto and idcircuito = @idCircuito and idTemporada = @idTemporada)
--begin
--print('a la verga')
--return
--end

if (select count(idcircuito) from sys_posicion where idpiloto = 7 and idcircuito = 4 and idtemporada = 29 )>0
     Select 1 [Exists]
else
        Select 0 [Exists]
GO
