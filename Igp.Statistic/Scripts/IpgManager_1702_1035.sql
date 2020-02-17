/****** Object:  Database [IgpManager]    Script Date: 17/02/2020 10:35:38 a.m. ******/
CREATE DATABASE [IgpManager]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'IgpManager', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\IgpManager.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'IgpManager_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\IgpManager_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
ALTER DATABASE [IgpManager] SET AUTO_CLOSE ON 
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
ALTER DATABASE [IgpManager] SET RECOVERY SIMPLE 
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
/****** Object:  Table [dbo].[SYS_Circuito]    Script Date: 17/02/2020 10:35:39 a.m. ******/
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
/****** Object:  Table [dbo].[SYS_Nacion]    Script Date: 17/02/2020 10:35:39 a.m. ******/
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
/****** Object:  Table [dbo].[SYS_Piloto]    Script Date: 17/02/2020 10:35:39 a.m. ******/
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
/****** Object:  Table [dbo].[SYS_PilotoNacion]    Script Date: 17/02/2020 10:35:39 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SYS_PilotoNacion](
	[idPiloto] [int] NOT NULL,
	[idNacion] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SYS_Punto]    Script Date: 17/02/2020 10:35:39 a.m. ******/
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
SET IDENTITY_INSERT [dbo].[SYS_Piloto] OFF
INSERT [dbo].[SYS_PilotoNacion] ([idPiloto], [idNacion]) VALUES (3, 1)
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
ALTER TABLE [dbo].[SYS_PilotoNacion]  WITH CHECK ADD  CONSTRAINT [FK_SYS_PilotoNacion_SYS_Nacion] FOREIGN KEY([idNacion])
REFERENCES [dbo].[SYS_Nacion] ([id])
GO
ALTER TABLE [dbo].[SYS_PilotoNacion] CHECK CONSTRAINT [FK_SYS_PilotoNacion_SYS_Nacion]
GO
ALTER TABLE [dbo].[SYS_PilotoNacion]  WITH CHECK ADD  CONSTRAINT [FK_SYS_PilotoNacion_SYS_Piloto] FOREIGN KEY([idPiloto])
REFERENCES [dbo].[SYS_Piloto] ([id])
GO
ALTER TABLE [dbo].[SYS_PilotoNacion] CHECK CONSTRAINT [FK_SYS_PilotoNacion_SYS_Piloto]
GO
/****** Object:  StoredProcedure [dbo].[SYS_CorrelativoP]    Script Date: 17/02/2020 10:35:39 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_DeletePiloto]    Script Date: 17/02/2020 10:35:39 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_ExistePiloto]    Script Date: 17/02/2020 10:35:39 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_InsertPiloto]    Script Date: 17/02/2020 10:35:39 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_InsertPiloto]

@nPiloto as nchar(30)



AS

Insert SYS_Piloto(nPiloto) values (@nPiloto)
 


GO
/****** Object:  StoredProcedure [dbo].[SYS_ObtenerNaciones]    Script Date: 17/02/2020 10:35:39 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SYS_ObtenerNaciones]
	
AS
    
	SELECT * FROM SYS_Nacion



GO
/****** Object:  StoredProcedure [dbo].[SYS_ObtenerPilotobyID]    Script Date: 17/02/2020 10:35:39 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_SelectallPilotos]    Script Date: 17/02/2020 10:35:39 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[SYS_UpdatePiloto]    Script Date: 17/02/2020 10:35:39 a.m. ******/
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
ALTER DATABASE [IgpManager] SET  READ_WRITE 
GO
