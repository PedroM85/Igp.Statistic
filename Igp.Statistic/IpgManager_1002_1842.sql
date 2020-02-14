USE [master]
GO
/****** Object:  Database [IgpManager]    Script Date: 10/02/2020 18:42:44 ******/
CREATE DATABASE [IgpManager] ON  PRIMARY 
( NAME = N'IgpManager', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL.1\MSSQL\DATA\IgpManager.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'IgpManager_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL.1\MSSQL\DATA\IgpManager_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [IgpManager] SET COMPATIBILITY_LEVEL = 90
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
ALTER DATABASE [IgpManager] SET  DISABLE_BROKER 
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
ALTER DATABASE [IgpManager] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [IgpManager] SET  MULTI_USER 
GO
ALTER DATABASE [IgpManager] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [IgpManager] SET DB_CHAINING OFF 
GO
USE [IgpManager]
GO
/****** Object:  Table [dbo].[SYS_Circuito]    Script Date: 10/02/2020 18:42:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SYS_Circuito](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[nCircuito] [nchar](100) NOT NULL,
	[bCircuito] [varbinary](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SYS_Piloto]    Script Date: 10/02/2020 18:42:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[SYS_Piloto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idP] [int] NULL,
	[nPiloto] [nchar](30) NOT NULL,
	[naPiloto] [nchar](30) NOT NULL,
	[bPiloto] [varbinary](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SYS_Piloto1]    Script Date: 10/02/2020 18:42:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SYS_Piloto1](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nPiloto] [nchar](30) NOT NULL,
	[naPiloto] [nchar](30) NOT NULL,
	[bPiloto] [varbinary](max) NULL,
	[idP] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[SYS_Piloto] ON 

INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (1, 1, N'Lucas Frassi                  ', N'Ucrania                       ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (2, 2, N'Zadquiel Caballero            ', N'Venezuela                     ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (3, 3, N'Agustin Cuesta                ', N'Argentina                     ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (4, 4, N'Ismael Fajardo                ', N'Uruguay                       ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (5, 5, N'Sergio Catalusci              ', N'Argentina                     ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (6, 6, N'Andres Greniuk                ', N'Alemania                      ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (7, 7, N'Pedro Maneiro                 ', N'Argentina                     ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (8, 8, N'Ayrton Lopez                  ', N'Suecia                        ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (9, 9, N'Cristian Fernandez            ', N'Ucrania                       ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (10, 10, N'Daniel Maldonado              ', N'Venezuela                     ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (11, 11, N'Yosman Zerpa                  ', N'Venezuela                     ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (12, 12, N'Marco Suarez                  ', N'Mexico                        ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (13, 13, N'Jesus Allones                 ', N'España                        ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (14, 14, N'Rodrigo Arancibia             ', N'Chile                         ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (15, 15, N'Mario Suarez                  ', N'Mexico                        ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (16, 16, N'Olger Martin                  ', N'Ucrania                       ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (17, 17, N'Daniel Garay                  ', N'Chile                         ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (18, 18, N'Patricio Invitto              ', N'Argentina                     ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (19, 19, N'Pablo Delgado                 ', N'Argentina                     ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (20, 20, N'Yair Duran                    ', N'Colombia                      ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (21, 21, N'Kai Renger                    ', N'Alemania                      ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (22, 22, N'Emilio Peralta                ', N'Argentina                     ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (23, 23, N'Jose Caparroso                ', N'Colombia                      ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (24, 24, N'Cesar Caparroso               ', N'Colombia                      ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (25, 25, N'Rafael Lopez                  ', N'Mexico                        ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (26, 26, N'Mario Fernandez               ', N'Colombia                      ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (27, 27, N'Juani Mirako                  ', N'Suecia                        ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (28, 28, N'Santiago Viotti               ', N'Uruguay                       ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (29, 29, N'Thomas Rincon                 ', N'Suecia                        ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (30, 30, N'Patricio Quesada              ', N'Argentina                     ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (31, 31, N'Roberto Balbio                ', N'Mexico                        ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (32, 32, N'Francisco Suarez              ', N'Uruguay                       ', NULL)
INSERT [dbo].[SYS_Piloto] ([id], [idP], [nPiloto], [naPiloto], [bPiloto]) VALUES (33, 33, N'Fco Muñoz                     ', N'Mexico                        ', NULL)
SET IDENTITY_INSERT [dbo].[SYS_Piloto] OFF
SET IDENTITY_INSERT [dbo].[SYS_Piloto1] ON 

INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (1, N'Lucas Frassi                  ', N'Ucrania                       ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (2, N'Zadquiel Caballero            ', N'Venezuela                     ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (3, N'Agustin Cuesta                ', N'Argentina                     ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (4, N'Ismael Fajardo                ', N'Uruguay                       ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (5, N'Sergio Catalusci              ', N'Argentina                     ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (6, N'Andres Greniuk                ', N'Alemania                      ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (7, N'Pedro Maneiro                 ', N'Argentina                     ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (8, N'Ayrton Lopez                  ', N'Suecia                        ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (9, N'Cristian Fernandez            ', N'Ucrania                       ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (10, N'Daniel Maldonado              ', N'Venezuela                     ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (11, N'Yosman Zerpa                  ', N'Venezuela                     ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (12, N'Marco Suarez                  ', N'Mexico                        ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (13, N'Jesus Allones                 ', N'España                        ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (14, N'Rodrigo Arancibia             ', N'Chile                         ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (15, N'Mario Suarez                  ', N'Mexico                        ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (16, N'Olger Martin                  ', N'Ucrania                       ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (17, N'Daniel Garay                  ', N'Chile                         ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (18, N'Patricio Invitto              ', N'Argentina                     ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (19, N'Pablo Delgado                 ', N'Argentina                     ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (20, N'Yair Duran                    ', N'Colombia                      ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (21, N'Kai Renger                    ', N'Alemania                      ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (22, N'Emilio Peralta                ', N'Argentina                     ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (23, N'Jose Caparroso                ', N'Colombia                      ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (24, N'Cesar Caparroso               ', N'Colombia                      ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (25, N'Rafael Lopez                  ', N'Mexico                        ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (26, N'Mario Fernandez               ', N'Colombia                      ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (27, N'Juani Mirako                  ', N'Suecia                        ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (28, N'Santiago Viotti               ', N'Uruguay                       ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (29, N'Thomas Rincon                 ', N'Suecia                        ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (30, N'Patricio Quesada              ', N'Argentina                     ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (31, N'Roberto Balbio                ', N'Mexico                        ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (32, N'Francisco Suarez              ', N'Uruguay                       ', NULL, NULL)
INSERT [dbo].[SYS_Piloto1] ([id], [nPiloto], [naPiloto], [bPiloto], [idP]) VALUES (33, N'Fco Muñoz                     ', N'Mexico                        ', NULL, NULL)
SET IDENTITY_INSERT [dbo].[SYS_Piloto1] OFF
/****** Object:  StoredProcedure [dbo].[SYS_CorrelativoP]    Script Date: 10/02/2020 18:42:44 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_DeletePiloto]    Script Date: 10/02/2020 18:42:44 ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_InsertPiloto]    Script Date: 10/02/2020 18:42:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_InsertPiloto]

@idP as int,
@nPiloto as nchar(30),
@naPiloto as nchar(30)


AS

Insert SYS_Piloto(idP,nPiloto,naPiloto) values (@idP,@nPiloto,@naPiloto)
 

GO
/****** Object:  StoredProcedure [dbo].[SYS_SelectallPilotos]    Script Date: 10/02/2020 18:42:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SYS_SelectallPilotos]
	AS

 
	SELECT * from SYS_Piloto
	--where naPiloto = 'Venezuela'

GO
/****** Object:  StoredProcedure [dbo].[SYS_UpdatePiloto]    Script Date: 10/02/2020 18:42:44 ******/
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
	@idP int,
	@nPiloto varchar(30),
	@naPiloto varchar(30)
	--@bPiloto varbinary(MAX)
	 
)
AS
	UPDATE SYS_Piloto
		SET idP=@idP,nPiloto = @nPiloto, naPiloto = @naPiloto --bPiloto = @bPiloto
		WHERE id = @id

GO
USE [master]
GO
ALTER DATABASE [IgpManager] SET  READ_WRITE 
GO
