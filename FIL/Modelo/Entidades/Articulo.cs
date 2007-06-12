using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NHibernate;
namespace Modelo.Entidades
{
  public class Articulo
  {
    private string codigo;
    private string nombre;

    protected Articulo()
    {
    }
    public Articulo(string pNombre)
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
