SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[SYS_ObtenerCircuitobyID]
	@id as int
AS
select * from SYS_Circuito where id= @id
GO
