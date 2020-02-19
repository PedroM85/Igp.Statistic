USE [IgpManager]
GO
/****** Object:  Table [dbo].[SYS_Circuito]    Script Date: 18/02/2020 17:58:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SYS_Circuito](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[nCircuito] [nchar](100) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SYS_Configuracion]    Script Date: 18/02/2020 17:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SYS_Configuracion](
	[PAR_Id] [nchar](10) NOT NULL,
	[PAR_Descripcion] [varchar](100) NOT NULL,
	[PAR_Type] [char](1) NOT NULL,
	[PAR_String] [varchar](4096) NULL,
	[PAR_Numeric] [numeric](19, 4) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SYS_Nacion]    Script Date: 18/02/2020 17:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SYS_Nacion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idNacion] [nchar](50) NULL,
 CONSTRAINT [PK_SYS_Nacion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SYS_Piloto]    Script Date: 18/02/2020 17:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SYS_Piloto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nPiloto] [nchar](40) NOT NULL,
	[IdNacion] [int] NULL,
 CONSTRAINT [PK_SYS_Piloto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SYS_Posicion]    Script Date: 18/02/2020 17:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SYS_Posicion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idTemporada] [int] NOT NULL,
	[idCircuito] [int] NOT NULL,
	[idPiloto] [int] NOT NULL,
	[Posllegada] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SYS_Punto]    Script Date: 18/02/2020 17:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SYS_Punto](
	[int] [int] IDENTITY(1,1) NOT NULL,
	[ptsPosicion] [nchar](10) NOT NULL,
	[ptsCantidad] [nchar](10) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SYS_Temporada]    Script Date: 18/02/2020 17:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SYS_Temporada](
	[idTem] [int] IDENTITY(1,1) NOT NULL,
	[Temporada] [nchar](30) NOT NULL,
	[isActive] [bit] NULL,
 CONSTRAINT [PK_SYS_Temporada] PRIMARY KEY CLUSTERED 
(
	[idTem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[SYS_Circuito] ON 

INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (1, N'Estados Unidos                                                                                      ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (2, N'Mexico                                                                                              ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (3, N'Monaco                                                                                              ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (4, N'Austria                                                                                             ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (5, N'Abu Dhabi                                                                                           ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (6, N'Japon                                                                                               ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (7, N'Azerbaiyan                                                                                          ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (8, N'Belgica                                                                                             ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (9, N'China                                                                                               ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (10, N'Malasia                                                                                             ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (11, N'Alemania                                                                                            ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (12, N'Australia                                                                                           ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (13, N'Rusia                                                                                               ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (14, N'España                                                                                              ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (15, N'Singapur                                                                                            ')
SET IDENTITY_INSERT [dbo].[SYS_Circuito] OFF
INSERT [dbo].[SYS_Configuracion] ([PAR_Id], [PAR_Descripcion], [PAR_Type], [PAR_String], [PAR_Numeric]) VALUES (N'NCARRE    ', N'Numero de Carreras por Temporada', N'N', NULL, CAST(15.0000 AS Numeric(19, 4)))
INSERT [dbo].[SYS_Configuracion] ([PAR_Id], [PAR_Descripcion], [PAR_Type], [PAR_String], [PAR_Numeric]) VALUES (N'test      ', N'para prueba', N'S', N'aaaaaaayyyyyyyyyyyyyyy', NULL)
SET IDENTITY_INSERT [dbo].[SYS_Nacion] ON 

INSERT [dbo].[SYS_Nacion] ([id], [idNacion]) VALUES (1, N'Venezuela                                         ')
INSERT [dbo].[SYS_Nacion] ([id], [idNacion]) VALUES (2, N'Ucrania                                           ')
SET IDENTITY_INSERT [dbo].[SYS_Nacion] OFF
SET IDENTITY_INSERT [dbo].[SYS_Piloto] ON 

INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (1, N'Prueba2                                 ', 1)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (3, N'Jose                                    ', 2)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (4, N'Carmen                                  ', 1)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (5, N'Camila                                  ', 2)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (6, N'Jesus                                   ', 1)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (7, N'Juano Mikaro                            ', 2)
SET IDENTITY_INSERT [dbo].[SYS_Piloto] OFF
SET IDENTITY_INSERT [dbo].[SYS_Punto] ON 

INSERT [dbo].[SYS_Punto] ([int], [ptsPosicion], [ptsCantidad]) VALUES (3, N'1         ', N'25        ')
INSERT [dbo].[SYS_Punto] ([int], [ptsPosicion], [ptsCantidad]) VALUES (4, N'2         ', N'18        ')
INSERT [dbo].[SYS_Punto] ([int], [ptsPosicion], [ptsCantidad]) VALUES (5, N'3         ', N'15        ')
INSERT [dbo].[SYS_Punto] ([int], [ptsPosicion], [ptsCantidad]) VALUES (6, N'4         ', N'12        ')
INSERT [dbo].[SYS_Punto] ([int], [ptsPosicion], [ptsCantidad]) VALUES (7, N'5         ', N'10        ')
INSERT [dbo].[SYS_Punto] ([int], [ptsPosicion], [ptsCantidad]) VALUES (8, N'6         ', N'8         ')
INSERT [dbo].[SYS_Punto] ([int], [ptsPosicion], [ptsCantidad]) VALUES (10, N'7         ', N'6         ')
INSERT [dbo].[SYS_Punto] ([int], [ptsPosicion], [ptsCantidad]) VALUES (11, N'8         ', N'4         ')
INSERT [dbo].[SYS_Punto] ([int], [ptsPosicion], [ptsCantidad]) VALUES (12, N'9         ', N'2         ')
INSERT [dbo].[SYS_Punto] ([int], [ptsPosicion], [ptsCantidad]) VALUES (13, N'10        ', N'1         ')
SET IDENTITY_INSERT [dbo].[SYS_Punto] OFF
/****** Object:  StoredProcedure [dbo].[SYS_CorrelativoP]    Script Date: 18/02/2020 17:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_CorrelativoP]
@CorrelativoP int
as
	
SELECT @CorrelativoP = count(id) from SYS_Piloto

print @Correlativop


GO
/****** Object:  StoredProcedure [dbo].[SYS_DeleteCircuito]    Script Date: 18/02/2020 17:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_DeleteCircuito]
@id as int

AS

DELETE  from SYS_Circuito where id=@id

GO
/****** Object:  StoredProcedure [dbo].[SYS_DeleteNacion]    Script Date: 18/02/2020 17:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SYS_DeleteNacion]
	@id as int
AS

DELETE  from SYS_Nacion where id=@id
GO
/****** Object:  StoredProcedure [dbo].[SYS_DeletePiloto]    Script Date: 18/02/2020 17:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_DeletePiloto]
	
	@id as int
AS

    -- Insert statements for procedure here
DELETE  from SYS_Piloto where id=@id





GO
/****** Object:  StoredProcedure [dbo].[SYS_ExisteCircuito]    Script Date: 18/02/2020 17:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_ExisteCircuito]
	-- Add the parameters for the stored procedure here
	@id as int
AS

SELECT COUNT(*) FROM SYS_Circuito	  WHERE id = @id


GO
/****** Object:  StoredProcedure [dbo].[SYS_ExisteNacion]    Script Date: 18/02/2020 17:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_ExisteNacion]

@id as int

AS

SELECT COUNT(*) FROM SYS_Nacion	  WHERE id = @id
GO
/****** Object:  StoredProcedure [dbo].[SYS_ExistePiloto]    Script Date: 18/02/2020 17:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_ExistePiloto]
	-- Add the parameters for the stored procedure here
@id int
	
AS

SELECT COUNT(*) FROM SYS_Piloto  WHERE id = @id



GO
/****** Object:  StoredProcedure [dbo].[SYS_InsertCircuito]    Script Date: 18/02/2020 17:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SYS_InsertCircuito] 
	@nCircuito as nchar(100)
AS

insert SYS_Circuito(nCircuito) values (@nCircuito)
GO
/****** Object:  StoredProcedure [dbo].[SYS_InsertNacion]    Script Date: 18/02/2020 17:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SYS_InsertNacion]
	
	@idNacion as nchar(50)
AS
insert SYS_Nacion(idNacion) values (@idNacion)
GO
/****** Object:  StoredProcedure [dbo].[SYS_InsertPiloto]    Script Date: 18/02/2020 17:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_InsertPiloto]


@npiloto as nchar(40),
@idnacion as int

AS

Insert SYS_Piloto(nPiloto,idNacion) values (@nPiloto,@idNacion)
 



GO
/****** Object:  StoredProcedure [dbo].[SYS_ObtenerCircuitobyID]    Script Date: 18/02/2020 17:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_ObtenerCircuitobyID]
	@id as int
AS
select * from SYS_Circuito where id= @id
GO
/****** Object:  StoredProcedure [dbo].[SYS_ObtenerNacionbyID]    Script Date: 18/02/2020 17:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_ObtenerNacionbyID]
	@id as int
AS

    -- Insert statements for procedure here
	SELECT * from SYS_Nacion where id = @id

GO
/****** Object:  StoredProcedure [dbo].[SYS_ObtenerPilotobyID]    Script Date: 18/02/2020 17:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[SYS_SelectallCircuito]    Script Date: 18/02/2020 17:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_SelectallCircuito]
as	
	Select * from SYS_Circuito

GO
/****** Object:  StoredProcedure [dbo].[SYS_SelectallConfig]    Script Date: 18/02/2020 17:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SYS_SelectallConfig]
as 
	select * from sys_configuracion

GO
/****** Object:  StoredProcedure [dbo].[SYS_SelectallNaciones]    Script Date: 18/02/2020 17:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_SelectallNaciones]
	
AS
    
	SELECT * FROM SYS_Nacion




GO
/****** Object:  StoredProcedure [dbo].[SYS_SelectallPilotos]    Script Date: 18/02/2020 17:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SYS_SelectallPilotos]
	AS

 
	--SELECT * from SYS_Piloto
	
select SYS_Piloto.id, SYS_Piloto.nPiloto, SYS_Nacion.idNacion from SYS_Nacion

inner join SYS_Piloto on SYS_Nacion.id = SYS_Piloto.IdNacion 



GO
/****** Object:  StoredProcedure [dbo].[SYS_UpdateCircuito]    Script Date: 18/02/2020 17:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SYS_UpdateCircuito]

@id as int,
@nCircuito nchar(100)

AS

update SYS_Circuito
set nCircuito = @nCircuito
where ID= @id

GO
/****** Object:  StoredProcedure [dbo].[SYS_UpdateNacion]    Script Date: 18/02/2020 17:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SYS_UpdateNacion]
	@id as int,
	@idNacion as nchar(50)
AS

update SYS_Nacion
set idNacion = @idNacion
where id= @id

GO
/****** Object:  StoredProcedure [dbo].[SYS_UpdatePiloto]    Script Date: 18/02/2020 17:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE procedure [dbo].[SYS_UpdatePiloto]
(	
	@id int,
	@nPiloto varchar(30),
	@idNacion int
)
AS
	UPDATE SYS_Piloto
		SET nPiloto = @nPiloto, IdNacion=  @idNacion 
		WHERE id=@id



GO
