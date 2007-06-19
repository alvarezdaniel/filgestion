USE [PrototipoFIL]
GO
/****** Object:  Table [dbo].[OpcionesDeMenu]    Script Date: 06/19/2007 15:19:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OpcionesDeMenu](
	[MnuId] [int] NOT NULL,
	[MnuIdPadre] [int] NULL,
	[MnuDescripcion] [nvarchar](50) NOT NULL,
	[MnuAccion] [int] NOT NULL,
	[MnuOrden] [int] NOT NULL CONSTRAINT [DF_OpcionesDeMenu_MnuOrden]  DEFAULT ((0)),
 CONSTRAINT [PK_OpcionesDeMenu] PRIMARY KEY CLUSTERED 
(
	[MnuId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[OpcionesDeMenu]  WITH CHECK ADD  CONSTRAINT [FK_OpcionesDeMenu_OpcionesDeMenu] FOREIGN KEY([MnuIdPadre])
REFERENCES [dbo].[OpcionesDeMenu] ([MnuId])
GO
ALTER TABLE [dbo].[OpcionesDeMenu] CHECK CONSTRAINT [FK_OpcionesDeMenu_OpcionesDeMenu]

/****** Inserto algunos datos *************/

INSERT INTO [PrototipoFIL].[dbo].[OpcionesDeMenu] VALUES (1, null, 'Usuarios', 1, 1)
INSERT INTO [PrototipoFIL].[dbo].[OpcionesDeMenu] VALUES (2, 1, 'Consulta de Usuarios', 1, 1)
INSERT INTO [PrototipoFIL].[dbo].[OpcionesDeMenu] VALUES (3, 1, 'Alta de Usuarios', 2, 2)
INSERT INTO [PrototipoFIL].[dbo].[OpcionesDeMenu] VALUES (4, 1, 'Baja de Usuarios', 3, 3)
INSERT INTO [PrototipoFIL].[dbo].[OpcionesDeMenu] VALUES (5, 1, 'Modificación de Usuarios', 4, 4)
