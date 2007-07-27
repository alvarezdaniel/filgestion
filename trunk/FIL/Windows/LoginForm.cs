using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Fil.Modelo.Entidades;

namespace Windows
{
  public partial class LoginForm : DevExpress.XtraEditors.XtraForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    public LoginForm()
    {
      // Required for Windows Form Designer support
      InitializeComponent();

      // TODO: Add any constructor code after InitializeComponent call
    }

    private void BtnIngresar_Click(object sender, EventArgs e)
    {
      if (Sistema.IngresarUsuario(TxtUsuario.Text, TxtPassword.Text))
      {
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
  }
}