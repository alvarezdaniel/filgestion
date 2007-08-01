namespace Windows
{
  partial class FrmEditorPerfil
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
      this.TxtDescripcion = new DevExpress.XtraEditors.TextEdit();
      this.LblDescripcion = new DevExpress.XtraEditors.LabelControl();
      this.LblAcciones = new DevExpress.XtraEditors.LabelControl();
      this.ChkLstAcciones = new DevExpress.XtraEditors.CheckedListBoxControl();
      this.BtnCancelar = new DevExpress.XtraEditors.SimpleButton();
      this.BtnAceptar = new DevExpress.XtraEditors.SimpleButton();
      ((System.ComponentModel.ISupportInitialize)(this.TxtDescripcion.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ChkLstAcciones)).BeginInit();
      this.SuspendLayout();
      // 
      // TxtDescripcion
      // 
      this.TxtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.TxtDescripcion.Location = new System.Drawing.Point(12, 31);
      this.TxtDescripcion.Name = "TxtDescripcion";
      this.TxtDescripcion.Size = new System.Drawing.Size(329, 20);
      this.TxtDescripcion.TabIndex = 0;
      // 
      // LblDescripcion
      // 
      this.LblDescripcion.Location = new System.Drawing.Point(12, 12);
      this.LblDescripcion.Name = "LblDescripcion";
      this.LblDescripcion.Size = new System.Drawing.Size(58, 13);
      this.LblDescripcion.TabIndex = 1;
      this.LblDescripcion.Text = "Descripción:";
      // 
      // LblAcciones
      // 
      this.LblAcciones.Location = new System.Drawing.Point(12, 57);
      this.LblAcciones.Name = "LblAcciones";
      this.LblAcciones.Size = new System.Drawing.Size(46, 13);
      this.LblAcciones.TabIndex = 2;
      this.LblAcciones.Text = "Acciones:";
      // 
      // ChkLstAcciones
      // 
      this.ChkLstAcciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.ChkLstAcciones.Location = new System.Drawing.Point(12, 76);
      this.ChkLstAcciones.Name = "ChkLstAcciones";
      this.ChkLstAcciones.Size = new System.Drawing.Size(329, 146);
      this.ChkLstAcciones.TabIndex = 3;
      // 
      // BtnCancelar
      // 
      this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.BtnCancelar.Location = new System.Drawing.Point(266, 228);
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
      this.BtnAceptar.Location = new System.Drawing.Point(185, 228);
      this.BtnAceptar.Name = "BtnAceptar";
      this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
      this.BtnAceptar.TabIndex = 5;
      this.BtnAceptar.Text = "&Aceptar";
      this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
      // 
      // FrmEditorPerfil
      // 
      this.ClientSize = new System.Drawing.Size(353, 263);
      this.Controls.Add(this.BtnAceptar);
      this.Controls.Add(this.BtnCancelar);
      this.Controls.Add(this.ChkLstAcciones);
      this.Controls.Add(this.LblAcciones);
      this.Controls.Add(this.LblDescripcion);
      this.Controls.Add(this.TxtDescripcion);
      this.Name = "FrmEditorPerfil";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Text = "Editor de Perfil";
      this.Load += new System.EventHandler(this.FrmEditorPerfil_Load);
      ((System.ComponentModel.ISupportInitialize)(this.TxtDescripcion.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ChkLstAcciones)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.TextEdit TxtDescripcion;
    private DevExpress.XtraEditors.LabelControl LblDescripcion;
    private DevExpress.XtraEditors.LabelControl LblAcciones;
    private DevExpress.XtraEditors.CheckedListBoxControl ChkLstAcciones;
    private DevExpress.XtraEditors.SimpleButton BtnCancelar;
    private DevExpress.XtraEditors.SimpleButton BtnAceptar;
  }
}