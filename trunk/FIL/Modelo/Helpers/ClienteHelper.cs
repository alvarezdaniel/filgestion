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
  public abstract class ClienteHelper: BaseHelper<Cliente>
  {

    public static Cliente ObtenerPorId(object pId)
    {
      return ObtenerPorCampo(ClienteManager.CLIENTE_ID, pId);
    }

  }
}
