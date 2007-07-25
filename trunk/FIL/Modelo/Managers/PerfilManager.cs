using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;

namespace Fil.Modelo.Managers
{

  internal abstract class PerfilManager: BaseManager
  {

    /// <summary>
    /// Guarda la instancia del objeto en la base de datos
    /// </summary>
    /// <param name="pPerfil">Perfil a guardar</param>
    internal static void Guardar(Perfil pPerfil)
    {
      Guardar<Perfil>(pPerfil);
    }

    /// <summary>
    /// Elimina la instancia del objeto de la base de datos
    /// </summary>
    /// <param name="pPerfil">Perfil a eliminar</param>
    internal static void Eliminar(Perfil pPerfil)
    {
      Eliminar<Perfil>(pPerfil);
    }

    /// <summary>
    /// Obtiene un perfil de la base de datos a partir de su Id
    /// </summary>
    /// <param name="id">Id del perfil a recuperar</param>
    /// <returns>Perfil</returns>
    internal static Perfil ObtenerPorId(string id)
    {
      return ObtenerPorClave<Perfil>("id", id);
    }

    /// <summary>
    /// Obtiene una lista con todos los perfiles de la base de datos
    /// </summary>
    /// <returns>Lista de Perfils</returns>
    internal static IList<Perfil> ObtenerTodos()
    {
      return ObtenerTodos<Perfil>();
    }

  }
}
