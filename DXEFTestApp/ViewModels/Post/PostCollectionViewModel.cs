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
    /// Represents the Posts collection view model.
    /// </summary>
    public partial class PostCollectionViewModel : CollectionViewModel<Post, int, IBloggingContextUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of PostCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static PostCollectionViewModel Create(IUnitOfWorkFactory<IBloggingContextUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new PostCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the PostCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PostCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected PostCollectionViewModel(IUnitOfWorkFactory<IBloggingContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Posts)
        {
        }
    }
}