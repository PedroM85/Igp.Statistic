SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>

-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SYS_SelectallTempo]
	
AS


--select * from SYS_Temporada
select idtem,
temporada,  
case when isactive is null then 0
else isactive
end as isactive


from sys_temporada
GO
