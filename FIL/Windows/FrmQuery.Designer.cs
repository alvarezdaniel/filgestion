namespace Windows
{
  partial class FrmQuery
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuery));
      this.trvModelo = new System.Windows.Forms.TreeView();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.splitContainer3 = new System.Windows.Forms.SplitContainer();
      this.splitContainer4 = new System.Windows.Forms.SplitContainer();
      this.trvMiembrosDeClases = new System.Windows.Forms.TreeView();
      this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
      this.splitContainer2 = new System.Windows.Forms.SplitContainer();
      this.rtbQuery = new System.Windows.Forms.RichTextBox();
      this.grdResultados = new DevExpress.XtraGrid.GridControl();
      this.grvResultados = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.splitContainer3.Panel1.SuspendLayout();
      this.splitContainer3.Panel2.SuspendLayout();
      this.splitContainer3.SuspendLayout();
      this.splitContainer4.Panel1.SuspendLayout();
      this.splitContainer4.Panel2.SuspendLayout();
      this.splitContainer4.SuspendLayout();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdResultados)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.grvResultados)).BeginInit();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // trvModelo
      // 
      this.trvModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.trvModelo.ImageIndex = 0;
      this.trvModelo.ImageList = this.imageList1;
      this.trvModelo.Location = new System.Drawing.Point(1, 0);
      this.trvModelo.Name = "trvModelo";
      this.trvModelo.SelectedImageIndex = 0;
      this.trvModelo.Size = new System.Drawing.Size(172, 150);
      this.trvModelo.TabIndex = 0;
      this.trvModelo.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvModelo_AfterSelect);
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "assembly.bmp");
      this.imageList1.Images.SetKeyName(1, "namespace.bmp");
      this.imageList1.Images.SetKeyName(2, "folder.bmp");
      this.imageList1.Images.SetKeyName(3, "class.bmp");
      this.imageList1.Images.SetKeyName(4, "internal_class.bmp");
      this.imageList1.Images.SetKeyName(5, "interface.bmp");
      this.imageList1.Images.SetKeyName(6, "enum.bmp");
      this.imageList1.Images.SetKeyName(7, "private field.bmp");
      this.imageList1.Images.SetKeyName(8, "protected field.bmp");
      this.imageList1.Images.SetKeyName(9, "public field.bmp");
      this.imageList1.Images.SetKeyName(10, "private property.bmp");
      this.imageList1.Images.SetKeyName(11, "protected property.bmp");
      this.imageList1.Images.SetKeyName(12, "public property.bmp");
      this.imageList1.Images.SetKeyName(13, "private_method.bmp");
      this.imageList1.Images.SetKeyName(14, "protected_method.bmp");
      this.imageList1.Images.SetKeyName(15, "public_method.bmp");
      this.imageList1.Images.SetKeyName(16, "enum_value.bmp");
      this.imageList1.Images.SetKeyName(17, "object.bmp");
      this.imageList1.Images.SetKeyName(18, "readonly property.bmp");
      this.imageList1.Images.SetKeyName(19, "play.png");
      // 
      // splitContainer1
      // 
      this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.splitContainer1.Location = new System.Drawing.Point(0, 28);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
      this.splitContainer1.Size = new System.Drawing.Size(708, 440);
      this.splitContainer1.SplitterDistance = 181;
      this.splitContainer1.TabIndex = 1;
      // 
      // splitContainer3
      // 
      this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.splitContainer3.Location = new System.Drawing.Point(3, 3);
      this.splitContainer3.Name = "splitContainer3";
      this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer3.Panel1
      // 
      this.splitContainer3.Panel1.Controls.Add(this.trvModelo);
      // 
      // splitContainer3.Panel2
      // 
      this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
      this.splitContainer3.Size = new System.Drawing.Size(176, 434);
      this.splitContainer3.SplitterDistance = 149;
      this.splitContainer3.TabIndex = 1;
      // 
      // splitContainer4
      // 
      this.splitContainer4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.splitContainer4.Location = new System.Drawing.Point(1, 3);
      this.splitContainer4.Name = "splitContainer4";
      this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer4.Panel1
      // 
      this.splitContainer4.Panel1.Controls.Add(this.trvMiembrosDeClases);
      // 
      // splitContainer4.Panel2
      // 
      this.splitContainer4.Panel2.Controls.Add(this.propertyGrid1);
      this.splitContainer4.Size = new System.Drawing.Size(172, 278);
      this.splitContainer4.SplitterDistance = 121;
      this.splitContainer4.TabIndex = 2;
      // 
      // trvMiembrosDeClases
      // 
      this.trvMiembrosDeClases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.trvMiembrosDeClases.ImageIndex = 0;
      this.trvMiembrosDeClases.ImageList = this.imageList1;
      this.trvMiembrosDeClases.Location = new System.Drawing.Point(0, 0);
      this.trvMiembrosDeClases.Name = "trvMiembrosDeClases";
      this.trvMiembrosDeClases.SelectedImageIndex = 0;
      this.trvMiembrosDeClases.Size = new System.Drawing.Size(172, 122);
      this.trvMiembrosDeClases.TabIndex = 0;
      this.trvMiembrosDeClases.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvMiembrosDeClases_AfterSelect);
      // 
      // propertyGrid1
      // 
      this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.propertyGrid1.Location = new System.Drawing.Point(0, 3);
      this.propertyGrid1.Name = "propertyGrid1";
      this.propertyGrid1.Size = new System.Drawing.Size(169, 150);
      this.propertyGrid1.TabIndex = 0;
      // 
      // splitContainer2
      // 
      this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.splitContainer2.Location = new System.Drawing.Point(0, 0);
      this.splitContainer2.Name = "splitContainer2";
      this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer2.Panel1
      // 
      this.splitContainer2.Panel1.Controls.Add(this.rtbQuery);
      // 
      // splitContainer2.Panel2
      // 
      this.splitContainer2.Panel2.Controls.Add(this.grdResultados);
      this.splitContainer2.Size = new System.Drawing.Size(520, 440);
      this.splitContainer2.SplitterDistance = 153;
      this.splitContainer2.TabIndex = 0;
      // 
      // rtbQuery
      // 
      this.rtbQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.rtbQuery.Location = new System.Drawing.Point(3, 3);
      this.rtbQuery.Name = "rtbQuery";
      this.rtbQuery.Size = new System.Drawing.Size(514, 147);
      this.rtbQuery.TabIndex = 0;
      this.rtbQuery.Text = "";
      this.rtbQuery.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtbQuery_KeyUp);
      // 
      // grdResultados
      // 
      this.grdResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.grdResultados.EmbeddedNavigator.Name = "";
      this.grdResultados.Location = new System.Drawing.Point(3, 3);
      this.grdResultados.MainView = this.grvResultados;
      this.grdResultados.Name = "grdResultados";
      this.grdResultados.Size = new System.Drawing.Size(514, 277);
      this.grdResultados.TabIndex = 0;
      this.grdResultados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvResultados});
      // 
      // grvResultados
      // 
      this.grvResultados.GridControl = this.grdResultados;
      this.grvResultados.GroupPanelText = "Arrastre una columna aquí para agrupar";
      this.grvResultados.Name = "grvResultados";
      this.grvResultados.OptionsBehavior.Editable = false;
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(708, 25);
      this.toolStrip1.TabIndex = 2;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // toolStripButton1
      // 
      this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
      this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton1.Name = "toolStripButton1";
      this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
      this.toolStripButton1.Text = "toolStripButton1";
      this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
      // 
      // FrmQuery
      // 
      this.ClientSize = new System.Drawing.Size(708, 470);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.splitContainer1);
      this.Name = "FrmQuery";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Text = "Cueri Analaiser";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.FrmQuery_Load);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.ResumeLayout(false);
      this.splitContainer3.Panel1.ResumeLayout(false);
      this.splitContainer3.Panel2.ResumeLayout(false);
      this.splitContainer3.ResumeLayout(false);
      this.splitContainer4.Panel1.ResumeLayout(false);
      this.splitContainer4.Panel2.ResumeLayout(false);
      this.splitContainer4.ResumeLayout(false);
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel2.ResumeLayout(false);
      this.splitContainer2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grdResultados)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.grvResultados)).EndInit();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TreeView trvModelo;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.SplitContainer splitContainer2;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.SplitContainer splitContainer3;
    private System.Windows.Forms.TreeView trvMiembrosDeClases;
    private System.Windows.Forms.SplitContainer splitContainer4;
    private System.Windows.Forms.PropertyGrid propertyGrid1;
    private System.Windows.Forms.RichTextBox rtbQuery;
    private System.Windows.Forms.ToolStripButton toolStripButton1;
    private DevExpress.XtraGrid.GridControl grdResultados;
    private DevExpress.XtraGrid.Views.Grid.GridView grvResultados;
  }
}