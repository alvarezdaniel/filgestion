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

    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      //Armar Menu
      ArmarMenu();
    }

    private void ArmarMenu()
    {
      //fuerzo al manager a crear los links
      this.barManager1.ForceLinkCreate();
      
      //DevExpress.XtraBars.BarSubItem mnu1 = new DevExpress.XtraBars.BarSubItem(this.barManager1, "Menu 1");
      //mnu1.Name = "mnu1";
      //mnu1.Id = this.barManager1.GetNewItemId();

      //DevExpress.XtraBars.BarButtonItem mnu2 = new DevExpress.XtraBars.BarButtonItem(this.barManager1, "Menu 3");
      //mnu2.Name = "mnu3";
      //mnu2.Id = this.barManager1.GetNewItemId();
      //mnu2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuItems_ItemClick); 
      //mnu1.AddItem(mnu2);

      //this.MainBar.InsertItem(mnuAyuda.Links[0], mnu1);
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

    private void menuItems_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      MessageBox.Show(e.Item.Name);
    }
  }
}