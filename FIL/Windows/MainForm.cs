using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Fil.Modelo.Entidades;
using Fil.Modelo.Helpers;
using Iesi.Collections;

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

      foreach (OpcionDeMenu raiz in OpcionDeMenuHelper.ObtenerRaices())
      {
        DevExpress.XtraBars.BarItem item;

        //ToDo: Verificar Permisos

        if (raiz.Hijos.Count > 0)
        {
          //Si la opcion tiene hijos, entonces es de tipo submenu
          item = new DevExpress.XtraBars.BarSubItem(this.barManager1, raiz.Descripcion);

          //ToDo: Armar Submenues
        }
        else
        {
          //Si la opcion tiene hijos, entonces es de tipo submenu
          item = new DevExpress.XtraBars.BarSubItem(this.barManager1, raiz.Descripcion);
          item.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuItems_ItemClick); 
        }
        item.Name = raiz.Id.ToString();
        item.Id = this.barManager1.GetNewItemId();

        this.MainBar.InsertItem(mnuAyuda.Links[0], item);
      }

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

    private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      FrmUsuarios frm = new FrmUsuarios();
      frm.MdiParent = this;
      frm.Show();
    }
  }
}