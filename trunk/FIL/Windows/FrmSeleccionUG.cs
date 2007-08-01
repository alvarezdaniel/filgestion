using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using Fil.Modelo.Entidades;

namespace Windows
{
  public partial class FrmSeleccionUG : DevExpress.XtraEditors.XtraForm
  {

#region Campos

    private IList unidades;
    
#endregion

#region Constructor

    /// <summary>
    /// Required designer variable.
    /// </summary>
    public FrmSeleccionUG(IList pUnidadesDeGestion)
    {
      // Required for Windows Form Designer support
      InitializeComponent();

      // TODO: Add any constructor code after InitializeComponent call
      this.unidades = pUnidadesDeGestion;
    }
    
#endregion

#region Eventos

    private void FrmSeleccionUG_Load(object sender, EventArgs e)
    {
      try
      {
        CargarUnidades();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    
#endregion

#region Metodos

    private void CargarUnidades()
    {
      this.CmbUnidades.DisplayMember = "Nombre";
      this.CmbUnidades.ValueMember = "Id";
      this.CmbUnidades.DataSource = this.unidades;
    }

    public UnidadDeGestion UnidadSeleccionada
    {
      get { return (UnidadDeGestion)this.CmbUnidades.SelectedItem; }
      set { this.CmbUnidades.SelectedItem = value; }
    }
    
#endregion

  }
}