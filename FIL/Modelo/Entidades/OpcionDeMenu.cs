using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Iesi.Collections;
using Fil.Modelo.Helpers;

namespace Fil.Modelo.Entidades
{
  public class OpcionDeMenu
  {

#region "Campos"

    private int id;
    private OpcionDeMenu padre;
    private Enumerados.Accion accion;
    private string descripcion;
    private ISet hijos = new HashedSet();
    private int orden;

#endregion

#region "Propiedades"

    /// <summary>
    /// Identificador de la Opci�n de Menu
    /// </summary>
    public virtual int Id
    {
      get { return id; }
      set { id = value; }
    }
    /// <summary>
    /// Opci�n de Men� Padre
    /// </summary>
    public virtual OpcionDeMenu Padre
    {
      get { return padre; }
      set { padre = value; }
    }
    /// <summary>
    /// Acci�n que permite la visualizaci�n de la Opci�n de Menu
    /// </summary>
    public virtual Enumerados.Accion Accion
    {
      get { return accion; }
      set { accion = value; }
    }
    /// <summary>
    /// Descripcion de la Opci�n de Menu
    /// </summary>
    public virtual string Descripcion
    {
      get { return descripcion; }
      set { descripcion = value; }
    }
    /// <summary>
    /// Opciones de menu hijas
    /// </summary>
    public virtual ISet Hijos
    {
      get { return hijos; }
      set { hijos = value; }
    }
    /// <summary>
    /// Orden de la opci�n de men� entre las opciones del mismo nivel
    /// </summary>
    public virtual int Orden
    {
      get { return orden; }
      set { orden = value; }
    }

#endregion

#region "Constructores"

    /// <summary>
    /// Constructor necesario para NHibernate
    /// </summary>
    protected OpcionDeMenu()
    {
    }

#endregion

#region "Metodos"

#endregion

  }
}
