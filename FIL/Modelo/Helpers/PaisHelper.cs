using System;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;
using Fil.Modelo.Managers;

namespace Fil.Modelo.Helpers
{
  /// <summary>
  /// Esta clase es la encargada de administrar la lógica de negocios de la clase Pais
  /// </summary>
  public abstract class PaisHelper
  {

    /// <summary>
    /// Guarda el Pais en la base de datos
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <param name="pPais">Pais a guardar</param>
    public static void Guardar(Pais pPais)
    {
      PaisManager.Guardar(pPais);
    }

    /// <summary>
    /// Elimina el Pais de la base de datos
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <param name="pPais">Pais a eliminar</param>
    public static void Eliminar(Pais pPais)
    {
      PaisManager.Eliminar(pPais);
    }

    /// <summary>
    /// Obtiene un Pais a partir de su ID
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <param name="id">ID de la pais a obtener</param>
    /// <returns>Pais</returns>
    public static Pais ObtenerPorId(string id)
    {
      return PaisManager.ObtenerPorId(id);
    }

    /// <summary>
    /// Obtiene una lista con todos los Paises
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <returns>Lista de Paises</returns>
    public static IList<Pais> ObtenerTodos()
    {
      return PaisManager.ObtenerTodos();
    }

    /// <summary>
    /// Obtiene una lista con todos los Paises
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <returns>Lista de Paises</returns>
    public static IList<Pais> ObtenerLike(string like)
    {
      return PaisManager.ObtenerLike(like);
    }

  }
}
