using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Reflection;
using System.Collections;
using Fil.Modelo;
using NHibernate.Mapping;

namespace Windows
{
  public partial class FrmQuery : DevExpress.XtraEditors.XtraForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    public FrmQuery()
    {
      // Required for Windows Form Designer support
      InitializeComponent();

      // TODO: Add any constructor code after InitializeComponent call
    }

    private void FrmQuery_Load(object sender, EventArgs e)
    {
      CargarArbol();
    }

    private void CargarArbol()
    {
      Hashtable namespacesnodes = new Hashtable();

      //Assembly asm = System.Reflection.Assembly.GetAssembly(typeof(Fil.Modelo.Entidades.Sistema));

      TreeNode node0 = new TreeNode("Mapeos");
      node0.ImageIndex = 0; // Assembly
      node0.SelectedImageIndex = 0; // Assembly
      //node0.StateImageIndex = 0; // Assembly
      node0.Expand();
      // Agerego los namespaces principales para colgarles despues el resto
      TreeNode node1 = new TreeNode("Fil");
      namespacesnodes.Add("Fil", node1);
      node1.ImageIndex = 1; // Namespace
      node1.SelectedImageIndex = 0; // Assembly
      //node1.StateImageIndex = 0; // Assembly
      node1.Expand();
      node0.Nodes.Add(node1);
      TreeNode node2 = new TreeNode("Modelo");
      node2.ImageIndex = 1; // Namespace
      node2.SelectedImageIndex = 0; // Assembly
      //node2.StateImageIndex = 0; // Assembly
      node2.Expand();
      namespacesnodes.Add("Modelo", node2);
      node1.Nodes.Add(node2);
      
      this.trvModelo.Nodes.Add(node0);

      foreach (RootClass rc in NHibernateManagerFacade.Mapeos)
      {
        //string[] nmsp = t.Namespace.Split('.');
        string[] nmsp = rc.Name.Split('.');
        for (int i = nmsp.Length - 2; i >= 0; i--)
        {
          TreeNode node = (TreeNode)namespacesnodes[nmsp[i]];
          if (node != null)
          {
            // Agergo los namespaces faltantes y me quedo con el nodo del q corresponde
            node = AgregarNamespacesFaltantes(namespacesnodes, nmsp, i, node);

            // Agergo la clase en cuestion
            AgregarTipo(rc, node);

            // Salgo del for
            break;
          } // end if (node != null])
        } // end for nmsp[i]
      } // end foreach(Type)
    }

    private void AgregarTipo(RootClass rc, TreeNode node)
    {
      // Aca tengo que agregar la clase o lo que sea q fuere
      TreeNode clase = new TreeNode(NormalizarNombre(rc.Name));
      clase.Tag = rc;

      clase.ImageIndex = 3; // clase publica

      clase.SelectedImageIndex = clase.ImageIndex;

      TreeNode claseSup = null;
      foreach (TreeNode c in node.Nodes)
      {
        if (c.Text.CompareTo(rc.Name) > 0)
        {
          claseSup = c;
          break;
        }
      }
      if (claseSup != null)
        node.Nodes.Insert(claseSup.Index, clase);
      else
        node.Nodes.Add(clase);

      //Agrego BaseTypes
      AgregarBaseTypes(clase);
    }

    private void AgregarBaseTypes(TreeNode clase)
    {
      RootClass tag = (RootClass)clase.Tag;
      RootClass t = (RootClass)tag.Superclass;

      TreeNode btFolder = new TreeNode("Base Types");
      btFolder.ImageIndex = 2;
      btFolder.SelectedImageIndex = 2;
      //btFolder.StateImageIndex = 2;
      clase.Nodes.Add(btFolder);

      TreeNode btNode = new TreeNode();
      btNode.Tag = t;
      if (t == null)
      {
        btNode.Text = "Object";
        btNode.ImageIndex = 17;
      }
      else
      {
        btNode.Text = NormalizarNombre(t.Name);
        btNode.ImageIndex = 3; // clase publica

        AgregarBaseTypes2(btNode);
      }
      btNode.SelectedImageIndex = btNode.ImageIndex;

      btFolder.Nodes.Add(btNode);

      return;
    }

    private string NormalizarNombre(string pNombre)
    {
      string[] nombre = pNombre.Split('.');
      if (nombre.Length > 1)
        return nombre[nombre.Length - 1];
      else
        return nombre[0];
    }

    private void AgregarBaseTypes2(TreeNode btHijo)
    {
      RootClass tag = (RootClass)btHijo.Tag;
      RootClass t = (RootClass)tag.Superclass;

      TreeNode btNode = new TreeNode();
      btNode.Tag = t;
      if (t == null)
      {
        btNode.Text = "Object";
        btNode.ImageIndex = 17;
      }
      else
      {
        btNode.Text = NormalizarNombre(t.Name);
        btNode.ImageIndex = 3; // clase publica

        AgregarBaseTypes2(btNode);
      }
      btNode.SelectedImageIndex = btNode.ImageIndex;

      btHijo.Nodes.Add(btNode);

      return;
    }

    private static TreeNode AgregarNamespacesFaltantes(Hashtable namespacesnodes, string[] nmsp, int i, TreeNode node)
    {
      //Agergo los namespaces q falten en la rama
      for (int j = i + 1; j < nmsp.Length-1; j++)
      {
        TreeNode newnode = new TreeNode(nmsp[j]);
        newnode.ImageIndex = 1; // Namespace
        newnode.SelectedImageIndex = 1; // Namespace
        //newnode.StateImageIndex = 1; // Namespace

        namespacesnodes.Add(newnode.Text, newnode);
        TreeNode nodeSup = null;
        foreach (TreeNode n in node.Nodes)
        {
          if (n.Text.CompareTo(newnode.Text) > 0)
          {
            nodeSup = n;
            break;
          }
        }
        if (nodeSup != null)
          node.Nodes.Insert(nodeSup.Index, newnode);
        else
          node.Nodes.Add(newnode);

        node = newnode;
      }
      return node;
    } // end CargarArbol()

    private void trvModelo_AfterSelect(object sender, TreeViewEventArgs e)
    {
      this.trvMiembrosDeClases.Nodes.Clear();
      if (e.Node.Tag != null)
      {
        CargarPropiedades((RootClass)e.Node.Tag);
        this.propertyGrid1.SelectedObject = e.Node.Tag;
      }
    }

    private void CargarPropiedades(RootClass rootClass)
    {
      TreeNode node;

      //Cargo la PK
      if (rootClass.HasIdentifierProperty)
      {
        node = new TreeNode(rootClass.IdentifierProperty.Name);
        node.Tag = rootClass.IdentifierProperty;
        if (!rootClass.IdentifierProperty.IsBasicPropertyAccessor)
        {
          node.Text += " (" + rootClass.IdentifierProperty.PropertyAccessorName + ")";
        }
        node.ImageIndex = 11;
        node.SelectedImageIndex = 11;
        trvMiembrosDeClases.Nodes.Add(node);
      }

      //Cargo las otras propiedades
      foreach (Property p in rootClass.PropertyCollection)
      {
        node = new TreeNode(p.Name);
        node.Tag = p;
        node.ImageIndex = 12;
        node.SelectedImageIndex = 12;
        this.trvMiembrosDeClases.Nodes.Add(node);
      }
    }

    private void trvMiembrosDeClases_AfterSelect(object sender, TreeViewEventArgs e)
    {
      if (e.Node.Tag != null)
        this.propertyGrid1.SelectedObject = e.Node.Tag;
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
      try
      {
        this.grdResultados.DataSource = NHibernateManagerFacade.EjecutarQuery(rtbQuery.Text);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);        
      }
    }

  }
}