using System;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;
using Fil.Modelo.Managers;

namespace Fil.Modelo.Helpers
{
  /// <summary>
  /// Esta clase es la encargada de administrar la lógica de negocios de la clase Perfil
  /// </summary>
  public abstract class PerfilHelper
  {

    /// <summary>
    /// Guarda el perfil la base de datos
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <param name="pPerfil">Perfil a guardar</param>
    public static void Guardar(Perfil pPerfil)
    {
      Managers.PerfilManager.Guardar(pPerfil);
    }

    /// <summary>
    /// Elimina el perfil de la base de datos
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <param name="pPerfil">Perfil a eliminar</param>
    public static void Eliminar(Perfil pPerfil)
    {
      Managers.PerfilManager.Eliminar(pPerfil);
    }

    /// <summary>
    /// Obtiene un perfil a partir de su ID
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <param name="id">ID del perfil a obtener</param>
    /// <returns>Perfil</returns>
    public static Perfil ObtenerPorId(string id)
    {
      return PerfilManager.ObtenerPorId(id);
    }

    /// <summary>
    /// Obtiene una lista con todos los perfiles
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <returns>Lista de Perfiles</returns>
    public static IList<Perfil> ObtenerTodos()
    {
      return PerfilManager.ObtenerTodos();
    }

  }
}
