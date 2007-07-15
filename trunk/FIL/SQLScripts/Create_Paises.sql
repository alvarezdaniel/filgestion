USE [PrototipoFIL]
GO
/****** Objeto:  Table [dbo].[Paises]    Fecha de la secuencia de comandos: 07/15/2007 15:46:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Paises](
	[PaiId] [char](32) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PaiNombre] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PaiAutonumerico] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Paises] PRIMARY KEY CLUSTERED 
(
	[PaiId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF