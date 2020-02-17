SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[SYS_InsertPiloto]

@nPiloto as nchar(30)



AS

Insert SYS_Piloto(nPiloto) values (@nPiloto)
 

GO
