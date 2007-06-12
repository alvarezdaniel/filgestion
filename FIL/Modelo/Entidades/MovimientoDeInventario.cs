using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Entidades
{
  public class MovimientoDeInventario
  {
    private int numero;

    protected MovimientoDeInventario()
    { }

    public virtual int Numero
    {
      set { this.numero = value; }
      get { return this.numero; }
    }
  }
}
