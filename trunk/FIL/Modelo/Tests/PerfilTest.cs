using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Fil.Modelo.Entidades;
using Fil.Modelo.Helpers;

namespace Fil.Modelo.Tests
{
  /// <summary>
  /// Esta clase contiene los métodos para probar la lógica de negocio de la clase Perfil
  /// </summary>
  /// <remarks>
  /// Es utilizada por NUnit
  /// </remarks>
  [TestFixture()]
  public class PerfilTest
  {

    /// <summary>
    /// Prueba básica de la clase perfil
    /// </summary>
    [Test()]
    public void TestCompleto()
    {
      try
      {
        NHibernateManager.BeginTransaction();

        //Creo un nuevo perfil
        Perfil p = new Perfil("PerfilPrueba");
        
        //Le asigno unas acciones
        p.AgregarAccion(Fil.Modelo.Enumerados.Accion.ConsultaUsuarios);
        p.AgregarAccion(Fil.Modelo.Enumerados.Accion.AltaUsuarios);
        p.AgregarAccion(Fil.Modelo.Enumerados.Accion.BajaUsuarios);

        //Lo guardo en la base
        p.Guardar();

        //Obtengo el perfil guardado y lo asigno a otra variable
        Perfil aux = PerfilHelper.ObtenerPorId(p.Id);

        //Verifico los datos
        Assert.AreEqual(p.Id, aux.Id);
        Assert.AreEqual(p.Autonumerico, aux.Autonumerico);
        Assert.AreEqual(p.Descripcion, aux.Descripcion);
        Assert.AreEqual(p.Acciones.Count, aux.Acciones.Count);

        //Modifico la Descripcion
        p.Descripcion = "Nueva Descripcion";
        p.QuitarAccion(Fil.Modelo.Enumerados.Accion.AltaUsuarios); //Elimino Altas
        p.QuitarAccion(Fil.Modelo.Enumerados.Accion.BajaUsuarios); //Elimino Bajas
        p.AgregarAccion(Fil.Modelo.Enumerados.Accion.ModificacionUsuarios); //Agrego Modificacion
        p.Guardar();

        //vuelvo a verificar
        aux = null;
        aux = PerfilHelper.ObtenerPorId(p.Id);

        //Verifico los datos
        Assert.AreEqual(p.Id, aux.Id);
        Assert.AreEqual(p.Autonumerico, aux.Autonumerico);
        Assert.AreEqual(p.Descripcion, aux.Descripcion);
        Assert.AreEqual(p.Acciones.Count, aux.Acciones.Count);


        //Verifico si puede realizar acciones()
        Assert.IsTrue(p.Puede(Fil.Modelo.Enumerados.Accion.AccionNula));
        Assert.IsTrue(p.Puede(Fil.Modelo.Enumerados.Accion.ConsultaUsuarios));
        Assert.IsFalse(p.Puede(Fil.Modelo.Enumerados.Accion.AltaUsuarios));
        Assert.IsFalse(p.Puede(Fil.Modelo.Enumerados.Accion.BajaUsuarios));
        Assert.IsTrue(p.Puede(Fil.Modelo.Enumerados.Accion.ModificacionUsuarios));

        //Obtengo una lista con todos los perfiles y verifico que este el q cree recien.
        IList<Perfil> list = PerfilHelper.ObtenerTodos();

        Assert.AreNotEqual(list.Count, 0);
        Assert.IsTrue(list.Contains(p));

        //Elimino el perfil de la base.
        p.Eliminar();

        //verifico que ya no lo traiga
        aux = null;
        aux = PerfilHelper.ObtenerPorId(p.Id);

        Assert.IsNull(aux);

        NHibernateManager.CommitTransaction();
      }
      catch (Exception ex)
      {
        NHibernateManager.RollbackTransaction();
        throw ex;
      }
    }

  }
}
