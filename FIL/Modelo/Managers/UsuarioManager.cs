using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;

namespace Fil.Modelo.Managers
{
  public abstract class UsuarioManager
  {

    public static void Guardar<T>(T objeto)
    {
      NHibernateManager.SaveObject(objeto);
      NHibernateManager.NHSession.Refresh(objeto);
    }

    public static void Actualizar<T>(T objeto)
    {
      NHibernateManager.UpdateObject(objeto);
    }

    public static void Eliminar<T>(T objeto)
    {
      NHibernateManager.DeleteObject(objeto);
    }

    public static Usuario ObtenerPorId(string id)
    {
      Hashtable ht = new Hashtable(1);
      ht.Add("Id", id);
      Usuario a = NHibernateManager.GetUniqueObject<Usuario>("Usuario.ObtenerPorId", ht);
      return a;
    }
    
    public static IList<Usuario> ObtenerTodos()
    {
      Hashtable ht = new Hashtable();
      IList<Usuario> lista = NHibernateManager.GetObjectList<Usuario>("Usuario.ObtenerTodos", ht);
      return lista;
    }

  }
}
