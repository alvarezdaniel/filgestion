namespace Windows
{
  partial class MainForm
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
      this.components = new System.ComponentModel.Container();
      this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
      this.MainBar = new DevExpress.XtraBars.Bar();
      this.mnuArchivo = new DevExpress.XtraBars.BarSubItem();
      this.mnuSalir = new DevExpress.XtraBars.BarButtonItem();
      this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
      this.StatusBar = new DevExpress.XtraBars.Bar();
      this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
      this.SuspendLayout();
      // 
      // barManager1
      // 
      this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.MainBar,
            this.StatusBar});
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = this;
      this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mnuArchivo,
            this.mnuSalir,
            this.barButtonItem1});
      this.barManager1.MainMenu = this.MainBar;
      this.barManager1.MaxItemId = 5;
      this.barManager1.StatusBar = this.StatusBar;
      // 
      // MainBar
      // 
      this.MainBar.BarName = "Barra de Menú";
      this.MainBar.DockCol = 0;
      this.MainBar.DockRow = 0;
      this.MainBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
      this.MainBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuArchivo),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
      this.MainBar.OptionsBar.MultiLine = true;
      this.MainBar.OptionsBar.UseWholeRow = true;
      this.MainBar.Text = "Barra de Menú";
      // 
      // mnuArchivo
      // 
      this.mnuArchivo.Caption = "&Archivo";
      this.mnuArchivo.Id = 0;
      this.mnuArchivo.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSalir, true)});
      this.mnuArchivo.Name = "mnuArchivo";
      // 
      // mnuSalir
      // 
      this.mnuSalir.Caption = "&Salir";
      this.mnuSalir.Id = 1;
      this.mnuSalir.Name = "mnuSalir";
      this.mnuSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSalir_ItemClick);
      // 
      // barButtonItem1
      // 
      this.barButtonItem1.Caption = "&?";
      this.barButtonItem1.Id = 2;
      this.barButtonItem1.Name = "barButtonItem1";
      // 
      // StatusBar
      // 
      this.StatusBar.BarName = "Barra de Estado";
      this.StatusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
      this.StatusBar.DockCol = 0;
      this.StatusBar.DockRow = 0;
      this.StatusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
      this.StatusBar.OptionsBar.AllowQuickCustomization = false;
      this.StatusBar.OptionsBar.DrawDragBorder = false;
      this.StatusBar.OptionsBar.UseWholeRow = true;
      this.StatusBar.Text = "Barra de Estado";
      // 
      // MainForm
      // 
      this.ClientSize = new System.Drawing.Size(465, 273);
      this.Controls.Add(this.barDockControlLeft);
      this.Controls.Add(this.barDockControlRight);
      this.Controls.Add(this.barDockControlBottom);
      this.Controls.Add(this.barDockControlTop);
      this.IsMdiContainer = true;
      this.Name = "MainForm";
      this.Text = "Prototipo FIL";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraBars.BarManager barManager1;
    private DevExpress.XtraBars.Bar MainBar;
    private DevExpress.XtraBars.BarSubItem mnuArchivo;
    private DevExpress.XtraBars.Bar StatusBar;
    private DevExpress.XtraBars.BarDockControl barDockControlTop;
    private DevExpress.XtraBars.BarDockControl barDockControlBottom;
    private DevExpress.XtraBars.BarDockControl barDockControlLeft;
    private DevExpress.XtraBars.BarDockControl barDockControlRight;
    private DevExpress.XtraBars.BarButtonItem mnuSalir;
    private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    private DevExpress.XtraBars.BarSubItem barSubItem1;
    private DevExpress.XtraBars.BarButtonItem barButtonItem2;


  }
}