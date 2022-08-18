using DevExpress.DashboardWeb;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.DataAccess.Web;
using MvcDashboard_CustomSchemaProvider.Code;
using System.Web.Routing;

namespace MvcDashboard_CustomSchemaProvider {
    public static class DashboardConfig {
        public static void RegisterService(RouteCollection routes) {
            routes.MapDashboardRoute("dashboardControl","DefaultDashboard");

            DashboardFileStorage dashboardFileStorage = new DashboardFileStorage("~/App_Data/Dashboards");
            DashboardConfigurator.Default.SetDashboardStorage(dashboardFileStorage);
            DashboardConfigurator.Default.SetConnectionStringsProvider(new ConfigFileConnectionStringsProvider());

            // This method assigns the database schema provider to the Web Dashboard.
            // Uncomment one of the following lines depending on the provider.
            DashboardConfigurator.Default.SetDBSchemaProvider(new ManualDBSchemaProvider());
            // DashboardConfigurator.Default.SetDBSchemaProvider(new LimitDBSchemaProvider());
        }
    }
}