SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SYS_ExistePosicion2] (
	@idTemporada  nchar(30),
	@idCircuito  int,
	@idpiloto  nchar(40)
	
	)
AS

select count(*) from SYS_Posicion  where  idCircuito = @idCircuito and idPiloto = @idpiloto and idTemporada = @idTemporada

GO
