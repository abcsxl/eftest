using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DXEFTestApp.Common.DataModel;
using DXEFTestApp.Common.ViewModel;
using DXEFTestApp.BloggingContextDataModel;
using Model;

namespace DXEFTestApp.ViewModels
{
    /// <summary>
    /// Represents the root POCO view model for the BloggingContext data model.
    /// </summary>
    public partial class BloggingContextViewModel : DocumentsViewModel<BloggingContextModuleDescription, IBloggingContextUnitOfWork>
    {

        const string TablesGroup = "Tables";

        const string ViewsGroup = "Views";
        INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }

        /// <summary>
        /// Creates a new instance of BloggingContextViewModel as a POCO view model.
        /// </summary>
        public static BloggingContextViewModel Create()
        {
            return ViewModelSource.Create(() => new BloggingContextViewModel());
        }

        /// <summary>
        /// Initializes a new instance of the BloggingContextViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the BloggingContextViewModel type without the POCO proxy factory.
        /// </summary>
        protected BloggingContextViewModel()
            : base(UnitOfWorkSource.GetUnitOfWorkFactory())
        {
        }

        protected override BloggingContextModuleDescription[] CreateModules()
        {
            return new BloggingContextModuleDescription[] {
                new BloggingContextModuleDescription("Blogs", "BlogCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Blogs)),
                new BloggingContextModuleDescription("Posts", "PostCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Posts)),
            };
        }



        protected override void OnActiveModuleChanged(BloggingContextModuleDescription oldModule)
        {
            if (ActiveModule != null && NavigationService != null)
            {
                NavigationService.ClearNavigationHistory();
            }
            base.OnActiveModuleChanged(oldModule);
        }
    }

    public partial class BloggingContextModuleDescription : ModuleDescription<BloggingContextModuleDescription>
    {
        public BloggingContextModuleDescription(string title, string documentType, string group, Func<BloggingContextModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory)
        {
        }
    }
}