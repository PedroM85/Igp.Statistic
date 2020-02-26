USE [IgpManager]
GO
/****** Object:  Table [dbo].[SYS_Circuito]    Script Date: 26/02/2020 17:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SYS_Circuito](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[nCircuito] [nchar](100) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SYS_Configuracion]    Script Date: 26/02/2020 17:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SYS_Configuracion](
	[PAR_Id] [int] IDENTITY(1,1) NOT NULL,
	[PAR_Idv] [nchar](10) NOT NULL,
	[PAR_Descripcion] [varchar](100) NOT NULL,
	[PAR_Type] [char](1) NOT NULL,
	[PAR_String] [varchar](4096) NULL,
	[PAR_Numeric] [numeric](19, 4) NULL,
	[PAR_Cacheable] [bit] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SYS_Nacion]    Script Date: 26/02/2020 17:32:49 ******/
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
/****** Object:  Table [dbo].[SYS_Piloto]    Script Date: 26/02/2020 17:32:49 ******/
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
/****** Object:  Table [dbo].[SYS_Posicion]    Script Date: 26/02/2020 17:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SYS_Posicion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idTemporada] [nchar](30) NOT NULL,
	[idCircuito] [int] NOT NULL,
	[idPiloto] [nchar](40) NOT NULL,
	[Posllegada] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SYS_Punto]    Script Date: 26/02/2020 17:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SYS_Punto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ptsPosicion] [nchar](10) NOT NULL,
	[ptsCantidad] [nchar](10) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SYS_Temporada]    Script Date: 26/02/2020 17:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SYS_Temporada](
	[idTem] [int] IDENTITY(1,1) NOT NULL,
	[Temporada] [nchar](30) NOT NULL,
	[isActive] [bit] NULL CONSTRAINT [DF_SYS_Temporada_isActive]  DEFAULT ((0)),
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
SET IDENTITY_INSERT [dbo].[SYS_Configuracion] ON 

INSERT [dbo].[SYS_Configuracion] ([PAR_Id], [PAR_Idv], [PAR_Descripcion], [PAR_Type], [PAR_String], [PAR_Numeric], [PAR_Cacheable]) VALUES (1, N'NCARRERA  ', N'Numero de Carreras por Temporada', N'N', NULL, CAST(23.0000 AS Numeric(19, 4)), 1)
INSERT [dbo].[SYS_Configuracion] ([PAR_Id], [PAR_Idv], [PAR_Descripcion], [PAR_Type], [PAR_String], [PAR_Numeric], [PAR_Cacheable]) VALUES (2, N'NPILOTO   ', N'Numero de Pilotos por temporadas', N'N', NULL, CAST(33.0000 AS Numeric(19, 4)), 1)
SET IDENTITY_INSERT [dbo].[SYS_Configuracion] OFF
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
SET IDENTITY_INSERT [dbo].[SYS_Posicion] ON 

INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada]) VALUES (1, N'29                            ', 4, N'7                                       ', 1)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada]) VALUES (4, N'29                            ', 4, N'1                                       ', 2)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada]) VALUES (5, N'29                            ', 4, N'5                                       ', 3)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada]) VALUES (6, N'29                            ', 4, N'3                                       ', 4)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada]) VALUES (8, N'28                            ', 4, N'4                                       ', 6)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada]) VALUES (10, N'29                            ', 1, N'2                                       ', 11)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada]) VALUES (11, N'29                            ', 1, N'3                                       ', 12)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada]) VALUES (13, N'29                            ', 1, N'1                                       ', 12)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada]) VALUES (16, N'29                            ', 14, N'1                                       ', 1)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada]) VALUES (17, N'29                            ', 14, N'3                                       ', 3)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada]) VALUES (18, N'29                            ', 14, N'4                                       ', 4)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada]) VALUES (19, N'29                            ', 14, N'5                                       ', 5)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada]) VALUES (20, N'29                            ', 14, N'6                                       ', 6)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada]) VALUES (21, N'29                            ', 14, N'7                                       ', 7)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada]) VALUES (22, N'29                            ', 15, N'1                                       ', 1)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada]) VALUES (23, N'29                            ', 15, N'3                                       ', 3)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada]) VALUES (24, N'29                            ', 15, N'4                                       ', 5)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada]) VALUES (25, N'29                            ', 15, N'5                                       ', 6)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada]) VALUES (26, N'29                            ', 15, N'6                                       ', 8)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada]) VALUES (27, N'29                            ', 15, N'7                                       ', 2)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada]) VALUES (28, N'29                            ', 8, N'7                                       ', 1)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada]) VALUES (14, N'29                            ', 8, N'7                                       ', 9)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada]) VALUES (29, N'29                            ', 15, N'7                                       ', 6)
SET IDENTITY_INSERT [dbo].[SYS_Posicion] OFF
SET IDENTITY_INSERT [dbo].[SYS_Punto] ON 

INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (3, N'1         ', N'25        ')
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (4, N'2         ', N'18        ')
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (5, N'3         ', N'15        ')
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (6, N'4         ', N'12        ')
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (7, N'5         ', N'10        ')
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (8, N'6         ', N'8         ')
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (10, N'7         ', N'6         ')
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (11, N'8         ', N'4         ')
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (12, N'9         ', N'2         ')
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (13, N'10        ', N'1         ')
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (14, N'11        ', N'0         ')
SET IDENTITY_INSERT [dbo].[SYS_Punto] OFF
SET IDENTITY_INSERT [dbo].[SYS_Temporada] ON 

INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (1, N'Temporada 1                   ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (2, N'Temporada 2                   ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (3, N'Temporada 3                   ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (4, N'Temporada 4                   ', 0)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (5, N'Temporada 5                   ', 0)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (6, N'Temporada 6                   ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (7, N'Temporada 7                   ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (8, N'Temporada 8                   ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (9, N'Temporada 9                   ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (10, N'Temporada 10                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (11, N'Temporada 11                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (12, N'Temporada 12                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (13, N'Temporada 13                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (14, N'Temporada 14                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (15, N'Temporada 15                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (16, N'Temporada 16                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (17, N'Temporada 17                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (18, N'Temporada 18                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (19, N'Temporada 19                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (20, N'Temporada 20                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (21, N'Temporada 21                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (22, N'Temporada 22                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (23, N'Temporada 23                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (24, N'Temporada 24                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (25, N'Temporada 25                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (26, N'Temporada 26                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (27, N'Temporada 27                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (28, N'Temporada 28                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (29, N'Temporada 29                  ', 1)
SET IDENTITY_INSERT [dbo].[SYS_Temporada] OFF
/****** Object:  StoredProcedure [dbo].[ADD_InsertPosicion]    Script Date: 26/02/2020 17:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ADD_InsertPosicion]
	@idTemporada as nchar(30),
	@idCircuito as int,
	@idPiloto as nchar(40),
	@idllegada as int
AS
insert SYS_Posicion (idTemporada,idCircuito,idPiloto,Posllegada)

values (@idtemporada,@idCircuito,@idPiloto,@idllegada)
GO
/****** Object:  StoredProcedure [dbo].[CON_GetParameters]    Script Date: 26/02/2020 17:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[CON_Verisactive]    Script Date: 26/02/2020 17:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CON_Verisactive] 
	
AS

declare @totalrecs int
 select @totalrecs =  count(isactive) from SYS_Temporada where isactive = '1'
GO
/****** Object:  StoredProcedure [dbo].[REP_CampeonatobyTemp]    Script Date: 26/02/2020 17:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[REP_CampeonatobyTemp]
@id as nchar(30)

AS


select SYS_Temporada.Temporada, sys_piloto.npiloto, sys_Circuito.nCircuito, SYS_Posicion.Posllegada, SYS_Punto.ptsCantidad from SYS_Posicion 

inner join SYS_Circuito on SYS_Posicion.idCircuito = sys_circuito.id
inner join sys_Piloto on sys_posicion.idPiloto = SYS_Piloto.id
inner join SYS_Temporada on sys_posicion.idTemporada = SYS_Temporada.idtem
inner join SYS_Punto on SYS_Posicion.posllegada = SYS_PUNTO.ptsPosicion

where sys_temporada.temporada = @id

GO
/****** Object:  StoredProcedure [dbo].[SYS_CorrelativoP]    Script Date: 26/02/2020 17:32:50 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_DeleteCircuito]    Script Date: 26/02/2020 17:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_DeleteCircuito]
@id as int

AS

DELETE  from SYS_Circuito where id=@id

GO
/****** Object:  StoredProcedure [dbo].[SYS_DeleteNacion]    Script Date: 26/02/2020 17:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SYS_DeleteNacion]
	@id as int
AS

DELETE  from SYS_Nacion where id=@id
GO
/****** Object:  StoredProcedure [dbo].[SYS_DeletePiloto]    Script Date: 26/02/2020 17:32:50 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_DeleteTempo]    Script Date: 26/02/2020 17:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SYS_DeleteTempo] 
@id as int
AS

delete from SYS_Temporada where idtem=@id
GO
/****** Object:  StoredProcedure [dbo].[SYS_ExisteCircuito]    Script Date: 26/02/2020 17:32:50 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_ExisteConfig]    Script Date: 26/02/2020 17:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_ExisteConfig]
	@id as int
	

AS
SELECT COUNT(*) FROM SYS_Configuracion	  WHERE PAR_Id = @id



GO
/****** Object:  StoredProcedure [dbo].[SYS_ExisteinPosicion]    Script Date: 26/02/2020 17:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_ExisteinPosicion] 
	@idTemporada as nchar(30),
	@idCircuito as int,
	@idpiloto as nchar(40)
AS
--select count (*) idTemporada,idCircuito,idPiloto,posllegada from sys_posicion where idcircuito = 1 and idpiloto = 1 and idTemporada = 29
--group by idTemporada,idCircuito,idPiloto,posllegada

--if exists(select * from sys_posicion where idpiloto = @idpiloto and idcircuito = @idCircuito and idTemporada = @idTemporada)
--begin
--print('a la verga')
--return
--end

if (select count(idcircuito) from sys_posicion where idpiloto = 7 and idcircuito = 4 and idtemporada = 29 )>0
     Select 1 [Exists]
else
        Select 0 [Exists]

GO
/****** Object:  StoredProcedure [dbo].[SYS_ExisteNacion]    Script Date: 26/02/2020 17:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_ExisteNacion]

@id as int

AS

SELECT COUNT(*) FROM SYS_Nacion	  WHERE id = @id
GO
/****** Object:  StoredProcedure [dbo].[SYS_ExistePiloto]    Script Date: 26/02/2020 17:32:50 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_ExisteTempo]    Script Date: 26/02/2020 17:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SYS_ExisteTempo]
	@id as int
AS

SELECT COUNT(*) FROM sys_temporada	  WHERE idtem = @id
GO
/****** Object:  StoredProcedure [dbo].[SYS_InsertCircuito]    Script Date: 26/02/2020 17:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SYS_InsertCircuito] 
	@nCircuito as nchar(100)
AS

insert SYS_Circuito(nCircuito) values (@nCircuito)
GO
/****** Object:  StoredProcedure [dbo].[SYS_InsertNacion]    Script Date: 26/02/2020 17:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SYS_InsertNacion]
	
	@idNacion as nchar(50)
AS
insert SYS_Nacion(idNacion) values (@idNacion)
GO
/****** Object:  StoredProcedure [dbo].[SYS_InsertPiloto]    Script Date: 26/02/2020 17:32:50 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_InsertTempo]    Script Date: 26/02/2020 17:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SYS_InsertTempo]

@Tempo as nchar(30),
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

insert sys_temporada (Temporada,isactive) values(@tempo,@isactive)

GO
/****** Object:  StoredProcedure [dbo].[SYS_ObtenerCircuitobyID]    Script Date: 26/02/2020 17:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_ObtenerCircuitobyID]
	@id as int
AS
select * from SYS_Circuito where id= @id
GO
/****** Object:  StoredProcedure [dbo].[SYS_ObtenerConfigbyID]    Script Date: 26/02/2020 17:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SYS_ObtenerConfigbyID]
	@id as int
AS
select * from SYS_Configuracion where PAR_id=@id

GO
/****** Object:  StoredProcedure [dbo].[SYS_ObtenerNacionbyID]    Script Date: 26/02/2020 17:32:50 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_ObtenerPilotobyID]    Script Date: 26/02/2020 17:32:50 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_ObtenerTempobyID]    Script Date: 26/02/2020 17:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[SYS_SelectallCircuito]    Script Date: 26/02/2020 17:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_SelectallCircuito]
as	
	Select * from SYS_Circuito

GO
/****** Object:  StoredProcedure [dbo].[SYS_SelectallConfig]    Script Date: 26/02/2020 17:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SYS_SelectallConfig]
as 
	select * from sys_configuracion

GO
/****** Object:  StoredProcedure [dbo].[SYS_SelectallNaciones]    Script Date: 26/02/2020 17:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_SelectallNaciones]
	
AS
    
	SELECT * FROM SYS_Nacion




GO
/****** Object:  StoredProcedure [dbo].[SYS_SelectallPilotos]    Script Date: 26/02/2020 17:32:50 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_SelectallTempo]    Script Date: 26/02/2020 17:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[SYS_SelectaTempoactive]    Script Date: 26/02/2020 17:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_SelectaTempoactive]
--@id as int

AS
select idtem, temporada,isactive= case isnull(isactive ,0) when 1 then 1 else 0 end 
from sys_temporada 
where isactive = '1'
GO
/****** Object:  StoredProcedure [dbo].[SYS_UpdateCircuito]    Script Date: 26/02/2020 17:32:50 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_UpdateConfig]    Script Date: 26/02/2020 17:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[SYS_UpdateNacion]    Script Date: 26/02/2020 17:32:50 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_UpdatePiloto]    Script Date: 26/02/2020 17:32:50 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_UpdateTempo]    Script Date: 26/02/2020 17:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
