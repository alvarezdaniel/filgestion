using System;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;
using Fil.Modelo.Managers;

namespace Fil.Modelo.Helpers
{
  /// <summary>
  /// Esta clase es la encargada de administrar la lógica de negocios de la clase UnidadDeGestion
  /// </summary>
  public abstract class UnidadDeGestionHelper: BaseHelper<UnidadDeGestion>
  {

    public static UnidadDeGestion ObtenerPorId(object pId)
    {
      return ObtenerPorCampo(UnidadDeGestionManager.UNIDAD_DE_GESTION_ID, pId);
    }

    /// <summary>
    /// Devuelve una unidad de gestion virtual. No se puede guardar o eliminar de la base.
    /// </summary>
    /// <returns></returns>
    internal static UnidadDeGestion GetUnidadVirtual()
    {
      return new UnidadDeGestion(UnidadDeGestion.UNIDADVIRTUAL_NOMBRE);
    }
  }
}
