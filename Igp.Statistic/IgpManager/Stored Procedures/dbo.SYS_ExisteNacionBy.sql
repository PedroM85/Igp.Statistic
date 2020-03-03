SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
create PROCEDURE [dbo].[SYS_ExisteNacionBy]

@id as nchar(50)

AS

SELECT COUNT(*) FROM SYS_Nacion	  WHERE idNacion = @id
GO
