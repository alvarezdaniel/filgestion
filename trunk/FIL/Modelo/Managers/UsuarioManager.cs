using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;

namespace Fil.Modelo.Managers
{
  public abstract class UsuarioManager
  {

    /// <summary>
    /// Guarda la instancia del objeto en la base de datos
    /// </summary>
    /// <param name="pUsuario">Usuario a guardar</param>
    public static void Guardar(Usuario pUsuario)
    {
      NHibernateManager.SaveObject(pUsuario);
      NHibernateManager.NHSession.Refresh(pUsuario);
    }

    /// <summary>
    /// Actualiza la instancia del objeto en la base de datos
    /// </summary>
    /// <param name="pUsuario">Usuario a actualizar</param>
    public static void Actualizar(Usuario pUsuario)
    {
      NHibernateManager.UpdateObject(pUsuario);
    }

    /// <summary>
    /// Elimina la instancia del objeto de la base de datos
    /// </summary>
    /// <param name="pUsuario">Usuario a eliminar</param>
    public static void Eliminar(Usuario pUsuario)
    {
      NHibernateManager.DeleteObject(pUsuario);
    }

    /// <summary>
    /// Obtiene un usuario de la base de datos a partir de su Id
    /// </summary>
    /// <param name="id">Id del usuario a recuperar</param>
    /// <returns>Usuario</returns>
    public static Usuario ObtenerPorId(string id)
    {
      Hashtable ht = new Hashtable(1);
      ht.Add("Id", id);
      Usuario a = NHibernateManager.GetUniqueObject<Usuario>("Usuario.ObtenerPorId", ht);
      return a;
    }
    
    /// <summary>
    /// Obtiene una lista con todos los usuario de la base de datos
    /// </summary>
    /// <returns>Lista de Usuarios</returns>
    public static IList<Usuario> ObtenerTodos()
    {
      Hashtable ht = new Hashtable();
      IList<Usuario> lista = NHibernateManager.GetObjectList<Usuario>("Usuario.ObtenerTodos", ht);
      return lista;
    }

  }
}
