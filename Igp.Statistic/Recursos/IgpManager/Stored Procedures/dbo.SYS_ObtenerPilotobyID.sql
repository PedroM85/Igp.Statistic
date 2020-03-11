SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[SYS_ObtenerPilotobyID]
	-- Add the parameters for the stored procedure here
	@id as int
AS
	SELECT * from SYS_Piloto where id = @id

--	select SYS_Piloto.id, SYS_Piloto.nPiloto, SYS_Nacion.Nacion from SYS_Nacion

--inner join SYS_Piloto on SYS_Nacion.id = SYS_Piloto.IdNacion 
--where SYS_Piloto.id = @id
GO
