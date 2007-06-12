using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using Iesi.Collections;

namespace Modelo.Entidades
{
  public class Maestro
  {
    private string codigo;
    private string descripcion;
    private IList detalle = new ArrayList();

    protected Maestro()
    {
    }
    public Maestro(string pDescripcion)
    {
      this.descripcion = pDescripcion;
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
    public virtual IList Detalle
    {
      get { return detalle; }
      set { detalle = value; }
    }
  }
}
