using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DXEFTestApp.Common.Utils;
using DXEFTestApp.BloggingContextDataModel;
using DXEFTestApp.Common.DataModel;
using Model;
using DXEFTestApp.Common.ViewModel;

namespace DXEFTestApp.ViewModels
{
    /// <summary>
    /// Represents the single Blog object view model.
    /// </summary>
    public partial class BlogViewModel : SingleObjectViewModel<Blog, int, IBloggingContextUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of BlogViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static BlogViewModel Create(IUnitOfWorkFactory<IBloggingContextUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new BlogViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the BlogViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the BlogViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected BlogViewModel(IUnitOfWorkFactory<IBloggingContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Blogs, x => x.Name)
        {
        }

        /// <summary>
        /// The view model for the BlogPost detail collection.
        /// </summary>
        public CollectionViewModel<Post, int, IBloggingContextUnitOfWork> BlogPostDetails
        {
            get { return GetDetailsCollectionViewModel((BlogViewModel x) => x.BlogPostDetails, x => x.Posts, x => x.BlogId, (x, key) => { x.BlogId = key; }); }
        }
    }
}
