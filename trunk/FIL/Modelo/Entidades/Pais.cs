using System;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Helpers;

namespace Fil.Modelo.Entidades
{
  public class Pais: IEntidadPersistible
  {

#region Campos

    private string id = null;
    private string nombre;
    private int autonumerico;
    
#endregion

#region Constructor

    protected Pais() { }

    public Pais(string pNombre)
    {
      this.Nombre = pNombre;
    }
    
#endregion

#region Propiedades

    /// <summary>
    /// Identificador de la clase
    /// </summary>
    public virtual string Id
    {
      get { return id; }
    }

    public virtual string Nombre
    {
      get { return nombre; }
      set { nombre = value; }
    }

    public virtual int Autonumerico
    {
      get { return autonumerico; }
      set { autonumerico = value; }
    }
    
#endregion

#region Miembros de IEntidadPersistible

    public void Guardar()
    {
      PaisHelper.Guardar(this);
    }

    public void Eliminar()
    {
      PaisHelper.Eliminar(this);
    }

#endregion

  }
}
