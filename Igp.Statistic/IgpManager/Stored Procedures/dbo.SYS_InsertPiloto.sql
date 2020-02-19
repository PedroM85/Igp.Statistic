SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[SYS_InsertPiloto]


@npiloto as nchar(40),
@idnacion as int

AS

Insert SYS_Piloto(nPiloto,idNacion) values (@nPiloto,@idNacion)
 


GO
