/*
   Viernes 27 de Julio de 200717:35:41
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
ALTER TABLE dbo.OpcionesDeMenu ADD
	MnuForm nvarchar(255) NULL,
	MnuMetodo nvarchar(255) NULL,
	MnuURL nvarchar(255) NULL
GO
COMMIT
