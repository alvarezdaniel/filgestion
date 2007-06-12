using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NHibernate;

namespace Fil.Modelo.Entidades
{
  public class Usuario
  {

#region Campos

    private string id;
    private int codigo;
    private string username;
    private string password;
    private string nombres;
    private string apellidos;
    private IList passwords = new ArrayList();

#endregion

#region Propiedades

    public virtual string Id
    {
      get { return id; }
    }

    public virtual int Codigo
    {
      get { return codigo; }
    }

    public virtual string Username
    {
      get { return username; }
      set { username = value; }
    }

    public virtual string Password
    {
      get { return password; }
      set { password = value; }
    }

    public virtual string Nombres
    {
      get { return nombres; }
      set { nombres = value; }
    }

    public virtual string Apellidos
    {
      get { return apellidos; }
      set { apellidos = value; }
    }

    public virtual IList Passwords
    {
      get { return passwords; }
      set { passwords = value; }
    }

#endregion   

#region Constructores

    protected Usuario()
    {
    }

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

    public virtual void Guardar()
    {
      Helpers.UsuarioHelper.Guardar<Usuario>(this);
    }

    public virtual void Actualizar()
    {
      Helpers.UsuarioHelper.Actualizar<Usuario>(this);
    }

    public virtual void Eliminar()
    {
      Helpers.UsuarioHelper.Eliminar<Usuario>(this);
    }

#endregion
    
  }
}
