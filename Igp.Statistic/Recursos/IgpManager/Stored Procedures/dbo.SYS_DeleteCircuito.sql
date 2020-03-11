SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[SYS_DeleteCircuito]
@id as int

AS

DELETE  from SYS_Circuito where id=@id
GO
