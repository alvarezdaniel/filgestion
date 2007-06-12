using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NHibernate;

namespace Fil.Modelo.Entidades
{
  public class Password
  {

#region Campos

    private string id;
    private string valor;
    private DateTime fechaAlta;
    private DateTime fechaVencimiento;
    private Usuario usuario;

#endregion

#region Propiedades

    public virtual string Id
    {
      get { return id; }
      set { id = value; }
    }

    public virtual string Valor
    {
      get { return valor; }
      set { valor = value; }
    }

    public virtual Usuario Usuario
    {
      get { return usuario; }
      set { usuario = value; }
    }

    public virtual DateTime FechaAlta
    {
      get { return fechaAlta; }
      set { fechaAlta = value; }
    }

    public virtual DateTime FechaVencimiento
    {
      get { return fechaVencimiento; }
      set { fechaVencimiento = value; }
    }

#endregion

#region Constructores

    protected Password(){}

    public Password(string pValor)
    {
      this.Valor = pValor;
      this.fechaAlta = DateTime.Now;
    }

    public Password(string pValor, DateTime pFechaVencimiento)
    {
      this.Valor = pValor;
      this.fechaAlta = DateTime.Now;
      this.FechaVencimiento = pFechaVencimiento;
    }

#endregion

  }
}
