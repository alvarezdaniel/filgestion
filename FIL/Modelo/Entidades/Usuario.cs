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
  /// Representa un usuario del sistema.
  /// </summary>
  public class Usuario: IEntidadPersistible
  {

#region Campos

    private string id = null;
    private int autonumerico;
    private string username;
    private string nombres;
    private string apellidos;
    private string password;
    private ISet perfilesAsignados = new HashedSet();

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
    public virtual int Autonumerico
    {
      get { return autonumerico; }
      set { autonumerico = value; }
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

    /// <summary>
    /// Lista de Perfiles Asignados al usuario para las diferenets unidades
    /// de gestion
    /// </summary>
    public virtual ISet PerfilesAsignados
    {
      get { return perfilesAsignados; }
      set { perfilesAsignados = value; }
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
                   string pApellidos,
                   string pPassword)
    {
      this.Username = pUsername;
      this.Nombres = pNombres;
      this.Apellidos = pApellidos;
      this.Password = pPassword;
    }
    
#endregion

#region Metodos Publicos

    /// <summary>
    /// Guarda la instancia del usuario en la base de datos
    /// </summary>
    public virtual void Guardar()
    {
      Helpers.UsuarioHelper.Guardar(this);
    }

    /// <summary>
    /// Elimina la instancia del usuario en la base de datos
    /// </summary>
    public virtual void Eliminar()
    {
      Helpers.UsuarioHelper.Eliminar(this);
    }

		/// <summary>
    /// Verifica si el usuario puede realizar una determinada accion.
    /// </summary>
		/// <param name="accion"></param>
		public virtual bool Puede(Accion pAccion, UnidadDeGestion pUnidadDeGestion){
      //Verifico entre los perfiles q tiene para la unidad de gestion, si puede
      //realizar la accion.
      foreach (PerfilAsignado pa in PerfilesAsignados)
      {
        if (pa.UnidadDeGestion.Equals(pUnidadDeGestion))
        {
          //corta con el primer perfil que puede
          if (pa.Perfil.Puede(pAccion))
            return true;
        }
      }
      return false;
		}

    /// <summary>
    /// Asigna un Perfil al Usuario para una Unidad De Gestion
    /// </summary>
    /// <param name="pPerfil">Perfil</param>
    /// <param name="pUnidadDeGestion">Unidad De Gestion</param>
    public virtual void AsignarPerfil(Perfil pPerfil, UnidadDeGestion pUnidadDeGestion)
    {
      //Me creo un perfilAsignado auxiliar y verifico si no tiene uno igual.
      PerfilAsignado aux = new PerfilAsignado(pPerfil, pUnidadDeGestion);
      if (!this.perfilesAsignados.Contains(aux))
        this.PerfilesAsignados.Add(aux);
    }

    /// <summary>
    /// Quita un Perfil asignado al Usuario para una Unidad De Gestion
    /// </summary>
    /// <param name="pPerfil">Perfil</param>
    /// <param name="pUnidadDeGestion">Unidad De Gestion</param>
    public virtual void QuitarPerfil(Perfil pPerfil, UnidadDeGestion pUnidadDeGestion)
    {
      //Me creo un perfilAsignado auxiliar y verifico si lo tiene.
      PerfilAsignado aux = new PerfilAsignado(pPerfil, pUnidadDeGestion);
      foreach (PerfilAsignado pa in this.PerfilesAsignados)
      {
        if (pa.Equals(aux))
          aux = pa;
      }
      this.PerfilesAsignados.Remove(aux);
    }

    public override bool Equals(object obj)
    {
      //Primero verifico si el objeto es de tipo Usuario o hereda de Usuario (es necesario
      //porque nhibernate genera RuntimeTypes que heredan de las clases persistentes, para 
      //manejar la instanciacion perezosa
      if ((obj.GetType() != typeof(Usuario)) && (obj.GetType().BaseType != typeof(Usuario)))
        return false;
      //Si es de tipo Usuario, verifico el Id.
      return ((Usuario)obj).Id == this.Id;
    }
    public override string ToString()
    {
      return (this.Apellidos != string.Empty ? this.Apellidos + ", " : String.Empty) + this.Nombres;
    }
    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

#endregion

  }
}
