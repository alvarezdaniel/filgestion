using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;

namespace Fil.Modelo.Managers
{

  internal abstract class UnidadDeGestionManager
  {

    /// <summary>
    /// Guarda la instancia del objeto en la base de datos
    /// </summary>
    /// <param name="pUnidadDeGestion">Unidad De Gestion a guardar</param>
    internal static void Guardar(UnidadDeGestion pUnidadDeGestion)
    {
      NHibernateManager.SaveObject(pUnidadDeGestion);
      NHibernateManager.NHSession.Refresh(pUnidadDeGestion);
    }

    /// <summary>
    /// Actualiza la instancia del objeto en la base de datos
    /// </summary>
    /// <param name="pUnidadDeGestion">UnidadDeGestion a actualizar</param>
    internal static void Actualizar(UnidadDeGestion pUnidadDeGestion)
    {
      NHibernateManager.UpdateObject(pUnidadDeGestion);
    }

    /// <summary>
    /// Elimina la instancia del objeto de la base de datos
    /// </summary>
    /// <param name="pUnidadDeGestion">UnidadDeGestion a eliminar</param>
    internal static void Eliminar(UnidadDeGestion pUnidadDeGestion)
    {
      NHibernateManager.DeleteObject(pUnidadDeGestion);
    }

    /// <summary>
    /// Obtiene una Unidad De Gestion de la base de datos a partir de su Id
    /// </summary>
    /// <param name="id">Id de la Unidad De Gestion a recuperar</param>
    /// <returns>UnidadDeGestion</returns>
    internal static UnidadDeGestion ObtenerPorId(string id)
    {
      Hashtable ht = new Hashtable(1);
      ht.Add("Id", id);
      UnidadDeGestion a = NHibernateManager.GetUniqueObject<UnidadDeGestion>("UnidadDeGestion.ObtenerPorId", ht);
      return a;
    }

    /// <summary>
    /// Obtiene una lista con todas las Unidades De Gestion de la base de datos
    /// </summary>
    /// <returns>Lista de Unidades De Gestions</returns>
    internal static IList<UnidadDeGestion> ObtenerTodos()
    {
      Hashtable ht = new Hashtable();
      IList<UnidadDeGestion> lista = NHibernateManager.GetObjectList<UnidadDeGestion>("UnidadDeGestion.ObtenerTodos", ht);
      return lista;
    }

  }
}
