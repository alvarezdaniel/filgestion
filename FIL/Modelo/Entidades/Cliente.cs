using System;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Helpers;
using Fil.Modelo.Entidades;

namespace Fil.Modelo.Entidades
{
  public class Cliente
  {

#region Campos
    
    private string id = null;
    private int autonumerico = 0;
    private string codigo;
    private string nombres;
    private string apellidos;
    private int anioNacimiento;
    #endregion

#region Propiedades
    /// <summary>
    /// Identificador un�voco del Cliente
    /// </summary>
    public virtual string Id
    {
      get { return id; }
    }

    /// <summary>
    /// C�digo autonum�rico
    /// </summary>
    /// <remarks>
    /// Este c�digo no tiene significancia funcional, pero es util
    /// en tiempo de desarrollo
    /// </remarks>
    public virtual int Autonumerico
    {
      get { return autonumerico; }
    }

    /// <summary>
    /// C�digo corto del cliente
    /// </summary>
    public virtual string Codigo
    {
      get { return codigo; }
      set { codigo = value; }
    }

    /// <summary>
    /// Nombres reales del cliente
    /// </summary>
    public virtual string Nombres
    {
      get { return nombres; }
      set { nombres = value; }
    }

    /// <summary>
    /// Apellidos reales del cliente
    /// </summary>
    public virtual string Apellidos
    {
      get { return apellidos; }
      set { apellidos = value; }
    }

    /// <summary>
    /// Fecha de nacimiento del cliente
    /// </summary>
    public virtual int AnioNacimiento
    {
      get { return anioNacimiento; }
      set { anioNacimiento = value; }
    }
    #endregion

#region Constructores
    /// <summary>
    /// Constructor sin par�metros necesario para NHibernate
    /// </summary>
    protected Cliente()
    {
    }

    /// <summary>
    /// Crea una nueva instancia de la clase Cliente
    /// </summary>
    /// <param name="pCodigo">C�digo corto del cliente</param>
    /// <param name="pNombres">Nombres reales de la persona f�sica</param>
    /// <param name="pApellidos">Apellidos reales de la persona f�sica</param>
    public Cliente(string pCodigo,
                           string pNombres,
                           string pApellidos)
    {
      this.Codigo = pCodigo;
      this.Nombres = pNombres;
      this.Apellidos = pApellidos;
    }

    /// <summary>
    /// Crea una nueva instancia de la clase Cliente
    /// </summary>
    /// <param name="pCodigo">C�digo corto del cliente</param>
    /// <param name="pNombres">Nombres reales de la persona f�sica</param>
    /// <param name="pApellidos">Apellidos reales de la persona f�sica</param>
    /// <param name="pFechaNacimiento">Fecha de nacimiento de la persona f�sica</param>
    public Cliente(string pCodigo,
                   string pNombres,
                   string pApellidos,
                   int pAnioNacimiento)
    {
      this.Codigo = pCodigo;
      this.Nombres = pNombres;
      this.Apellidos = pApellidos;
      this.AnioNacimiento = pAnioNacimiento;
    }
    #endregion

  }
}
