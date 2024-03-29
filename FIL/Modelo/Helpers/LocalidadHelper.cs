using System;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;
using Fil.Modelo.Managers;

namespace Fil.Modelo.Helpers
{
  /// <summary>
  /// Esta clase es la encargada de administrar la l�gica de negocios de la clase Localidad
  /// </summary>
  public class LocalidadHelper : BaseHelper<Localidad>
  {

    public static new Boolean Validar(object pObj)
    {
      Localidad loc = (Localidad)pObj;
      if (loc.Nombre == null)
        return false;
      else
        return true;
    }

    public override void GuardarValido(Localidad pObjeto)
    {
      if (Validar(pObjeto))
        base.GuardarValido(pObjeto);
    }

    public static new void Guardar(Localidad pObjeto)
    {
      if (Validar(pObjeto))
        LocalidadManager.Guardar(pObjeto);
    }

    /// <summary>
    /// Obtiene una lista con todos los Paises
    /// </summary>
    /// <remarks>
    /// En este m�todo deber�n estar las validaciones de negocio que sean necesarias
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
