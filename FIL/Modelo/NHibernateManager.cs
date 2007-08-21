using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Expression;

namespace Fil.Modelo
{
  /// <summary>
  /// Esta clase se encarga de la interaccion con NHibernate
  /// </summary>
  internal class NHibernateManager
  {
    private static ISessionFactory nhFactory;
    private static ITransaction nhTransaction;
    private static ISession nhSession;
    private static Configuration nhConfig;

    /// <summary>
    /// Constructor de clase
    /// </summary>
    static NHibernateManager()
    {
      nhConfig = new Configuration();
      nhConfig.Configure("hibernate.cfg.xml");
      nhFactory = nhConfig.BuildSessionFactory();
    }

    /// <summary>
    /// Sesión de NH
    /// </summary>
    internal static ISession NHSession
    {
      get
      {
        if (nhSession == null)
          nhSession = nhFactory.OpenSession();
        if (!nhSession.IsConnected || !nhSession.IsOpen)
        {
          nhSession.Dispose();
          nhSession = null;
          nhSession = nhFactory.OpenSession();
        }
        return nhSession;
      }
    }

    /// <summary>
    /// Cierra la session factory
    /// </summary>
    internal static void CloseSessionFactory()
    {
      if (nhFactory != null)
        nhFactory.Close();
    }

    /// <summary>
    /// Cierra la sesión actual
    /// </summary>
    internal static void CloseSession()
    {
      if (nhSession != null && nhSession.IsOpen)
      {
        nhSession.Close();
        nhSession = null;
      }
    }

    /// <summary>
    /// Inicia una transacción
    /// </summary>
    internal static void BeginTransaction()
    {
      nhTransaction = NHSession.BeginTransaction();
    }

    /// <summary>
    /// Ejecuta las sentencias de la transacción
    /// </summary>
    internal static void CommitTransaction()
    {
      nhTransaction.Commit();
      nhTransaction.Dispose();
    }

    /// <summary>
    /// Cancela la ejecución de la transacción
    /// </summary>
    internal static void RollbackTransaction()
    {
      nhTransaction.Rollback();
      nhTransaction.Dispose();
    }

    /// <summary>
    /// Guarda un objeto en la base de datos
    /// </summary>
    /// <param name="objectToSave">Objeto a guardar</param>
    [Obsolete("No usar mas. En su lugar usar SaveOrUpdate().")]
    internal static void SaveObject(object objectToSave)
    {
      try
      {
        ISession session = NHSession;

        session.Save(objectToSave);
        session.Flush();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    /// <summary>
    /// Actualiza un objeto en la base de datos
    /// </summary>
    /// <param name="objectToUpdate">Objeto a actualizar</param>
    [Obsolete("No usar mas. En su lugar usar SaveOrUpdate().")]
    internal static void UpdateObject(object objectToUpdate)
    {
      try
      {
        ISession session = NHSession;

        session.Update(objectToUpdate);
        session.Flush();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    /// <summary>
    /// Guarda o Actualiza un objeto en la base de datos dependiendo de si ya existe o no.
    /// </summary>
    /// <param name="objectToSaveOrUpdate">Objeto en cuestion</param>
    internal static void SaveOrUpdateObject(object objectToSaveOrUpdate)
    {
      try
      {
        ISession session = NHSession;

        session.SaveOrUpdate(objectToSaveOrUpdate);
        session.Flush();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    /// <summary>
    /// Elimina un objeto de la base de datos
    /// </summary>
    /// <param name="objectToDelete">Objeto a eliminar</param>
    internal static void DeleteObject(object objectToDelete)
    {
      try
      {
        ISession session = NHSession;

        session.Delete(objectToDelete);
        session.Flush();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    /// <summary>
    /// Obtiene un unico objeto de la base de datos
    /// </summary>
    /// <typeparam name="T">Tipo/Clase del objeto a obtener</typeparam>
    /// <param name="queryName">Nombre de la consulta de HQL a ejecutar para recuperar el objeto</param>
    /// <param name="parameters">Coleccion de parámetros necesarios para ejecutar la consulta</param>
    /// <returns>Objeto de tipo/clase T</returns>
    [Obsolete("Este metodo se va a dejar de usar. En su lugar se deberia usar GetObjectList<T>() y pasar como parametro el Id. Ver PaisManager.ObtenerPorId(...).")]
    internal static T GetUniqueObject<T>(string queryName, Hashtable parameters)
    {
      try
      {
        ISession session = NHSession;
        IQuery query = session.GetNamedQuery(queryName);
        IEnumerator e = parameters.GetEnumerator();
        while (e.MoveNext())
        {
          query.SetParameter(((DictionaryEntry)e.Current).Key.ToString(), ((DictionaryEntry)e.Current).Value);
        }
        T result = query.UniqueResult<T>();
        return result;
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    /// <summary>
    /// Devuelve una lista de objetos de la clase T que cumple con los criterios
    /// </summary>
    /// <typeparam name="T">Clase de los objetos a retornar</typeparam>
    /// <returns>Lista de objetos</returns>
    internal static IList<T> GetObjectList<T>()
    {
      try
      {
        ISession session = NHSession;
        ICriteria criteria = session.CreateCriteria(typeof(T));
        IList<T> result = criteria.List<T>();
        return result;
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    /// <summary>
    /// Devuelve una lista de objetos de la clase T que cumple con los criterios
    /// </summary>
    /// <typeparam name="T">Clase de los objetos a retornar</typeparam>
    /// <param name="expressions">Lista de expresiones</param>
    /// <returns>Lista de objetos</returns>
    internal static IList<T> GetObjectList<T>(IList expressions)
    {
      try
      {
        ISession session = NHSession;
        ICriteria criteria = session.CreateCriteria(typeof(T));
        foreach(ICriterion exp in expressions){
          criteria.Add(exp);
        }
        IList<T> result = criteria.List<T>();
        return result;
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    /// <summary>
    /// Devuelve una lista de objetos de la clase T que cumple con los criterios
    /// </summary>
    /// <typeparam name="T">Clase de los objetos a retornar</typeparam>
    /// <param name="expressions">Lista de expresiones</param>
    /// <param name="orders">Lista de expresiones de ordenamiento</param>
    /// <returns>Lista de objetos</returns>
    internal static IList<T> GetObjectList<T>(IList expressions, IList orders)
    {
      try
      {
        ISession session = NHSession;
        ICriteria criteria = session.CreateCriteria(typeof(T));
        foreach (ICriterion exp in expressions)
        {
          criteria.Add(exp);
        }
        foreach (Order ord in orders)
        {
          criteria.AddOrder(ord);
        }
        IList<T> result = criteria.List<T>();
        return result;
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    /// <summary>
    /// Obtiene una lista de objetos de la base de datos
    /// </summary>
    /// <typeparam name="T">Tipo/Clase de los objetos a obtener</typeparam>
    /// <param name="queryName">Nombre de la consulta de HQL a ejecutar para recuperar los objetos</param>
    /// <param name="parameters">Coleccion de parámetros necesarios para ejecutar la consulta</param>
    /// <returns>Lista de objetos de tipo/clase T</returns>
    [Obsolete("Este metodo se va a dejar de usar. En su lugar se deberian usar las otras sobrecargas.")]
    internal static IList<T> GetObjectList<T>(string queryName, Hashtable parameters)
    {
      try
      {
        ISession session = NHSession;
        IQuery query = session.GetNamedQuery(queryName);
        IEnumerator e = parameters.GetEnumerator();
        while (e.MoveNext())
        {
          query.SetParameter(e.Current.ToString(), parameters[e.Current]);
        }
        IList<T> lista = query.List<T>();
        return lista;
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public static ICollection Mapeos
    {
      get { return nhConfig.ClassMappings; }
    }

    public static IList EjecutarQuery(string query)
    {
      IQuery qry = NHSession.CreateQuery(query);
      return qry.List();
    }
  }

}
