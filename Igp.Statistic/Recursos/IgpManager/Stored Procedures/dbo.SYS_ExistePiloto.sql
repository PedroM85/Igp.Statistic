SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[SYS_ExistePiloto]
	-- Add the parameters for the stored procedure here
@id int
	
AS

SELECT COUNT(*) FROM SYS_Piloto  WHERE id = @id

GO
