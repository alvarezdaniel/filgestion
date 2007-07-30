using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Fil.Modelo.Entidades;
using System.Collections;

namespace Windows
{
  public partial class LoginForm : DevExpress.XtraEditors.XtraForm
  {

#region Contructor

    /// <summary>
    /// Required designer variable.
    /// </summary>
    public LoginForm()
    {
      // Required for Windows Form Designer support
      InitializeComponent();

      // TODO: Add any constructor code after InitializeComponent call
    }
    
#endregion

#region Eventos

    private void BtnIngresar_Click(object sender, EventArgs e)
    {
      if (Sistema.IngresarUsuario(TxtUsuario.Text, TxtPassword.Text))
      {
        if (Sistema.UnidadActual == null)
        {
          // No tenia una unica UG.
          // Podria no tener ninguna, en cuyo caso no va a poder hacer nada, o podria tener varias
          // y tiene q elegir una.
          SeleccionarUnidadDeGestion(Sistema.UsuarioActual);
        }

        this.Hide();
        MainForm frm = new MainForm(this);
        frm.Show();
      }
      else
      {
        MessageBox.Show("Usuario o Password incorrectos", "Usuario Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
        this.TxtUsuario.Focus();
        this.TxtUsuario.SelectAll();
      }
    }
    
#endregion

#region Metodos

    private void SeleccionarUnidadDeGestion(Usuario usr)
    {
      if (usr.PerfilesAsignados.Count > 1)
      {
        // Si tiene mas de un perfil asignado, me fijo si hay mas de una UG
        IList ugs = new ArrayList();
        foreach (PerfilAsignado pfa in usr.PerfilesAsignados)
        {
          if (!ugs.Contains(pfa.UnidadDeGestion))
            ugs.Add(pfa.UnidadDeGestion);
        }
        if (ugs.Count > 1)
        {
          //Tengo varias UG's => tiene q elegir una.
          FrmSeleccionUG frm = new FrmSeleccionUG(ugs);
          if (frm.ShowDialog() == DialogResult.OK)
          {
            Sistema.UnidadActual = frm.UnidadSeleccionada;
          }
        }
      }
    }
    
#endregion

  }
}