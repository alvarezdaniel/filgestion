using System;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Managers;
using Fil.Modelo.Entidades;

namespace Fil.Modelo.Helpers
{
  public abstract class BaseHelper<T> 
  {

    public static void Guardar(T pObjeto)
    {
      BaseManager<T>.Guardar(pObjeto);
    }

    public static void Eliminar(T pObjeto)
    {
      BaseManager<T>.Eliminar(pObjeto);
    }

    public static T ObtenerPorCampo(string pNombreCampo, object pValorCampo)
    {

      return BaseManager<T>.ObtenerPorCampo(pNombreCampo, pValorCampo);
    }

    public static IList<T> ObtenerTodos()
    {
      return BaseManager<T>.ObtenerTodos();
    }
  }
}
