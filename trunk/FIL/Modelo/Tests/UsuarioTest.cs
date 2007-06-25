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
  /// Esta clase contiene los m�todos para probar la l�gica de negocio de la clase Usuario
  /// </summary>
  /// <remarks>
  /// Es utilizada por NUnit
  /// </remarks>
  [TestFixture()]
  public class UsuarioTest
  {
    /// <summary>
    /// Prueba completa de la clase Usuario
    /// </summary>
    [Test()]
    public void UsuarioTestCopleto()
    {
      //Creo el usuario
      Usuario usuario = new Usuario("UserName Test", "Nombres Test", "Apellidos Test", "asdf1234");

      NHibernateManager.BeginTransaction();

      try
      {

        //Lo guardo
        usuario.Guardar();

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

        //Le cambio el nombre y lo actualizo
        usuario.Username = "UserName Test 2";
        usuario.Nombres = "Nombres Test 2";
        usuario.Apellidos = "Apellidos Test 2";
        usuario.Password = "4321fdsa";
        usuario.Guardar();

        //Busco el usuario
        usuario = null;
        usuario = UsuarioHelper.ObtenerPorId(id);

        //Verifico q lo haya traido y el nombre sea el nuevo
        Assert.IsNotNull(usuario);
        Assert.AreEqual(usuario.Username, "UserName Test 2");
        Assert.AreEqual(usuario.Nombres, "Nombres Test 2");
        Assert.AreEqual(usuario.Apellidos, "Apellidos Test 2");
        Assert.AreEqual(usuario.Password, "4321fdsa");

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