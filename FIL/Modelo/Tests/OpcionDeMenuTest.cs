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
  public class OpcionDeMenuTest
  {

    [Test]
    public void TestCompleto(){

      try
      {
        IList<OpcionDeMenu> opciones = OpcionDeMenuHelper.ObtenerTodos();
        Assert.AreNotEqual(opciones.Count, 0);

        //Pruebo levantar una opción por su Id
        //Levanto la opción 2: Usuarios
        OpcionDeMenu opm = OpcionDeMenuHelper.ObtenerPorId(2);
        Assert.AreEqual(opm.Accion, Enumerados.Accion.ConsultaUsuarios);
        Assert.AreEqual(opm.Descripcion, "Usuarios");

      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    [Test]
    public void TestArmadoDeMenu()
    {

      try
      {
        IList<OpcionDeMenu> raices = OpcionDeMenuHelper.ObtenerRaices();
        Assert.AreNotEqual(raices.Count, 0);

        //Imprimo el menu
        ImprimirOpciones(raices, 0);

      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    private void ImprimirOpciones(ICollection<OpcionDeMenu> opciones, int nivel)
    {
        //simulo el armado del menu recorriendo los hijos
        foreach (OpcionDeMenu opm in opciones)
        {
          StringBuilder sb = new StringBuilder();
          System.Console.WriteLine(sb.Append('\t', nivel) + opm.Descripcion);
          ImprimirOpciones(opm.Hijos, nivel + 1);
        }
    }

    private void ImprimirOpciones(ICollection opciones, int nivel)
    {
      //simulo el armado del menu recorriendo los hijos
      foreach (OpcionDeMenu opm in opciones)
      {
        StringBuilder sb = new StringBuilder();
        System.Console.WriteLine(sb.Append('\t', nivel) + opm.Descripcion);
        ImprimirOpciones(opm.Hijos, nivel + 1);
      }
    }
  }
}
