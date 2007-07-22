/*
   Domingo, 22 de Julio de 200712:45:11 p.m.
   User: 
   Server: FELDMAN\SQLEXPRESS
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
EXECUTE sp_rename N'dbo.UnidadesDeGestion.UdgCodigo', N'Tmp_UdgAutonumerico_3', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.UnidadesDeGestion.Tmp_UdgAutonumerico_3', N'UdgAutonumerico', 'COLUMN' 
GO
COMMIT
select Has_Perms_By_Name(N'dbo.UnidadesDeGestion', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.UnidadesDeGestion', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.UnidadesDeGestion', 'Object', 'CONTROL') as Contr_Per 