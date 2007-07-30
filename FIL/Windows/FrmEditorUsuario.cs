using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Fil.Modelo.Entidades;

namespace Windows
{
  public partial class FrmEditorUsuario : DevExpress.XtraEditors.XtraForm
  {

#region Campos

    private Usuario usuario;
    
#endregion

#region Constructor

    /// <summary>
    /// Required designer variable.
    /// </summary>
    public FrmEditorUsuario(Usuario pUsuario)
    {
      // Required for Windows Form Designer support
      InitializeComponent();

      // TODO: Add any constructor code after InitializeComponent call
      this.usuario = pUsuario;
    }
    
#endregion

#region Eventos

    private void FrmEditorUsuario_Load(object sender, EventArgs e)
    {
      try
      {
        CargarDatos();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    
    private void BtnAceptar_Click(object sender, EventArgs e)
    {
      try
      {
        GuardarUsuario();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    private void BtnCancelar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

#endregion

#region Metodos

    private void CargarDatos()
    {
      if (this.usuario != null)
      {
        this.TxtNombres.Text = usuario.Nombres;
        this.TxtApellidos.Text = usuario.Apellidos;
        this.TxtUsername.Text = usuario.Username;
        this.TxtPassword.Text = usuario.Password;
      }
    }
    
    private void GuardarUsuario()
    {
      if (usuario == null)
        usuario = new Usuario(TxtUsername.Text, TxtNombres.Text, TxtApellidos.Text, TxtPassword.Text);
      else
      {
        usuario.Nombres = TxtNombres.Text;
        usuario.Apellidos = TxtApellidos.Text;
        usuario.Username = TxtUsername.Text;
        usuario.Password = TxtPassword.Text;
      }
      usuario.Guardar();
      this.Close();
    }

#endregion

  }
}