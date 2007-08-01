using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Fil.Modelo.Entidades;
using Fil.Modelo.Enumerados;

namespace Windows
{
  public partial class FrmEditorPerfil : DevExpress.XtraEditors.XtraForm
  {

#region Campos

    private Perfil perfil = null;

#endregion

#region Constructor

    /// <summary>
    /// Required designer variable.
    /// </summary>
    public FrmEditorPerfil(Perfil pPerfil)
    {
      // Required for Windows Form Designer support
      InitializeComponent();

      // TODO: Add any constructor code after InitializeComponent call
      this.perfil = pPerfil;
    }
    
#endregion

#region Eventos

    private void FrmEditorPerfil_Load(object sender, EventArgs e)
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

    private void BtnAceptar_Click(object sender, EventArgs e)
    {
      try
      {
        GuardarPerfil();
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
      if (this.perfil != null)
      {
        this.TxtDescripcion.Text = this.perfil.Descripcion;
      }
      else
      {
        //Creo un perfil vacio para poder verificar las acciones
        this.perfil = new Perfil(String.Empty);
      }

      this.ChkLstAcciones.Items.Clear();
      foreach (Accion acn in Enum.GetValues(typeof(Accion)))
        this.ChkLstAcciones.Items.Add(acn, this.perfil.Puede(acn));

    }

    private void VerificarPermisos()
    {
    }

    private void GuardarPerfil()
    {
      if (this.perfil == null)
        this.perfil = new Perfil(this.TxtDescripcion.Text);
      else
      {
        this.perfil.Descripcion = this.TxtDescripcion.Text;
      }

      foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in this.ChkLstAcciones.Items)
      {
        switch (item.CheckState){
          case CheckState.Checked:
            {
              if (!perfil.Puede((Accion)item.Value))
                this.perfil.AgregarAccion((Accion)item.Value);
            }; break;
          case CheckState.Unchecked:
            {
              if (perfil.Puede((Accion)item.Value))
                this.perfil.QuitarAccion((Accion)item.Value);
            }; break;
        }
      }

      this.perfil.Guardar();
      this.Close();
    }

#endregion

  }
}