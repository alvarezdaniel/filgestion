USE [PrototipoFIL]
GO
/****** Object:  Table [dbo].[Localidades]    Script Date: 07/28/2007 12:36:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Localidades](
	[LocId] [char](32) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[LocNombre] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[LocAutonumerico] [int] IDENTITY(1,1) NOT NULL,
	[LocCodigoPostal] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_Localidades] PRIMARY KEY CLUSTERED 
(
	[LocId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF