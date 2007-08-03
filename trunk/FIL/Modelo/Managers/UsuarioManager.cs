using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;

namespace Fil.Modelo.Managers
{
  internal abstract class UsuarioManager : BaseManager<Usuario>
  {

    public const string USUARIO_ID = "id";

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
