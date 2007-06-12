using System;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Entidades;
using Fil.Modelo.Managers;

namespace Fil.Modelo.Helpers
{
  public abstract class UsuarioHelper
  {

    public static void Guardar<T>(T objeto)
    {
      Managers.UsuarioManager.Guardar<T>(objeto);
    }

    public static void Actualizar<T>(T objeto)
    {
      Managers.UsuarioManager.Actualizar<T>(objeto);
    }

    public static void Eliminar<T>(T objeto)
    {
      Managers.UsuarioManager.Eliminar<T>(objeto);
    }

    public static Usuario ObtenerPorId(string id)
    {
      return UsuarioManager.ObtenerPorId(id);
    }

    public static IList<Usuario> ObtenerTodos()
    {
      return UsuarioManager.ObtenerTodos();
    }

  }
}
