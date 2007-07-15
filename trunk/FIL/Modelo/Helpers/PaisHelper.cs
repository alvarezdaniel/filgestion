using System;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;
using Fil.Modelo.Managers;

namespace Fil.Modelo.Helpers
{
  /// <summary>
  /// Esta clase es la encargada de administrar la l�gica de negocios de la clase Pais
  /// </summary>
  public abstract class PaisHelper
  {

    /// <summary>
    /// Guarda el Pais en la base de datos
    /// </summary>
    /// <remarks>
    /// En este m�todo deber�n estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <param name="pPais">Pais a guardar</param>
    public static void Guardar(Pais pPais)
    {
      Managers.PaisManager.Guardar(pPais);
    }

    /// <summary>
    /// Actualiza el Pais en la base de datos
    /// </summary>
    /// <remarks>
    /// En este m�todo deber�n estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <param name="pPais">Pais a actualizar</param>
    public static void Actualizar(Pais pPais)
    {
      Managers.PaisManager.Actualizar(pPais);
    }

    /// <summary>
    /// Elimina el Pais de la base de datos
    /// </summary>
    /// <remarks>
    /// En este m�todo deber�n estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <param name="pPais">Pais a eliminar</param>
    public static void Eliminar(Pais pPais)
    {
      Managers.PaisManager.Eliminar(pPais);
    }

    /// <summary>
    /// Obtiene un Pais a partir de su ID
    /// </summary>
    /// <remarks>
    /// En este m�todo deber�n estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <param name="id">ID de la pais a obtener</param>
    /// <returns>Pais</returns>
    public static Pais ObtenerPorId(string id)
    {
      return PaisManager.ObtenerPorId(id);
    }

    /// <summary>
    /// Obtiene una lista con todas las Unidades De Gestion
    /// </summary>
    /// <remarks>
    /// En este m�todo deber�n estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <returns>Lista de Unidades De Gestion</returns>
    public static IList<Pais> ObtenerTodos()
    {
      return PaisManager.ObtenerTodos();
    }

  }
}