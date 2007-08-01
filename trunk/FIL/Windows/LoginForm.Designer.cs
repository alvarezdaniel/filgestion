namespace Windows
{
  partial class LoginForm
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
      this.LblUsuario = new DevExpress.XtraEditors.LabelControl();
      this.LblPassword = new DevExpress.XtraEditors.LabelControl();
      this.TxtUsuario = new DevExpress.XtraEditors.TextEdit();
      this.TxtPassword = new DevExpress.XtraEditors.TextEdit();
      this.BtnIngresar = new DevExpress.XtraEditors.SimpleButton();
      ((System.ComponentModel.ISupportInitialize)(this.TxtUsuario.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.TxtPassword.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // LblUsuario
      // 
      this.LblUsuario.Location = new System.Drawing.Point(12, 16);
      this.LblUsuario.Name = "LblUsuario";
      this.LblUsuario.Size = new System.Drawing.Size(40, 13);
      this.LblUsuario.TabIndex = 0;
      this.LblUsuario.Text = "Usuario:";
      // 
      // LblPassword
      // 
      this.LblPassword.Location = new System.Drawing.Point(12, 42);
      this.LblPassword.Name = "LblPassword";
      this.LblPassword.Size = new System.Drawing.Size(60, 13);
      this.LblPassword.TabIndex = 1;
      this.LblPassword.Text = "Contraseña:";
      // 
      // TxtUsuario
      // 
      this.TxtUsuario.Location = new System.Drawing.Point(83, 13);
      this.TxtUsuario.Name = "TxtUsuario";
      this.TxtUsuario.Size = new System.Drawing.Size(194, 20);
      this.TxtUsuario.TabIndex = 2;
      // 
      // TxtPassword
      // 
      this.TxtPassword.EnterMoveNextControl = true;
      this.TxtPassword.Location = new System.Drawing.Point(83, 39);
      this.TxtPassword.Name = "TxtPassword";
      this.TxtPassword.Properties.PasswordChar = '*';
      this.TxtPassword.Size = new System.Drawing.Size(194, 20);
      this.TxtPassword.TabIndex = 3;
      // 
      // BtnIngresar
      // 
      this.BtnIngresar.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.BtnIngresar.Location = new System.Drawing.Point(201, 67);
      this.BtnIngresar.Name = "BtnIngresar";
      this.BtnIngresar.Size = new System.Drawing.Size(75, 23);
      this.BtnIngresar.TabIndex = 4;
      this.BtnIngresar.Text = "Ingresar";
      this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
      // 
      // LoginForm
      // 
      this.ClientSize = new System.Drawing.Size(289, 102);
      this.Controls.Add(this.BtnIngresar);
      this.Controls.Add(this.TxtPassword);
      this.Controls.Add(this.TxtUsuario);
      this.Controls.Add(this.LblPassword);
      this.Controls.Add(this.LblUsuario);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "LoginForm";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Inicio de Sesión";
      this.TopMost = true;
      this.Load += new System.EventHandler(this.LoginForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.TxtUsuario.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.TxtPassword.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.LabelControl LblUsuario;
    private DevExpress.XtraEditors.LabelControl LblPassword;
    private DevExpress.XtraEditors.TextEdit TxtUsuario;
    private DevExpress.XtraEditors.TextEdit TxtPassword;
    private DevExpress.XtraEditors.SimpleButton BtnIngresar;
  }
}