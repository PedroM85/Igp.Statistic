SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO


CREATE PROCEDURE [dbo].[SYS_DeleteTempo] 
@id as int
AS

delete from SYS_Temporada where idtem=@id
GO
