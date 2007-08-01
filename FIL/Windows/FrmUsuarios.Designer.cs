namespace Windows
{
  partial class FrmUsuarios
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
      this.GrdDatos = new DevExpress.XtraGrid.GridControl();
      this.GrvDatos = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.ColId = new DevExpress.XtraGrid.Columns.GridColumn();
      this.ColApellidos = new DevExpress.XtraGrid.Columns.GridColumn();
      this.ColNombres = new DevExpress.XtraGrid.Columns.GridColumn();
      this.ColUsername = new DevExpress.XtraGrid.Columns.GridColumn();
      this.BtnNuevo = new DevExpress.XtraEditors.SimpleButton();
      this.BtnCerrar = new DevExpress.XtraEditors.SimpleButton();
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.BtnModificar = new DevExpress.XtraEditors.SimpleButton();
      this.BtnEliminar = new DevExpress.XtraEditors.SimpleButton();
      this.BtnPerfiles = new DevExpress.XtraEditors.SimpleButton();
      ((System.ComponentModel.ISupportInitialize)(this.GrdDatos)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GrvDatos)).BeginInit();
      this.flowLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // GrdDatos
      // 
      this.GrdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.GrdDatos.EmbeddedNavigator.Name = "";
      this.GrdDatos.Location = new System.Drawing.Point(12, 12);
      this.GrdDatos.MainView = this.GrvDatos;
      this.GrdDatos.Name = "GrdDatos";
      this.GrdDatos.Size = new System.Drawing.Size(328, 263);
      this.GrdDatos.TabIndex = 0;
      this.GrdDatos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvDatos});
      // 
      // GrvDatos
      // 
      this.GrvDatos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColId,
            this.ColApellidos,
            this.ColNombres,
            this.ColUsername});
      this.GrvDatos.GridControl = this.GrdDatos;
      this.GrvDatos.Name = "GrvDatos";
      this.GrvDatos.OptionsBehavior.Editable = false;
      // 
      // ColId
      // 
      this.ColId.Caption = "Id";
      this.ColId.FieldName = "Autonumerico";
      this.ColId.Name = "ColId";
      this.ColId.OptionsColumn.AllowEdit = false;
      this.ColId.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
      this.ColId.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
      this.ColId.Visible = true;
      this.ColId.VisibleIndex = 0;
      // 
      // ColApellidos
      // 
      this.ColApellidos.Caption = "Apellidos";
      this.ColApellidos.FieldName = "Apellidos";
      this.ColApellidos.Name = "ColApellidos";
      this.ColApellidos.OptionsColumn.AllowEdit = false;
      this.ColApellidos.Visible = true;
      this.ColApellidos.VisibleIndex = 1;
      // 
      // ColNombres
      // 
      this.ColNombres.Caption = "Nombres";
      this.ColNombres.FieldName = "Nombres";
      this.ColNombres.Name = "ColNombres";
      this.ColNombres.OptionsColumn.AllowEdit = false;
      this.ColNombres.Visible = true;
      this.ColNombres.VisibleIndex = 2;
      // 
      // ColUsername
      // 
      this.ColUsername.Caption = "Username";
      this.ColUsername.FieldName = "Username";
      this.ColUsername.Name = "ColUsername";
      this.ColUsername.OptionsColumn.AllowEdit = false;
      this.ColUsername.Visible = true;
      this.ColUsername.VisibleIndex = 3;
      // 
      // BtnNuevo
      // 
      this.BtnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnNuevo.Location = new System.Drawing.Point(3, 3);
      this.BtnNuevo.Name = "BtnNuevo";
      this.BtnNuevo.Size = new System.Drawing.Size(96, 23);
      this.BtnNuevo.TabIndex = 1;
      this.BtnNuevo.Text = "&Nuevo";
      this.BtnNuevo.Visible = false;
      this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
      // 
      // BtnCerrar
      // 
      this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnCerrar.Location = new System.Drawing.Point(352, 252);
      this.BtnCerrar.Name = "BtnCerrar";
      this.BtnCerrar.Size = new System.Drawing.Size(96, 23);
      this.BtnCerrar.TabIndex = 2;
      this.BtnCerrar.Text = "&Cerrar";
      this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.flowLayoutPanel1.Controls.Add(this.BtnNuevo);
      this.flowLayoutPanel1.Controls.Add(this.BtnModificar);
      this.flowLayoutPanel1.Controls.Add(this.BtnEliminar);
      this.flowLayoutPanel1.Controls.Add(this.BtnPerfiles);
      this.flowLayoutPanel1.Location = new System.Drawing.Point(349, 12);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(107, 128);
      this.flowLayoutPanel1.TabIndex = 3;
      // 
      // BtnModificar
      // 
      this.BtnModificar.Location = new System.Drawing.Point(3, 32);
      this.BtnModificar.Name = "BtnModificar";
      this.BtnModificar.Size = new System.Drawing.Size(96, 23);
      this.BtnModificar.TabIndex = 2;
      this.BtnModificar.Text = "&Modificar";
      this.BtnModificar.Visible = false;
      this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
      // 
      // BtnEliminar
      // 
      this.BtnEliminar.Location = new System.Drawing.Point(3, 61);
      this.BtnEliminar.Name = "BtnEliminar";
      this.BtnEliminar.Size = new System.Drawing.Size(96, 23);
      this.BtnEliminar.TabIndex = 3;
      this.BtnEliminar.Text = "&Eliminar";
      this.BtnEliminar.Visible = false;
      this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
      // 
      // BtnPerfiles
      // 
      this.BtnPerfiles.Location = new System.Drawing.Point(3, 90);
      this.BtnPerfiles.Name = "BtnPerfiles";
      this.BtnPerfiles.Size = new System.Drawing.Size(96, 23);
      this.BtnPerfiles.TabIndex = 4;
      this.BtnPerfiles.Text = "&Perfiles";
      this.BtnPerfiles.Visible = false;
      this.BtnPerfiles.Click += new System.EventHandler(this.BtnPerfiles_Click);
      // 
      // FrmUsuarios
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(457, 287);
      this.Controls.Add(this.flowLayoutPanel1);
      this.Controls.Add(this.BtnCerrar);
      this.Controls.Add(this.GrdDatos);
      this.Name = "FrmUsuarios";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Text = "Usuarios";
      this.Load += new System.EventHandler(this.FrmUsuarios_Load);
      ((System.ComponentModel.ISupportInitialize)(this.GrdDatos)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GrvDatos)).EndInit();
      this.flowLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl GrdDatos;
    private DevExpress.XtraGrid.Views.Grid.GridView GrvDatos;
    private DevExpress.XtraEditors.SimpleButton BtnNuevo;
    private DevExpress.XtraGrid.Columns.GridColumn ColId;
    private DevExpress.XtraGrid.Columns.GridColumn ColApellidos;
    private DevExpress.XtraGrid.Columns.GridColumn ColNombres;
    private DevExpress.XtraGrid.Columns.GridColumn ColUsername;
    private DevExpress.XtraEditors.SimpleButton BtnCerrar;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private DevExpress.XtraEditors.SimpleButton BtnModificar;
    private DevExpress.XtraEditors.SimpleButton BtnEliminar;
    private DevExpress.XtraEditors.SimpleButton BtnPerfiles;
  }
}