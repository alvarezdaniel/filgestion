using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;

namespace Fil.Modelo.Managers
{

  internal abstract class PerfilManager
  {

    /// <summary>
    /// Guarda la instancia del objeto en la base de datos
    /// </summary>
    /// <param name="pPerfil">Perfil a guardar</param>
    internal static void Guardar(Perfil pPerfil)
    {
      NHibernateManager.SaveObject(pPerfil);
      NHibernateManager.NHSession.Refresh(pPerfil);
    }

    /// <summary>
    /// Actualiza la instancia del objeto en la base de datos
    /// </summary>
    /// <param name="pPerfil">Perfil a actualizar</param>
    internal static void Actualizar(Perfil pPerfil)
    {
      NHibernateManager.UpdateObject(pPerfil);
    }

    /// <summary>
    /// Elimina la instancia del objeto de la base de datos
    /// </summary>
    /// <param name="pPerfil">Perfil a eliminar</param>
    internal static void Eliminar(Perfil pPerfil)
    {
      NHibernateManager.DeleteObject(pPerfil);
    }

    /// <summary>
    /// Obtiene un perfil de la base de datos a partir de su Id
    /// </summary>
    /// <param name="id">Id del perfil a recuperar</param>
    /// <returns>Perfil</returns>
    internal static Perfil ObtenerPorId(string id)
    {
      Hashtable ht = new Hashtable(1);
      ht.Add("Id", id);
      Perfil a = NHibernateManager.GetUniqueObject<Perfil>("Perfil.ObtenerPorId", ht);
      return a;
    }

    /// <summary>
    /// Obtiene una lista con todos los perfiles de la base de datos
    /// </summary>
    /// <returns>Lista de Perfils</returns>
    internal static IList<Perfil> ObtenerTodos()
    {
      Hashtable ht = new Hashtable();
      IList<Perfil> lista = NHibernateManager.GetObjectList<Perfil>("Perfil.ObtenerTodos", ht);
      return lista;
    }

  }
}
