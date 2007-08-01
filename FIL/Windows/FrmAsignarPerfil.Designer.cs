namespace Windows
{
  partial class FrmAsignarPerfil
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
      this.CmbUnidadesDeGestion = new DevExpress.XtraEditors.ComboBoxEdit();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.CmbPerfiles = new DevExpress.XtraEditors.ComboBoxEdit();
      this.BtnCancelar = new DevExpress.XtraEditors.SimpleButton();
      this.BtnAceptar = new DevExpress.XtraEditors.SimpleButton();
      ((System.ComponentModel.ISupportInitialize)(this.CmbUnidadesDeGestion.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.CmbPerfiles.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // CmbUnidadesDeGestion
      // 
      this.CmbUnidadesDeGestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.CmbUnidadesDeGestion.Location = new System.Drawing.Point(110, 9);
      this.CmbUnidadesDeGestion.Name = "CmbUnidadesDeGestion";
      this.CmbUnidadesDeGestion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.CmbUnidadesDeGestion.Size = new System.Drawing.Size(179, 20);
      this.CmbUnidadesDeGestion.TabIndex = 0;
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(12, 12);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(92, 13);
      this.labelControl1.TabIndex = 1;
      this.labelControl1.Text = "Unidad De Gestion:";
      // 
      // labelControl2
      // 
      this.labelControl2.Location = new System.Drawing.Point(12, 38);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(28, 13);
      this.labelControl2.TabIndex = 2;
      this.labelControl2.Text = "Perfil:";
      // 
      // CmbPerfiles
      // 
      this.CmbPerfiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.CmbPerfiles.Location = new System.Drawing.Point(110, 35);
      this.CmbPerfiles.Name = "CmbPerfiles";
      this.CmbPerfiles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.CmbPerfiles.Size = new System.Drawing.Size(179, 20);
      this.CmbPerfiles.TabIndex = 3;
      // 
      // BtnCancelar
      // 
      this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.BtnCancelar.Location = new System.Drawing.Point(213, 71);
      this.BtnCancelar.Name = "BtnCancelar";
      this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
      this.BtnCancelar.TabIndex = 4;
      this.BtnCancelar.Text = "&Cancelar";
      this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
      // 
      // BtnAceptar
      // 
      this.BtnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.BtnAceptar.Location = new System.Drawing.Point(132, 71);
      this.BtnAceptar.Name = "BtnAceptar";
      this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
      this.BtnAceptar.TabIndex = 5;
      this.BtnAceptar.Text = "&Aceptar";
      this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
      // 
      // FrmAsignarPerfil
      // 
      this.ClientSize = new System.Drawing.Size(297, 102);
      this.ControlBox = false;
      this.Controls.Add(this.BtnAceptar);
      this.Controls.Add(this.BtnCancelar);
      this.Controls.Add(this.CmbPerfiles);
      this.Controls.Add(this.labelControl2);
      this.Controls.Add(this.labelControl1);
      this.Controls.Add(this.CmbUnidadesDeGestion);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "FrmAsignarPerfil";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Text = "Asignar Perfil";
      this.Load += new System.EventHandler(this.FrmAsignarPerfil_Load);
      ((System.ComponentModel.ISupportInitialize)(this.CmbUnidadesDeGestion.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.CmbPerfiles.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.ComboBoxEdit CmbUnidadesDeGestion;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.LabelControl labelControl2;
    private DevExpress.XtraEditors.ComboBoxEdit CmbPerfiles;
    private DevExpress.XtraEditors.SimpleButton BtnCancelar;
    private DevExpress.XtraEditors.SimpleButton BtnAceptar;
  }
}