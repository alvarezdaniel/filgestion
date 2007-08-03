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
  /// Esta clase contiene los métodos para probar la lógica de negocio de la clase Cliente
  /// </summary>
  /// <remarks>
  /// Es utilizada por NUnit
  /// </remarks>
  [TestFixture]
  public class ClienteTest
  {

    [Test()]
    public void TestCompleto()
    {
      //Creo dos clientes
      Cliente c = new Cliente("mviegas", "Martín Alberto", "Viegas Barriga");
      Cliente c2 = new Cliente("clicli", "Cliente", "por defecto", 1985);

      //Los gurdo en la base
      ClienteHelper.Guardar(c);
      ClienteHelper.Guardar(c2);

      //Le agreo un dato al primer cliente
      c.AnioNacimiento = 1980;
      //Lo mando a guardar para que lo actualice
      ClienteHelper.Guardar(c);

      //Obtengo el cliente guardado
      Cliente c3 = ClienteHelper.ObtenerPorId(c.Id);

      //Me fijo que tengan los mismos datos
      Assert.AreEqual(c3.Autonumerico, c.Autonumerico);
      Assert.AreEqual(c3.Codigo, c.Codigo);
      Assert.AreEqual(c3.Nombres, c.Nombres);
      Assert.AreEqual(c3.Apellidos, c.Apellidos);
      Assert.AreEqual(c3.AnioNacimiento, c.AnioNacimiento);

      //Cambio el código del cliente y vuelvo a guardar
      c.Codigo = "MartinV";
      ClienteHelper.Guardar(c);
      
      //Vuelvo a traer el cliente guardado
      c3 = null;
      c3 = ClienteHelper.ObtenerPorId(c.Id);

      //Comparo que el cambio se haya reflejado
      Assert.AreEqual(c3.Codigo, c.Codigo);

      //Traigo todos y veo que no sea cero
      IList<Cliente> lista = ClienteHelper.ObtenerTodos();
      Assert.AreNotEqual(lista.Count, 0);

      //Elimino a los dos clientes
      ClienteHelper.Eliminar(c);
      ClienteHelper.Eliminar(c2);

      //Verifico que los haya eliminado
      c3 = null;
      c3 = ClienteHelper.ObtenerPorId(c.Id);
      Assert.IsNull(c3);

      c3 = null;
      c3 = ClienteHelper.ObtenerPorId(c2.Id);
      Assert.IsNull(c3);
    }
  }
}
