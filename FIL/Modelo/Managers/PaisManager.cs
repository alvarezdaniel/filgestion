using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;

namespace Fil.Modelo.Managers
{

  internal abstract class PaisManager
  {

    /// <summary>
    /// Guarda la instancia del objeto en la base de datos
    /// </summary>
    /// <param name="pPais">Pais a guardar</param>
    internal static void Guardar(Pais pPais)
    {
      NHibernateManager.SaveObject(pPais);
      NHibernateManager.NHSession.Refresh(pPais);
    }

    /// <summary>
    /// Actualiza la instancia del objeto en la base de datos
    /// </summary>
    /// <param name="pPais">Pais a actualizar</param>
    internal static void Actualizar(Pais pPais)
    {
      NHibernateManager.UpdateObject(pPais);
    }

    /// <summary>
    /// Elimina la instancia del objeto de la base de datos
    /// </summary>
    /// <param name="pPais">Pais a eliminar</param>
    internal static void Eliminar(Pais pPais)
    {
      NHibernateManager.DeleteObject(pPais);
    }

    /// <summary>
    /// Obtiene el Pais de la base de datos a partir de su Id
    /// </summary>
    /// <param name="id">Id de el Pais a recuperar</param>
    /// <returns>Pais</returns>
    internal static Pais ObtenerPorId(string id)
    {
      IList exp = new ArrayList();
      exp.Add(NHibernate.Expression.Expression.Eq("id", id));
      Pais pais = null;
      IList<Pais> list = NHibernateManager.GetObjectList<Pais>(exp);
      if (list.Count == 1)
        pais = (Pais)list[0];
      return pais;
    }

    /// <summary>
    /// Obtiene una lista con todas los Paises de la base de datos
    /// </summary>
    /// <returns>Lista de Paises</returns>
    internal static IList<Pais> ObtenerTodos()
    {
      IList<Pais> lista = NHibernateManager.GetObjectList<Pais>();
      return lista;
    }

    /// <summary>
    /// Obtiene los paises q se llaman parecido al texto a buscar
    /// </summary>
    /// <param name="like">texto a buscar</param>
    /// <returns></returns>
    internal static IList<Pais> ObtenerLike(string like)
    {
      string strLike = like.Replace("%","").Replace("'","").Trim();
      strLike = "%" + strLike + "%";
      IList exp = new ArrayList();
      exp.Add(NHibernate.Expression.Expression.Like("Nombre", strLike).IgnoreCase());
      IList<Pais> lista = NHibernateManager.GetObjectList<Pais>(exp);
      return lista;
    }
  }
}
