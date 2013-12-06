// --------------------------------------------------------------------------
// <copyright file="Global.asax.cs" company="Nexcel Solutions Vietnam">
// Copyright (c) Nexcel Solutions Vietnam. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------
// <history>
//   <change who="Ricky.Nguyen" date="2013.9.23">Created</change>
// </history>

namespace Fanex.CustSetting.Sample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Http;
    using System.Web.Mvc;
    using System.Web.Routing;
    using Fanex.Data.Configuration;

    /// <summary>
    /// Class was documented.
    /// </summary>
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            DbSettingProviderManager.Current.Start();
            AreaRegistration.RegisterAllAreas();

            ////WebApiConfig.Register(GlobalConfiguration.Configuration);
            ////FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            ////RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}