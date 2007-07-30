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
      this.BtnNuevo = new DevExpress.XtraEditors.SimpleButton();
      this.ColId = new DevExpress.XtraGrid.Columns.GridColumn();
      this.ColApellidos = new DevExpress.XtraGrid.Columns.GridColumn();
      this.ColNombres = new DevExpress.XtraGrid.Columns.GridColumn();
      this.ColUsername = new DevExpress.XtraGrid.Columns.GridColumn();
      ((System.ComponentModel.ISupportInitialize)(this.GrdDatos)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GrvDatos)).BeginInit();
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
      this.GrdDatos.Size = new System.Drawing.Size(409, 270);
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
      // 
      // BtnNuevo
      // 
      this.BtnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnNuevo.Location = new System.Drawing.Point(345, 292);
      this.BtnNuevo.Name = "BtnNuevo";
      this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
      this.BtnNuevo.TabIndex = 1;
      this.BtnNuevo.Text = "&Nuevo";
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
      this.ColApellidos.Visible = true;
      this.ColApellidos.VisibleIndex = 1;
      // 
      // ColNombres
      // 
      this.ColNombres.Caption = "Nombres";
      this.ColNombres.FieldName = "Nombres";
      this.ColNombres.Name = "ColNombres";
      this.ColNombres.Visible = true;
      this.ColNombres.VisibleIndex = 2;
      // 
      // ColUsername
      // 
      this.ColUsername.Caption = "Username";
      this.ColUsername.FieldName = "Username";
      this.ColUsername.Name = "ColUsername";
      this.ColUsername.Visible = true;
      this.ColUsername.VisibleIndex = 3;
      // 
      // FrmUsuarios
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(433, 327);
      this.Controls.Add(this.BtnNuevo);
      this.Controls.Add(this.GrdDatos);
      this.Name = "FrmUsuarios";
      this.ShowIcon = false;
      this.Text = "Usuarios";
      this.Load += new System.EventHandler(this.FrmUsuarios_Load);
      ((System.ComponentModel.ISupportInitialize)(this.GrdDatos)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GrvDatos)).EndInit();
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
  }
}