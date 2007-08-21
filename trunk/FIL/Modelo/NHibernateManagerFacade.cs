using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Fil.Modelo
{
  public abstract class NHibernateManagerFacade
  {
    public static ICollection Mapeos
    {
      get { return NHibernateManager.Mapeos; }
    }

    public static IList EjecutarQuery(string query)
    {
      return NHibernateManager.EjecutarQuery(query);
    }
  }
}
