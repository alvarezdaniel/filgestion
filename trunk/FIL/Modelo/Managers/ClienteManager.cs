using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;

namespace Fil.Modelo.Managers
{
  internal abstract class ClienteManager: BaseManager<Cliente>
  {

    public const string CLIENTE_ID = "id";

    ///// <summary>
    ///// Guarda la instancia del objeto en la base de datos
    ///// </summary>
    ///// <param name="pCliente">Cliente a guardar</param>
    //internal static void Guardar(Cliente pCliente)
    //{
    //  NHibernateManager.SaveObject(pCliente);
    //  NHibernateManager.NHSession.Refresh(pCliente);
    //}

    ///// <summary>
    ///// Actualiza la instancia del objeto en la base de datos
    ///// </summary>
    ///// <param name="pCliente">Cliente a actualizar</param>
    //internal static void Actualizar(Cliente pCliente)
    //{
    //  NHibernateManager.UpdateObject(pCliente);
    //}

    ///// <summary>
    ///// Elimina la instancia del objeto de la base de datos
    ///// </summary>
    ///// <param name="pCliente">Cliente a eliminar</param>
    //internal static void Eliminar(Cliente pCliente)
    //{
    //  NHibernateManager.DeleteObject(pCliente);
    //}

    ///// <summary>
    ///// Obtiene un Cliente de la base de datos a partir de su Id
    ///// </summary>
    ///// <param name="id">Id del Cliente a recuperar</param>
    ///// <returns>Cliente</returns>
    //internal static Cliente ObtenerPorId(string id)
    //{
    //  Hashtable ht = new Hashtable(1);
    //  ht.Add("Id", id);
    //  Cliente a = NHibernateManager.GetUniqueObject<Cliente>("Cliente.ObtenerPorId", ht);
    //  return a;
    //}

    ///// <summary>
    ///// Obtiene una lista con todos los clientes de la base de datos
    ///// </summary>
    ///// <returns>Lista de Clientes</returns>
    //internal static IList<Cliente> ObtenerTodos()
    //{
    //  Hashtable ht = new Hashtable();
    //  IList<Cliente> lista = NHibernateManager.GetObjectList<Cliente>("Cliente.ObtenerTodos", ht);
    //  return lista;
    //}
  }
}
