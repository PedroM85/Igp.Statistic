SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROCEDURE [dbo].[SYS_ObtenerTempobyID]
	@id as int
AS

select idtem,
temporada,  
case when isactive is null then 0
else isactive
end as isactive


from sys_temporada

where idtem=@id
GO
