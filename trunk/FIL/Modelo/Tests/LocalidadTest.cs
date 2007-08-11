using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Fil.Modelo.Entidades;
using Fil.Modelo.Helpers;


namespace Fil.Modelo.Tests
{
  [TestFixture()]
  public class LocalidadTest
  {
    [Test()]
    public void TestCompleto()
    {
      try
      {
        NHibernateManager.BeginTransaction();

        Localidad p = new Localidad("Localidad Test xxxx");
        LocalidadHelper lh = new LocalidadHelper();
        lh.GuardarValido(p);

        Localidad Localidad2 = LocalidadHelper.ObtenerPorId(p.Id);

        Assert.AreEqual(p.Nombre, Localidad2.Nombre);
        Assert.AreEqual(p.Autonumerico, Localidad2.Autonumerico);
        Assert.AreEqual(p.CodigoPostal, Localidad2.CodigoPostal);

        p.Nombre = "Localidad Test 2 xxxx";
        p.CodigoPostal = "1636 xxxx";
        LocalidadHelper.Guardar(p);

        Localidad2 = null;
        Localidad2 = LocalidadHelper.ObtenerPorId(p.Id);

        Assert.AreEqual(p.Nombre, Localidad2.Nombre);
        Assert.AreEqual(p.Autonumerico, Localidad2.Autonumerico);

        IList<Localidad> lista = LocalidadHelper.ObtenerTodos();
        Assert.AreNotEqual(lista.Count, 0);

        LocalidadHelper.Eliminar(p);

        Localidad2 = null;
        Localidad2 = LocalidadHelper.ObtenerPorId(p.Id);

        Assert.IsNull(Localidad2);

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
        Localidad olivos = new Localidad("Olivos");
        LocalidadHelper.Guardar(olivos);

        Localidad olivares = new Localidad("Olivares");
        LocalidadHelper.Guardar(olivares);
        
        Localidad carupa = new Localidad("Carupá");
        LocalidadHelper.Guardar(carupa);
        
        Localidad matanza = new Localidad("Matanza");
        LocalidadHelper.Guardar(matanza);
        
        Localidad mataderos = new Localidad("Mataderos");
        LocalidadHelper.Guardar(mataderos);
        

        //Hago consultas por el parecido del nombre
        IList<Localidad> list;

        //Busco paises con "oli"
        list = LocalidadHelper.ObtenerLike("oli");
        Assert.AreEqual(list.Count, 2);
        //Busco paises con "mata"
        list = LocalidadHelper.ObtenerLike("mata");
        Assert.AreEqual(list.Count, 2);
        //Busco paises con "up"
        list = LocalidadHelper.ObtenerLike("up");
        Assert.AreEqual(list.Count, 1);

        //Elimino las localidades 
        LocalidadHelper.Eliminar(olivos);
        LocalidadHelper.Eliminar(olivares);
        LocalidadHelper.Eliminar(mataderos);
        LocalidadHelper.Eliminar(matanza);
        LocalidadHelper.Eliminar(carupa);
                
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
