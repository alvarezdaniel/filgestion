/*
   Lunes 30 de Julio de 200711:32:24
   User: 
   Server: BUE0PC223\SQLEXPRESS
   Database: PrototipoFIL
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_UnidadesDeGestion
	(
	UdgId char(32) NOT NULL,
	UdgAutonumerico int NOT NULL IDENTITY (1, 1),
	UdgNombre nvarchar(50) NOT NULL
	)  ON [PRIMARY]
GO
SET IDENTITY_INSERT dbo.Tmp_UnidadesDeGestion ON
GO
IF EXISTS(SELECT * FROM dbo.UnidadesDeGestion)
	 EXEC('INSERT INTO dbo.Tmp_UnidadesDeGestion (UdgId, UdgAutonumerico)
		SELECT UdgId, UdgAutonumerico FROM dbo.UnidadesDeGestion WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_UnidadesDeGestion OFF
GO
ALTER TABLE dbo.PerfilesAsignados
	DROP CONSTRAINT FK_PerfilesAsignados_UnidadesDeGestion
GO
DROP TABLE dbo.UnidadesDeGestion
GO
EXECUTE sp_rename N'dbo.Tmp_UnidadesDeGestion', N'UnidadesDeGestion', 'OBJECT' 
GO
ALTER TABLE dbo.UnidadesDeGestion ADD CONSTRAINT
	PK_UnidadesDeGestion PRIMARY KEY CLUSTERED 
	(
	UdgId
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.PerfilesAsignados ADD CONSTRAINT
	FK_PerfilesAsignados_UnidadesDeGestion FOREIGN KEY
	(
	PasUnidadDeGestion
	) REFERENCES dbo.UnidadesDeGestion
	(
	UdgId
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
