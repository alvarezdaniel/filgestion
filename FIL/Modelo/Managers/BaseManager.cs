using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Fil.Modelo.Managers
{
  /// <summary>
  /// Manager Genérico.
  /// esta clase define los métodos generales de todos los managers
  /// </summary>
  internal abstract class BaseManager
  {

    /// <summary>
    /// Guarda un objeto en la base de datos
    /// </summary>
    /// <typeparam name="T">Clase del Objeto a guardar</typeparam>
    /// <param name="pObject">Objeto a guardar</param>
    internal static void Guardar<T>(T pObject)
    {
      NHibernateManager.SaveOrUpdateObject(pObject);
      NHibernateManager.NHSession.Refresh(pObject);
    }

    /// <summary>
    /// Elimina un objeto de la base de datos
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="pObject"></param>
    internal static void Eliminar<T>(T pObject)
    {
      NHibernateManager.DeleteObject(pObject);
    }

    /// <summary>
    /// Obtiene un objeto a partir de si clave
    /// </summary>
    /// <typeparam name="T">Clase del objeto</typeparam>
    /// <param name="nombreClave">Nombre del campo o propiedad clave</param>
    /// <param name="valorClave">Valor de la clave</param>
    /// <remarks>
    /// Atencion! El nombre de la clave tiene q ser la q se uso en el mapa.
    /// Verificar si se mapeo como ID el campo "id" o la propiedad "Id".
    /// </remarks>
    /// <returns>Objeto buscado</returns>
    internal static T ObtenerPorClave<T>(string nombreClave, string valorClave)
    {
      IList exp = new ArrayList();
      exp.Add(NHibernate.Expression.Expression.Eq(nombreClave, valorClave));
      T obj = default(T);
      IList<T> list = NHibernateManager.GetObjectList<T>(exp);
      if (list.Count == 1)
        obj = (T)list[0];
      return obj;
    }

    /// <summary>
    /// Obtiene una lista de objetos
    /// </summary>
    /// <typeparam name="T">Clase de los objetos buscados</typeparam>
    /// <returns>Lista de Objetos</returns>
    internal static IList<T> ObtenerTodos<T>()
    {
      IList<T> lista = NHibernateManager.GetObjectList<T>();
      return lista;
    }

  }
}
