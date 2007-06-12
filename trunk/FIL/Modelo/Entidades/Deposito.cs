using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Entidades
{
  public class Deposito
  {
    private string codigo;
    private string nombre;

    protected Deposito()
    { }
    public Deposito(string pNombre)
    {
      this.nombre = pNombre;
    }

    public virtual string Codigo
    {
      set { this.codigo = value; }
      get { return this.codigo; }
    }
    public virtual string Nombre
    {
      set { this.nombre = value; }
      get { return this.nombre; }
    }
  }
}
