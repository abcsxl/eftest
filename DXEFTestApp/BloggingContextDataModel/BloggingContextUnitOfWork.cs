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
    /// A BloggingContextUnitOfWork instance that represents the run-time implementation of the IBloggingContextUnitOfWork interface.
    /// </summary>
    public class BloggingContextUnitOfWork : DbUnitOfWork<BloggingContext>, IBloggingContextUnitOfWork
    {

        public BloggingContextUnitOfWork(Func<BloggingContext> contextFactory)
            : base(contextFactory)
        {
        }

        IRepository<Blog, int> IBloggingContextUnitOfWork.Blogs
        {
            get { return GetRepository(x => x.Set<Blog>(), (Blog x) => x.Id); }
        }

        IRepository<Post, int> IBloggingContextUnitOfWork.Posts
        {
            get { return GetRepository(x => x.Set<Post>(), (Post x) => x.Id); }
        }
    }
}
