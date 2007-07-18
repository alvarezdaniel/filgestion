USE [PrototipoFIL]
GO
/****** Objeto:  Table [dbo].[Clientes]    Fecha de la secuencia de comandos: 07/17/2007 20:43:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[CliID] [char](32) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CliAutonumerico] [int] IDENTITY(1,1) NOT NULL,
	[CliCodigo] [nvarchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CliNombres] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CliApellidos] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CliAnioNacimiento] [int] NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[CliID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO