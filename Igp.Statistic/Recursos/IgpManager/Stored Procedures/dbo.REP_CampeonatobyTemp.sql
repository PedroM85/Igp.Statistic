SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[REP_CampeonatobyTemp]
@id as nchar(30)

AS


select SYS_Temporada.Temporada, sys_piloto.npiloto, sys_Circuito.nCircuito, SYS_Posicion.Posllegada, SYS_Punto.ptsCantidad from SYS_Posicion 

inner join SYS_Circuito on SYS_Posicion.idCircuito = sys_circuito.id
inner join sys_Piloto on sys_posicion.idPiloto = SYS_Piloto.id
inner join SYS_Temporada on sys_posicion.idTemporada = SYS_Temporada.idtem
inner join SYS_Punto on SYS_Posicion.posllegada = SYS_PUNTO.ptsPosicion

where sys_temporada.temporada = @id
GO
