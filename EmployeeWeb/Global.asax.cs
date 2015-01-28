using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;

namespace EmployeeWeb
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //string str = "1.11.2";

            //ScriptManager.ScriptResourceMapping.AddDefinition("jquery.ui.combined", new ScriptResourceDefinition

            //{

            //    Path = "~/Scripts/jquery-ui-" + str + ".min.js",

            //    DebugPath = "~/Scripts/jquery-ui-" + str + ".js",

            //    CdnPath = "http://ajax.aspnetcdn.com/ajax/jquery.ui/" + str + "/jquery-ui.min.js",

            //    CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jquery.ui/" + str + "/jquery-ui.js",

            //    CdnSupportsSecureConnection = true

            //});
        }
    }
}