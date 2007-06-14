using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NHibernate;

namespace Fil.Modelo.Entidades
{
  /// <summary>
  /// Representa un usuario del sistema.
  /// </summary>
  public class Usuario
  {

#region Campos

    private string id;
    private int codigo;
    private string username;
    private string nombres;
    private string apellidos;
    private string password;

#endregion

#region Propiedades

    /// <summary>
    /// Identificador unívoco del usuario
    /// </summary>
    public virtual string Id
    {
      get { return id; }
    }

    /// <summary>
    /// Código autonumerico
    /// </summary>
    /// <remarks>
    /// Este código no tiene significancia funcional, pero es util
    /// en tiempo de desarrollo
    /// </remarks>
    public virtual int Codigo
    {
      get { return codigo; }
    }

    /// <summary>
    /// Nombre del usuario con el que se identifica en el sistema
    /// </summary>
    public virtual string Username
    {
      get { return username; }
      set { username = value; }
    }

    /// <summary>
    /// Nombres reales de la persona
    /// </summary>
    public virtual string Nombres
    {
      get { return nombres; }
      set { nombres = value; }
    }

    /// <summary>
    /// Apellidos de la persona
    /// </summary>
    public virtual string Apellidos
    {
      get { return apellidos; }
      set { apellidos = value; }
    }

    /// <summary>
    /// Contaseña del usuario
    /// </summary>
    public virtual String Password
    {
      get { return password; }
      set { password = value; }
    }

#endregion   

#region Constructores

    /// <summary>
    /// Constructor sin parámetros necesario para NHibernate
    /// </summary>
    protected Usuario()
    {
    }

    /// <summary>
    /// Crea una nueva instancia de la clase Usuario
    /// </summary>
    /// <param name="pUsername">Nombre de Usuario para identificarse</param>
    /// <param name="pNombres">Nombres reales de la persona física</param>
    /// <param name="pApellidos">Apellidos de la persona física</param>
    public Usuario(string pUsername,
                   string pNombres,
                   string pApellidos)
    {
      this.Username = pUsername;
      this.Nombres = pNombres;
      this.Apellidos = pApellidos;
    }
    
#endregion

#region Metodos Publicos

    /// <summary>
    /// Guarda la instancia del usuario en la base de datos
    /// </summary>
    public virtual void Guardar()
    {
      if (this.id == string.Empty)
        Helpers.UsuarioHelper.Guardar(this);
      else
        Helpers.UsuarioHelper.Actualizar(this);
    }

    /// <summary>
    /// Elimina la instancia del usuario en la base de datos
    /// </summary>
    public virtual void Eliminar()
    {
      Helpers.UsuarioHelper.Eliminar(this);
    }

#endregion
    
  }
}
