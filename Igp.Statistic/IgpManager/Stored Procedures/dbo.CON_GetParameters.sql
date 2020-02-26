SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[CON_GetParameters]
AS
SELECT PAR_Id,
	   PAR_Idv,
       PAR_Type,       
       PAR_String,
       PAR_Numeric
FROM SYS_Configuracion WITH (NOLOCK)
WHERE PAR_Cacheable <> 0
GO
