using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using NHibernate.Cfg;

namespace Fil.Modelo
{
  /// <summary>
  /// Esta clase se encarga de la interaccion con NHibernate
  /// </summary>
  public class NHibernateManager
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
    public static ISession NHSession
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
    public static void CloseSessionFactory()
    {
      if (nhFactory != null)
        nhFactory.Close();
    }

    /// <summary>
    /// Cierra la sesión actual
    /// </summary>
    public static void CloseSession()
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
    public static void BeginTransaction()
    {
      nhTransaction = NHSession.BeginTransaction();
    }

    /// <summary>
    /// Ejecuta las sentencias de la transacción
    /// </summary>
    public static void CommitTransaction()
    {
      nhTransaction.Commit();
      nhTransaction.Dispose();
    }

    /// <summary>
    /// Cancela la ejecución de la transacción
    /// </summary>
    public static void RollbackTransaction()
    {
      nhTransaction.Rollback();
      nhTransaction.Dispose();
    }

    /// <summary>
    /// Guarda un objeto en la base de datos
    /// </summary>
    /// <param name="objectToSave">Objeto a guardar</param>
    public static void SaveObject(object objectToSave)
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
    public static void UpdateObject(object objectToUpdate)
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
    /// Elimina un objeto de la base de datos
    /// </summary>
    /// <param name="objectToDelete">Objeto a eliminar</param>
    public static void DeleteObject(object objectToDelete)
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
    public static T GetUniqueObject<T>(string queryName, Hashtable parameters)
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
    /// Obtiene una lista de objetos de la base de datos
    /// </summary>
    /// <typeparam name="T">Tipo/Clase de los objetos a obtener</typeparam>
    /// <param name="queryName">Nombre de la consulta de HQL a ejecutar para recuperar los objetos</param>
    /// <param name="parameters">Coleccion de parámetros necesarios para ejecutar la consulta</param>
    /// <returns>Lista de objetos de tipo/clase T</returns>
    public static IList<T> GetObjectList<T>(string queryName, Hashtable parameters)
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

  }

}
