SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO


create PROCEDURE [dbo].[REP_CampeobyTempoPiloto]
	@idTemporada nchar(40)
	
AS
select 
sys_piloto.npiloto,

 sum(SYS_Posicion.Ptsllegada) as Totales
  
 from SYS_Posicion with (nolock)

 inner join sys_Piloto on sys_posicion.idPiloto = SYS_Piloto.id

  where   SYS_Posicion.idTemporada = '30' 

 group by 
 sys_piloto.npiloto

 order by Totales desc
GO
