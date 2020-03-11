SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROCEDURE [dbo].[SYS_InsertNacion]
	
	@idNacion as nchar(50)
AS
insert SYS_Nacion(idNacion) values (@idNacion)
GO
