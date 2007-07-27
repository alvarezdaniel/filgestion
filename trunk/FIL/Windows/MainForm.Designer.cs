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
      this.mnuAyuda = new DevExpress.XtraBars.BarButtonItem();
      this.StatusBar = new DevExpress.XtraBars.Bar();
      this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
      this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
      this.menuImageList = new System.Windows.Forms.ImageList(this.components);
      this.mnuABMs = new DevExpress.XtraBars.BarSubItem();
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
      this.barManager1.Images = this.menuImageList;
      this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mnuArchivo,
            this.mnuSalir,
            this.mnuAyuda,
            this.barStaticItem1});
      this.barManager1.MainMenu = this.MainBar;
      this.barManager1.MaxItemId = 3;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuAyuda)});
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
      // mnuAyuda
      // 
      this.mnuAyuda.Caption = "&?";
      this.mnuAyuda.Id = 2;
      this.mnuAyuda.Name = "mnuAyuda";
      // 
      // StatusBar
      // 
      this.StatusBar.BarName = "Barra de Estado";
      this.StatusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
      this.StatusBar.DockCol = 0;
      this.StatusBar.DockRow = 0;
      this.StatusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
      this.StatusBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1)});
      this.StatusBar.OptionsBar.AllowQuickCustomization = false;
      this.StatusBar.OptionsBar.DrawDragBorder = false;
      this.StatusBar.OptionsBar.UseWholeRow = true;
      this.StatusBar.Text = "Barra de Estado";
      // 
      // barStaticItem1
      // 
      this.barStaticItem1.Caption = "Listo";
      this.barStaticItem1.Id = 3;
      this.barStaticItem1.Name = "barStaticItem1";
      this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
      // 
      // menuImageList
      // 
      this.menuImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
      this.menuImageList.ImageSize = new System.Drawing.Size(8, 8);
      this.menuImageList.TransparentColor = System.Drawing.Color.Transparent;
      // 
      // mnuABMs
      // 
      this.mnuABMs.Id = -1;
      this.mnuABMs.Name = "mnuABMs";
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
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.MainForm_Load);
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
    private DevExpress.XtraBars.BarButtonItem mnuAyuda;
    private DevExpress.XtraBars.BarStaticItem barStaticItem1;
    private DevExpress.XtraBars.BarSubItem mnuABMs;
    private System.Windows.Forms.ImageList menuImageList;

  }
}