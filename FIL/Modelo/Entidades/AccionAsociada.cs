///////////////////////////////////////////////////////////
//  AccionAsociada.cs
//  Implementation of the Class AccionAsociada
//  Generated by Enterprise Architect
//  Created on:      05-Jul-2007 09:07:02
///////////////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using Iesi.Collections;
using Fil.Modelo.Enumerados;

namespace Fil.Modelo.Entidades 
{

	/// <summary>
	/// La raz�n de existencia de esta clase es porque al ser la entidad "Accion" de
	/// tipo Enumerado no se puede representar la relaci�n muchos-a-muchos.
	/// </summary>
	public class AccionAsociada 
  {

#region Campos Privados

    private Accion accion;
    
#endregion

#region Constructores

    /// <summary>
    /// Constructor sin par�metros necesario para NHibernate
    /// </summary>
    protected AccionAsociada()
    {}
    /// <summary>
    /// Constructor de la clase
    /// </summary>
    /// <param name="pPerfil">Perfil</param>
    /// <param name="pAccion">Accion</param>
    public AccionAsociada(Accion pAccion)
    {
      this.Accion = pAccion;
    }

#endregion

#region Propiedades

    /// <summary>
    /// Accion asociada al perfil
    /// </summary>
    public Accion Accion
    {
      get { return accion; }
      set { accion = value; }
    }
    
#endregion

	}//end AccionAsociada

}//end namespace Entidades