using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ContosoUniversity.DAL;
using System.Data.Entity.Infrastructure.Interception;

namespace ContosoUniversity
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //这些代码行是当Entity Framework向数据库发送查询时会导致拦截器代码运行的。
            //请注意，由于您为瞬态错误模拟和日志记录创建了单独的拦截器类，因此可以独立地启用和禁用它们。
            //您可以使用DbInterception.Add代码中的任何地方添加拦截器; 它不必在该Application_Start方法中
            //请注意，此处激活的两个拦截器也可安放在：SchoolConfiguration.cs类中，但是，无论在哪里启用拦截器
            //请不要对同一个拦截器添加两次，会产生两个日志
            DbInterception.Add(new SchoolInterceptorTransientErrors());
            DbInterception.Add(new SchoolInterceptorLogging());
        }
    }
}
