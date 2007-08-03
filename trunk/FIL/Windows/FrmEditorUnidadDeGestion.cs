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
  public partial class FrmEditorUnidadDeGestion : DevExpress.XtraEditors.XtraForm
  {

#region Campos

    private UnidadDeGestion unidadDeGestion = null;
    
#endregion

#region Contructor

    /// <summary>
    /// Required designer variable.
    /// </summary>
    public FrmEditorUnidadDeGestion(UnidadDeGestion pUnidadDeGestion)
    {
      // Required for Windows Form Designer support
      InitializeComponent();

      // TODO: Add any constructor code after InitializeComponent call
      this.unidadDeGestion = pUnidadDeGestion;
    }
    
#endregion

#region Eventos

    private void FrmEditorUnidadDeGestion_Load(object sender, EventArgs e)
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
        GuardarUG();
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
      if (this.unidadDeGestion != null)
      {
        this.TxtNombre.Text = unidadDeGestion.Nombre;
      }
    }

    private void VerificarPermisos()
    {
    }

    private void GuardarUG()
    {
      if (unidadDeGestion == null)
        unidadDeGestion = new UnidadDeGestion(TxtNombre.Text);
      else
      {
        unidadDeGestion.Nombre = TxtNombre.Text;
      }

      UnidadDeGestionHelper.Guardar(this.unidadDeGestion);
      this.Close();
    }

#endregion

  }
}