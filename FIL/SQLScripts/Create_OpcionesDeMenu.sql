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
