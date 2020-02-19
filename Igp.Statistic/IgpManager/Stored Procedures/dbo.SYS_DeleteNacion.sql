SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROCEDURE [dbo].[SYS_DeleteNacion]
	@id as int
AS

DELETE  from SYS_Nacion where id=@id
GO
