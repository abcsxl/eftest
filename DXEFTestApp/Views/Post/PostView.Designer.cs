namespace DXEFTestApp.Views.PostView
{
    partial class PostView
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
            this.postViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BlogLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.BlogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.IdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForId = new DevExpress.XtraLayout.LayoutControlItem();
            this.TitleTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForTitle = new DevExpress.XtraLayout.LayoutControlItem();
            this.ContentTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForContent = new DevExpress.XtraLayout.LayoutControlItem();
            this.BlogLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ItemForBlogId = new DevExpress.XtraLayout.LayoutControlItem();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.windowsUIButtonPanelCloseButton = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.windowsUIButtonPanelMain = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlogLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContentTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlogLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBlogId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.IdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TitleTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ContentTextEdit);
            this.dataLayoutControl1.Controls.Add(this.BlogLookUpEdit);
            this.dataLayoutControl1.DataSource = this.postViewBindingSource;
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
            // postViewBindingSource
            // 
            this.postViewBindingSource.DataSource = typeof(Model.Post);
            // 
            // BlogLookUpEdit
            // 
            this.BlogLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.postViewBindingSource, "BlogId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BlogLookUpEdit.Location = new System.Drawing.Point(60, 84);
            this.BlogLookUpEdit.Name = "BlogLookUpEdit";
            this.BlogLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BlogLookUpEdit.Properties.DataSource = this.BlogBindingSource;
            this.BlogLookUpEdit.Properties.DisplayMember = "Name";
            this.BlogLookUpEdit.Properties.ValueMember = "Id";
            this.BlogLookUpEdit.Properties.View = this.BlogLookUpEditView;
            this.BlogLookUpEdit.Size = new System.Drawing.Size(1071, 20);
            this.BlogLookUpEdit.StyleController = this.dataLayoutControl1;
            this.BlogLookUpEdit.TabIndex = 7;
            // 
            // BlogBindingSource
            // 
            this.BlogBindingSource.DataSource = typeof(Model.Blog);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForId,
            this.ItemForTitle,
            this.ItemForContent,
            this.ItemForBlogId});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1123, 712);
            // 
            // IdTextEdit
            // 
            this.IdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.postViewBindingSource, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IdTextEdit.Location = new System.Drawing.Point(60, 12);
            this.IdTextEdit.Name = "IdTextEdit";
            this.IdTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.IdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IdTextEdit.Properties.Mask.EditMask = "N0";
            this.IdTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.IdTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.IdTextEdit.Size = new System.Drawing.Size(1071, 20);
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
            this.ItemForId.TextSize = new System.Drawing.Size(45, 14);
            // 
            // TitleTextEdit
            // 
            this.TitleTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.postViewBindingSource, "Title", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TitleTextEdit.Location = new System.Drawing.Point(60, 36);
            this.TitleTextEdit.Name = "TitleTextEdit";
            this.TitleTextEdit.Size = new System.Drawing.Size(1071, 20);
            this.TitleTextEdit.StyleController = this.dataLayoutControl1;
            this.TitleTextEdit.TabIndex = 5;
            // 
            // ItemForTitle
            // 
            this.ItemForTitle.Control = this.TitleTextEdit;
            this.ItemForTitle.Location = new System.Drawing.Point(0, 24);
            this.ItemForTitle.Name = "ItemForTitle";
            this.ItemForTitle.Size = new System.Drawing.Size(1123, 24);
            this.ItemForTitle.Text = "Title";
            this.ItemForTitle.TextSize = new System.Drawing.Size(45, 14);
            // 
            // ContentTextEdit
            // 
            this.ContentTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.postViewBindingSource, "Content", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ContentTextEdit.Location = new System.Drawing.Point(60, 60);
            this.ContentTextEdit.Name = "ContentTextEdit";
            this.ContentTextEdit.Size = new System.Drawing.Size(1071, 20);
            this.ContentTextEdit.StyleController = this.dataLayoutControl1;
            this.ContentTextEdit.TabIndex = 6;
            // 
            // ItemForContent
            // 
            this.ItemForContent.Control = this.ContentTextEdit;
            this.ItemForContent.Location = new System.Drawing.Point(0, 48);
            this.ItemForContent.Name = "ItemForContent";
            this.ItemForContent.Size = new System.Drawing.Size(1123, 24);
            this.ItemForContent.Text = "Content";
            this.ItemForContent.TextSize = new System.Drawing.Size(45, 14);
            // 
            // BlogLookUpEditView
            // 
            this.BlogLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.BlogLookUpEditView.Name = "BlogLookUpEditView";
            this.BlogLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.BlogLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // ItemForBlogId
            // 
            this.ItemForBlogId.Control = this.BlogLookUpEdit;
            this.ItemForBlogId.Location = new System.Drawing.Point(0, 72);
            this.ItemForBlogId.Name = "ItemForBlogId";
            this.ItemForBlogId.Size = new System.Drawing.Size(1123, 640);
            this.ItemForBlogId.Text = "Blog Id";
            this.ItemForBlogId.TextSize = new System.Drawing.Size(45, 14);
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(DXEFTestApp.ViewModels.PostViewModel);
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
            this.labelControl.Text = "Post - Element View";
            // 
            // PostView
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
            this.Name = "PostView";
            this.Size = new System.Drawing.Size(1195, 827);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlogLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContentTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlogLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBlogId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
        private DevExpress.XtraEditors.LabelControl labelControl;
        private System.Windows.Forms.BindingSource postViewBindingSource;
        private DevExpress.XtraEditors.GridLookUpEdit BlogLookUpEdit;
        private System.Windows.Forms.BindingSource BlogBindingSource;
        private DevExpress.XtraEditors.TextEdit IdTextEdit;
        private DevExpress.XtraEditors.TextEdit TitleTextEdit;
        private DevExpress.XtraEditors.TextEdit ContentTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView BlogLookUpEditView;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTitle;
        private DevExpress.XtraLayout.LayoutControlItem ItemForContent;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBlogId;
    }
}
