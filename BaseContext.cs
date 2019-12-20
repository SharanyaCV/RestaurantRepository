using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using RestaurantApplication3.Context.Mapping;
using RestaurantApplication3.Models;
using RestaurantApplication3.Context;

namespace RestaurantApplication3.Context
{
    public class BaseContext<TContext> : DbContext where TContext : DbContext, IDisposable
    {
        static BaseContext()
        {
            Database.SetInitializer<TContext>(null);
        }


        protected BaseContext()
            : base("CustomerContext")//Always include Connection String name. Connection string name for all the contexts can be the same.
        {
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
        }



        protected BaseContext(string CustomerContext) : base(CustomerContext)
        {
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
        }

    }
}