using System;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;
using Fil.Modelo.Managers;

namespace Fil.Modelo.Helpers
{
  /// <summary>
  /// Esta clase es la encargada de administrar la lógica de negocios de la clase Localidad
  /// </summary>
  public abstract class LocalidadHelper: BaseHelper<Localidad>
  {

    /// <summary>
    /// Obtiene una lista con todos los Paises
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <returns>Lista de Paises</returns>
    public static IList<Localidad> ObtenerLike(string like)
    {
      return LocalidadManager.ObtenerLike(like);
    }

    public static Localidad ObtenerPorId(object pId)
    {
      return ObtenerPorCampo(LocalidadManager.LOCALIDAD_ID, pId);
    }

  }
}
