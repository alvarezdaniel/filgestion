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
      CargarDatos();
      VerificarPermisos();
    }

    private void VerificarPermisos()
    {
      this.BtnNuevo.Visible = Sistema.UsuarioActual.Puede(Fil.Modelo.Enumerados.Accion.AltaUsuarios);
      this.BtnEliminar.Visible = Sistema.UsuarioActual.Puede(Fil.Modelo.Enumerados.Accion.BajaUsuarios);
      this.BtnEliminar.Visible = Sistema.UsuarioActual.Puede(Fil.Modelo.Enumerados.Accion.ModificacionUsuarios);
      this.BtnPerfiles.Visible = Sistema.UsuarioActual.Puede(Fil.Modelo.Enumerados.Accion.AsignarPerfiles);
    }

    private void BtnCerrar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void BtnNuevo_Click(object sender, EventArgs e)
    {
      FrmEditorUsuario editor = new FrmEditorUsuario(null);
      if (editor.ShowDialog() == DialogResult.OK)
        CargarDatos();
    }

    private void BtnEliminar_Click(object sender, EventArgs e)
    {
      if (this.GrvDatos.GetSelectedRows().Length == 1)
      {
        if (MessageBox.Show("¿Seguro que desea eliminar el usuario seleccionado?",
                            "Eliminación de Usuario",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          Usuario usr = (Usuario)this.GrvDatos.GetRow(this.GrvDatos.GetSelectedRows()[0]);
          usr.Eliminar();
          CargarDatos();
        }
      }
    }

    private void BtnModificar_Click(object sender, EventArgs e)
    {
      if (this.GrvDatos.GetSelectedRows().Length == 1)
      {
        Usuario usr = (Usuario)this.GrvDatos.GetRow(this.GrvDatos.GetSelectedRows()[0]);
        FrmEditorUsuario editor = new FrmEditorUsuario(usr);
        if (editor.ShowDialog() == DialogResult.OK)
          CargarDatos();
      }
    }

#endregion  

#region Metodos
    
    private void CargarDatos()
    {
      IList<Usuario> lst = UsuarioHelper.ObtenerTodos();
      this.GrdDatos.DataSource = lst;
    }
    
#endregion

  }
}