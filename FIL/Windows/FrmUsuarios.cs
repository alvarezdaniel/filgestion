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
      IList<Usuario> lst = UsuarioHelper.ObtenerTodos();
      this.GrdDatos.DataSource = lst;
    }
 
#endregion  

  }
}