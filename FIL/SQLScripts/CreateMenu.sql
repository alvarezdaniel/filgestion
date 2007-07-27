/**********************************************
*     Creacion del Menu de la Aplicacion      *
**********************************************/
USE PrototipoFIL

TRUNCATE TABLE OpcionesDeMenu

INSERT INTO OpcionesDeMenu (MnuId, MnuIdPadre,MnuDescripcion,MnuAccion,MnuOrden,MnuForm,MnuMetodo,MnuURL) VALUES (1, null, 'ABM''s', 0, 1,null,null,null)
INSERT INTO OpcionesDeMenu (MnuId, MnuIdPadre,MnuDescripcion,MnuAccion,MnuOrden,MnuForm,MnuMetodo,MnuURL) VALUES (2, 1, 'Usuarios', 1, 1,'FrmUsuarios',null,null)
INSERT INTO OpcionesDeMenu (MnuId, MnuIdPadre,MnuDescripcion,MnuAccion,MnuOrden,MnuForm,MnuMetodo,MnuURL) VALUES (3, 2, 'Alta de Usuarios', 2, 1,'FrmUsuarios',null,null)
INSERT INTO OpcionesDeMenu (MnuId, MnuIdPadre,MnuDescripcion,MnuAccion,MnuOrden,MnuForm,MnuMetodo,MnuURL) VALUES (4, 2, 'Baja de Usuarios', 3, 2,'FrmUsuarios',null,null)
INSERT INTO OpcionesDeMenu (MnuId, MnuIdPadre,MnuDescripcion,MnuAccion,MnuOrden,MnuForm,MnuMetodo,MnuURL) VALUES (5, 2, 'Modificacion de Usuarios', 4, 3,'FrmUsuarios',null,null)

