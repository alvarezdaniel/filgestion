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

#region Constructor

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

#region Propiedades

    public string Username
    {
      get { return this.TxtUsuario.Text; }
    }
    public string Password
    {
      get { return this.TxtPassword.Text; }
    }

#endregion

#region Eventos

    private void BtnIngresar_Click(object sender, EventArgs e)
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
    
    private void LoginForm_Load(object sender, EventArgs e)
    {
      try
      {
        this.TxtUsuario.Focus();
        this.TxtUsuario.SelectAll();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

#endregion

  }
}