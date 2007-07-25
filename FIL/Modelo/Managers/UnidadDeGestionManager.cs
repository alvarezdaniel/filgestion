using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;

namespace Fil.Modelo.Managers
{

  internal abstract class UnidadDeGestionManager: BaseManager
  {

    /// <summary>
    /// Guarda la instancia del objeto en la base de datos
    /// </summary>
    /// <param name="pUnidadDeGestion">Unidad De Gestion a guardar</param>
    internal static void Guardar(UnidadDeGestion pUnidadDeGestion)
    {
      Guardar<UnidadDeGestion>(pUnidadDeGestion);
    }

    /// <summary>
    /// Elimina la instancia del objeto de la base de datos
    /// </summary>
    /// <param name="pUnidadDeGestion">UnidadDeGestion a eliminar</param>
    internal static void Eliminar(UnidadDeGestion pUnidadDeGestion)
    {
      Eliminar<UnidadDeGestion>(pUnidadDeGestion);
    }

    /// <summary>
    /// Obtiene una Unidad De Gestion de la base de datos a partir de su Id
    /// </summary>
    /// <param name="id">Id de la Unidad De Gestion a recuperar</param>
    /// <returns>UnidadDeGestion</returns>
    internal static UnidadDeGestion ObtenerPorId(string id)
    {
      return ObtenerPorClave<UnidadDeGestion>("id", id);
    }

    /// <summary>
    /// Obtiene una lista con todas las Unidades De Gestion de la base de datos
    /// </summary>
    /// <returns>Lista de Unidades De Gestions</returns>
    internal static IList<UnidadDeGestion> ObtenerTodos()
    {
      return ObtenerTodos<UnidadDeGestion>();
    }

  }
}
