SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[SYS_ExisteinPosicion]( 
	@posicion int output,
	@resultado int output,	
	@piloto int output,
	@idTemporada  nchar(30),
	@idCircuito  int,
	@idpiloto  nchar(40),
	@Posllegada int
	)
AS

begin
--declare 
--@posicion int,
--@resultado int 

select @posicion = count(Posllegada)from SYS_Posicion where Posllegada = @Posllegada and idCircuito = @idCircuito and idPiloto = @idpiloto and idTemporada = @idTemporada
--select @posicion = count(Posllegada) from SYS_Posicion where Posllegada = 2 and idCircuito = 1 and idPiloto = 8 and idTemporada = 29


select @resultado = id from sys_posicion where  Posllegada = @Posllegada and idCircuito = @idCircuito and idPiloto = @idpiloto and  idTemporada = @idTemporada 
	

--select @resultado = id from sys_posicion where  Posllegada = 2 and idCircuito = 1 and idPiloto = 8 and  idTemporada = 29   	  
select @piloto = count(idPiloto) from SYS_Posicion where Posllegada = @Posllegada and idCircuito = @idCircuito and idPiloto = @idpiloto and idTemporada = @idTemporada


return @posicion
--print @posicion
return @resultado
--print @resultado
return @piloto
--print @piloto
end












----if (select count(idcircuito) from sys_posicion where idpiloto = 7 and idcircuito = 4 and idtemporada = 29 )>0
----if (select count(idcircuito ) from sys_posicion where idpiloto = @idpiloto and idcircuito = @idCircuito and idTemporada = @idTemporada and Posllegada = @Posllegada )>0
----     Select 1 [Exists]
----else
----        Select 0 [Exists]

----		begin
--begin

--select @posicion = Posllegada	from SYS_Posicion where idpiloto = @idpiloto and idcircuito = @idCircuito and idTemporada = @idTemporada and Posllegada = @Posllegada

--end 

--begin		--declare @id int
----	 select id from sys_posicion where idpiloto = 1 and idcircuito = 2 and idTemporada = 29

--	  select @resultado = id from sys_posicion where  idPiloto = @idpiloto and Posllegada = @Posllegada and idTemporada = @idTemporada and idCircuito = @idCircuito  	  
--		 --return @id 
--	 end

	 

--		--declare @posicion int
----	 select id from sys_posicion where idpiloto = 1 and idcircuito = 2 and idTemporada = 29

--	 --if( select count(@Posllegada) from sys_posicion where  idPiloto = @idpiloto  and idTemporada = @idTemporada and idCircuito = @idCircuito  )>0	  
--		-- --return @id 
--	 --select 1 [aaa]
--	 --else
--	 --select 0 [111]
GO
