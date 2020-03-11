SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
create PROCEDURE [dbo].[SYS_ExistePilotoBy]
	-- Add the parameters for the stored procedure here
@id nchar(40)
	
AS

select * from sys_piloto where nPiloto= @id

GO
