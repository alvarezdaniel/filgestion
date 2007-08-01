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
    AsignarPerfiles = 5,
    AltaPerfiles = 6,
    ConsultaPerfiles = 7,
    BajaPerfiles = 8,
    ModificacionPerfiles = 9,
    ConsultaUnidadesDeGestion = 10,
    AltaUnidadesDeGestion = 11,
    BajaUnidadesDeGestion = 12,
    ModificacionUnidadesDeGestion = 13
  }

}
