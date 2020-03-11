SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SYS_ExistePosicion] (
	@idTemporada  nchar(30),
	@idCircuito  int,
	@idpiloto  nchar(40),
	@Posllegada int
	)
AS

select count(*) from SYS_Posicion  where Posllegada = @Posllegada and idCircuito = @idCircuito and idPiloto = @idpiloto and idTemporada = @idTemporada

GO
