///////////////////////////////////////////////////////////
//  PerfilAsignado.cs
//  Implementation of the Class PerfilAsignado
//  Generated by Enterprise Architect
//  Created on:      05-Jul-2007 09:07:03
///////////////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using Iesi.Collections;

namespace Fil.Modelo.Entidades 
{

	/// <summary>
	/// La raz�n de existencia de esta clase es para poder representar una relaci�n
	/// "muchos-a-muchos-a-muchos" entre las entidades Usuario, Perfil y
	/// UnidadDeGestion
	/// </summary>
	public class PerfilAsignado 
  {

#region Campos Privados

    private Perfil perfil;
    private UnidadDeGestion unidadDeGestion;

#endregion

#region Constructores

    /// <summary>
    /// Constructor sin par�metros necesario para NHibernate
    /// </summary>
    protected PerfilAsignado()
    {
    }

    /// <summary>
    /// Constructor publico de la clase
    /// </summary>
    /// <param name="pUsuario">Usuairo</param>
    /// <param name="pPerfil">Perfil</param>
    /// <param name="pUnidadDeGestion">Unidad De Gestion</param>
    public PerfilAsignado(Perfil pPerfil, UnidadDeGestion pUnidadDeGestion)
    {
      this.Perfil = pPerfil;
      this.UnidadDeGestion = pUnidadDeGestion;
    }

#endregion

#region Propiedades

    /// <summary>
    /// Perfil Asignado al Usuario para la Unidad de Gestion
    /// </summary>
    public Perfil Perfil
    {
      get { return perfil; }
      set { perfil = value; }
    }
    /// <summary>
    /// Unidad de Gestion para la cual se asocia el Perfil
    /// </summary>
    public UnidadDeGestion UnidadDeGestion
    {
      get { return unidadDeGestion; }
      set { unidadDeGestion = value; }
    }
    
#endregion

    public override bool Equals(object obj)
    {
      //Primero verifico si el objeto es de tipo Usuario o hereda de Usuario (es necesario
      //porque nhibernate genera RuntimeTypes que heredan de las clases persistentes, para 
      //manejar la instanciacion perezosa
      if ((obj.GetType() != typeof(PerfilAsignado)) && (obj.GetType().BaseType != typeof(PerfilAsignado)))
        return false;
      //Si es de tipo PerfilAsignado, verifico el Usuario/Perfil/UnidadDeGestion.
      return (((PerfilAsignado)obj).Perfil == this.Perfil) &&
        (((PerfilAsignado)obj).UnidadDeGestion == this.UnidadDeGestion);
    }
    public override int GetHashCode()
    {
      return base.GetHashCode();
    }


	}//end PerfilAsignado

}//end namespace Entidades