using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;

namespace Fil.Modelo.Managers
{
  /// <summary>
  /// Manager de Paises. Se encarga de interactuar con la base para el manejo de paises
  /// </summary>
  internal abstract class PaisManager : BaseManager
  {

    /// <summary>
    /// Obtiene los paises q se llaman parecido al texto a buscar
    /// </summary>
    /// <param name="like">texto a buscar</param>
    /// <returns></returns>
    internal static IList<Pais> ObtenerLike(string like)
    {
      string strLike = like.Replace("%","").Replace("'","").Trim();
      strLike = "%" + strLike + "%";
      IList exp = new ArrayList();
      exp.Add(NHibernate.Expression.Expression.Like("Nombre", strLike).IgnoreCase());
      return NHibernateManager.GetObjectList<Pais>(exp);
    }


    internal static void Guardar(Pais pPais)
    {
      Guardar<Pais>(pPais);
    }

    internal static void Eliminar(Pais pPais)
    {
      Eliminar<Pais>(pPais);
    }

    internal static Pais ObtenerPorId(string pId)
    {
      return ObtenerPorClave<Pais>("id", pId);
    }

    internal static IList<Pais> ObtenerTodos()
    {
      return ObtenerTodos<Pais>();
    }
    
  }

}
