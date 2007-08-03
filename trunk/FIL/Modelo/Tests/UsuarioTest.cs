using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Fil.Modelo.Entidades;
using Fil.Modelo.Helpers;

namespace Fil.Modelo.Tests
{
  /// <summary>
  /// Esta clase contiene los métodos para probar la lógica de negocio de la clase Usuario
  /// </summary>
  /// <remarks>
  /// Es utilizada por NUnit
  /// </remarks>
  [TestFixture()]
  public class UsuarioTest
  {
    private UnidadDeGestion ug1;
    private UnidadDeGestion ug2;
    private Perfil pf1;
    private Perfil pf2;

    /// <summary>
    /// Prueba completa de la clase Usuario
    /// </summary>
    [Test()]
    public void UsuarioTestCopleto()
    {
      try
      {
        NHibernateManager.BeginTransaction();

        //Creo el usuario
        Usuario usuario = new Usuario("UserName Test", "Nombres Test", "Apellidos Test", "asdf1234");
        
        //Creo un par de perfiles y unidades de gestion y se los asigno
        this.ug1 = new UnidadDeGestion("UG1");
        UnidadDeGestionHelper.Guardar(ug1);
        this.ug2 = new UnidadDeGestion("UG2");
        UnidadDeGestionHelper.Guardar(ug2);

        this.pf1 = new Perfil("Perfil Test 1");
        pf1.AgregarAccion(Fil.Modelo.Enumerados.Accion.ConsultaUsuarios); 
        pf1.AgregarAccion(Fil.Modelo.Enumerados.Accion.AltaUsuarios);
        PerfilHelper.Guardar(pf1);
        this.pf2 = new Perfil("Perfil Test 2");
        pf1.AgregarAccion(Fil.Modelo.Enumerados.Accion.ConsultaUsuarios); 
        pf1.AgregarAccion(Fil.Modelo.Enumerados.Accion.ModificacionUsuarios);
        PerfilHelper.Guardar(pf2);

        usuario.AsignarPerfil(pf1, ug1);
        usuario.AsignarPerfil(pf2, ug1);
        usuario.AsignarPerfil(pf2, ug2);

        //Lo guardo
        UsuarioHelper.Guardar(usuario);

        //Recupero el codigo generado
        string id = usuario.Id;

        //Busco el usuario
        usuario = null;
        usuario = UsuarioHelper.ObtenerPorId(id);

        //Verifico q lo haya traido y el nombre sea el esperado
        Assert.IsNotNull(usuario);
        Assert.AreEqual(usuario.Username, "UserName Test");
        Assert.AreEqual(usuario.Nombres, "Nombres Test");
        Assert.AreEqual(usuario.Apellidos, "Apellidos Test");
        Assert.AreEqual(usuario.Password, "asdf1234");

        //Verifico que pueda realizar acciones
        Assert.IsTrue(usuario.Puede(Fil.Modelo.Enumerados.Accion.AccionNula, ug1)); 
        Assert.IsTrue(usuario.Puede(Fil.Modelo.Enumerados.Accion.AccionNula, ug2)); 
        Assert.IsTrue(usuario.Puede(Fil.Modelo.Enumerados.Accion.AltaUsuarios, ug1)); 
        Assert.IsFalse(usuario.Puede(Fil.Modelo.Enumerados.Accion.AltaUsuarios, ug2)); 

        //Le cambio el nombre y lo actualizo
        usuario.Username = "UserName Test 2";
        usuario.Nombres = "Nombres Test 2";
        usuario.Apellidos = "Apellidos Test 2";
        usuario.Password = "4321fdsa";

        //Le quito algunos perfiles
        usuario.QuitarPerfil(pf1, ug1);
        usuario.QuitarPerfil(pf2, ug1);

        UsuarioHelper.Eliminar(usuario);

        //Busco el usuario
        usuario = null;
        usuario = UsuarioHelper.ObtenerPorId(id);

        //Verifico q lo haya traido y el nombre sea el nuevo
        Assert.IsNotNull(usuario);
        Assert.AreEqual(usuario.Username, "UserName Test 2");
        Assert.AreEqual(usuario.Nombres, "Nombres Test 2");
        Assert.AreEqual(usuario.Apellidos, "Apellidos Test 2");
        Assert.AreEqual(usuario.Password, "4321fdsa");

        //Verifico que pueda realizar acciones
        Assert.IsFalse(usuario.Puede(Fil.Modelo.Enumerados.Accion.ConsultaUsuarios, ug1));
        Assert.IsFalse(usuario.Puede(Fil.Modelo.Enumerados.Accion.AltaUsuarios, ug1));

        //Verifico que la lista de todos los usuarios traiga algo
        IList<Usuario> lista = UsuarioHelper.ObtenerTodos();
        Assert.IsNotEmpty((IList)lista);

        //Verifico que entre todos este el que cree.
        Assert.IsTrue(lista.Contains(usuario));

        //Borro el usuario
        UsuarioHelper.Eliminar(usuario);

        //Busco el usuario
        usuario = null;
        usuario = UsuarioHelper.ObtenerPorId(id);

        //Verifico que no lo haya encontrado
        Assert.IsNull(usuario);

        //Elimino las UG's y los perfiles
        UnidadDeGestionHelper.Eliminar(ug1);
        UnidadDeGestionHelper.Eliminar(ug2);
        PerfilHelper.Eliminar(pf1);
        PerfilHelper.Eliminar(pf2);

        NHibernateManager.CommitTransaction();
      }
      catch (Exception ex)
      {
        NHibernateManager.RollbackTransaction();

        System.Console.Write(ex.Message);

        throw ex;
      }
    }

  }
}
