using System;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;
using Fil.Modelo.Managers;

namespace Fil.Modelo.Helpers
{
  /// <summary>
  /// Esta clase es la encargada de administrar la lógica de negocios de la clase Pais
  /// </summary>
  public abstract class PaisHelper: BaseHelper<Pais>
  {

    public static Pais ObtenerPorId(object pId)
    {
      return ObtenerPorCampo(PaisManager.PAIS_ID, pId);
    }

    /// <summary>
    /// Obtiene una lista con todos los Paises
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <returns>Lista de Paises</returns>
    public static IList<Pais> ObtenerLike(string like)
    {
      return PaisManager.ObtenerLike(like);
    }

  }
}
