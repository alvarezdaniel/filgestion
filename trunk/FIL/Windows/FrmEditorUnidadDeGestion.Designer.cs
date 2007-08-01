namespace Windows
{
  partial class FrmEditorUnidadDeGestion
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
      this.TxtNombre = new DevExpress.XtraEditors.TextEdit();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.BtnCancelar = new DevExpress.XtraEditors.SimpleButton();
      this.BtnAceptar = new DevExpress.XtraEditors.SimpleButton();
      ((System.ComponentModel.ISupportInitialize)(this.TxtNombre.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // TxtNombre
      // 
      this.TxtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.TxtNombre.Location = new System.Drawing.Point(60, 15);
      this.TxtNombre.Name = "TxtNombre";
      this.TxtNombre.Size = new System.Drawing.Size(220, 20);
      this.TxtNombre.TabIndex = 0;
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(13, 18);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(41, 13);
      this.labelControl1.TabIndex = 1;
      this.labelControl1.Text = "Nombre:";
      // 
      // BtnCancelar
      // 
      this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.BtnCancelar.Location = new System.Drawing.Point(204, 52);
      this.BtnCancelar.Name = "BtnCancelar";
      this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
      this.BtnCancelar.TabIndex = 2;
      this.BtnCancelar.Text = "&Cancelar";
      this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
      // 
      // BtnAceptar
      // 
      this.BtnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.BtnAceptar.Location = new System.Drawing.Point(123, 51);
      this.BtnAceptar.Name = "BtnAceptar";
      this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
      this.BtnAceptar.TabIndex = 3;
      this.BtnAceptar.Text = "&Aceptar";
      this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
      // 
      // FrmEditorUnidadDeGestion
      // 
      this.ClientSize = new System.Drawing.Size(292, 87);
      this.Controls.Add(this.BtnAceptar);
      this.Controls.Add(this.BtnCancelar);
      this.Controls.Add(this.labelControl1);
      this.Controls.Add(this.TxtNombre);
      this.Name = "FrmEditorUnidadDeGestion";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Text = "Editor de Unidad De Gestion";
      this.Load += new System.EventHandler(this.FrmEditorUnidadDeGestion_Load);
      ((System.ComponentModel.ISupportInitialize)(this.TxtNombre.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.TextEdit TxtNombre;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.SimpleButton BtnCancelar;
    private DevExpress.XtraEditors.SimpleButton BtnAceptar;
  }
}