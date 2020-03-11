SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROCEDURE [dbo].[SYS_InsertCircuito] 
	@nCircuito as nchar(100)
AS

insert SYS_Circuito(nCircuito) values (@nCircuito)
GO
