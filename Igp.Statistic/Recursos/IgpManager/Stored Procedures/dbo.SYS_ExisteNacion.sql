SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[SYS_ExisteNacion]

@id as int

AS

SELECT COUNT(*) FROM SYS_Nacion	  WHERE id = @id
GO