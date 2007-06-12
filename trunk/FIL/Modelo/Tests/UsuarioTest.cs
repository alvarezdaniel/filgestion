using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Fil.Modelo.Entidades;
using Fil.Modelo.Helpers;

namespace Fil.Modelo.Tests
{
  [TestFixture()]
  public class UsuarioTest
  {
    [Test()]
    public void UsuarioTestCopleto()
    {
      //Creo el usuario
      Usuario usuario = new Usuario("UserName Test", "Nombres Test", "Apellidos Test");

      NHibernateManager.BeginTransaction();

      try
      {

        //Lo guardo
        usuario.Guardar();

        //Recupero el codigo generado
        string id = usuario.Id;

        //Verifico el codigo y el nombre
        Assert.AreNotEqual(id, String.Empty);
        Assert.AreEqual(usuario.Username, "UserName Test");
        Assert.AreEqual(usuario.Nombres, "Nombres Test");
        Assert.AreEqual(usuario.Apellidos, "Apellidos Test");

        //Busco el usuario
        usuario = null;
        usuario = UsuarioHelper.ObtenerPorId(id);

        //Verifico q lo haya traido y el nombre sea el esperado
        Assert.IsNotNull(usuario);
        Assert.AreEqual(usuario.Username, "UserName Test");
        Assert.AreEqual(usuario.Nombres, "Nombres Test");
        Assert.AreEqual(usuario.Apellidos, "Apellidos Test");

        //Le cambio el nombre y lo actualizo
        usuario.Username = "UserName Test 2";
        usuario.Nombres = "Nombres Test 2";
        usuario.Apellidos = "Apellidos Test 2";
        usuario.Actualizar();

        //Busco el usuario
        usuario = null;
        usuario = UsuarioHelper.ObtenerPorId(id);

        //Verifico q lo haya traido y el nombre sea el nuevo
        Assert.IsNotNull(usuario);
        Assert.AreEqual(usuario.Username, "UserName Test 2");
        Assert.AreEqual(usuario.Nombres, "Nombres Test 2");
        Assert.AreEqual(usuario.Apellidos, "Apellidos Test 2");

        //Verifico que la lista de todos los usuarios traiga algo
        IList<Usuario> lista = UsuarioHelper.ObtenerTodos();
        Assert.IsNotEmpty((IList)lista);

        //Verifico que entre todos este el que cree.
        Assert.IsTrue(lista.Contains(usuario));

        //Borro el usuario
        usuario.Eliminar();

        //Busco el usuario
        usuario = null;
        usuario = UsuarioHelper.ObtenerPorId(id);

        //Verifico que no lo haya encontrado
        Assert.IsNull(usuario);

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
