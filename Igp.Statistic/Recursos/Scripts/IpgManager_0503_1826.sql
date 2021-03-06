USE [master]
GO
/****** Object:  Database [IgpManager]    Script Date: 05/03/2020 18:26:58 ******/
CREATE DATABASE [IgpManager]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'IgpManager', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\IgpManager.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'IgpManager_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\IgpManager_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [IgpManager] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [IgpManager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [IgpManager] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [IgpManager] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [IgpManager] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [IgpManager] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [IgpManager] SET ARITHABORT OFF 
GO
ALTER DATABASE [IgpManager] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [IgpManager] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [IgpManager] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [IgpManager] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [IgpManager] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [IgpManager] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [IgpManager] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [IgpManager] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [IgpManager] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [IgpManager] SET  ENABLE_BROKER 
GO
ALTER DATABASE [IgpManager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [IgpManager] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [IgpManager] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [IgpManager] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [IgpManager] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [IgpManager] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [IgpManager] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [IgpManager] SET RECOVERY FULL 
GO
ALTER DATABASE [IgpManager] SET  MULTI_USER 
GO
ALTER DATABASE [IgpManager] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [IgpManager] SET DB_CHAINING OFF 
GO
ALTER DATABASE [IgpManager] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [IgpManager] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [IgpManager] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'IgpManager', N'ON'
GO
USE [IgpManager]
GO
/****** Object:  Table [dbo].[SYS_Circuito]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SYS_Circuito](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[nCircuito] [nchar](100) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SYS_Configuracion]    Script Date: 05/03/2020 18:26:58 ******/
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
/****** Object:  Table [dbo].[SYS_Nacion]    Script Date: 05/03/2020 18:26:58 ******/
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
/****** Object:  Table [dbo].[SYS_Piloto]    Script Date: 05/03/2020 18:26:58 ******/
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
/****** Object:  Table [dbo].[SYS_Posicion]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SYS_Posicion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idTemporada] [nchar](30) NOT NULL,
	[idCircuito] [int] NOT NULL,
	[idPiloto] [nchar](40) NOT NULL,
	[Posllegada] [int] NOT NULL,
	[Ptsllegada] [int] NOT NULL,
	[InsertedFecha] [datetime] NOT NULL CONSTRAINT [DF__SYS_Posic__Inser__33D4B598]  DEFAULT (getdate()),
	[ModifyFecha] [datetime] NULL CONSTRAINT [DF__SYS_Posic__Modif__34C8D9D1]  DEFAULT (getdate())
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SYS_Punto]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SYS_Punto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ptsPosicion] [nchar](10) NOT NULL,
	[ptsCantidad] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SYS_Temporada]    Script Date: 05/03/2020 18:26:58 ******/
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
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (18, N'Hungria                                                                                             ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (19, N'Gran Bretaña 19                                                                                     ')
SET IDENTITY_INSERT [dbo].[SYS_Circuito] OFF
SET IDENTITY_INSERT [dbo].[SYS_Configuracion] ON 

INSERT [dbo].[SYS_Configuracion] ([PAR_Id], [PAR_Idv], [PAR_Descripcion], [PAR_Type], [PAR_String], [PAR_Numeric], [PAR_Cacheable]) VALUES (1, N'NCARRERA  ', N'Numero de Carreras por Temporada', N'N', NULL, CAST(23.0000 AS Numeric(19, 4)), 1)
INSERT [dbo].[SYS_Configuracion] ([PAR_Id], [PAR_Idv], [PAR_Descripcion], [PAR_Type], [PAR_String], [PAR_Numeric], [PAR_Cacheable]) VALUES (2, N'NPILOTO   ', N'Numero de Pilotos por temporadas', N'N', NULL, CAST(32.0000 AS Numeric(19, 4)), 1)
SET IDENTITY_INSERT [dbo].[SYS_Configuracion] OFF
SET IDENTITY_INSERT [dbo].[SYS_Nacion] ON 

INSERT [dbo].[SYS_Nacion] ([id], [idNacion]) VALUES (1, N'Venezuela                                         ')
INSERT [dbo].[SYS_Nacion] ([id], [idNacion]) VALUES (2, N'Ucrania                                           ')
INSERT [dbo].[SYS_Nacion] ([id], [idNacion]) VALUES (5, N'Argentina                                         ')
INSERT [dbo].[SYS_Nacion] ([id], [idNacion]) VALUES (6, N'Uruguay                                           ')
INSERT [dbo].[SYS_Nacion] ([id], [idNacion]) VALUES (7, N'Alemania                                          ')
INSERT [dbo].[SYS_Nacion] ([id], [idNacion]) VALUES (8, N'Suecia                                            ')
INSERT [dbo].[SYS_Nacion] ([id], [idNacion]) VALUES (9, N'Mexico                                            ')
INSERT [dbo].[SYS_Nacion] ([id], [idNacion]) VALUES (10, N'España                                            ')
INSERT [dbo].[SYS_Nacion] ([id], [idNacion]) VALUES (11, N'Chile                                             ')
INSERT [dbo].[SYS_Nacion] ([id], [idNacion]) VALUES (12, N'Colombia                                          ')
INSERT [dbo].[SYS_Nacion] ([id], [idNacion]) VALUES (13, N'Singapure                                         ')
INSERT [dbo].[SYS_Nacion] ([id], [idNacion]) VALUES (14, N'United States                                     ')
SET IDENTITY_INSERT [dbo].[SYS_Nacion] OFF
SET IDENTITY_INSERT [dbo].[SYS_Piloto] ON 

INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (1, N'Erick Acosta                            ', 14)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (3, N'Ismael Fajardo                          ', 6)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (4, N'Yair Alonso Duran                       ', 12)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (5, N'Agustin Cuesta                          ', 5)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (6, N'Yosman Zerpa                            ', 1)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (7, N'Juano Mikaro                            ', 8)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (8, N'Pedro Maneiro                           ', 13)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (9, N'Ruben Gonzalez                          ', 9)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (10, N'Ayrton Lopez                            ', 8)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (12, N'Zadquiel Caballero                      ', 1)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (13, N'Marco Suarez                            ', 9)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (14, N'Emilio Peralta                          ', 5)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (15, N'Sergio Catalusci                        ', 5)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (16, N'Lucas Frassi                            ', 2)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (17, N'Mario Perez                             ', 9)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (18, N'Cristian Ariel Fernandez                ', 2)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (19, N'Daniel Maldonado                        ', 1)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (20, N'Santiago Viotti                         ', 6)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (21, N'Daniel Garay                            ', 11)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (22, N'Franco Insaurralde                      ', 14)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (23, N'Jesus Allones                           ', 10)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (24, N'Patricio Quesada                        ', 5)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (25, N'Cesar Caparros                          ', 12)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (26, N'Rafael Lopez                            ', 9)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (27, N'Fco Muñoz                               ', 9)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (28, N'Jesus Lopez                             ', 10)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (29, N'Thomas Rincon                           ', 8)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (30, N'Olger Martin                            ', 2)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (31, N'Pablo Delgado                           ', 5)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (32, N'Jose Caparroso                          ', 12)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (33, N'Mario Fernandez                         ', 12)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (34, N'Patricio Invitto                        ', 13)
SET IDENTITY_INSERT [dbo].[SYS_Piloto] OFF
SET IDENTITY_INSERT [dbo].[SYS_Posicion] ON 

INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (50, N'29                            ', 1, N'7                                       ', 1, 25, CAST(N'2020-02-28 11:41:47.800' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (53, N'29                            ', 1, N'6                                       ', 3, 15, CAST(N'2020-02-29 02:23:27.227' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (54, N'29                            ', 1, N'5                                       ', 4, 12, CAST(N'2020-02-29 02:23:28.683' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (55, N'29                            ', 1, N'4                                       ', 5, 10, CAST(N'2020-02-29 02:23:29.290' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (56, N'29                            ', 1, N'3                                       ', 6, 8, CAST(N'2020-02-29 02:23:29.717' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (81, N'30                            ', 18, N'1                                       ', 1, 25, CAST(N'2020-03-03 18:36:10.260' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (58, N'29                            ', 1, N'8                                       ', 2, 18, CAST(N'2020-03-02 13:57:45.250' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (113, N'30                            ', 15, N'19                                      ', 1, 25, CAST(N'2020-03-04 15:08:47.090' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (114, N'30                            ', 15, N'29                                      ', 2, 18, CAST(N'2020-03-04 15:08:47.093' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (79, N'29                            ', 1, N'9                                       ', 14, 0, CAST(N'2020-03-03 13:26:00.060' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (115, N'30                            ', 15, N'6                                       ', 3, 15, CAST(N'2020-03-04 15:08:47.097' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (116, N'30                            ', 15, N'1                                       ', 4, 12, CAST(N'2020-03-04 15:08:47.097' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (117, N'30                            ', 15, N'7                                       ', 5, 10, CAST(N'2020-03-04 15:08:47.100' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (118, N'30                            ', 15, N'10                                      ', 6, 8, CAST(N'2020-03-04 15:08:47.100' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (119, N'30                            ', 15, N'21                                      ', 7, 6, CAST(N'2020-03-04 15:08:47.103' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (120, N'30                            ', 15, N'13                                      ', 8, 4, CAST(N'2020-03-04 15:08:47.103' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (121, N'30                            ', 15, N'16                                      ', 9, 2, CAST(N'2020-03-04 15:08:47.107' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (122, N'30                            ', 15, N'4                                       ', 10, 1, CAST(N'2020-03-04 15:08:47.107' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (123, N'30                            ', 15, N'3                                       ', 11, 0, CAST(N'2020-03-04 15:08:47.107' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (124, N'30                            ', 15, N'14                                      ', 12, 0, CAST(N'2020-03-04 15:08:47.110' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (125, N'30                            ', 15, N'15                                      ', 13, 0, CAST(N'2020-03-04 15:08:47.110' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (126, N'30                            ', 15, N'12                                      ', 14, 0, CAST(N'2020-03-04 15:08:47.110' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (127, N'30                            ', 15, N'5                                       ', 15, 0, CAST(N'2020-03-04 15:08:47.113' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (128, N'30                            ', 15, N'20                                      ', 16, 0, CAST(N'2020-03-04 15:08:47.113' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (129, N'30                            ', 15, N'17                                      ', 17, 0, CAST(N'2020-03-04 15:08:47.117' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (130, N'30                            ', 15, N'30                                      ', 18, 0, CAST(N'2020-03-04 15:08:47.117' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (131, N'30                            ', 15, N'8                                       ', 19, 0, CAST(N'2020-03-04 15:08:47.117' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (132, N'30                            ', 15, N'34                                      ', 20, 0, CAST(N'2020-03-04 15:08:47.120' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (133, N'30                            ', 15, N'27                                      ', 21, 0, CAST(N'2020-03-04 15:08:47.120' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (134, N'30                            ', 15, N'26                                      ', 22, 0, CAST(N'2020-03-04 15:08:47.120' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (135, N'30                            ', 15, N'22                                      ', 23, 0, CAST(N'2020-03-04 15:08:47.123' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (136, N'30                            ', 15, N'24                                      ', 25, 0, CAST(N'2020-03-04 15:08:47.123' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (137, N'30                            ', 15, N'23                                      ', 26, 0, CAST(N'2020-03-04 15:08:47.127' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (138, N'30                            ', 15, N'9                                       ', 27, 0, CAST(N'2020-03-04 15:08:47.127' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (139, N'30                            ', 15, N'18                                      ', 28, 0, CAST(N'2020-03-04 15:08:47.127' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (140, N'30                            ', 15, N'31                                      ', 29, 0, CAST(N'2020-03-04 15:08:47.130' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (141, N'30                            ', 15, N'32                                      ', 30, 0, CAST(N'2020-03-04 15:08:47.130' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (142, N'30                            ', 15, N'33                                      ', 31, 0, CAST(N'2020-03-04 15:08:47.130' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (143, N'30                            ', 15, N'25                                      ', 32, 0, CAST(N'2020-03-04 15:08:47.133' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (144, N'30                            ', 15, N'28                                      ', 24, 0, CAST(N'2020-03-04 15:09:52.200' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (145, N'30                            ', 19, N'10                                      ', 1, 25, CAST(N'2020-03-05 11:19:53.917' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (146, N'30                            ', 19, N'7                                       ', 2, 18, CAST(N'2020-03-05 11:19:53.917' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (147, N'30                            ', 19, N'29                                      ', 3, 15, CAST(N'2020-03-05 11:19:53.920' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (82, N'30                            ', 18, N'3                                       ', 2, 18, CAST(N'2020-03-03 18:36:10.263' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (148, N'30                            ', 19, N'3                                       ', 4, 12, CAST(N'2020-03-05 11:19:53.920' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (149, N'30                            ', 19, N'6                                       ', 5, 10, CAST(N'2020-03-05 11:19:53.923' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (150, N'30                            ', 19, N'1                                       ', 6, 8, CAST(N'2020-03-05 11:19:53.923' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (151, N'30                            ', 19, N'12                                      ', 7, 6, CAST(N'2020-03-05 11:19:53.927' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (152, N'30                            ', 19, N'4                                       ', 8, 4, CAST(N'2020-03-05 11:19:53.927' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (153, N'30                            ', 19, N'15                                      ', 9, 2, CAST(N'2020-03-05 11:19:53.927' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (154, N'30                            ', 19, N'13                                      ', 10, 1, CAST(N'2020-03-05 11:19:53.930' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (155, N'30                            ', 19, N'19                                      ', 11, 0, CAST(N'2020-03-05 11:19:53.930' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (156, N'30                            ', 19, N'5                                       ', 12, 0, CAST(N'2020-03-05 11:19:53.930' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (157, N'30                            ', 19, N'30                                      ', 13, 0, CAST(N'2020-03-05 11:19:53.933' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (158, N'30                            ', 19, N'20                                      ', 14, 0, CAST(N'2020-03-05 11:19:53.933' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (159, N'30                            ', 19, N'17                                      ', 15, 0, CAST(N'2020-03-05 11:19:53.933' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (160, N'30                            ', 19, N'34                                      ', 16, 0, CAST(N'2020-03-05 11:19:53.937' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (161, N'30                            ', 19, N'23                                      ', 17, 0, CAST(N'2020-03-05 11:19:53.937' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (162, N'30                            ', 19, N'21                                      ', 18, 0, CAST(N'2020-03-05 11:19:53.940' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (163, N'30                            ', 19, N'14                                      ', 19, 0, CAST(N'2020-03-05 11:19:53.940' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (164, N'30                            ', 19, N'8                                       ', 20, 0, CAST(N'2020-03-05 11:19:53.940' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (165, N'30                            ', 19, N'27                                      ', 21, 0, CAST(N'2020-03-05 11:19:53.943' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (166, N'30                            ', 19, N'26                                      ', 22, 0, CAST(N'2020-03-05 11:19:53.943' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (167, N'30                            ', 19, N'25                                      ', 23, 0, CAST(N'2020-03-05 11:19:53.947' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (168, N'30                            ', 19, N'9                                       ', 24, 0, CAST(N'2020-03-05 11:19:53.947' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (169, N'30                            ', 19, N'31                                      ', 25, 0, CAST(N'2020-03-05 11:19:53.950' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (170, N'30                            ', 19, N'16                                      ', 26, 0, CAST(N'2020-03-05 11:19:53.950' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (171, N'30                            ', 19, N'22                                      ', 27, 0, CAST(N'2020-03-05 11:19:53.950' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (172, N'30                            ', 19, N'18                                      ', 28, 0, CAST(N'2020-03-05 11:19:53.953' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (173, N'30                            ', 19, N'28                                      ', 29, 0, CAST(N'2020-03-05 11:19:53.953' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (174, N'30                            ', 19, N'24                                      ', 30, 0, CAST(N'2020-03-05 11:19:53.953' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (175, N'30                            ', 19, N'32                                      ', 31, 0, CAST(N'2020-03-05 11:19:53.957' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (176, N'30                            ', 19, N'33                                      ', 32, 0, CAST(N'2020-03-05 11:19:53.957' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (72, N'29                            ', 1, N'1                                       ', 9, 2, CAST(N'2020-03-02 17:06:06.143' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (83, N'30                            ', 18, N'7                                       ', 3, 15, CAST(N'2020-03-03 18:36:10.267' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (84, N'30                            ', 18, N'4                                       ', 4, 12, CAST(N'2020-03-03 18:36:10.267' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (85, N'30                            ', 18, N'5                                       ', 5, 10, CAST(N'2020-03-03 18:36:10.267' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (86, N'30                            ', 18, N'6                                       ', 6, 8, CAST(N'2020-03-03 18:36:10.270' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (87, N'30                            ', 18, N'10                                      ', 7, 6, CAST(N'2020-03-03 18:36:10.270' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (88, N'30                            ', 18, N'8                                       ', 8, 4, CAST(N'2020-03-03 18:36:10.270' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (89, N'30                            ', 18, N'12                                      ', 9, 2, CAST(N'2020-03-03 18:36:10.270' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (90, N'30                            ', 18, N'13                                      ', 10, 1, CAST(N'2020-03-03 18:36:10.273' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (91, N'30                            ', 18, N'14                                      ', 11, 0, CAST(N'2020-03-03 18:36:10.273' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (92, N'30                            ', 18, N'15                                      ', 12, 0, CAST(N'2020-03-03 18:36:10.273' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (93, N'30                            ', 18, N'16                                      ', 13, 0, CAST(N'2020-03-03 18:36:10.277' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (94, N'30                            ', 18, N'17                                      ', 14, 0, CAST(N'2020-03-03 18:36:10.277' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (95, N'30                            ', 18, N'18                                      ', 15, 0, CAST(N'2020-03-03 18:36:10.277' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (96, N'30                            ', 18, N'19                                      ', 16, 0, CAST(N'2020-03-03 18:36:10.280' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (97, N'30                            ', 18, N'20                                      ', 17, 0, CAST(N'2020-03-03 18:36:10.280' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (98, N'30                            ', 18, N'21                                      ', 18, 0, CAST(N'2020-03-03 18:36:10.280' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (99, N'30                            ', 18, N'22                                      ', 19, 0, CAST(N'2020-03-03 18:36:10.280' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (100, N'30                            ', 18, N'23                                      ', 20, 0, CAST(N'2020-03-03 18:36:10.283' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (101, N'30                            ', 18, N'24                                      ', 21, 0, CAST(N'2020-03-03 18:36:10.283' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (102, N'30                            ', 18, N'25                                      ', 22, 0, CAST(N'2020-03-03 18:36:10.283' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (103, N'30                            ', 18, N'26                                      ', 23, 0, CAST(N'2020-03-03 18:36:10.287' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (104, N'30                            ', 18, N'27                                      ', 24, 0, CAST(N'2020-03-03 18:36:10.287' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (105, N'30                            ', 18, N'9                                       ', 25, 0, CAST(N'2020-03-03 18:36:10.287' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (106, N'30                            ', 18, N'28                                      ', 26, 0, CAST(N'2020-03-03 18:36:10.290' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (107, N'30                            ', 18, N'29                                      ', 27, 0, CAST(N'2020-03-03 18:36:10.290' AS DateTime), NULL)
GO
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (108, N'30                            ', 18, N'30                                      ', 28, 0, CAST(N'2020-03-03 18:36:10.290' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (109, N'30                            ', 18, N'31                                      ', 29, 0, CAST(N'2020-03-03 18:36:10.293' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (110, N'30                            ', 18, N'32                                      ', 30, 0, CAST(N'2020-03-03 18:36:10.293' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (111, N'30                            ', 18, N'33                                      ', 31, 0, CAST(N'2020-03-03 18:36:10.293' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (112, N'30                            ', 18, N'34                                      ', 32, 0, CAST(N'2020-03-03 18:36:10.293' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[SYS_Posicion] OFF
SET IDENTITY_INSERT [dbo].[SYS_Punto] ON 

INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (3, N'1         ', 25)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (4, N'2         ', 18)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (5, N'3         ', 15)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (6, N'4         ', 12)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (7, N'5         ', 10)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (8, N'6         ', 8)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (10, N'7         ', 6)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (11, N'8         ', 4)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (12, N'9         ', 2)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (13, N'10        ', 1)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (14, N'11        ', 0)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (16, N'12        ', 0)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (17, N'13        ', 0)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (18, N'14        ', 0)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (20, N'15        ', 0)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (21, N'16        ', 0)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (22, N'17        ', 0)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (23, N'18        ', 0)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (24, N'19        ', 0)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (25, N'20        ', 0)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (26, N'21        ', 0)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (28, N'22        ', 0)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (29, N'23        ', 0)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (30, N'24        ', 0)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (31, N'25        ', 0)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (32, N'26        ', 0)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (33, N'27        ', 0)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (34, N'28        ', 0)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (35, N'29        ', 0)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (36, N'30        ', 0)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (37, N'31        ', 0)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (38, N'32        ', 0)
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (40, N'33        ', 0)
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
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (28, N'Temporada 28                  ', 0)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (29, N'Temporada 29                  ', 1)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (30, N'Temporada 30                  ', 1)
SET IDENTITY_INSERT [dbo].[SYS_Temporada] OFF
/****** Object:  StoredProcedure [dbo].[ADD_InsertPosicion]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ADD_InsertPosicion]
	@idTemporada  int,
	@idCircuito  int,
	@idPiloto  int,
	@idllegada  int,
	@Pllegada  int
AS


insert into SYS_Posicion 

(idTemporada,idCircuito,idPiloto,Posllegada,Ptsllegada,InsertedFecha,ModifyFecha)

values 

(@idtemporada,@idCircuito,@idPiloto,@idllegada,@Pllegada,GETDATE(),NULL)



GO
/****** Object:  StoredProcedure [dbo].[ADD_UpdatePosicion]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ADD_UpdatePosicion]

	@id as int,
	@idTemporada as nchar(30),
	@idCircuito as int,
	@idPiloto as nchar(40),
	@Posllegada as int
	
AS

begin
Declare @ModifyFecha as datetime

Set @ModifyFecha=GETDATE()
Select CONVERT(varchar,@ModifyFecha,21)



UPDATE SYS_Posicion
SET idTemporada = @idTemporada, idCircuito = @idCircuito, idPiloto = @idPiloto, Posllegada = @Posllegada, ModifyFecha=@ModifyFecha
where ID= @id

end

GO
/****** Object:  StoredProcedure [dbo].[CON_GetParameters]    Script Date: 05/03/2020 18:26:58 ******/
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
/****** Object:  StoredProcedure [dbo].[CON_Verisactive]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CON_Verisactive] 
	
AS

declare @totalrecs int
 select @totalrecs =  count(isactive) from SYS_Temporada where isactive = '1'

GO
/****** Object:  StoredProcedure [dbo].[REP_CampeobyTempoCircui]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[REP_CampeobyTempoCircui]
	@idTemporada nchar(40),
	@idCircuito nchar(30)
AS
select sys_posicion.id,SYS_Temporada.Temporada, sys_piloto.npiloto, sys_Circuito.nCircuito, SYS_Posicion.Posllegada, SYS_Punto.ptsCantidad from SYS_Posicion 

inner join SYS_Circuito on SYS_Posicion.idCircuito = sys_circuito.id
inner join sys_Piloto on sys_posicion.idPiloto = SYS_Piloto.id
inner join SYS_Temporada on sys_posicion.idTemporada = SYS_Temporada.idtem
inner join SYS_Punto on SYS_Posicion.posllegada = SYS_PUNTO.ptsPosicion

where sys_temporada.temporada = @idTemporada and sys_Circuito.nCircuito = @idCircuito

GO
/****** Object:  StoredProcedure [dbo].[REP_CampeobyTempoPiloto]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[REP_CampeobyTempoPiloto]
	@idTemporada nchar(40)
	
AS
select 
sys_piloto.npiloto,

 sum(SYS_Posicion.Ptsllegada) as Totales
  
 from SYS_Posicion with (nolock)

 inner join sys_Piloto on sys_posicion.idPiloto = SYS_Piloto.id

  where   SYS_Posicion.idTemporada = '30' 

 group by 

 sys_piloto.npiloto

 order by Totales desc
GO
/****** Object:  StoredProcedure [dbo].[REP_CampeobyTempoTOP3]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[REP_CampeobyTempoTOP3]
	@idTemporada nchar(40)
	
AS
select top(3)
sys_piloto.npiloto,

 sum(SYS_Posicion.Ptsllegada) as Totales
  
 from SYS_Posicion with (nolock)

 inner join sys_Piloto on sys_posicion.idPiloto = SYS_Piloto.id

  where   SYS_Posicion.idTemporada = '30' 

 group by 
 sys_piloto.npiloto

 order by Totales desc
GO
/****** Object:  StoredProcedure [dbo].[REP_CampeonatobyTemp]    Script Date: 05/03/2020 18:26:58 ******/
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
/****** Object:  StoredProcedure [dbo].[REP_PilotobyEquipo]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[REP_PilotobyEquipo] (
	@idEquipo as int
	)
AS
select sys_piloto.id,sys_piloto.nPiloto,sys_nacion.idNacion from SYS_Piloto 

inner join SYS_Nacion on SYS_Piloto.IdNacion = SYS_Nacion.id

where SYS_Nacion.idNacion = @idEquipo


GO
/****** Object:  StoredProcedure [dbo].[SYS_CorrelativoP]    Script Date: 05/03/2020 18:26:58 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_DeleteCircuito]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_DeleteCircuito]
@id as int

AS

DELETE  from SYS_Circuito where id=@id

GO
/****** Object:  StoredProcedure [dbo].[SYS_DeleteNacion]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SYS_DeleteNacion]
	@id as int
AS

DELETE  from SYS_Nacion where id=@id

GO
/****** Object:  StoredProcedure [dbo].[SYS_DeletePiloto]    Script Date: 05/03/2020 18:26:58 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_DeleteTempo]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SYS_DeleteTempo] 
@id as int
AS

delete from SYS_Temporada where idtem=@id

GO
/****** Object:  StoredProcedure [dbo].[SYS_ExisteCircuito]    Script Date: 05/03/2020 18:26:58 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_ExisteConfig]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_ExisteConfig]
	@id as int
	

AS
SELECT COUNT(*) FROM SYS_Configuracion	  WHERE PAR_Id = @id



GO
/****** Object:  StoredProcedure [dbo].[SYS_ExisteinPosicion]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_ExisteinPosicion]( 
	@posicion int output,
	@resultado int output,	
	@piloto int output,
	@idTemporada  nchar(30),
	@idCircuito  int,
	@idpiloto  nchar(40),
	@Posllegada int
	)
AS

begin
--declare 
--@posicion int,
--@resultado int 

select @posicion = count(Posllegada)from SYS_Posicion where Posllegada = @Posllegada and idCircuito = @idCircuito and idPiloto = @idpiloto and idTemporada = @idTemporada
--select @posicion = count(Posllegada) from SYS_Posicion where Posllegada = 2 and idCircuito = 1 and idPiloto = 8 and idTemporada = 29


select @resultado = id from sys_posicion where  Posllegada = @Posllegada and idCircuito = @idCircuito and idPiloto = @idpiloto and  idTemporada = @idTemporada 
	

--select @resultado = id from sys_posicion where  Posllegada = 2 and idCircuito = 1 and idPiloto = 8 and  idTemporada = 29   	  
select @piloto = count(idPiloto) from SYS_Posicion where Posllegada = @Posllegada and idCircuito = @idCircuito and idPiloto = @idpiloto and idTemporada = @idTemporada


return @posicion
--print @posicion
return @resultado
--print @resultado
return @piloto
--print @piloto
end












----if (select count(idcircuito) from sys_posicion where idpiloto = 7 and idcircuito = 4 and idtemporada = 29 )>0
----if (select count(idcircuito ) from sys_posicion where idpiloto = @idpiloto and idcircuito = @idCircuito and idTemporada = @idTemporada and Posllegada = @Posllegada )>0
----     Select 1 [Exists]
----else
----        Select 0 [Exists]

----		begin
--begin

--select @posicion = Posllegada	from SYS_Posicion where idpiloto = @idpiloto and idcircuito = @idCircuito and idTemporada = @idTemporada and Posllegada = @Posllegada

--end 

--begin		--declare @id int
----	 select id from sys_posicion where idpiloto = 1 and idcircuito = 2 and idTemporada = 29

--	  select @resultado = id from sys_posicion where  idPiloto = @idpiloto and Posllegada = @Posllegada and idTemporada = @idTemporada and idCircuito = @idCircuito  	  
--		 --return @id 
--	 end

	 

--		--declare @posicion int
----	 select id from sys_posicion where idpiloto = 1 and idcircuito = 2 and idTemporada = 29

--	 --if( select count(@Posllegada) from sys_posicion where  idPiloto = @idpiloto  and idTemporada = @idTemporada and idCircuito = @idCircuito  )>0	  
--		-- --return @id 
--	 --select 1 [aaa]
--	 --else
--	 --select 0 [111]

GO
/****** Object:  StoredProcedure [dbo].[SYS_ExisteNacion]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_ExisteNacion]

@id as int

AS

SELECT COUNT(*) FROM SYS_Nacion	  WHERE id = @id

GO
/****** Object:  StoredProcedure [dbo].[SYS_ExisteNacionBy]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SYS_ExisteNacionBy]

@id as nchar(50)

AS

SELECT COUNT(*) FROM SYS_Nacion	  WHERE idNacion = @id

GO
/****** Object:  StoredProcedure [dbo].[SYS_ExistePiloto]    Script Date: 05/03/2020 18:26:58 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_ExistePilotoBy]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SYS_ExistePilotoBy]
	-- Add the parameters for the stored procedure here
@id nchar(40)
	
AS

select * from sys_piloto where nPiloto= @id


GO
/****** Object:  StoredProcedure [dbo].[SYS_ExistePosicion]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SYS_ExistePosicion] (
	@idTemporada  nchar(30),
	@idCircuito  int,
	@idpiloto  nchar(40),
	@Posllegada int
	)
AS

select count(*) from SYS_Posicion  where Posllegada = @Posllegada and idCircuito = @idCircuito and idPiloto = @idpiloto and idTemporada = @idTemporada


GO
/****** Object:  StoredProcedure [dbo].[SYS_ExistePosicion1]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SYS_ExistePosicion1] (
	@idTemporada  nchar(30),
	@idCircuito  int,	
	@Posllegada int
	)
AS

select count(Posllegada) from SYS_Posicion  where Posllegada = @Posllegada and idCircuito = @idCircuito  and idTemporada = @idTemporada


GO
/****** Object:  StoredProcedure [dbo].[SYS_ExistePosicion2]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SYS_ExistePosicion2] (
	@idTemporada  nchar(30),
	@idCircuito  int,
	@idpiloto  nchar(40)
	
	)
AS

select count(*) from SYS_Posicion  where  idCircuito = @idCircuito and idPiloto = @idpiloto and idTemporada = @idTemporada


GO
/****** Object:  StoredProcedure [dbo].[SYS_ExisteTempo]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SYS_ExisteTempo]
	@id as int
AS

SELECT COUNT(*) FROM sys_temporada	  WHERE idtem = @id

GO
/****** Object:  StoredProcedure [dbo].[SYS_InsertCircuito]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SYS_InsertCircuito] 
	@nCircuito as nchar(100)
AS

insert SYS_Circuito(nCircuito) values (@nCircuito)

GO
/****** Object:  StoredProcedure [dbo].[SYS_InsertNacion]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SYS_InsertNacion]
	
	@idNacion as nchar(50)
AS
insert SYS_Nacion(idNacion) values (@idNacion)

GO
/****** Object:  StoredProcedure [dbo].[SYS_InsertPiloto]    Script Date: 05/03/2020 18:26:58 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_InsertTempo]    Script Date: 05/03/2020 18:26:58 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_ObtenerCircuitobyID]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_ObtenerCircuitobyID]
	@id as int
AS
select * from SYS_Circuito where id= @id

GO
/****** Object:  StoredProcedure [dbo].[SYS_ObtenerConfigbyID]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SYS_ObtenerConfigbyID]
	@id as int
AS
select * from SYS_Configuracion where PAR_id=@id

GO
/****** Object:  StoredProcedure [dbo].[SYS_ObtenerNacionbyID]    Script Date: 05/03/2020 18:26:58 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_ObtenerPilotobyID]    Script Date: 05/03/2020 18:26:58 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_ObtenerTempobyID]    Script Date: 05/03/2020 18:26:58 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_SelectallCircuito]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_SelectallCircuito]
as	
	Select * from SYS_Circuito

GO
/****** Object:  StoredProcedure [dbo].[SYS_SelectallConfig]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SYS_SelectallConfig]
as 
	select * from sys_configuracion

GO
/****** Object:  StoredProcedure [dbo].[SYS_SelectallNaciones]    Script Date: 05/03/2020 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_SelectallNaciones]
	
AS
    
	SELECT * FROM SYS_Nacion




GO
/****** Object:  StoredProcedure [dbo].[SYS_SelectallPilotos]    Script Date: 05/03/2020 18:26:58 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_SelectallTempo]    Script Date: 05/03/2020 18:26:58 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_SelectaTempoactive]    Script Date: 05/03/2020 18:26:58 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_UpdateCircuito]    Script Date: 05/03/2020 18:26:58 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_UpdateConfig]    Script Date: 05/03/2020 18:26:58 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_UpdateNacion]    Script Date: 05/03/2020 18:26:58 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_UpdatePiloto]    Script Date: 05/03/2020 18:26:58 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_UpdateTempo]    Script Date: 05/03/2020 18:26:58 ******/
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
USE [master]
GO
ALTER DATABASE [IgpManager] SET  READ_WRITE 
GO
