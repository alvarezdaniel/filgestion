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

    private ArrayList itemsMenu = new ArrayList();

#region Contructor

    /// <summary>
    /// Required designer variable.
    /// </summary>
    public MainForm()
    {
      // Required for Windows Form Designer support
      InitializeComponent();
    }
    
#endregion

#region Eventos

    private void MainForm_Load(object sender, EventArgs e)
    {
      try
      {
        //Verifico si hay alguien logueado
        VerificarUsuario();

        //Armar Menu
        ArmarMenu();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    private void mnuSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      try
      {
        DialogResult dr = MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        if (dr == DialogResult.No)
        {
          e.Cancel = true;
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    private void menuItems_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      try
      {
        OpcionDeMenu opt = (OpcionDeMenu)e.Item.Tag;
        if (opt.Form != null)
        {
          // Reviso entre los forms abiertos si ya tengo uno instanciado
          foreach (Form f in this.MdiChildren){
            if (f.GetType() == System.Reflection.Assembly.GetExecutingAssembly().GetType("Windows." + opt.Form))
            {
              // Si encuentro uno del mismo tipo, lo activo.
              f.Activate();
              return;
            }
          }
          // Si no lo encontre, lo instancio.

          Form frm = (Form)System.Reflection.Assembly.GetExecutingAssembly().CreateInstance("Windows." + opt.Form, true);
          //Type t = System.Reflection.Assembly.GetExecutingAssembly().GetType(opt.Form);
          frm.MdiParent = this;
          frm.Show();
        }
        else if (opt.Metodo != null)
        {
          //ToDo: Obtener el método por reflection e invocarlo.
        }

      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    
    private void mnuCambiarUsuario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      try
      {
        CerrarVentanasAbiertas();
        LoguearUsuario();
        ArmarMenu();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

#endregion

#region Métodos

    private void ArmarMenu()
    {
      // Elimino las opciones agregadas anteriormente
      foreach (DevExpress.XtraBars.BarItem item in itemsMenu)
      {
        this.barManager1.Items.Remove(item);
      }
      // fuerzo al manager a crear los links
      // this.barManager1.ForceInitialize();
      this.barManager1.ForceLinkCreate();

      foreach (OpcionDeMenu raiz in OpcionDeMenuHelper.ObtenerRaices())
      {
        DevExpress.XtraBars.BarItem item;

        //Si no tiene permiso, salteo la opcion.
        if (!Sistema.UsuarioActual.Puede(raiz.Accion))
          continue;

        if (raiz.Hijos.Count > 0)
        {
          //Si la opcion tiene hijos, entonces es de tipo submenu
          item = new DevExpress.XtraBars.BarSubItem(this.barManager1, raiz.Descripcion);

          //ToDo: Armar Submenues
          ArmarSubmenu(raiz, (DevExpress.XtraBars.BarSubItem)item);
        }
        else
        {
          //Si la opcion tiene hijos, entonces es de tipo submenu
          item = new DevExpress.XtraBars.BarButtonItem(this.barManager1, raiz.Descripcion);
          item.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuItems_ItemClick);
        }
        item.Name = raiz.Id.ToString();
        item.Id = this.barManager1.GetNewItemId();
        item.Tag = raiz;

        this.MainBar.InsertItem(mnuAyuda.Links[0], item);
        this.itemsMenu.Add(item);
      }

    }

    private void ArmarSubmenu(OpcionDeMenu pPadre, DevExpress.XtraBars.BarSubItem menu)
    {
      foreach (OpcionDeMenu opc in pPadre.Hijos)
      {
        DevExpress.XtraBars.BarItem item;

        //Si no tiene permiso, salteo la opcion.
        if (!Sistema.UsuarioActual.Puede(opc.Accion))
          continue;

        if (opc.Hijos.Count > 0)
        {
          //Si la opcion tiene hijos, entonces es de tipo submenu
          item = new DevExpress.XtraBars.BarSubItem(this.barManager1, opc.Descripcion);

          menu.AddItem(item);

          //ToDo: Armar Submenues
          ArmarSubmenu(opc, (DevExpress.XtraBars.BarSubItem)item);
        }
        else
        {
          //Si la opcion tiene hijos, entonces es de tipo submenu
          item = new DevExpress.XtraBars.BarButtonItem(this.barManager1, opc.Descripcion);
          item.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuItems_ItemClick);
          item.Tag = opc;

          menu.AddItem(item);
        }

        item.Name = opc.Id.ToString();
        item.Id = this.barManager1.GetNewItemId();

        this.itemsMenu.Add(item);

      }
    }

    private void VerificarUsuario()
    {
      if (Sistema.UsuarioActual == null)
      {
        LoguearUsuario();
      }
    }

    private void LoguearUsuario()
    {
      LoginForm frm = new LoginForm();
      while (true)
      {
        if (frm.ShowDialog() == DialogResult.OK)
        {
          if (Sistema.IngresarUsuario(frm.Username, frm.Password))
          {
            if (Sistema.UnidadActual == null)
            {
              if (Sistema.UsuarioActual.PerfilesAsignados.Count > 1)
              {
                // Si tiene mas de un perfil asignado, me fijo si hay mas de una UG
                IList ugs = new ArrayList();
                foreach (PerfilAsignado pfa in Sistema.UsuarioActual.PerfilesAsignados)
                {
                  if (!ugs.Contains(pfa.UnidadDeGestion))
                    ugs.Add(pfa.UnidadDeGestion);
                }
                if (ugs.Count > 1)
                {
                  //Tengo varias UG's => tiene q elegir una.
                  FrmSeleccionUG frmug = new FrmSeleccionUG(ugs);
                  if (frmug.ShowDialog() == DialogResult.OK)
                  {
                    Sistema.UnidadActual = frmug.UnidadSeleccionada;
                  }
                }
              }
            }
            return;
          }
          else
          {
            MessageBox.Show("Usuario o Password incorrectos", "Usuario Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
        else
        {
          return;
        }
      }
    }

    private void CerrarVentanasAbiertas()
    {
      foreach (Form frm in this.MdiChildren)
      {
        frm.Close();
      }
    }

#endregion

  }
}