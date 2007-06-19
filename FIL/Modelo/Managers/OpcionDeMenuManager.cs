using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;

namespace Fil.Modelo.Managers
{
  internal abstract class OpcionDeMenuManager
  {

    /// <summary>
    /// Obtiene de la base de datos una opcion de menú a partir de su id
    /// </summary>
    /// <param name="id">id de la opción de menú</param>
    /// <returns></returns>
    internal static OpcionDeMenu ObtenerPorId(int id)
    {
      Hashtable ht = new Hashtable(1);
      ht.Add("Id", id);
      OpcionDeMenu obj = NHibernateManager.GetUniqueObject<OpcionDeMenu>("OpcionDeMenu.ObtenerPorId", ht);
      return obj;
    }

    /// <summary>
    /// Obtiene de la base de datos una lista con todas las opciones de menú
    /// </summary>
    /// <returns></returns>
    internal static IList<Fil.Modelo.Entidades.OpcionDeMenu> ObtenerTodos()
    {
      Hashtable ht = new Hashtable();
      IList<OpcionDeMenu> lista = NHibernateManager.GetObjectList<OpcionDeMenu>("OpcionDeMenu.ObtenerTodos", ht);
      return lista;
    }

    /// <summary>
    /// Obtiene de la base de datos una lista con todas las opciones de menú raices (sin padre)
    /// </summary>
    /// <returns></returns>
    internal static IList<Fil.Modelo.Entidades.OpcionDeMenu> ObtenerRaices()
    {
      Hashtable ht = new Hashtable();
      IList<OpcionDeMenu> lista = NHibernateManager.GetObjectList<OpcionDeMenu>("OpcionDeMenu.ObtenerRaices", ht);
      return lista;
    }

  }
}
