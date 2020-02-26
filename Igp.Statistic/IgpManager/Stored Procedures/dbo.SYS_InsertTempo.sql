SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROCEDURE [dbo].[SYS_InsertTempo]

@Tempo as nchar(30),
@isactive as bit

AS

if @isactive = 0

BEGIN 		
		SET @isactive = 0
	END 

	if @isactive = 1

BEGIN 		
		SET @isactive = 1
	END 

insert sys_temporada (Temporada,isactive) values(@tempo,@isactive)
GO
