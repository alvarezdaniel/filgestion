using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using Nullables;

namespace Fil.Modelo.Entidades
{
  public class Password
  {

#region Campos

    private string id;
    private string valor;
    private DateTime fechaAlta;
    private NullableDateTime fechaVencimiento;
    private Usuario usuario;

#endregion

#region Propiedades

    /// <summary>
    /// Identificador un�voco de la contrase�a
    /// </summary>
    public virtual string Id
    {
      get { return id; }
      set { id = value; }
    }

    /// <summary>
    /// Valor de la contrase�a
    /// </summary>
    public virtual string Valor
    {
      get { return valor; }
      set { valor = value; }
    }

    /// <summary>
    /// Usuario al cual pertenece la contrase�a
    /// </summary>
    public virtual Usuario Usuario
    {
      get { return usuario; }
      set { usuario = value; }
    }

    /// <summary>
    /// Fecha en la que se dio de alta
    /// </summary>
    public virtual DateTime FechaAlta
    {
      get { return fechaAlta; }
      set { fechaAlta = value; }
    }

    /// <summary>
    /// Fecha en la que caduca la contrase�a
    /// </summary>
    /// <remarks>
    /// Si esta fecha es alcanzada el usuario deberia tener que ingresar una nueva
    /// </remarks>
    public virtual NullableDateTime FechaVencimiento
    {
      get { return fechaVencimiento; }
      set { fechaVencimiento = value; }
    }

#endregion

#region Constructores

    /// <summary>
    /// Constructor sin par�metros necesario para NHibernate
    /// </summary>
    protected Password(){}

    /// <summary>
    /// Crea una nueva instancia de la clase Password
    /// </summary>
    /// <param name="pValor">Valor</param>
    public Password(string pValor)
    {
      this.Valor = pValor;
      this.fechaAlta = DateTime.Now;
    }

    /// <summary>
    /// Crea una nueva instancia de la clase Password
    /// </summary>
    /// <param name="pValor">Valor</param>
    /// <param name="pFechaVencimiento">Fecha de Vencimiento</param>
    public Password(string pValor, DateTime pFechaVencimiento)
    {
      this.Valor = pValor;
      this.fechaAlta = DateTime.Now;
      this.FechaVencimiento = new NullableDateTime(pFechaVencimiento);
    }

#endregion

  }
}
