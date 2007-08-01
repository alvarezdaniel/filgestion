namespace Windows
{
  partial class FrmPerfiles
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
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.BtnNuevo = new DevExpress.XtraEditors.SimpleButton();
      this.BtnModificar = new DevExpress.XtraEditors.SimpleButton();
      this.BtnEliminar = new DevExpress.XtraEditors.SimpleButton();
      this.BtnCerrar = new DevExpress.XtraEditors.SimpleButton();
      this.GrdDatos = new DevExpress.XtraGrid.GridControl();
      this.GrvDatos = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.ColId = new DevExpress.XtraGrid.Columns.GridColumn();
      this.ColDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.flowLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.GrdDatos)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GrvDatos)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
      this.SuspendLayout();
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.flowLayoutPanel1.Controls.Add(this.BtnNuevo);
      this.flowLayoutPanel1.Controls.Add(this.BtnModificar);
      this.flowLayoutPanel1.Controls.Add(this.BtnEliminar);
      this.flowLayoutPanel1.Location = new System.Drawing.Point(318, 12);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(107, 136);
      this.flowLayoutPanel1.TabIndex = 2;
      // 
      // BtnNuevo
      // 
      this.BtnNuevo.Location = new System.Drawing.Point(3, 3);
      this.BtnNuevo.Name = "BtnNuevo";
      this.BtnNuevo.Size = new System.Drawing.Size(96, 23);
      this.BtnNuevo.TabIndex = 2;
      this.BtnNuevo.Text = "&Nueva";
      this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
      // 
      // BtnModificar
      // 
      this.BtnModificar.Location = new System.Drawing.Point(3, 32);
      this.BtnModificar.Name = "BtnModificar";
      this.BtnModificar.Size = new System.Drawing.Size(96, 23);
      this.BtnModificar.TabIndex = 3;
      this.BtnModificar.Text = "&Modificar";
      this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
      // 
      // BtnEliminar
      // 
      this.BtnEliminar.Location = new System.Drawing.Point(3, 61);
      this.BtnEliminar.Name = "BtnEliminar";
      this.BtnEliminar.Size = new System.Drawing.Size(96, 23);
      this.BtnEliminar.TabIndex = 4;
      this.BtnEliminar.Text = "&Eliminar";
      this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
      // 
      // BtnCerrar
      // 
      this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnCerrar.Location = new System.Drawing.Point(321, 238);
      this.BtnCerrar.Name = "BtnCerrar";
      this.BtnCerrar.Size = new System.Drawing.Size(96, 23);
      this.BtnCerrar.TabIndex = 3;
      this.BtnCerrar.Text = "&Cerrar";
      this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
      // 
      // GrdDatos
      // 
      this.GrdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.GrdDatos.EmbeddedNavigator.Name = "";
      this.GrdDatos.Location = new System.Drawing.Point(13, 12);
      this.GrdDatos.MainView = this.GrvDatos;
      this.GrdDatos.Name = "GrdDatos";
      this.GrdDatos.Size = new System.Drawing.Size(302, 249);
      this.GrdDatos.TabIndex = 4;
      this.GrdDatos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvDatos,
            this.gridView2});
      // 
      // GrvDatos
      // 
      this.GrvDatos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColId,
            this.ColDescripcion});
      this.GrvDatos.GridControl = this.GrdDatos;
      this.GrvDatos.Name = "GrvDatos";
      this.GrvDatos.OptionsDetail.AllowZoomDetail = false;
      this.GrvDatos.OptionsDetail.EnableMasterViewMode = false;
      this.GrvDatos.OptionsDetail.ShowDetailTabs = false;
      this.GrvDatos.OptionsDetail.SmartDetailExpand = false;
      // 
      // ColId
      // 
      this.ColId.Caption = "Id";
      this.ColId.FieldName = "Autonumerico";
      this.ColId.Name = "ColId";
      this.ColId.OptionsColumn.AllowEdit = false;
      this.ColId.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
      this.ColId.Visible = true;
      this.ColId.VisibleIndex = 0;
      this.ColId.Width = 31;
      // 
      // ColDescripcion
      // 
      this.ColDescripcion.Caption = "Descripcion";
      this.ColDescripcion.FieldName = "Descripcion";
      this.ColDescripcion.Name = "ColDescripcion";
      this.ColDescripcion.OptionsColumn.AllowEdit = false;
      this.ColDescripcion.UnboundType = DevExpress.Data.UnboundColumnType.String;
      this.ColDescripcion.Visible = true;
      this.ColDescripcion.VisibleIndex = 1;
      this.ColDescripcion.Width = 250;
      // 
      // gridView2
      // 
      this.gridView2.GridControl = this.GrdDatos;
      this.gridView2.Name = "gridView2";
      // 
      // FrmPerfiles
      // 
      this.ClientSize = new System.Drawing.Size(425, 273);
      this.Controls.Add(this.GrdDatos);
      this.Controls.Add(this.BtnCerrar);
      this.Controls.Add(this.flowLayoutPanel1);
      this.Name = "FrmPerfiles";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Text = "Perfiles";
      this.Load += new System.EventHandler(this.FrmPerfiles_Load);
      this.flowLayoutPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.GrdDatos)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GrvDatos)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private DevExpress.XtraEditors.SimpleButton BtnNuevo;
    private DevExpress.XtraEditors.SimpleButton BtnModificar;
    private DevExpress.XtraEditors.SimpleButton BtnEliminar;
    private DevExpress.XtraEditors.SimpleButton BtnCerrar;
    private DevExpress.XtraGrid.GridControl GrdDatos;
    private DevExpress.XtraGrid.Views.Grid.GridView GrvDatos;
    private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    private DevExpress.XtraGrid.Columns.GridColumn ColId;
    private DevExpress.XtraGrid.Columns.GridColumn ColDescripcion;
  }
}