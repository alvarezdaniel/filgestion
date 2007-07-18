using System;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;
using Fil.Modelo.Managers;

namespace Fil.Modelo.Helpers
{
  /// <summary>
  /// Esta clase es la encargada de administrar la lógica de negocios de la clase Cliente
  /// </summary>
  public abstract class ClienteHelper
  {

    /// <summary>
    /// Guarda el cliente la base de datos
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <param name="pCliente">Cliente a guardar</param>
    public static void Guardar(Cliente pCliente)
    {
      ClienteManager.Guardar(pCliente);
    }

    /// <summary>
    /// Actualiza el cliente en la base de datos
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <param name="pCliente">Cliente a actualizar</param>
    public static void Actualizar(Cliente pCliente)
    {
      ClienteManager.Actualizar(pCliente);
    }

    /// <summary>
    /// Elimina el cliente de la base de datos
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <param name="pCliente">Cliente a eliminar</param>
    public static void Eliminar(Cliente pCliente)
    {
      ClienteManager.Eliminar(pCliente);
    }

    /// <summary>
    /// Obtiene un cliente a partir de su ID
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <param name="id">ID del cliente a obtener</param>
    /// <returns>Cliente</returns>
    public static Cliente ObtenerPorId(string id)
    {
      return ClienteManager.ObtenerPorId(id);
    }

    /// <summary>
    /// Obtiene una lista con todos los clientes
    /// </summary>
    /// <remarks>
    /// En este método deberán estar las validaciones de negocio que sean necesarias
    /// </remarks>
    /// <returns>Lista de Cliente</returns>
    public static IList<Cliente> ObtenerTodos()
    {
      return ClienteManager.ObtenerTodos();
    }
  }
}
