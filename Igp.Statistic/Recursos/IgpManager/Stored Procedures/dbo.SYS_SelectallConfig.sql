SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROCEDURE [dbo].[SYS_SelectallConfig]
as 
	select * from sys_configuracion
GO
