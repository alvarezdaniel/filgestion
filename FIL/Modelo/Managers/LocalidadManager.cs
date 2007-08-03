using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;

namespace Fil.Modelo.Managers
{
  internal abstract class LocalidadManager: BaseManager<Localidad>
  {

    public const string LOCALIDAD_ID = "id";

    /// <summary>
    /// Obtiene las localidades q se llaman parecido al texto a buscar
    /// </summary>
    /// <param name="like">texto a buscar</param>
    /// <returns></returns>
    internal static IList<Localidad> ObtenerLike(string like)
    {
      string strLike = like.Replace("%", "").Replace("'", "").Trim();
      strLike = "%" + strLike + "%";
      IList exp = new ArrayList();
      exp.Add(NHibernate.Expression.Expression.Like("Nombre", strLike).IgnoreCase());
      return NHibernateManager.GetObjectList<Localidad>(exp);
    }

  }
}
