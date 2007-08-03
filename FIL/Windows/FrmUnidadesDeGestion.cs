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
  public partial class FrmUnidadesDeGestion : DevExpress.XtraEditors.XtraForm
  {

#region Contructor

    /// <summary>
    /// Required designer variable.
    /// </summary>
    public FrmUnidadesDeGestion()
    {
      // Required for Windows Form Designer support
      InitializeComponent();

      // TODO: Add any constructor code after InitializeComponent call
    }
    
#endregion

#region Eventos

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

    private void FrmUnidadesDeGestion_Load(object sender, EventArgs e)
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

    private void BtnNuevo_Click(object sender, EventArgs e)
    {
      try
      {
        FrmEditorUnidadDeGestion editor = new FrmEditorUnidadDeGestion(null);
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
          UnidadDeGestion ug = (UnidadDeGestion)this.GrvDatos.GetRow(this.GrvDatos.GetSelectedRows()[0]);
          FrmEditorUnidadDeGestion editor = new FrmEditorUnidadDeGestion(ug);
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
          if (MessageBox.Show("¿Seguro que desea eliminar la Unidad de Gestión seleccionada?",
                              "Eliminación de Unidad de Gestion",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          {
            UnidadDeGestion ug = (UnidadDeGestion)this.GrvDatos.GetRow(this.GrvDatos.GetSelectedRows()[0]);
            UnidadDeGestionHelper.Eliminar(ug);
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
      IList<UnidadDeGestion> lst = UnidadDeGestionHelper.ObtenerTodos();
      this.GrdDatos.DataSource = lst;
    }

    private void VerificarPermisos()
    {
      this.BtnNuevo.Visible = Sistema.UsuarioActual.Puede(Fil.Modelo.Enumerados.Accion.AltaUnidadesDeGestion);
      this.BtnEliminar.Visible = Sistema.UsuarioActual.Puede(Fil.Modelo.Enumerados.Accion.BajaUnidadesDeGestion);
      this.BtnModificar.Visible = Sistema.UsuarioActual.Puede(Fil.Modelo.Enumerados.Accion.ModificacionUnidadesDeGestion);
    }

#endregion

  }
}