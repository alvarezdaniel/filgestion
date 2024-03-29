USE [PrototipoFIL]
GO
/****** Object:  ForeignKey [FK_AccionesAsociadas_Perfiles]    Script Date: 08/07/2007 11:55:21 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AccionesAsociadas_Perfiles]') AND parent_object_id = OBJECT_ID(N'[dbo].[AccionesAsociadas]'))
ALTER TABLE [dbo].[AccionesAsociadas] DROP CONSTRAINT [FK_AccionesAsociadas_Perfiles]
GO
/****** Object:  ForeignKey [FK_OpcionesDeMenu_OpcionesDeMenu]    Script Date: 08/07/2007 11:55:33 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_OpcionesDeMenu_OpcionesDeMenu]') AND parent_object_id = OBJECT_ID(N'[dbo].[OpcionesDeMenu]'))
ALTER TABLE [dbo].[OpcionesDeMenu] DROP CONSTRAINT [FK_OpcionesDeMenu_OpcionesDeMenu]
GO
/****** Object:  ForeignKey [FK_PerfilesAsignados_Perfiles]    Script Date: 08/07/2007 11:55:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PerfilesAsignados_Perfiles]') AND parent_object_id = OBJECT_ID(N'[dbo].[PerfilesAsignados]'))
ALTER TABLE [dbo].[PerfilesAsignados] DROP CONSTRAINT [FK_PerfilesAsignados_Perfiles]
GO
/****** Object:  ForeignKey [FK_PerfilesAsignados_UnidadesDeGestion]    Script Date: 08/07/2007 11:55:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PerfilesAsignados_UnidadesDeGestion]') AND parent_object_id = OBJECT_ID(N'[dbo].[PerfilesAsignados]'))
ALTER TABLE [dbo].[PerfilesAsignados] DROP CONSTRAINT [FK_PerfilesAsignados_UnidadesDeGestion]
GO
/****** Object:  ForeignKey [FK_PerfilesAsignados_Usuarios]    Script Date: 08/07/2007 11:55:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PerfilesAsignados_Usuarios]') AND parent_object_id = OBJECT_ID(N'[dbo].[PerfilesAsignados]'))
ALTER TABLE [dbo].[PerfilesAsignados] DROP CONSTRAINT [FK_PerfilesAsignados_Usuarios]
GO
/****** Object:  Table [dbo].[OpcionesDeMenu]    Script Date: 08/07/2007 11:55:33 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OpcionesDeMenu]') AND type in (N'U'))
DROP TABLE [dbo].[OpcionesDeMenu]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 08/07/2007 11:55:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Clientes]') AND type in (N'U'))
DROP TABLE [dbo].[Clientes]
GO
/****** Object:  Table [dbo].[Paises]    Script Date: 08/07/2007 11:55:35 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Paises]') AND type in (N'U'))
DROP TABLE [dbo].[Paises]
GO
/****** Object:  Table [dbo].[Localidades]    Script Date: 08/07/2007 11:55:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Localidades]') AND type in (N'U'))
DROP TABLE [dbo].[Localidades]
GO
/****** Object:  Table [dbo].[PerfilesAsignados]    Script Date: 08/07/2007 11:55:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PerfilesAsignados]') AND type in (N'U'))
DROP TABLE [dbo].[PerfilesAsignados]
GO
/****** Object:  Table [dbo].[AccionesAsociadas]    Script Date: 08/07/2007 11:55:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AccionesAsociadas]') AND type in (N'U'))
DROP TABLE [dbo].[AccionesAsociadas]
GO
/****** Object:  Table [dbo].[UnidadesDeGestion]    Script Date: 08/07/2007 11:55:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UnidadesDeGestion]') AND type in (N'U'))
DROP TABLE [dbo].[UnidadesDeGestion]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 08/07/2007 11:55:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuarios]') AND type in (N'U'))
DROP TABLE [dbo].[Usuarios]
GO
/****** Object:  Table [dbo].[Perfiles]    Script Date: 08/07/2007 11:55:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Perfiles]') AND type in (N'U'))
DROP TABLE [dbo].[Perfiles]
GO
/****** Object:  Table [dbo].[OpcionesDeMenu]    Script Date: 08/07/2007 11:55:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OpcionesDeMenu]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[OpcionesDeMenu](
	[MnuId] [int] NOT NULL,
	[MnuIdPadre] [int] NULL,
	[MnuDescripcion] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[MnuAccion] [int] NOT NULL,
	[MnuOrden] [int] NOT NULL CONSTRAINT [DF_OpcionesDeMenu_MnuOrden]  DEFAULT ((0)),
	[MnuForm] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[MnuMetodo] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[MnuURL] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_OpcionesDeMenu] PRIMARY KEY CLUSTERED 
(
	[MnuId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 08/07/2007 11:55:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuarios]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Usuarios](
	[UsrId] [char](32) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[UsrAutonumerico] [int] IDENTITY(1,1) NOT NULL,
	[UsrUsername] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[UsrNombres] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[UsrApellidos] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[UsrPassword] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL CONSTRAINT [DF_Usuarios_UsrPassword]  DEFAULT ((0)),
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[UsrId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Perfiles]    Script Date: 08/07/2007 11:55:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Perfiles]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Perfiles](
	[PflId] [char](32) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PflDescripcion] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PflAutonumerico] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Perfiles] PRIMARY KEY CLUSTERED 
(
	[PflId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 08/07/2007 11:55:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Clientes]') AND type in (N'U'))
BEGIN
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Paises]    Script Date: 08/07/2007 11:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Paises]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Paises](
	[PaiId] [char](32) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PaiNombre] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PaiAutonumerico] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Paises] PRIMARY KEY CLUSTERED 
(
	[PaiId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Localidades]    Script Date: 08/07/2007 11:55:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Localidades]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Localidades](
	[LocId] [char](32) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[LocNombre] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[LocAutonumerico] [int] IDENTITY(1,1) NOT NULL,
	[LocCodigoPostal] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_Localidades] PRIMARY KEY CLUSTERED 
(
	[LocId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UnidadesDeGestion]    Script Date: 08/07/2007 11:55:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UnidadesDeGestion]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UnidadesDeGestion](
	[UdgId] [char](32) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[UdgAutonumerico] [int] IDENTITY(1,1) NOT NULL,
	[UdgNombre] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_UnidadesDeGestion] PRIMARY KEY CLUSTERED 
(
	[UdgId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PerfilesAsignados]    Script Date: 08/07/2007 11:55:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PerfilesAsignados]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PerfilesAsignados](
	[PasUsuario] [char](32) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PasPerfil] [char](32) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PasUnidadDeGestion] [char](32) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_PerfilesAsignados] PRIMARY KEY CLUSTERED 
(
	[PasUsuario] ASC,
	[PasPerfil] ASC,
	[PasUnidadDeGestion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AccionesAsociadas]    Script Date: 08/07/2007 11:55:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AccionesAsociadas]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AccionesAsociadas](
	[AasPerfil] [char](32) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[AasAccion] [int] NOT NULL,
 CONSTRAINT [PK_AccionesAsociadas] PRIMARY KEY CLUSTERED 
(
	[AasPerfil] ASC,
	[AasAccion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_AccionesAsociadas_Perfiles]    Script Date: 08/07/2007 11:55:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AccionesAsociadas_Perfiles]') AND parent_object_id = OBJECT_ID(N'[dbo].[AccionesAsociadas]'))
ALTER TABLE [dbo].[AccionesAsociadas]  WITH CHECK ADD  CONSTRAINT [FK_AccionesAsociadas_Perfiles] FOREIGN KEY([AasPerfil])
REFERENCES [dbo].[Perfiles] ([PflId])
GO
ALTER TABLE [dbo].[AccionesAsociadas] CHECK CONSTRAINT [FK_AccionesAsociadas_Perfiles]
GO
/****** Object:  ForeignKey [FK_OpcionesDeMenu_OpcionesDeMenu]    Script Date: 08/07/2007 11:55:33 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_OpcionesDeMenu_OpcionesDeMenu]') AND parent_object_id = OBJECT_ID(N'[dbo].[OpcionesDeMenu]'))
ALTER TABLE [dbo].[OpcionesDeMenu]  WITH CHECK ADD  CONSTRAINT [FK_OpcionesDeMenu_OpcionesDeMenu] FOREIGN KEY([MnuIdPadre])
REFERENCES [dbo].[OpcionesDeMenu] ([MnuId])
GO
ALTER TABLE [dbo].[OpcionesDeMenu] CHECK CONSTRAINT [FK_OpcionesDeMenu_OpcionesDeMenu]
GO
/****** Object:  ForeignKey [FK_PerfilesAsignados_Perfiles]    Script Date: 08/07/2007 11:55:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PerfilesAsignados_Perfiles]') AND parent_object_id = OBJECT_ID(N'[dbo].[PerfilesAsignados]'))
ALTER TABLE [dbo].[PerfilesAsignados]  WITH CHECK ADD  CONSTRAINT [FK_PerfilesAsignados_Perfiles] FOREIGN KEY([PasPerfil])
REFERENCES [dbo].[Perfiles] ([PflId])
GO
ALTER TABLE [dbo].[PerfilesAsignados] CHECK CONSTRAINT [FK_PerfilesAsignados_Perfiles]
GO
/****** Object:  ForeignKey [FK_PerfilesAsignados_UnidadesDeGestion]    Script Date: 08/07/2007 11:55:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PerfilesAsignados_UnidadesDeGestion]') AND parent_object_id = OBJECT_ID(N'[dbo].[PerfilesAsignados]'))
ALTER TABLE [dbo].[PerfilesAsignados]  WITH CHECK ADD  CONSTRAINT [FK_PerfilesAsignados_UnidadesDeGestion] FOREIGN KEY([PasUnidadDeGestion])
REFERENCES [dbo].[UnidadesDeGestion] ([UdgId])
GO
ALTER TABLE [dbo].[PerfilesAsignados] CHECK CONSTRAINT [FK_PerfilesAsignados_UnidadesDeGestion]
GO
/****** Object:  ForeignKey [FK_PerfilesAsignados_Usuarios]    Script Date: 08/07/2007 11:55:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PerfilesAsignados_Usuarios]') AND parent_object_id = OBJECT_ID(N'[dbo].[PerfilesAsignados]'))
ALTER TABLE [dbo].[PerfilesAsignados]  WITH CHECK ADD  CONSTRAINT [FK_PerfilesAsignados_Usuarios] FOREIGN KEY([PasUsuario])
REFERENCES [dbo].[Usuarios] ([UsrId])
GO
ALTER TABLE [dbo].[PerfilesAsignados] CHECK CONSTRAINT [FK_PerfilesAsignados_Usuarios]
GO
