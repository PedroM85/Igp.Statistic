CREATE TABLE [dbo].[SYS_Nacion]
(
[id] [int] NOT NULL IDENTITY(1, 1),
[Nacion] [nchar] (50) COLLATE Modern_Spanish_CI_AS NULL
)
GO
ALTER TABLE [dbo].[SYS_Nacion] ADD CONSTRAINT [PK_SYS_Nacion] PRIMARY KEY CLUSTERED  ([id])
GO
