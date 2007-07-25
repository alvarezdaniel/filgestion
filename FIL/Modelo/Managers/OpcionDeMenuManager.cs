using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;

namespace Fil.Modelo.Managers
{
  internal abstract class OpcionDeMenuManager: BaseManager
  {

    /// <summary>
    /// Obtiene de la base de datos una opcion de menú a partir de su id
    /// </summary>
    /// <param name="id">id de la opción de menú</param>
    /// <returns></returns>
    internal static OpcionDeMenu ObtenerPorId(int id)
    {
      return ObtenerPorClave<OpcionDeMenu>("id", id);
    }

    /// <summary>
    /// Obtiene de la base de datos una lista con todas las opciones de menú
    /// </summary>
    /// <returns></returns>
    internal static IList<OpcionDeMenu> ObtenerTodos()
    {
      return ObtenerTodos<OpcionDeMenu>();
    }

    /// <summary>
    /// Obtiene de la base de datos una lista con todas las opciones de menú raices (sin padre)
    /// </summary>
    /// <returns></returns>
    internal static IList<OpcionDeMenu> ObtenerRaices()
    {
      IList exp = new ArrayList();
      exp.Add(NHibernate.Expression.Expression.IsNull("Padre"));
      IList ord = new ArrayList();
      ord.Add(NHibernate.Expression.Order.Asc("Orden"));
      return NHibernateManager.GetObjectList<OpcionDeMenu>(exp, ord);
    }

  }
}
