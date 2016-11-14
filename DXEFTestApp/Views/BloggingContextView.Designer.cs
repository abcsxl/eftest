namespace DXEFTestApp.Views.BloggingContextView
{
    partial class BloggingContextView
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroupTables = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarItemBlogCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItemPostCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarGroupViews = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // tileBar
            // 
            this.tileBar.AllowDrag = false;
            this.tileBar.AllowGlyphSkinning = true;
            this.tileBar.AllowSelectedItem = true;
            this.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tileBar.AppearanceGroupText.Options.UseForeColor = true;
            this.tileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.DropDownButtonWidth = 30;
            this.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar.Groups.Add(this.tileBarGroupTables);
            this.tileBar.Groups.Add(this.tileBarGroupViews);
            this.tileBar.IndentBetweenGroups = 10;
            this.tileBar.IndentBetweenItems = 10;
            this.tileBar.ItemPadding = new System.Windows.Forms.Padding(8, 6, 12, 6);
            this.tileBar.Location = new System.Drawing.Point(0, 0);
            this.tileBar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tileBar.MaximumSize = new System.Drawing.Size(0, 118);
            this.tileBar.MinimumSize = new System.Drawing.Size(117, 118);
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(34, 12, 34, 12);
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.Size = new System.Drawing.Size(1195, 118);
            this.tileBar.TabIndex = 1;
            this.tileBar.Text = "tileBar";
            this.tileBar.WideTileWidth = 150;
            // 
            // tileBarGroupTables
            // 
            this.tileBarGroupTables.Items.Add(this.tileBarItemBlogCollectionView);
            this.tileBarGroupTables.Items.Add(this.tileBarItemPostCollectionView);
            this.tileBarGroupTables.Name = "tileBarGroupTables";
            this.tileBarGroupTables.Text = "TABLES";
            // 
            // tileBarItemBlogCollectionView
            // 
            this.tileBarItemBlogCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.tileBarItemBlogCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItemBlogCollectionView.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
            tileItemElement1.Text = "Blogs";
            this.tileBarItemBlogCollectionView.Elements.Add(tileItemElement1);
            this.tileBarItemBlogCollectionView.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileBarItemBlogCollectionView.Name = "tileBarItemBlogCollectionView";
            // 
            // tileBarItemPostCollectionView
            // 
            this.tileBarItemPostCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tileBarItemPostCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItemPostCollectionView.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
            tileItemElement2.Text = "Posts";
            this.tileBarItemPostCollectionView.Elements.Add(tileItemElement2);
            this.tileBarItemPostCollectionView.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileBarItemPostCollectionView.Name = "tileBarItemPostCollectionView";
            // 
            // tileBarGroupViews
            // 
            this.tileBarGroupViews.Name = "tileBarGroupViews";
            this.tileBarGroupViews.Text = "VIEWS";
            // 
            // navigationFrame
            // 
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 118);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.SelectedPage = null;
            this.navigationFrame.SelectedPageIndex = -1;
            this.navigationFrame.Size = new System.Drawing.Size(1195, 709);
            this.navigationFrame.TabIndex = 0;
            this.navigationFrame.Text = "navigationFrame";
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(DXEFTestApp.ViewModels.BloggingContextViewModel);
            // 
            // BloggingContextView
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.tileBar);
            this.Name = "BloggingContextView";
            this.Size = new System.Drawing.Size(1195, 827);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupTables;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupViews;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemBlogCollectionView;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemPostCollectionView;
    }
}
