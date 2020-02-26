SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[SYS_SelectaTempoactive]
--@id as int

AS
select idtem, temporada,isactive= case isnull(isactive ,0) when 1 then 1 else 0 end 
from sys_temporada 
where isactive = '1'
GO
