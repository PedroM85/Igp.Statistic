CREATE TABLE [dbo].[SYS_Piloto]
(
[id] [int] NOT NULL IDENTITY(1, 1),
[nPiloto] [nchar] (40) COLLATE Modern_Spanish_CI_AS NOT NULL,
[bPiloto] [image] NULL
)
GO
ALTER TABLE [dbo].[SYS_Piloto] ADD CONSTRAINT [PK_SYS_Piloto] PRIMARY KEY CLUSTERED  ([id])
GO
