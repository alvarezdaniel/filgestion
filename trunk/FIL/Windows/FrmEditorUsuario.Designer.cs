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
      this.BtnCancelar = new DevExpress.XtraEditors.SimpleButton();
      this.BtnAceptar = new DevExpress.XtraEditors.SimpleButton();
      ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
      this.xtraTabControl1.SuspendLayout();
      this.TabGeneral.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.TxtPassword.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.TxtUsername.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.TxtApellidos.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.TxtNombres.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // LblNombres
      // 
      this.LblNombres.Location = new System.Drawing.Point(9, 13);
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
      this.xtraTabControl1.Location = new System.Drawing.Point(1, 0);
      this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(0);
      this.xtraTabControl1.Name = "xtraTabControl1";
      this.xtraTabControl1.SelectedTabPage = this.TabGeneral;
      this.xtraTabControl1.Size = new System.Drawing.Size(299, 238);
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
      this.TabGeneral.Size = new System.Drawing.Size(290, 207);
      this.TabGeneral.Text = "Datos Generales";
      // 
      // TxtPassword
      // 
      this.TxtPassword.Location = new System.Drawing.Point(66, 88);
      this.TxtPassword.Name = "TxtPassword";
      this.TxtPassword.Size = new System.Drawing.Size(216, 20);
      this.TxtPassword.TabIndex = 7;
      // 
      // TxtUsername
      // 
      this.TxtUsername.EditValue = "";
      this.TxtUsername.Location = new System.Drawing.Point(66, 62);
      this.TxtUsername.Name = "TxtUsername";
      this.TxtUsername.Size = new System.Drawing.Size(216, 20);
      this.TxtUsername.TabIndex = 6;
      // 
      // TxtApellidos
      // 
      this.TxtApellidos.Location = new System.Drawing.Point(66, 36);
      this.TxtApellidos.Name = "TxtApellidos";
      this.TxtApellidos.Size = new System.Drawing.Size(216, 20);
      this.TxtApellidos.TabIndex = 5;
      // 
      // TxtNombres
      // 
      this.TxtNombres.Location = new System.Drawing.Point(66, 10);
      this.TxtNombres.Name = "TxtNombres";
      this.TxtNombres.Size = new System.Drawing.Size(216, 20);
      this.TxtNombres.TabIndex = 4;
      // 
      // TabPerfiles
      // 
      this.TabPerfiles.Name = "TabPerfiles";
      this.TabPerfiles.Size = new System.Drawing.Size(285, 207);
      this.TabPerfiles.Text = "Perfiles";
      // 
      // BtnCancelar
      // 
      this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.BtnCancelar.Location = new System.Drawing.Point(211, 243);
      this.BtnCancelar.Name = "BtnCancelar";
      this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
      this.BtnCancelar.TabIndex = 5;
      this.BtnCancelar.Text = "&Cancelar";
      this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
      // 
      // BtnAceptar
      // 
      this.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.BtnAceptar.Location = new System.Drawing.Point(130, 243);
      this.BtnAceptar.Name = "BtnAceptar";
      this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
      this.BtnAceptar.TabIndex = 6;
      this.BtnAceptar.Text = "&Aceptar";
      this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
      // 
      // FrmEditorUsuario
      // 
      this.ClientSize = new System.Drawing.Size(297, 272);
      this.ControlBox = false;
      this.Controls.Add(this.BtnAceptar);
      this.Controls.Add(this.BtnCancelar);
      this.Controls.Add(this.xtraTabControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmEditorUsuario";
      this.ShowIcon = false;
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
  }
}