CREATE TABLE [dbo].[SYS_Temporada]
(
[idTem] [int] NOT NULL IDENTITY(1, 1),
[Temporada] [nchar] (30) COLLATE Latin1_General_CI_AS NOT NULL,
[isActive] [bit] NULL CONSTRAINT [DF_SYS_Temporada_isActive] DEFAULT ((0))
)
GO
ALTER TABLE [dbo].[SYS_Temporada] ADD CONSTRAINT [PK_SYS_Temporada] PRIMARY KEY CLUSTERED  ([idTem])
GO
