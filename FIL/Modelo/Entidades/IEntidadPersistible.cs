using System;
using System.Collections.Generic;
using System.Text;

namespace Fil.Modelo.Entidades
{
  interface IEntidadPersistible
  {
    void Guardar();
    void Eliminar();
  }
}
