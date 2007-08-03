using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Fil.Modelo.Entidades;
using Fil.Modelo.Helpers;
using System.Collections;

namespace Windows
{
  public partial class FrmEditorUsuario : DevExpress.XtraEditors.XtraForm
  {

#region Campos

    private Usuario usuario;
    private bool focoPerfiles = false;
    private IList perfilesAsignados = new ArrayList();
    
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

    /// <summary>
    /// Required designer variable.
    /// </summary>
    public FrmEditorUsuario(Usuario pUsuario, bool verPerfiles)
    {
      // Required for Windows Form Designer support
      InitializeComponent();

      // TODO: Add any constructor code after InitializeComponent call
      this.usuario = pUsuario;
      this.focoPerfiles = verPerfiles;
    }

#endregion

#region Eventos

    private void FrmEditorUsuario_Load(object sender, EventArgs e)
    {
      try
      {
        //Cargo los datos
        CargarDatos();

        //Verifico los permisos
        VerificarPermisos();

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
      try
      {
        this.Close();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    private void BtnQuitar_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.GrvPerfilesAsignados.GetSelectedRows().Length == 1)
        {
          if (MessageBox.Show("¿Seguro que desea quitar la asignacion del perfil?",
                              "Desasignar Perfil",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          {
            PerfilAsignado pfa = (PerfilAsignado)this.GrvPerfilesAsignados.GetRow(this.GrvPerfilesAsignados.GetSelectedRows()[0]);
            this.perfilesAsignados.Remove(pfa);
            CargarPerfiles();
          }
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    private void BtnAgregar_Click(object sender, EventArgs e)
    {
      try
      {
        FrmAsignarPerfil frm = new FrmAsignarPerfil();
        if (frm.ShowDialog() == DialogResult.OK)
        {
          Perfil p = frm.PerfilSeleccionado;
          UnidadDeGestion u = frm.UnidadDeGestionSeleccionada;
          if (p != null && u != null)
          {
            PerfilAsignado pfa = new PerfilAsignado(p, u);
            if (!this.perfilesAsignados.Contains(pfa))
              this.perfilesAsignados.Add(pfa);
          }
          CargarPerfiles();
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
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

        //Cargo los perfiles asignados a la lista temporal
        foreach (PerfilAsignado pfa in this.usuario.PerfilesAsignados)
        {
          this.perfilesAsignados.Add(pfa);
        }
      }

      if (Sistema.UsuarioActual.Puede(Fil.Modelo.Enumerados.Accion.AsignarPerfiles))
      {
        CargarPerfiles();
      }
    }

    private void CargarPerfiles()
    {
      this.GrdPerfilesAsignados.DataSource = this.perfilesAsignados;
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

      // Asigno los perfiles
      usuario.PerfilesAsignados.Clear();
      foreach (PerfilAsignado pfa in this.perfilesAsignados)
      {
        usuario.AsignarPerfil(pfa.Perfil, pfa.UnidadDeGestion);
      }

      UsuarioHelper.Guardar(usuario);
      this.Close();
    }

    private void VerificarPermisos()
    {
      if (Sistema.UsuarioActual.Puede(Fil.Modelo.Enumerados.Accion.AsignarPerfiles))
      {
        //Seteo el foco del tab
        if (this.focoPerfiles)
        {
          //this.TabPerfiles.Select();
          this.xtraTabControl1.SelectedTabPage = this.TabPerfiles;
        }
      }
      else
      {
        // si no tiene permisos, le oculto el Tab
        //this.TabPerfiles.Hide();
        this.TabPerfiles.PageVisible = false;
      }

      //this.BtnNuevoPerfil.Visible = Sistema.UsuarioActual.Puede(Fil.Modelo.Enumerados.Accion.AltaPerfiles);
    }

#endregion

  }
}