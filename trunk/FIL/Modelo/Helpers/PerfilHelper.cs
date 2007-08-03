using System;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;
using Fil.Modelo.Managers;
using Fil.Modelo.Enumerados;

namespace Fil.Modelo.Helpers
{
  /// <summary>
  /// Esta clase es la encargada de administrar la lógica de negocios de la clase Perfil
  /// </summary>
  public abstract class PerfilHelper: BaseHelper<Perfil>
  {

    public static Perfil ObtenerPorId(object pId)
    {
      return ObtenerPorCampo(PerfilManager.PERFIL_ID, pId);
    }

    /// <summary>
    /// Devuelve un perfil con todas las acciones asignadas
    /// </summary>
    /// <returns></returns>
    internal static Perfil GetSuperPerfil()
    {
      Perfil pfl = new Perfil(Perfil.SUPERPERFIL_NOMBRE);
      foreach(Accion acn in Enum.GetValues(typeof(Accion))){
        pfl.AgregarAccion(acn);
      }
      return pfl;
    }
  }
}
