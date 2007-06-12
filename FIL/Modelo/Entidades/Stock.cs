using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Entidades
{
  public class Stock
  {
    private Articulo articulo;
    private Deposito deposito;
    private Double cantidad;

    protected Stock()
    {
    }
    public Stock(Articulo pArticulo, Deposito pDeposito)
    {
      this.articulo = pArticulo;
      this.deposito = pDeposito;
      this.cantidad = 0L;
    }

    public virtual Articulo Articulo
    {
      set { this.articulo = value; }
      get { return this.articulo; }
    }
    public virtual Deposito Deposito
    {
      set { this.deposito = value; }
      get { return this.deposito; }
    }
    public virtual Double Cantidad
    {
      set { this.cantidad = value; }
      get { return this.cantidad; }
    }

    public override bool Equals(object obj)
    {
      if (obj.GetType() != this.GetType())
        return false;
      else
      {
        if (!((Stock)obj).Articulo.Equals(this.Articulo))
          return false;
        else if (!((Stock)obj).Deposito.Equals(this.Deposito))
          return false;
        else
          return true;
      }
    }
    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

  }
}
