using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;

namespace Fil.Modelo.Managers
{
  internal abstract class LocalidadManager: BaseManager
  {
    /// <summary>
    /// Obtiene las localidades q se llaman parecido al texto a buscar
    /// </summary>
    /// <param name="like">texto a buscar</param>
    /// <returns></returns>
    internal static IList<Localidad> ObtenerLike(string like)
    {
      string strLike = like.Replace("%", "").Replace("'", "").Trim();
      strLike = "%" + strLike + "%";
      IList exp = new ArrayList();
      exp.Add(NHibernate.Expression.Expression.Like("Nombre", strLike).IgnoreCase());
      return NHibernateManager.GetObjectList<Localidad>(exp);
    }


    /// <summary>
    /// Guarda la instancia del objeto en la base de datos
    /// </summary>
    /// <param name="pLocalidad">Localidad a guardar</param>
    internal static void Guardar (Localidad pLocalidad)
    {
      Guardar<Localidad>(pLocalidad);       
    }

    /// <summary>
    /// Actualiza la instancia del objeto en la base de datos
    /// </summary>
    /// <param name="pLocalidad">Localidad a actualizar</param>
    internal static void Actualizar(Localidad pLocalidad)
    {
      NHibernateManager.UpdateObject(pLocalidad);
    }

    /// <summary>
    /// Elimina la instancia del objeto de la base de datos
    /// </summary>
    /// <param name="pLocalidad">Localidad a eliminar</param>
    internal static void Eliminar(Localidad pLocalidad)
    {
      Eliminar<Localidad>(pLocalidad);
    }

    /// <summary>
    /// Obtiene la Localidad de la base de datos a partir de su Id1
    /// </summary>
    /// <param name="id">Id1 de la Localidad a recuperar</param>
    /// <returns>Localidad</returns>
    internal static Localidad ObtenerPorId(string pId)
    {
      return ObtenerPorClave<Localidad>("id", pId);
    }

    /// <summary>
    /// Obtiene una lista con todas las Localidad de la base de datos
    /// </summary>
    /// <returns>Lista de Localidad</returns>
    internal static IList<Localidad> ObtenerTodos()
    {
      return ObtenerTodos<Localidad>();
    }

  }
}
