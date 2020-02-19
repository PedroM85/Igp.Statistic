SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROCEDURE [dbo].[SYS_UpdateNacion]
	@id as int,
	@idNacion as nchar(50)
AS

update SYS_Nacion
set idNacion = @idNacion
where id= @id
GO
