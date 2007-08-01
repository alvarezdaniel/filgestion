/**********************************************
*     Creacion del Menu de la Aplicacion      *
**********************************************/
USE PrototipoFIL

TRUNCATE TABLE OpcionesDeMenu

-- ABM's
INSERT INTO OpcionesDeMenu (MnuId, MnuIdPadre,MnuDescripcion,MnuAccion,MnuOrden,MnuForm,MnuMetodo,MnuURL) VALUES (1, null, 'ABM''s', 0, 1,null,null,null)
--- Usuarios
INSERT INTO OpcionesDeMenu (MnuId, MnuIdPadre,MnuDescripcion,MnuAccion,MnuOrden,MnuForm,MnuMetodo,MnuURL) VALUES (2, 1, 'Usuarios', 1, 1,'FrmUsuarios',null,null)
INSERT INTO OpcionesDeMenu (MnuId, MnuIdPadre,MnuDescripcion,MnuAccion,MnuOrden,MnuForm,MnuMetodo,MnuURL) VALUES (3, 2, 'Alta de Usuarios', 2, 1,'FrmUsuarios',null,null)
INSERT INTO OpcionesDeMenu (MnuId, MnuIdPadre,MnuDescripcion,MnuAccion,MnuOrden,MnuForm,MnuMetodo,MnuURL) VALUES (4, 2, 'Baja de Usuarios', 3, 2,'FrmUsuarios',null,null)
INSERT INTO OpcionesDeMenu (MnuId, MnuIdPadre,MnuDescripcion,MnuAccion,MnuOrden,MnuForm,MnuMetodo,MnuURL) VALUES (5, 2, 'Modificacion de Usuarios', 4, 3,'FrmUsuarios',null,null)
--- Perfiles
INSERT INTO OpcionesDeMenu (MnuId, MnuIdPadre,MnuDescripcion,MnuAccion,MnuOrden,MnuForm,MnuMetodo,MnuURL) VALUES (6, 1, 'Perfiles', 7, 2,'FrmPerfiles',null,null)
INSERT INTO OpcionesDeMenu (MnuId, MnuIdPadre,MnuDescripcion,MnuAccion,MnuOrden,MnuForm,MnuMetodo,MnuURL) VALUES (7, 6, 'Alta de Perfiles', 6, 1,'FrmPerfiles',null,null)
INSERT INTO OpcionesDeMenu (MnuId, MnuIdPadre,MnuDescripcion,MnuAccion,MnuOrden,MnuForm,MnuMetodo,MnuURL) VALUES (8, 6, 'Baja de Perfiles', 8, 2,'FrmPerfiles',null,null)
INSERT INTO OpcionesDeMenu (MnuId, MnuIdPadre,MnuDescripcion,MnuAccion,MnuOrden,MnuForm,MnuMetodo,MnuURL) VALUES (9, 6, 'Modificacion de Perfiles', 9, 3,'FrmPerfiles',null,null)
--- Unidades De Gestion
INSERT INTO OpcionesDeMenu (MnuId, MnuIdPadre,MnuDescripcion,MnuAccion,MnuOrden,MnuForm,MnuMetodo,MnuURL) VALUES (10, 1, 'Unidades De Gestion', 10, 3,'FrmUnidadesDeGestion',null,null)
INSERT INTO OpcionesDeMenu (MnuId, MnuIdPadre,MnuDescripcion,MnuAccion,MnuOrden,MnuForm,MnuMetodo,MnuURL) VALUES (11, 10, 'Alta de Unidades De Gestion', 11, 1,'FrmUnidadesDeGestion',null,null)
INSERT INTO OpcionesDeMenu (MnuId, MnuIdPadre,MnuDescripcion,MnuAccion,MnuOrden,MnuForm,MnuMetodo,MnuURL) VALUES (12, 10, 'Baja de Unidades De Gestion', 12, 2,'FrmUnidadesDeGestion',null,null)
INSERT INTO OpcionesDeMenu (MnuId, MnuIdPadre,MnuDescripcion,MnuAccion,MnuOrden,MnuForm,MnuMetodo,MnuURL) VALUES (13, 10, 'Modificacion de Unidades De Gestion', 13, 3,'FrmUnidadesDeGestion',null,null)
