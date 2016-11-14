using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DXEFTestApp.Common.Utils;
using DXEFTestApp.BloggingContextDataModel;
using DXEFTestApp.Common.DataModel;
using Model;
using DXEFTestApp.Common.ViewModel;

namespace DXEFTestApp.ViewModels
{
    /// <summary>
    /// Represents the Blogs collection view model.
    /// </summary>
    public partial class BlogCollectionViewModel : CollectionViewModel<Blog, int, IBloggingContextUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of BlogCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static BlogCollectionViewModel Create(IUnitOfWorkFactory<IBloggingContextUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new BlogCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the BlogCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the BlogCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected BlogCollectionViewModel(IUnitOfWorkFactory<IBloggingContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Blogs)
        {
        }
    }
}