using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Entidades
{
  public class ItemDeMovimientoDeInventario
  {
    private MovimientoDeInventario movimiento;
    private Articulo articulo;
    private Deposito depositoEntrada;
    private Deposito depositoSalida;
    private Double cantidad;

    protected ItemDeMovimientoDeInventario()
    { }
    public ItemDeMovimientoDeInventario(MovimientoDeInventario pMovimiento, Articulo pArticulo, Deposito pDepositoEntrada, Deposito pDepositoSalida, Double pCantidad)
    {
      this.movimiento = pMovimiento;
      this.articulo = pArticulo;
      this.depositoEntrada = pDepositoEntrada;
      this.depositoSalida = pDepositoSalida;
      this.cantidad = pCantidad;
    }

    public virtual MovimientoDeInventario Movimiento
    {
      get { return this.movimiento; }
      set { this.movimiento = value; }
    }
    public virtual Articulo Articulo
    {
      set { this.articulo = value; }
      get { return this.articulo; }
    }
    public virtual Deposito DepositoEntrada
    {
      set { this.depositoEntrada = value; }
      get { return this.depositoEntrada; }
    }
    public virtual Deposito DepositoSalida
    {
      set { this.depositoSalida = value; }
      get { return this.depositoSalida; }
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
        if (!((ItemDeMovimientoDeInventario)obj).Movimiento.Equals(this.Movimiento))
          return false;
        else if (!((ItemDeMovimientoDeInventario)obj).Articulo.Equals(this.Articulo))
          return false;
        else if (!((ItemDeMovimientoDeInventario)obj).DepositoEntrada.Equals(this.DepositoEntrada))
          return false;
        else if (!((ItemDeMovimientoDeInventario)obj).DepositoSalida.Equals(this.DepositoSalida))
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
