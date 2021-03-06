﻿using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace DXEFTestApp.Views.BlogView
{
    public partial class BlogView : XtraUserControl
    {
        public BlogView()
        {
            InitializeComponent();
            if (!mvvmContext.IsDesignMode)
                InitBindings();
        }
        void InitBindings()
        {
            var fluentAPI = mvvmContext.OfType<DXEFTestApp.ViewModels.BlogViewModel>();
            fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                blogViewBindingSource, x => x.Entity, x => x.Update());
            #region Post Detail Collection
            // We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(PostGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.BlogPostDetails.SelectedEntity,
                    args => args.Row as Model.Post,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            // We want to proceed the Edit command when row double-clicked
            fluentAPI.WithEvent<RowClickEventArgs>(PostGridView, "RowClick")
                         .EventToCommand(
                             x => x.BlogPostDetails.Edit(null), x => x.BlogPostDetails.SelectedEntity,
                             args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
            //We want to show PopupMenu when row clicked by right button
            PostGridView.RowClick += (s, e) =>
            {
                if (e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    PostPopUpMenu.ShowPopup(PostGridControl.PointToScreen(e.Location), s);
                }
            };
            // We want to show the BlogPostDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluentAPI.SetBinding(PostGridControl, g => g.DataSource, x => x.BlogPostDetails.Entities);

            fluentAPI.BindCommand(bbiPostNew, x => x.BlogPostDetails.New());
            fluentAPI.BindCommand(bbiPostEdit, x => x.BlogPostDetails.Edit(null), x => x.BlogPostDetails.SelectedEntity);
            fluentAPI.BindCommand(bbiPostDelete, x => x.BlogPostDetails.Delete(null), x => x.BlogPostDetails.SelectedEntity);
            fluentAPI.BindCommand(bbiPostRefresh, x => x.BlogPostDetails.Refresh());
            #endregion
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());
        }
    }
}
