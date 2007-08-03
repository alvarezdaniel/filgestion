using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;

namespace Fil.Modelo.Managers
{
  internal abstract class OpcionDeMenuManager: BaseManager<OpcionDeMenu>
  {

    public const string OPCION_DE_MENU_ID = "id";

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
