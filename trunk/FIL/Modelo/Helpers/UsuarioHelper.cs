using System;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;
using Fil.Modelo.Managers;

namespace Fil.Modelo.Helpers
{
  /// <summary>
  /// Esta clase es la encargada de administrar la lógica de negocios de la clase Usuario
  /// </summary>
  public abstract class UsuarioHelper
  {

    /// <summary>
    /// Guarda el usuario la base de datos
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <param name="pUsuario">Usuario a guardar</param>
    public static void Guardar(Usuario pUsuario)
    {
      UsuarioManager.Guardar(pUsuario);
    }

    /// <summary>
    /// Elimina el usuario de la base de datos
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <param name="pUsuario">Usuario a eliminar</param>
    public static void Eliminar(Usuario pUsuario)
    {
      UsuarioManager.Eliminar(pUsuario);
    }

    /// <summary>
    /// Obtiene un usuario a partir de si ID
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <param name="id">ID del usuario a obtener</param>
    /// <returns>Usuario</returns>
    public static Usuario ObtenerPorId(string id)
    {
      return UsuarioManager.ObtenerPorId(id);
    }

    /// <summary>
    /// Obtiene una lista con todos los usuarios
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <returns>Lista de Usuarios</returns>
    public static IList<Usuario> ObtenerTodos()
    {
      return UsuarioManager.ObtenerTodos();
    }

    /// <summary>
    /// Obtiene un usuario a partir de si Username
    /// </summary>
    /// <param name="pUsername">Nombre de Usuario del usuario a obtener</param>
    /// <returns>Usuario</returns>
    public static Usuario ObtenerPorUsername(string pUsername)
    {
      return UsuarioManager.ObtenerPorUsername(pUsername);
    }

  }
}
