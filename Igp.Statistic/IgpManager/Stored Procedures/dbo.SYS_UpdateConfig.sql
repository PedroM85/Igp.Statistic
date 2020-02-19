SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[SYS_UpdateConfig]

@id as int,
@PAR_Type as char(1),
@PAR_String as varchar(4096),
@PAR_Numeric as numeric(19, 4)

AS

if @PAR_Type = 'S'
	BEGIN 		
		SET @PAR_Numeric = NULL
	END 

if @PAR_Type = 'N'
	BEGIN 		
		SET @PAR_String = NULL
	END 

update SYS_Configuracion
set PAR_Numeric =@PAR_Numeric,PAR_String=@PAR_String
where PAR_ID= @id


GO
