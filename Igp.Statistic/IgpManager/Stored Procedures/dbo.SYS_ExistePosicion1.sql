SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SYS_ExistePosicion1] (
	@idTemporada  nchar(30),
	@idCircuito  int,	
	@Posllegada int
	)
AS

select count(Posllegada) from SYS_Posicion  where Posllegada = @Posllegada and idCircuito = @idCircuito  and idTemporada = @idTemporada

GO
