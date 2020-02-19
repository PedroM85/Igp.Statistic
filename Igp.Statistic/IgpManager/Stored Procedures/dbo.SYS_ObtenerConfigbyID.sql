SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROCEDURE [dbo].[SYS_ObtenerConfigbyID]
	@id as int
AS
select * from SYS_Configuracion where PAR_id=@id
GO
