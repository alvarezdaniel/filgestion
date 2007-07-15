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
      Pais p = new Pais("Pais Test");
      p.Guardar();

      Pais pais2 = PaisHelper.ObtenerPorId(p.Id);

      Assert.AreEqual(p.Nombre, pais2.Nombre);
      Assert.AreEqual(p.Autonumerico, pais2.Autonumerico);

      p.Nombre = "Pais Test 2";
      p.Guardar();

      pais2 = null;
      pais2 = PaisHelper.ObtenerPorId(p.Id);

      Assert.AreEqual(p.Nombre, pais2.Nombre);
      Assert.AreEqual(p.Autonumerico, pais2.Autonumerico);

      IList<Pais> lista = PaisHelper.ObtenerTodos();
      Assert.AreNotEqual(lista.Count, 0);

      p.Eliminar();

      pais2 = null;
      pais2 = PaisHelper.ObtenerPorId(p.Id);

      Assert.IsNull(pais2);

    }
  }
}
