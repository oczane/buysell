using System;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MyJourney.Models;
using System.Data.Entity;

namespace MyJourney
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //Database.SetInitializer<BuySellContext>(new MyDbInitializer());

            //using (var ctx = new BuySellContext())
            //{
            //    new MyDbInitializer().InitializeDatabase(ctx);
            //}

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            UnityConfig.RegisterComponents();
            
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }

    //public class MyDbInitializer : DropCreateDatabaseAlways<BuySellContext>
    //{
    //    protected override void Seed(BuySellContext context)
    //    {
    //        var category1 = new Category { Name = "Rent", IsActive = true, Created = DateTime.UtcNow };
    //        var category2 = new Category { Name = "Sell", IsActive = true, Created = DateTime.UtcNow };

    //        context.Category.Add(category1);
    //        context.Category.Add(category2);
    //        context.SaveChanges();
    //    }
    //}
}
