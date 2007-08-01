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
  public partial class FrmAsignarPerfil : DevExpress.XtraEditors.XtraForm
  {

#region Contructores

    /// <summary>
    /// Required designer variable.
    /// </summary>
    public FrmAsignarPerfil()
    {
      // Required for Windows Form Designer support
      InitializeComponent();

      // TODO: Add any constructor code after InitializeComponent call
    }
    
#endregion

#region Propiedades

    public Perfil PerfilSeleccionado
    {
      get { return (Perfil)this.CmbPerfiles.SelectedItem; }
    }

    public UnidadDeGestion UnidadDeGestionSeleccionada
    {
      get { return (UnidadDeGestion)this.CmbUnidadesDeGestion.SelectedItem; }
    }
    
#endregion

#region Eventos

    private void FrmAsignarPerfil_Load(object sender, EventArgs e)
    {
      try
      {
        CargarCombos();
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
        this.Close();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

#endregion

#region Metodos

    private void CargarCombos()
    {
      //
      // Unidades De Gestion
      //
      IList<UnidadDeGestion> ugs = UnidadDeGestionHelper.ObtenerTodos();
      DevExpress.XtraEditors.Repository.RepositoryItemComboBox properties = this.CmbUnidadesDeGestion.Properties;
      foreach (UnidadDeGestion ug in ugs)
        properties.Items.Add(ug);
      //Select the first item
      this.CmbUnidadesDeGestion.SelectedIndex = 0;
      //Disable editing
      properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
      //
      // Perfiles
      //
      IList<Perfil> perfiles = PerfilHelper.ObtenerTodos();
      properties = this.CmbPerfiles.Properties;
      foreach (Perfil p in perfiles)
        properties.Items.Add(p);
      //Select the first item
      this.CmbPerfiles.SelectedIndex = 0;
      //Disable editing
      properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
    }
    
#endregion

  }
}