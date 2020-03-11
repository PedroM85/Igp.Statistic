SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[SYS_ObtenerNacionbyID]
	@id as int
AS

    -- Insert statements for procedure here
	SELECT * from SYS_Nacion where id = @id
GO
