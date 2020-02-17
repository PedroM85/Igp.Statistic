CREATE TABLE [dbo].[SYS_Circuito]
(
[ID] [int] NOT NULL IDENTITY(1, 1),
[nCircuito] [nchar] (100) COLLATE Modern_Spanish_CI_AS NOT NULL,
[bCircuito] [varbinary] (max) NULL
)
GO
