using System;
using System.Linq;
using System.Data;
using System.Linq.Expressions;
using System.Collections.Generic;
using DXEFTestApp.Common.Utils;
using DXEFTestApp.Common.DataModel;
using DXEFTestApp.Common.DataModel.EntityFramework;
using Model;
using DevExpress.Mvvm;
using System.Collections;
using System.ComponentModel;
using DevExpress.Data.Linq;
using DevExpress.Data.Linq.Helpers;
using DevExpress.Data.Async.Helpers;

namespace DXEFTestApp.BloggingContextDataModel
{
    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource
    {

        /// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<IBloggingContextUnitOfWork> GetUnitOfWorkFactory()
        {
            return new DbUnitOfWorkFactory<IBloggingContextUnitOfWork>(() => new BloggingContextUnitOfWork(() => new BloggingContext()));
        }
    }
}