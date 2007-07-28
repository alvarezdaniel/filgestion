using System;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;
using Fil.Modelo.Managers;

namespace Fil.Modelo.Helpers
{
  /// <summary>
  /// Esta clase es la encargada de administrar la lógica de negocios de la clase Localidad
  /// </summary>
  public abstract class LocalidadHelper
  {
    /// <summary>
    /// Guarda la Localidad en la base de datos
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <param name="pLocalidad">Localidad a guardar</param>
    public static void Guardar(Localidad pLocalidad)
    {
      LocalidadManager.Guardar(pLocalidad);
    }

    /// <summary>
    /// Elimina la Localidad de la base de datos
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <param name="pLocalidad">Localidad a eliminar</param>
    public static void Eliminar(Localidad pLocalidad)
    {
      LocalidadManager.Eliminar(pLocalidad);
    }

    /// <summary>
    /// Obtiene una Localidad a partir de su ID
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <param name="id">ID de la Localidad a obtener</param>
    /// <returns>Localidad</returns>
    public static Localidad ObtenerPorId(string id)
    {
      return LocalidadManager.ObtenerPorId(id);
    }

    /// <summary>
    /// Obtiene una lista con todas las Localidad
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <returns>Lista de Localidad</returns>
    public static IList<Localidad> ObtenerTodos()
    {
      return LocalidadManager.ObtenerTodos();
    }

    /// <summary>
    /// Obtiene una lista con todos los Paises
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <returns>Lista de Paises</returns>
    public static IList<Localidad> ObtenerLike(string like)
    {
      return LocalidadManager.ObtenerLike(like);
    }
  }
}
