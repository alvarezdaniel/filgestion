using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Windows
{
  public partial class MainForm : DevExpress.XtraEditors.XtraForm
  {
    private Form opener;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    public MainForm(Form pOpener)
    {
      // Required for Windows Form Designer support
      InitializeComponent();

      this.opener = pOpener;

      //Armar Menu
      ArmarMenu();
    }

    private void ArmarMenu()
    {
      //ToDo: Armar menu.
    }

    private void mnuSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      this.Close();
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      DialogResult dr = MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
      if (dr == DialogResult.No)
        e.Cancel = true;
      this.opener.Close();
    }

  }
}