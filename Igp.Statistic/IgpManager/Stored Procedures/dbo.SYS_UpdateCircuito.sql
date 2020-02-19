SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROCEDURE [dbo].[SYS_UpdateCircuito]

@id as int,
@nCircuito nchar(100)

AS

update SYS_Circuito
set nCircuito = @nCircuito
where ID= @id
GO
