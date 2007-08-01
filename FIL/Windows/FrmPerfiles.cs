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

namespace Windows
{
  public partial class FrmPerfiles : DevExpress.XtraEditors.XtraForm
  {

#region Constructor

    /// <summary>
    /// Required designer variable.
    /// </summary>
    public FrmPerfiles()
    {
      // Required for Windows Form Designer support
      InitializeComponent();

      // TODO: Add any constructor code after InitializeComponent call
    }
    
#endregion

#region Eventos

    private void FrmPerfiles_Load(object sender, EventArgs e)
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
        FrmEditorPerfil editor = new FrmEditorPerfil(null);
        if (editor.ShowDialog() == DialogResult.OK)
          CargarDatos();
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
          Perfil p = (Perfil)this.GrvDatos.GetRow(this.GrvDatos.GetSelectedRows()[0]);
          FrmEditorPerfil editor = new FrmEditorPerfil(p);
          if (editor.ShowDialog() == DialogResult.OK)
            CargarDatos();
        }
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
          if (MessageBox.Show("¿Seguro que desea eliminar el Perfil seleccionado?",
                              "Eliminación de Perfil",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          {
            Perfil p = (Perfil)this.GrvDatos.GetRow(this.GrvDatos.GetSelectedRows()[0]);
            p.Eliminar();
            CargarDatos();
          }
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
      IList<Perfil> lst = PerfilHelper.ObtenerTodos();
      this.GrdDatos.DataSource = lst;
    }

    private void VerificarPermisos()
    {
      this.BtnNuevo.Visible = Sistema.UsuarioActual.Puede(Fil.Modelo.Enumerados.Accion.AltaPerfiles);
      this.BtnEliminar.Visible = Sistema.UsuarioActual.Puede(Fil.Modelo.Enumerados.Accion.BajaPerfiles);
      this.BtnModificar.Visible = Sistema.UsuarioActual.Puede(Fil.Modelo.Enumerados.Accion.ModificacionPerfiles);
    }

#endregion

  }
}