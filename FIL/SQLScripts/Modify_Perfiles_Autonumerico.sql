/*
   Domingo, 22 de Julio de 200712:40:16 p.m.
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
EXECUTE sp_rename N'dbo.Perfiles.PflCodigo', N'Tmp_PflAutonumerico', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.Perfiles.Tmp_PflAutonumerico', N'PflAutonumerico', 'COLUMN' 
GO
COMMIT
