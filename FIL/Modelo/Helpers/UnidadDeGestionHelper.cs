using System;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;
using Fil.Modelo.Managers;

namespace Fil.Modelo.Helpers
{
  /// <summary>
  /// Esta clase es la encargada de administrar la lógica de negocios de la clase UnidadDeGestion
  /// </summary>
  public abstract class UnidadDeGestionHelper
  {

    /// <summary>
    /// Guarda la UnidadDeGestion en la base de datos
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <param name="pUnidadDeGestion">UnidadDeGestion a guardar</param>
    public static void Guardar(UnidadDeGestion pUnidadDeGestion)
    {
      if (pUnidadDeGestion.Nombre == UnidadDeGestion.UNIDADVIRTUAL_NOMBRE)
        return;
      Managers.UnidadDeGestionManager.Guardar(pUnidadDeGestion);
    }

    /// <summary>
    /// Elimina la Unidad De Gestion de la base de datos
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <param name="pUnidadDeGestion">UnidadDeGestion a eliminar</param>
    public static void Eliminar(UnidadDeGestion pUnidadDeGestion)
    {
      if (pUnidadDeGestion.Nombre == UnidadDeGestion.UNIDADVIRTUAL_NOMBRE)
        return;
      Managers.UnidadDeGestionManager.Eliminar(pUnidadDeGestion);
    }

    /// <summary>
    /// Obtiene una Unidad De Gestion a partir de su ID
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <param name="id">ID de la unidadDeGestion a obtener</param>
    /// <returns>UnidadDeGestion</returns>
    public static UnidadDeGestion ObtenerPorId(string id)
    {
      return UnidadDeGestionManager.ObtenerPorId(id);
    }

    /// <summary>
    /// Obtiene una lista con todas las Unidades De Gestion
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <returns>Lista de Unidades De Gestion</returns>
    public static IList<UnidadDeGestion> ObtenerTodos()
    {
      return UnidadDeGestionManager.ObtenerTodos();
    }

    /// <summary>
    /// Devuelve una unidad de gestion virtual. No se puede guardar o eliminar de la base.
    /// </summary>
    /// <returns></returns>
    internal static UnidadDeGestion GetUnidadVirtual()
    {
      return new UnidadDeGestion(UnidadDeGestion.UNIDADVIRTUAL_NOMBRE);
    }
  }
}
