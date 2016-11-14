namespace DXEFTestApp.Views.BlogView
{
    partial class BlogView
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
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.blogViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PostXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
            this.PostGridControl = new DevExpress.XtraGrid.GridControl();
            this.PostGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBlogId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBlog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.IdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForId = new DevExpress.XtraLayout.LayoutControlItem();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.UrlTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForUrl = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPost = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.windowsUIButtonPanelCloseButton = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.windowsUIButtonPanelMain = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.PostBarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bbiPostNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPostEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPostDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPostRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.PostBar = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.PostPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogViewBindingSource)).BeginInit();
            this.PostXtraUserControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PostGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UrlTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostBarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostPopUpMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.IdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UrlTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PostXtraUserControl);
            this.dataLayoutControl1.DataSource = this.blogViewBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(52, 30);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1143, 732);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1143, 732);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // blogViewBindingSource
            // 
            this.blogViewBindingSource.DataSource = typeof(Model.Blog);
            // 
            // PostXtraUserControl
            // 
            this.PostXtraUserControl.Controls.Add(this.PostGridControl);
            this.PostXtraUserControl.Controls.Add(this.barDockControlLeft);
            this.PostXtraUserControl.Controls.Add(this.barDockControlRight);
            this.PostXtraUserControl.Controls.Add(this.barDockControlBottom);
            this.PostXtraUserControl.Controls.Add(this.barDockControlTop);
            this.PostXtraUserControl.Location = new System.Drawing.Point(24, 119);
            this.PostXtraUserControl.MinimumSize = new System.Drawing.Size(117, 108);
            this.PostXtraUserControl.Name = "PostXtraUserControl";
            this.PostXtraUserControl.Size = new System.Drawing.Size(1095, 589);
            this.PostXtraUserControl.TabIndex = 7;
            // 
            // PostGridControl
            // 
            this.PostGridControl.DataSource = this.PostBindingSource;
            this.PostGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PostGridControl.Location = new System.Drawing.Point(0, 24);
            this.PostGridControl.MainView = this.PostGridView;
            this.PostGridControl.Name = "PostGridControl";
            this.PostGridControl.Size = new System.Drawing.Size(1095, 565);
            this.PostGridControl.TabIndex = 0;
            this.PostGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PostGridView});
            // 
            // PostGridView
            // 
            this.PostGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTitle,
            this.colContent,
            this.colBlogId,
            this.colBlog});
            this.PostGridView.GridControl = this.PostGridControl;
            this.PostGridView.Name = "PostGridView";
            this.PostGridView.OptionsBehavior.Editable = false;
            this.PostGridView.OptionsBehavior.ReadOnly = true;
            this.PostGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colTitle
            // 
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 1;
            // 
            // colContent
            // 
            this.colContent.FieldName = "Content";
            this.colContent.Name = "colContent";
            this.colContent.Visible = true;
            this.colContent.VisibleIndex = 2;
            // 
            // colBlogId
            // 
            this.colBlogId.FieldName = "BlogId";
            this.colBlogId.Name = "colBlogId";
            // 
            // colBlog
            // 
            this.colBlog.FieldName = "Blog";
            this.colBlog.Name = "colBlog";
            // 
            // PostBindingSource
            // 
            this.PostBindingSource.DataSource = typeof(Model.Post);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForId,
            this.ItemForName,
            this.ItemForUrl,
            this.tabbedControlGroup1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1123, 712);
            // 
            // IdTextEdit
            // 
            this.IdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.blogViewBindingSource, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IdTextEdit.Location = new System.Drawing.Point(46, 12);
            this.IdTextEdit.Name = "IdTextEdit";
            this.IdTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.IdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IdTextEdit.Properties.Mask.EditMask = "N0";
            this.IdTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.IdTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.IdTextEdit.Size = new System.Drawing.Size(1085, 20);
            this.IdTextEdit.StyleController = this.dataLayoutControl1;
            this.IdTextEdit.TabIndex = 4;
            // 
            // ItemForId
            // 
            this.ItemForId.Control = this.IdTextEdit;
            this.ItemForId.Location = new System.Drawing.Point(0, 0);
            this.ItemForId.Name = "ItemForId";
            this.ItemForId.Size = new System.Drawing.Size(1123, 24);
            this.ItemForId.Text = "Id";
            this.ItemForId.TextSize = new System.Drawing.Size(31, 14);
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.blogViewBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NameTextEdit.Location = new System.Drawing.Point(46, 36);
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Size = new System.Drawing.Size(1085, 20);
            this.NameTextEdit.StyleController = this.dataLayoutControl1;
            this.NameTextEdit.TabIndex = 5;
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.Location = new System.Drawing.Point(0, 24);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(1123, 24);
            this.ItemForName.Text = "Name";
            this.ItemForName.TextSize = new System.Drawing.Size(31, 14);
            // 
            // UrlTextEdit
            // 
            this.UrlTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.blogViewBindingSource, "Url", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.UrlTextEdit.Location = new System.Drawing.Point(46, 60);
            this.UrlTextEdit.Name = "UrlTextEdit";
            this.UrlTextEdit.Size = new System.Drawing.Size(1085, 20);
            this.UrlTextEdit.StyleController = this.dataLayoutControl1;
            this.UrlTextEdit.TabIndex = 6;
            // 
            // ItemForUrl
            // 
            this.ItemForUrl.Control = this.UrlTextEdit;
            this.ItemForUrl.Location = new System.Drawing.Point(0, 48);
            this.ItemForUrl.Name = "ItemForUrl";
            this.ItemForUrl.Size = new System.Drawing.Size(1123, 24);
            this.ItemForUrl.Text = "Url";
            this.ItemForUrl.TextSize = new System.Drawing.Size(31, 14);
            // 
            // ItemForPost
            // 
            this.ItemForPost.Control = this.PostXtraUserControl;
            this.ItemForPost.Location = new System.Drawing.Point(0, 0);
            this.ItemForPost.Name = "ItemForPost";
            this.ItemForPost.Size = new System.Drawing.Size(1099, 593);
            this.ItemForPost.StartNewLine = true;
            this.ItemForPost.Text = "Post";
            this.ItemForPost.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForPost.TextVisible = false;
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 72);
            this.tabbedControlGroup1.Name = "autoGroupForTabs";
            this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup3;
            this.tabbedControlGroup1.SelectedTabPageIndex = 0;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(1123, 640);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            this.tabbedControlGroup1.Text = "Tabs";
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForPost});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "autoGroupForPost";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1099, 593);
            this.layoutControlGroup3.Text = "Post";
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(DXEFTestApp.ViewModels.BlogViewModel);
            // 
            // windowsUIButtonPanelCloseButton
            // 
            this.windowsUIButtonPanelCloseButton.ButtonInterval = 0;
            this.windowsUIButtonPanelCloseButton.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", null, "Backward;Size32x32;GrayScaled")});
            this.windowsUIButtonPanelCloseButton.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.windowsUIButtonPanelCloseButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.windowsUIButtonPanelCloseButton.ForeColor = System.Drawing.Color.Gray;
            this.windowsUIButtonPanelCloseButton.Location = new System.Drawing.Point(0, 0);
            this.windowsUIButtonPanelCloseButton.MaximumSize = new System.Drawing.Size(52, 0);
            this.windowsUIButtonPanelCloseButton.MinimumSize = new System.Drawing.Size(52, 0);
            this.windowsUIButtonPanelCloseButton.Name = "windowsUIButtonPanelCloseButton";
            this.windowsUIButtonPanelCloseButton.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.windowsUIButtonPanelCloseButton.Padding = new System.Windows.Forms.Padding(6, 5, 0, 0);
            this.windowsUIButtonPanelCloseButton.Size = new System.Drawing.Size(52, 762);
            this.windowsUIButtonPanelCloseButton.TabIndex = 2;
            this.windowsUIButtonPanelCloseButton.Text = "windowsUIButtonPanel1";
            // 
            // windowsUIButtonPanelMain
            // 
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Normal.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Normal.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.windowsUIButtonPanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.windowsUIButtonPanelMain.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save", null, "Save;Size32x32;GrayScaled"),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save And Close", null, "SaveAndClose;Size32x32;GrayScaled"),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save And New", null, "SaveAndNew;Size32x32;GrayScaled"),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Reset Changes", null, "Reset;Size32x32;GrayScaled"),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Delete", null, "Edit/Delete;Size32x32;GrayScaled")});
            this.windowsUIButtonPanelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowsUIButtonPanelMain.EnableImageTransparency = true;
            this.windowsUIButtonPanelMain.ForeColor = System.Drawing.Color.White;
            this.windowsUIButtonPanelMain.Location = new System.Drawing.Point(0, 762);
            this.windowsUIButtonPanelMain.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.windowsUIButtonPanelMain.MaximumSize = new System.Drawing.Size(0, 65);
            this.windowsUIButtonPanelMain.MinimumSize = new System.Drawing.Size(70, 65);
            this.windowsUIButtonPanelMain.Name = "windowsUIButtonPanelMain";
            this.windowsUIButtonPanelMain.Size = new System.Drawing.Size(1195, 65);
            this.windowsUIButtonPanelMain.TabIndex = 3;
            this.windowsUIButtonPanelMain.Text = "windowsUIButtonPanelMain";
            this.windowsUIButtonPanelMain.UseButtonBackgroundImages = false;
            // 
            // labelControl
            // 
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Location = new System.Drawing.Point(52, 0);
            this.labelControl.Name = "labelControl";
            this.labelControl.Padding = new System.Windows.Forms.Padding(12, 5, 0, 0);
            this.labelControl.Size = new System.Drawing.Size(1143, 30);
            this.labelControl.TabIndex = 1;
            this.labelControl.Text = "Blog - Element View";
            // 
            // PostBarManager
            // 
            this.PostBarManager.AllowCustomization = false;
            this.PostBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.PostBar});
            this.PostBarManager.DockControls.Add(this.barDockControlTop);
            this.PostBarManager.DockControls.Add(this.barDockControlBottom);
            this.PostBarManager.DockControls.Add(this.barDockControlLeft);
            this.PostBarManager.DockControls.Add(this.barDockControlRight);
            this.PostBarManager.Form = this.PostXtraUserControl;
            this.PostBarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiPostNew,
            this.bbiPostEdit,
            this.bbiPostDelete,
            this.bbiPostRefresh});
            this.PostBarManager.MainMenu = this.PostBar;
            this.PostBarManager.MaxItemId = 4;
            // 
            // bbiPostNew
            // 
            this.bbiPostNew.Caption = "New";
            this.bbiPostNew.Id = 0;
            this.bbiPostNew.ImageUri.Uri = "New";
            this.bbiPostNew.Name = "bbiPostNew";
            this.bbiPostNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbiPostEdit
            // 
            this.bbiPostEdit.Caption = "Edit";
            this.bbiPostEdit.Id = 1;
            this.bbiPostEdit.ImageUri.Uri = "Edit";
            this.bbiPostEdit.Name = "bbiPostEdit";
            this.bbiPostEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbiPostDelete
            // 
            this.bbiPostDelete.Caption = "Delete";
            this.bbiPostDelete.Id = 2;
            this.bbiPostDelete.ImageUri.Uri = "Delete";
            this.bbiPostDelete.Name = "bbiPostDelete";
            this.bbiPostDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbiPostRefresh
            // 
            this.bbiPostRefresh.Caption = "Refresh";
            this.bbiPostRefresh.Id = 3;
            this.bbiPostRefresh.ImageUri.Uri = "Refresh";
            this.bbiPostRefresh.Name = "bbiPostRefresh";
            this.bbiPostRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // PostBar
            // 
            this.PostBar.BarName = "Post";
            this.PostBar.DockCol = 0;
            this.PostBar.DockRow = 0;
            this.PostBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.PostBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiPostNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiPostEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiPostDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiPostRefresh)});
            this.PostBar.OptionsBar.AllowQuickCustomization = false;
            this.PostBar.OptionsBar.DrawDragBorder = false;
            this.PostBar.Text = "Post";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1095, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 589);
            this.barDockControlBottom.Size = new System.Drawing.Size(1095, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 565);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1095, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 565);
            // 
            // PostPopUpMenu
            // 
            this.PostPopUpMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiPostNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiPostEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiPostDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiPostRefresh)});
            this.PostPopUpMenu.Manager = this.PostBarManager;
            this.PostPopUpMenu.Name = "PostPopUpMenu";
            // 
            // BlogView
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.labelControl);
            this.Controls.Add(this.windowsUIButtonPanelCloseButton);
            this.Controls.Add(this.windowsUIButtonPanelMain);
            this.Name = "BlogView";
            this.Size = new System.Drawing.Size(1195, 827);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogViewBindingSource)).EndInit();
            this.PostXtraUserControl.ResumeLayout(false);
            this.PostXtraUserControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PostGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UrlTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostBarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostPopUpMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
        private DevExpress.XtraEditors.LabelControl labelControl;
        private System.Windows.Forms.BindingSource blogViewBindingSource;
        private DevExpress.XtraGrid.GridControl PostGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView PostGridView;
        private DevExpress.XtraBars.BarManager PostBarManager;
        private DevExpress.XtraBars.Bar PostBar;
        private DevExpress.XtraEditors.XtraUserControl PostXtraUserControl;
        private DevExpress.XtraBars.PopupMenu PostPopUpMenu;
        private DevExpress.XtraBars.BarButtonItem bbiPostNew;
        private DevExpress.XtraBars.BarButtonItem bbiPostEdit;
        private DevExpress.XtraBars.BarButtonItem bbiPostDelete;
        private DevExpress.XtraBars.BarButtonItem bbiPostRefresh;
        private DevExpress.XtraEditors.TextEdit IdTextEdit;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private DevExpress.XtraEditors.TextEdit UrlTextEdit;
        private System.Windows.Forms.BindingSource PostBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colContent;
        private DevExpress.XtraGrid.Columns.GridColumn colBlogId;
        private DevExpress.XtraGrid.Columns.GridColumn colBlog;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUrl;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPost;
    }
}
