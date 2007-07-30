using System;
using System.Collections.Generic;
using System.Text;
using Fil.Modelo.Helpers;

namespace Fil.Modelo.Entidades
{
  public class Localidad: IEntidadPersistible
  {
#region Campos


    private string id = null;
    private string nombre;
    private int autonumerico;
    private string codigoPostal;

    
#endregion

#region Constructores
    protected Localidad()
    {}

    public Localidad(string pNombre)
    {
      this.Nombre = pNombre;
    }
#endregion

# region Propiedades
    /// <summary>
    /// Identificador de Clase
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

    public virtual string CodigoPostal
    {
      get { return codigoPostal; }
      set { codigoPostal = value; }
    }

#endregion

#region Miembros de IEntidadPersistible

    public void Guardar()
    {
      LocalidadHelper.Guardar(this);
    }

    public void Eliminar()
    {
      LocalidadHelper.Eliminar(this);
    }


#endregion

  }
}
