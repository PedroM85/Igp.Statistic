CREATE TABLE [dbo].[SYS_Piloto]
(
[id] [int] NOT NULL IDENTITY(1, 1),
[nPiloto] [nchar] (40) COLLATE Latin1_General_CI_AS NOT NULL,
[IdNacion] [int] NULL
)
GO
ALTER TABLE [dbo].[SYS_Piloto] ADD CONSTRAINT [PK_SYS_Piloto] PRIMARY KEY CLUSTERED  ([id])
GO
