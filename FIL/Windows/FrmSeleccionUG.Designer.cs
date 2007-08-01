namespace Windows
{
  partial class FrmSeleccionUG
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
      this.LblSeleccione = new System.Windows.Forms.Label();
      this.CmbUnidades = new System.Windows.Forms.ComboBox();
      this.BtnAceptar = new DevExpress.XtraEditors.SimpleButton();
      this.SuspendLayout();
      // 
      // LblSeleccione
      // 
      this.LblSeleccione.AutoSize = true;
      this.LblSeleccione.Location = new System.Drawing.Point(13, 13);
      this.LblSeleccione.Name = "LblSeleccione";
      this.LblSeleccione.Size = new System.Drawing.Size(172, 13);
      this.LblSeleccione.TabIndex = 0;
      this.LblSeleccione.Text = "Seleccione una Unidad de Gestión:";
      // 
      // CmbUnidades
      // 
      this.CmbUnidades.FormattingEnabled = true;
      this.CmbUnidades.Location = new System.Drawing.Point(16, 29);
      this.CmbUnidades.Name = "CmbUnidades";
      this.CmbUnidades.Size = new System.Drawing.Size(261, 21);
      this.CmbUnidades.TabIndex = 1;
      // 
      // BtnAceptar
      // 
      this.BtnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.BtnAceptar.Location = new System.Drawing.Point(202, 61);
      this.BtnAceptar.Name = "BtnAceptar";
      this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
      this.BtnAceptar.TabIndex = 2;
      this.BtnAceptar.Text = "&Aceptar";
      // 
      // FrmSeleccionUG
      // 
      this.ClientSize = new System.Drawing.Size(289, 96);
      this.ControlBox = false;
      this.Controls.Add(this.BtnAceptar);
      this.Controls.Add(this.CmbUnidades);
      this.Controls.Add(this.LblSeleccione);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "FrmSeleccionUG";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Text = "Selección de Unidad de Gestión";
      this.Load += new System.EventHandler(this.FrmSeleccionUG_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label LblSeleccione;
    private System.Windows.Forms.ComboBox CmbUnidades;
    private DevExpress.XtraEditors.SimpleButton BtnAceptar;
  }
}