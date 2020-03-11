SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE procedure [dbo].[SYS_UpdatePiloto]
(	
	@id int,
	@nPiloto varchar(30),
	@idNacion int
)
AS
	UPDATE SYS_Piloto
		SET nPiloto = @nPiloto, IdNacion=  @idNacion 
		WHERE id=@id


GO
