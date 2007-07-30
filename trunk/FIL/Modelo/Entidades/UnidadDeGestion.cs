///////////////////////////////////////////////////////////
//  UnidadDeGestion.cs
//  Implementation of the Class UnidadDeGestion
//  Generated by Enterprise Architect
//  Created on:      05-Jul-2007 09:07:07
///////////////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using Iesi.Collections;
using Fil.Modelo.Helpers;

namespace Fil.Modelo.Entidades {

  /// <summary>
  /// Representa una unidad de gestion operativa
  /// </summary>
	public class UnidadDeGestion: IEntidadPersistible
  {

#region Cosntantes

    internal const string UNIDADVIRTUAL_NOMBRE = "__unidad__virtual";
    
#endregion

#region Campos Privados

    private string id = null;
    private int autonumerico;
    private string nombre;

#endregion

#region Constructores

    /// <summary>
    /// Constructor sin par�metros necesario para NHibernate
    /// </summary>
    protected UnidadDeGestion()
    {
    }

    /// <summary>
    /// Constructor publico de la clase
    /// </summary>
    /// <param name="pNombre"></param>
    public UnidadDeGestion(string pNombre)
    {
      this.Nombre = pNombre;
    }

#endregion

#region Propiedades

    /// <summary>
    /// Identificador del perfil
    /// </summary>
    public virtual string Id
    {
      get { return id; }
    }

    /// <summary>
    /// C�digo autonumerico
    /// </summary>
    public virtual int Autonumerico
    {
      get { return autonumerico; }
      set { autonumerico = value; }
    }

    /// <summary>
    /// Devuelve o setea el nombre de la UG
    /// </summary>
    public virtual string Nombre
    {
      get { return this.nombre; }
      set { this.nombre = value; }
    }

#endregion

#region Metodos Publicos

    /// <summary>
    /// Guarda la instancia en la base de datos
    /// </summary>
    public virtual void Guardar()
    {
      UnidadDeGestionHelper.Guardar(this);
    }

    /// <summary>
    /// Elimina la instancia de la base de datos
    /// </summary>
    public virtual void Eliminar()
    {
      UnidadDeGestionHelper.Eliminar(this);
    }

    public override bool Equals(object obj)
    {
      //Primero verifico si el objeto es de tipo UnidadDeGestion o hereda de UnidadDeGestion (es necesario
      //porque nhibernate genera RuntimeTypes que heredan de las clases persistentes, para 
      //manejar la instanciacion perezosa
      if ((obj.GetType() != typeof(UnidadDeGestion)) && (obj.GetType().BaseType != typeof(UnidadDeGestion)))
        return false;
      //Si es de tipo UnidadDeGestion, verifico el Id.
      return ((UnidadDeGestion)obj).Id == this.Id;
    }
    public override string ToString()
    {
      return "Unidad De Gestion";
    }
    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

#endregion

  }//end UnidadDeGestion

}//end namespace Entidades