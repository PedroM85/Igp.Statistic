SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[SYS_ExisteCircuito]
	-- Add the parameters for the stored procedure here
	@id as int
AS

SELECT COUNT(*) FROM SYS_Circuito	  WHERE id = @id

GO
