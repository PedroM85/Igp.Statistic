CREATE TABLE [dbo].[SYS_Configuracion]
(
[PAR_Id] [int] NOT NULL IDENTITY(1, 1),
[PAR_Idv] [nchar] (10) COLLATE Latin1_General_CI_AS NOT NULL,
[PAR_Descripcion] [varchar] (100) COLLATE Latin1_General_CI_AS NOT NULL,
[PAR_Type] [char] (1) COLLATE Latin1_General_CI_AS NOT NULL,
[PAR_String] [varchar] (4096) COLLATE Latin1_General_CI_AS NULL,
[PAR_Numeric] [numeric] (19, 4) NULL,
[PAR_Cacheable] [bit] NULL
)
GO
