﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace LIMS
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //注册 ASP.NET MVC 应用程序中的所有区域
            AreaRegistration.RegisterAllAreas();
            //注册 全局的Filters
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            //注册 路由规则
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //注册 打包绑定（js,css等）
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
