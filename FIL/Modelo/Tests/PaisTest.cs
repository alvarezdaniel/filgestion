using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Fil.Modelo.Entidades;
using Fil.Modelo.Helpers;

namespace Fil.Modelo.Tests
{
  [TestFixture()]
  public class PaisTest
  {

    [Test()]
    public void TestCompleto()
    {
      try
      {

        NHibernateManager.BeginTransaction();

        Pais p = new Pais("Pais Test");
        PaisHelper.Guardar(p);

        Pais pais2 = PaisHelper.ObtenerPorId(p.Id);

        Assert.AreEqual(p.Nombre, pais2.Nombre);
        Assert.AreEqual(p.Autonumerico, pais2.Autonumerico);

        p.Nombre = "Pais Test 2";
        PaisHelper.Guardar(p);

        pais2 = null;
        pais2 = PaisHelper.ObtenerPorId(p.Id);

        Assert.AreEqual(p.Nombre, pais2.Nombre);
        Assert.AreEqual(p.Autonumerico, pais2.Autonumerico);

        IList<Pais> lista = PaisHelper.ObtenerTodos();
        Assert.AreNotEqual(lista.Count, 0);

        PaisHelper.Eliminar(p);

        pais2 = null;
        pais2 = PaisHelper.ObtenerPorId(p.Id);

        Assert.IsNull(pais2);

        NHibernateManager.CommitTransaction();
      }
      catch
      {
        NHibernateManager.RollbackTransaction();
        throw;
      }
    }

    [Test()]
    public void TestObtenerLike()
    {
      try
      {
        NHibernateManager.BeginTransaction();

        //Creo varios paises
        Pais austria = new Pais("Austria");
        PaisHelper.Guardar(austria);
        Pais australia = new Pais("Australia");
        PaisHelper.Guardar(australia);
        Pais argentina = new Pais("Argentina");
        PaisHelper.Guardar(argentina);
        Pais chile = new Pais("Chile");
        PaisHelper.Guardar(chile);
        Pais china = new Pais("China");
        PaisHelper.Guardar(china);


        //Hago consultas por el parecido del nombre
        IList<Pais> list;

        //Busco paises con "aus"
        list = PaisHelper.ObtenerLike("aus");
        Assert.AreEqual(list.Count, 2);
        //Busco paises con "chi"
        list = PaisHelper.ObtenerLike("chi");
        Assert.AreEqual(list.Count, 2);
        //Busco paises con "ina"
        list = PaisHelper.ObtenerLike("ina");
        Assert.AreEqual(list.Count, 2);

        //Elimino los paises
        PaisHelper.Eliminar(austria);
        PaisHelper.Eliminar(australia);
        PaisHelper.Eliminar(argentina);
        PaisHelper.Eliminar(chile);
        PaisHelper.Eliminar(china);


        NHibernateManager.CommitTransaction();
      }
      catch
      {
        NHibernateManager.RollbackTransaction();
        throw;
      }
    }
  }
}
