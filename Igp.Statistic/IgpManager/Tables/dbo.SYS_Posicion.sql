CREATE TABLE [dbo].[SYS_Posicion]
(
[id] [int] NOT NULL IDENTITY(1, 1),
[idTemporada] [nchar] (30) COLLATE Latin1_General_CI_AS NOT NULL,
[idCircuito] [int] NOT NULL,
[idPiloto] [nchar] (40) COLLATE Latin1_General_CI_AS NOT NULL,
[Posllegada] [int] NOT NULL
)
GO
