SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[CON_Verisactive] 
	
AS

declare @totalrecs int
 select @totalrecs =  count(isactive) from SYS_Temporada where isactive = '1'
GO
