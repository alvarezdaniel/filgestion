using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;

namespace Fil.Modelo.Managers
{

  internal abstract class PaisManager
  {

    /// <summary>
    /// Guarda la instancia del objeto en la base de datos
    /// </summary>
    /// <param name="pPais">Pais a guardar</param>
    internal static void Guardar(Pais pPais)
    {
      NHibernateManager.SaveObject(pPais);
      NHibernateManager.NHSession.Refresh(pPais);
    }

    /// <summary>
    /// Actualiza la instancia del objeto en la base de datos
    /// </summary>
    /// <param name="pPais">Pais a actualizar</param>
    internal static void Actualizar(Pais pPais)
    {
      NHibernateManager.UpdateObject(pPais);
    }

    /// <summary>
    /// Elimina la instancia del objeto de la base de datos
    /// </summary>
    /// <param name="pPais">Pais a eliminar</param>
    internal static void Eliminar(Pais pPais)
    {
      NHibernateManager.DeleteObject(pPais);
    }

    /// <summary>
    /// Obtiene el Pais de la base de datos a partir de su Id
    /// </summary>
    /// <param name="id">Id de el Pais a recuperar</param>
    /// <returns>Pais</returns>
    internal static Pais ObtenerPorId(string id)
    {
      Hashtable ht = new Hashtable(1);
      ht.Add("Id", id);
      Pais a = NHibernateManager.GetUniqueObject<Pais>("Pais.ObtenerPorId", ht);
      return a;
    }

    /// <summary>
    /// Obtiene una lista con todas los Paises de la base de datos
    /// </summary>
    /// <returns>Lista de Paises</returns>
    internal static IList<Pais> ObtenerTodos()
    {
      Hashtable ht = new Hashtable();
      IList<Pais> lista = NHibernateManager.GetObjectList<Pais>("Pais.ObtenerTodos", ht);
      return lista;
    }

  }
}
