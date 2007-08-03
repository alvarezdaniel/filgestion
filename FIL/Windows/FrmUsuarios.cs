using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Fil.Modelo.Entidades;
using Fil.Modelo.Helpers;

namespace Windows
{
  public partial class FrmUsuarios : DevExpress.XtraEditors.XtraForm
  {

#region Contructor

    public FrmUsuarios()
    {
      InitializeComponent();
    }
    
#endregion

#region Eventos
		
    private void FrmUsuarios_Load(object sender, EventArgs e)
    {
      try
      {
        CargarDatos();
        VerificarPermisos();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    private void BtnCerrar_Click(object sender, EventArgs e)
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

    private void BtnNuevo_Click(object sender, EventArgs e)
    {
      try
      {
        FrmEditorUsuario editor = new FrmEditorUsuario(null);
        if (editor.ShowDialog() == DialogResult.OK)
          CargarDatos();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    private void BtnEliminar_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.GrvDatos.GetSelectedRows().Length == 1)
        {
          if (MessageBox.Show("¿Seguro que desea eliminar el Usuario seleccionado?",
                              "Eliminación de Usuario",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          {
            Usuario usr = (Usuario)this.GrvDatos.GetRow(this.GrvDatos.GetSelectedRows()[0]);
            UsuarioHelper.Eliminar(usr);
            CargarDatos();
          }
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    private void BtnModificar_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.GrvDatos.GetSelectedRows().Length == 1)
        {
          Usuario usr = (Usuario)this.GrvDatos.GetRow(this.GrvDatos.GetSelectedRows()[0]);
          FrmEditorUsuario editor = new FrmEditorUsuario(usr);
          if (editor.ShowDialog() == DialogResult.OK)
            CargarDatos();
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    private void BtnPerfiles_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.GrvDatos.GetSelectedRows().Length == 1)
        {
          Usuario usr = (Usuario)this.GrvDatos.GetRow(this.GrvDatos.GetSelectedRows()[0]);
          FrmEditorUsuario editor = new FrmEditorUsuario(usr, true);
          if (editor.ShowDialog() == DialogResult.OK)
            CargarDatos();
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
      IList<Usuario> lst = UsuarioHelper.ObtenerTodos();
      this.GrdDatos.DataSource = lst;
    }

    private void VerificarPermisos()
    {
      this.BtnNuevo.Visible = Sistema.UsuarioActual.Puede(Fil.Modelo.Enumerados.Accion.AltaUsuarios);
      this.BtnEliminar.Visible = Sistema.UsuarioActual.Puede(Fil.Modelo.Enumerados.Accion.BajaUsuarios);
      this.BtnModificar.Visible = Sistema.UsuarioActual.Puede(Fil.Modelo.Enumerados.Accion.ModificacionUsuarios);
      this.BtnPerfiles.Visible = Sistema.UsuarioActual.Puede(Fil.Modelo.Enumerados.Accion.AsignarPerfiles);
    }

#endregion

  }
}