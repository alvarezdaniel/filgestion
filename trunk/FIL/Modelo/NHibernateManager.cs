using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using NHibernate.Cfg;

namespace Fil.Modelo
{
  public class NHibernateManager
  {
    private static ISessionFactory nhFactory;
    private static ITransaction nhTransaction;
    private static ISession nhSession;
    private static Configuration nhConfig;

    static NHibernateManager()
    {
      nhConfig = new Configuration();
      nhConfig.Configure("hibernate.cfg.xml");
      nhFactory = nhConfig.BuildSessionFactory();
    }

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

    public static void CloseSessionFactory()
    {
      if (nhFactory != null)
        nhFactory.Close();
    }

    public static void CloseSession()
    {
      nhSession.Close();
      nhSession = null;
    }

    public static void BeginTransaction()
    {
      nhTransaction = NHSession.BeginTransaction();
    }

    public static void CommitTransaction()
    {
      nhTransaction.Commit();
      nhTransaction.Dispose();
    }

    public static void RollbackTransaction()
    {
      nhTransaction.Rollback();
      nhTransaction.Dispose();
    }

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
