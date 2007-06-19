using System;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;
using Fil.Modelo.Managers;

namespace Fil.Modelo.Helpers
{

  /// <summary>
  /// Esta clase es la encargada de administrar la l�gica de negocios de la clase Usuario
  /// </summary>
  public abstract class OpcionDeMenuHelper
  {

    /// <summary>
    /// Obtiene la opcion de men� a partir de su ID
    /// </summary>
    /// <param name="id">ID de la opci�n de men� a obtener</param>
    /// <returns>Opci�n De Menu</returns>
    public static OpcionDeMenu ObtenerPorId(int id)
    {
      return OpcionDeMenuManager.ObtenerPorId(id);
    }

    /// <summary>
    /// Obtiene una lista con todas las opciones de men�
    /// </summary>
    /// <returns>Lista de Opciones De Men�</returns>
    public static IList<OpcionDeMenu> ObtenerTodos()
    {
      return OpcionDeMenuManager.ObtenerTodos();
    }

    /// <summary>
    /// Obtiene una lista con todas las opciones de men� raiz (que no tienen padre)
    /// </summary>
    /// <returns>Lista de Opciones De Men�</returns>
    public static IList<OpcionDeMenu> ObtenerRaices()
    {
      return OpcionDeMenuManager.ObtenerRaices();
    }

   
  }
}

