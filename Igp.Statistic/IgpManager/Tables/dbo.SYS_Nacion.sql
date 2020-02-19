CREATE TABLE [dbo].[SYS_Nacion]
(
[id] [int] NOT NULL IDENTITY(1, 1),
[idNacion] [nchar] (50) COLLATE Latin1_General_CI_AS NULL
)
GO
ALTER TABLE [dbo].[SYS_Nacion] ADD CONSTRAINT [PK_SYS_Nacion] PRIMARY KEY CLUSTERED  ([id])
GO
