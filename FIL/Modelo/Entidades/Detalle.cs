using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NHibernate;
namespace Modelo.Entidades
{
  public class Detalle
  {
    private string codigo;
    private Maestro maestro;
    private string descripcion;

    protected Detalle()
    {
    }
    public Detalle(Maestro pMaestro, string pDescripcion)
    {
      this.descripcion = pDescripcion;
      this.maestro = pMaestro;
    }

    public virtual string Codigo
    {
      set { this.codigo = value; }
      get { return this.codigo; }
    }
    public virtual string Descripcion
    {
      set { this.descripcion = value; }
      get { return this.descripcion; }
    }
    public virtual Maestro Maestro
    {
      set { this.maestro = value; }
      get { return this.maestro; }
    }

  }
}
