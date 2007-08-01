namespace Windows
{
  partial class FrmEditorUsuario
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
      this.LblNombres = new DevExpress.XtraEditors.LabelControl();
      this.LblApellidos = new DevExpress.XtraEditors.LabelControl();
      this.LblUsername = new DevExpress.XtraEditors.LabelControl();
      this.LblPassword = new DevExpress.XtraEditors.LabelControl();
      this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
      this.TabGeneral = new DevExpress.XtraTab.XtraTabPage();
      this.TxtPassword = new DevExpress.XtraEditors.TextEdit();
      this.TxtUsername = new DevExpress.XtraEditors.TextEdit();
      this.TxtApellidos = new DevExpress.XtraEditors.TextEdit();
      this.TxtNombres = new DevExpress.XtraEditors.TextEdit();
      this.TabPerfiles = new DevExpress.XtraTab.XtraTabPage();
      this.BtnQuitar = new DevExpress.XtraEditors.SimpleButton();
      this.BtnAgregar = new DevExpress.XtraEditors.SimpleButton();
      this.GrdPerfilesAsignados = new DevExpress.XtraGrid.GridControl();
      this.GrvPerfilesAsignados = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.ColUnidadDeGestion = new DevExpress.XtraGrid.Columns.GridColumn();
      this.ColPerfil = new DevExpress.XtraGrid.Columns.GridColumn();
      this.LblPerfiles = new DevExpress.XtraEditors.LabelControl();
      this.BtnCancelar = new DevExpress.XtraEditors.SimpleButton();
      this.BtnAceptar = new DevExpress.XtraEditors.SimpleButton();
      ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
      this.xtraTabControl1.SuspendLayout();
      this.TabGeneral.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.TxtPassword.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.TxtUsername.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.TxtApellidos.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.TxtNombres.Properties)).BeginInit();
      this.TabPerfiles.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.GrdPerfilesAsignados)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GrvPerfilesAsignados)).BeginInit();
      this.SuspendLayout();
      // 
      // LblNombres
      // 
      this.LblNombres.Location = new System.Drawing.Point(8, 13);
      this.LblNombres.Name = "LblNombres";
      this.LblNombres.Size = new System.Drawing.Size(46, 13);
      this.LblNombres.TabIndex = 0;
      this.LblNombres.Text = "Nombres:";
      // 
      // LblApellidos
      // 
      this.LblApellidos.Location = new System.Drawing.Point(9, 39);
      this.LblApellidos.Name = "LblApellidos";
      this.LblApellidos.Size = new System.Drawing.Size(46, 13);
      this.LblApellidos.TabIndex = 1;
      this.LblApellidos.Text = "Apellidos:";
      // 
      // LblUsername
      // 
      this.LblUsername.Location = new System.Drawing.Point(9, 65);
      this.LblUsername.Name = "LblUsername";
      this.LblUsername.Size = new System.Drawing.Size(52, 13);
      this.LblUsername.TabIndex = 2;
      this.LblUsername.Text = "Username:";
      // 
      // LblPassword
      // 
      this.LblPassword.Location = new System.Drawing.Point(9, 91);
      this.LblPassword.Name = "LblPassword";
      this.LblPassword.Size = new System.Drawing.Size(50, 13);
      this.LblPassword.TabIndex = 3;
      this.LblPassword.Text = "Password:";
      // 
      // xtraTabControl1
      // 
      this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.xtraTabControl1.Location = new System.Drawing.Point(3, 0);
      this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(0);
      this.xtraTabControl1.Name = "xtraTabControl1";
      this.xtraTabControl1.SelectedTabPage = this.TabGeneral;
      this.xtraTabControl1.Size = new System.Drawing.Size(397, 271);
      this.xtraTabControl1.TabIndex = 4;
      this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabGeneral,
            this.TabPerfiles});
      // 
      // TabGeneral
      // 
      this.TabGeneral.Controls.Add(this.TxtPassword);
      this.TabGeneral.Controls.Add(this.TxtUsername);
      this.TabGeneral.Controls.Add(this.TxtApellidos);
      this.TabGeneral.Controls.Add(this.TxtNombres);
      this.TabGeneral.Controls.Add(this.LblUsername);
      this.TabGeneral.Controls.Add(this.LblPassword);
      this.TabGeneral.Controls.Add(this.LblNombres);
      this.TabGeneral.Controls.Add(this.LblApellidos);
      this.TabGeneral.Name = "TabGeneral";
      this.TabGeneral.Size = new System.Drawing.Size(388, 240);
      this.TabGeneral.Text = "Datos Generales";
      // 
      // TxtPassword
      // 
      this.TxtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.TxtPassword.Location = new System.Drawing.Point(66, 88);
      this.TxtPassword.Name = "TxtPassword";
      this.TxtPassword.Size = new System.Drawing.Size(313, 20);
      this.TxtPassword.TabIndex = 7;
      // 
      // TxtUsername
      // 
      this.TxtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.TxtUsername.EditValue = "";
      this.TxtUsername.Location = new System.Drawing.Point(66, 62);
      this.TxtUsername.Name = "TxtUsername";
      this.TxtUsername.Size = new System.Drawing.Size(313, 20);
      this.TxtUsername.TabIndex = 6;
      // 
      // TxtApellidos
      // 
      this.TxtApellidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.TxtApellidos.Location = new System.Drawing.Point(66, 36);
      this.TxtApellidos.Name = "TxtApellidos";
      this.TxtApellidos.Size = new System.Drawing.Size(313, 20);
      this.TxtApellidos.TabIndex = 5;
      // 
      // TxtNombres
      // 
      this.TxtNombres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.TxtNombres.Location = new System.Drawing.Point(66, 10);
      this.TxtNombres.Name = "TxtNombres";
      this.TxtNombres.Size = new System.Drawing.Size(313, 20);
      this.TxtNombres.TabIndex = 4;
      // 
      // TabPerfiles
      // 
      this.TabPerfiles.Controls.Add(this.BtnQuitar);
      this.TabPerfiles.Controls.Add(this.BtnAgregar);
      this.TabPerfiles.Controls.Add(this.GrdPerfilesAsignados);
      this.TabPerfiles.Controls.Add(this.LblPerfiles);
      this.TabPerfiles.Name = "TabPerfiles";
      this.TabPerfiles.Size = new System.Drawing.Size(388, 240);
      this.TabPerfiles.Text = "Perfiles";
      // 
      // BtnQuitar
      // 
      this.BtnQuitar.Location = new System.Drawing.Point(311, 63);
      this.BtnQuitar.Name = "BtnQuitar";
      this.BtnQuitar.Size = new System.Drawing.Size(73, 23);
      this.BtnQuitar.TabIndex = 4;
      this.BtnQuitar.Text = "&Quitar";
      this.BtnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
      // 
      // BtnAgregar
      // 
      this.BtnAgregar.Location = new System.Drawing.Point(310, 34);
      this.BtnAgregar.Name = "BtnAgregar";
      this.BtnAgregar.Size = new System.Drawing.Size(74, 23);
      this.BtnAgregar.TabIndex = 3;
      this.BtnAgregar.Text = "&Agregar";
      this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
      // 
      // GrdPerfilesAsignados
      // 
      this.GrdPerfilesAsignados.EmbeddedNavigator.Name = "";
      this.GrdPerfilesAsignados.Location = new System.Drawing.Point(9, 34);
      this.GrdPerfilesAsignados.MainView = this.GrvPerfilesAsignados;
      this.GrdPerfilesAsignados.Name = "GrdPerfilesAsignados";
      this.GrdPerfilesAsignados.Size = new System.Drawing.Size(294, 203);
      this.GrdPerfilesAsignados.TabIndex = 2;
      this.GrdPerfilesAsignados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvPerfilesAsignados});
      // 
      // GrvPerfilesAsignados
      // 
      this.GrvPerfilesAsignados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColUnidadDeGestion,
            this.ColPerfil});
      this.GrvPerfilesAsignados.GridControl = this.GrdPerfilesAsignados;
      this.GrvPerfilesAsignados.Name = "GrvPerfilesAsignados";
      this.GrvPerfilesAsignados.OptionsBehavior.Editable = false;
      // 
      // ColUnidadDeGestion
      // 
      this.ColUnidadDeGestion.Caption = "Unidad De Gestion";
      this.ColUnidadDeGestion.FieldName = "UnidadDeGestion";
      this.ColUnidadDeGestion.Name = "ColUnidadDeGestion";
      this.ColUnidadDeGestion.OptionsColumn.AllowEdit = false;
      this.ColUnidadDeGestion.OptionsColumn.ReadOnly = true;
      this.ColUnidadDeGestion.UnboundType = DevExpress.Data.UnboundColumnType.Object;
      this.ColUnidadDeGestion.Visible = true;
      this.ColUnidadDeGestion.VisibleIndex = 0;
      // 
      // ColPerfil
      // 
      this.ColPerfil.Caption = "Perfil";
      this.ColPerfil.FieldName = "Perfil";
      this.ColPerfil.Name = "ColPerfil";
      this.ColPerfil.OptionsColumn.AllowEdit = false;
      this.ColPerfil.OptionsColumn.ReadOnly = true;
      this.ColPerfil.UnboundType = DevExpress.Data.UnboundColumnType.Object;
      this.ColPerfil.Visible = true;
      this.ColPerfil.VisibleIndex = 1;
      // 
      // LblPerfiles
      // 
      this.LblPerfiles.Location = new System.Drawing.Point(8, 14);
      this.LblPerfiles.Name = "LblPerfiles";
      this.LblPerfiles.Size = new System.Drawing.Size(91, 13);
      this.LblPerfiles.TabIndex = 1;
      this.LblPerfiles.Text = "Perfiles Asignados:";
      // 
      // BtnCancelar
      // 
      this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.BtnCancelar.Location = new System.Drawing.Point(315, 274);
      this.BtnCancelar.Name = "BtnCancelar";
      this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
      this.BtnCancelar.TabIndex = 5;
      this.BtnCancelar.Text = "&Cancelar";
      this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
      // 
      // BtnAceptar
      // 
      this.BtnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.BtnAceptar.Location = new System.Drawing.Point(234, 274);
      this.BtnAceptar.Name = "BtnAceptar";
      this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
      this.BtnAceptar.TabIndex = 6;
      this.BtnAceptar.Text = "&Aceptar";
      this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
      // 
      // FrmEditorUsuario
      // 
      this.ClientSize = new System.Drawing.Size(399, 305);
      this.ControlBox = false;
      this.Controls.Add(this.BtnAceptar);
      this.Controls.Add(this.BtnCancelar);
      this.Controls.Add(this.xtraTabControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmEditorUsuario";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Text = "Editor de Usuario";
      this.Load += new System.EventHandler(this.FrmEditorUsuario_Load);
      ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
      this.xtraTabControl1.ResumeLayout(false);
      this.TabGeneral.ResumeLayout(false);
      this.TabGeneral.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.TxtPassword.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.TxtUsername.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.TxtApellidos.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.TxtNombres.Properties)).EndInit();
      this.TabPerfiles.ResumeLayout(false);
      this.TabPerfiles.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.GrdPerfilesAsignados)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GrvPerfilesAsignados)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.LabelControl LblNombres;
    private DevExpress.XtraEditors.LabelControl LblApellidos;
    private DevExpress.XtraEditors.LabelControl LblUsername;
    private DevExpress.XtraEditors.LabelControl LblPassword;
    private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
    private DevExpress.XtraTab.XtraTabPage TabGeneral;
    private DevExpress.XtraTab.XtraTabPage TabPerfiles;
    private DevExpress.XtraEditors.TextEdit TxtPassword;
    private DevExpress.XtraEditors.TextEdit TxtUsername;
    private DevExpress.XtraEditors.TextEdit TxtApellidos;
    private DevExpress.XtraEditors.TextEdit TxtNombres;
    private DevExpress.XtraEditors.SimpleButton BtnCancelar;
    private DevExpress.XtraEditors.SimpleButton BtnAceptar;
    private DevExpress.XtraEditors.LabelControl LblPerfiles;
    private DevExpress.XtraGrid.GridControl GrdPerfilesAsignados;
    private DevExpress.XtraGrid.Views.Grid.GridView GrvPerfilesAsignados;
    private DevExpress.XtraEditors.SimpleButton BtnAgregar;
    private DevExpress.XtraGrid.Columns.GridColumn ColUnidadDeGestion;
    private DevExpress.XtraGrid.Columns.GridColumn ColPerfil;
    private DevExpress.XtraEditors.SimpleButton BtnQuitar;
  }
}