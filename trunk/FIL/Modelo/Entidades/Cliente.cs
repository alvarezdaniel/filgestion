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
    /// Identificador unívoco del Cliente
    /// </summary>
    public virtual string Id
    {
      get { return id; }
    }

    /// <summary>
    /// Código autonumérico
    /// </summary>
    /// <remarks>
    /// Este código no tiene significancia funcional, pero es util
    /// en tiempo de desarrollo
    /// </remarks>
    public virtual int Autonumerico
    {
      get { return autonumerico; }
    }

    /// <summary>
    /// Código corto del cliente
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
    /// Constructor sin parámetros necesario para NHibernate
    /// </summary>
    protected Cliente()
    {
    }

    /// <summary>
    /// Crea una nueva instancia de la clase Cliente
    /// </summary>
    /// <param name="pCodigo">Código corto del cliente</param>
    /// <param name="pNombres">Nombres reales de la persona física</param>
    /// <param name="pApellidos">Apellidos reales de la persona física</param>
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
    /// <param name="pCodigo">Código corto del cliente</param>
    /// <param name="pNombres">Nombres reales de la persona física</param>
    /// <param name="pApellidos">Apellidos reales de la persona física</param>
    /// <param name="pFechaNacimiento">Fecha de nacimiento de la persona física</param>
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
