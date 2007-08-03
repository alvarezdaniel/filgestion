using System;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;
using Fil.Modelo.Managers;

namespace Fil.Modelo.Helpers
{

  /// <summary>
  /// Esta clase es la encargada de administrar la lógica de negocios de la clase Usuario
  /// </summary>
  public abstract class OpcionDeMenuHelper: BaseHelper<OpcionDeMenu>
  {

    public static OpcionDeMenu ObtenerPorId(object pId)
    {
      return ObtenerPorCampo(OpcionDeMenuManager.OPCION_DE_MENU_ID, pId);
    }

    /// <summary>
    /// Obtiene una lista con todas las opciones de menú raiz (que no tienen padre)
    /// </summary>
    /// <returns>Lista de Opciones De Menú</returns>
    public static IList<OpcionDeMenu> ObtenerRaices()
    {
      return OpcionDeMenuManager.ObtenerRaices();
    }

  }
}

