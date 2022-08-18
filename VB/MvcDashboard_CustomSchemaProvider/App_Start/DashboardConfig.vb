Imports System.Collections.Specialized
Imports System.Web.Routing
Imports DevExpress.DashboardWeb
Imports DevExpress.DashboardWeb.Mvc
Imports DevExpress.DataAccess.Sql
Imports DevExpress.DataAccess.Web
Imports DevExpress.Xpo.DB

Namespace MvcDashboard_CustomSchemaProvider
    Public NotInheritable Class DashboardConfig

        Private Sub New()
        End Sub

        Public Shared Sub RegisterService(ByVal routes As RouteCollection)
            routes.MapDashboardRoute("dashboardControl", "DefaultDashboard")

            Dim dashboardFileStorage As New DashboardFileStorage("~/App_Data/Dashboards")
            DashboardConfigurator.Default.SetDashboardStorage(dashboardFileStorage)
            DashboardConfigurator.Default.SetConnectionStringsProvider(New ConfigFileConnectionStringsProvider())


            ' This method assigns the database schema provider to the Web Dashboard.
            ' Uncomment one of the following lines depending on the provider.
            DashboardConfigurator.Default.SetDBSchemaProvider(New LimitDBSchemaProvider())
            ' DashboardConfigurator.Default.SetDBSchemaProvider(New ManualDBSchemaProvider())

        End Sub
    End Class

End Namespace