SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROCEDURE [dbo].[SYS_UpdateTempo]
@id as int,
@tempo as nchar(30),
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

	Update SYS_Temporada
	set Temporada=@tempo,isactive=@isactive
	where idtem=@id
GO
