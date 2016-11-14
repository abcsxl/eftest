using System;
using System.Linq;
using System.Data;
using System.Linq.Expressions;
using System.Collections.Generic;
using DXEFTestApp.Common.Utils;
using DXEFTestApp.Common.DataModel;
using DXEFTestApp.Common.DataModel.EntityFramework;
using Model;

namespace DXEFTestApp.BloggingContextDataModel
{
    /// <summary>
    /// IBloggingContextUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IBloggingContextUnitOfWork : IUnitOfWork
    {

        /// <summary>
        /// The Blog entities repository.
        /// </summary>
        IRepository<Blog, int> Blogs { get; }

        /// <summary>
        /// The Post entities repository.
        /// </summary>
        IRepository<Post, int> Posts { get; }
    }
}
