using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;

namespace Fil.Modelo.Managers
{
  internal abstract class UsuarioManager : BaseManager
  {

    /// <summary>
    /// Guarda la instancia del objeto en la base de datos
    /// </summary>
    /// <param name="pUsuario">Usuario a guardar</param>
    internal static void Guardar(Usuario pUsuario)
    {
      Guardar<Usuario>(pUsuario);
    }

    /// <summary>
    /// Elimina la instancia del objeto de la base de datos
    /// </summary>
    /// <param name="pUsuario">Usuario a eliminar</param>
    internal static void Eliminar(Usuario pUsuario)
    {
      Eliminar<Usuario>(pUsuario);
    }

    /// <summary>
    /// Obtiene un usuario de la base de datos a partir de su Id
    /// </summary>
    /// <param name="id">Id del usuario a recuperar</param>
    /// <returns>Usuario</returns>
    internal static Usuario ObtenerPorId(string id)
    {
      return ObtenerPorClave<Usuario>("id", id);
    }
    
    /// <summary>
    /// Obtiene una lista con todos los usuario de la base de datos
    /// </summary>
    /// <returns>Lista de Usuarios</returns>
    internal static IList<Usuario> ObtenerTodos()
    {
      return ObtenerTodos<Usuario>();
    }

    /// <summary>
    /// Obtiene un usuario de la base de datos a partir de su Username
    /// </summary>
    /// <param name="pUsername">Username del usuario a recuperar</param>
    /// <returns>Usuario</returns>
    internal static Usuario ObtenerPorUsername(string pUsername)
    {
      IList exp = new ArrayList();
      exp.Add(NHibernate.Expression.Expression.Eq("Username", pUsername).IgnoreCase());
      Usuario usr = null;
      IList<Usuario> list = NHibernateManager.GetObjectList<Usuario>(exp);
      if (list.Count == 1)
        usr = (Usuario)list[0];
      return usr;
    }

  }
}
