SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROCEDURE [dbo].[REP_PilotobyEquipo] (
	@idEquipo as int
	)
AS
select sys_piloto.id,sys_piloto.nPiloto,sys_nacion.idNacion from SYS_Piloto 

inner join SYS_Nacion on SYS_Piloto.IdNacion = SYS_Nacion.id

where SYS_Nacion.idNacion = @idEquipo

GO
