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
    /// Represents the single Post object view model.
    /// </summary>
    public partial class PostViewModel : SingleObjectViewModel<Post, int, IBloggingContextUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of PostViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static PostViewModel Create(IUnitOfWorkFactory<IBloggingContextUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new PostViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the PostViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PostViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected PostViewModel(IUnitOfWorkFactory<IBloggingContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Posts, x => x.Title)
        {
        }


        /// <summary>
		/// The view model that contains a look-up collection of Blogs for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Blog> LookUpBlogs
        {
            get { return GetLookUpEntitiesViewModel((PostViewModel x) => x.LookUpBlogs, x => x.Blogs); }
        }
    }
}
