using System;
using System.Collections.Generic;
using System.Text;

namespace Fil.Modelo.Enumerados
{
  /// <summary>
  /// Representa las acciones de los usuarios en el sistema.
  /// </summary>
  /// <remarks>
  /// Sirve para validar los permisos de los usuarios.
  /// </remarks>
  public enum Accion
  {
    AccionNula = 0,
    ConsultaUsuarios = 1,
    AltaUsuarios = 2,
    BajaUsuarios = 3,
    ModificacionUsuarios = 4,
    AsignarPerfiles = 5
  }

}
