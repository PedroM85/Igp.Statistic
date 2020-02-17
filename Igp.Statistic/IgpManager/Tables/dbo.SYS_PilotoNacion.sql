CREATE TABLE [dbo].[SYS_PilotoNacion]
(
[idPiloto] [int] NOT NULL,
[idNacion] [int] NOT NULL
)
GO
ALTER TABLE [dbo].[SYS_PilotoNacion] ADD CONSTRAINT [FK_SYS_PilotoNacion_SYS_Nacion] FOREIGN KEY ([idNacion]) REFERENCES [dbo].[SYS_Nacion] ([id])
GO
ALTER TABLE [dbo].[SYS_PilotoNacion] ADD CONSTRAINT [FK_SYS_PilotoNacion_SYS_Piloto] FOREIGN KEY ([idPiloto]) REFERENCES [dbo].[SYS_Piloto] ([id])
GO
