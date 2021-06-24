<!-- default file list -->
*Files to look at*:

* [DashboardConfig.cs](./CS/MvcDashboard_CustomSchemaProvider/App_Start/DashboardConfig.cs) (VB: [DashboardConfig.vb](./VB/MvcDashboard_CustomSchemaProvider/App_Start/DashboardConfig.vb))
* [FilterConfig.cs](./CS/MvcDashboard_CustomSchemaProvider/App_Start/FilterConfig.cs) (VB: [FilterConfig.vb](./VB/MvcDashboard_CustomSchemaProvider/App_Start/FilterConfig.vb))
* [RouteConfig.cs](./CS/MvcDashboard_CustomSchemaProvider/App_Start/RouteConfig.cs) (VB: [RouteConfig.vb](./VB/MvcDashboard_CustomSchemaProvider/App_Start/RouteConfig.vb))
* [HomeController.cs](./CS/MvcDashboard_CustomSchemaProvider/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/MvcDashboard_CustomSchemaProvider/Controllers/HomeController.vb))
* [Global.asax.cs](./CS/MvcDashboard_CustomSchemaProvider/Global.asax.cs) (VB: [Global.asax.vb](./VB/MvcDashboard_CustomSchemaProvider/Global.asax.vb))
* [Index.cshtml](./CS/MvcDashboard_CustomSchemaProvider/Views/Home/Index.cshtml)
<!-- default file list end -->
# Dashboard for MVC - How to customize a data store schema for SQL data sources

This example demonstrates how to customize a data store schema for a dashboard data source that uses a connection to the Northwind database.

In this example, the [IDBSchemaProviderEx](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Sql.IDBSchemaProviderEx) interface is implemented by a class that defines a custom data store schema containing two related tables.

To see the result, add a new query or edit the existing query.

## Documentation

- [IDBSchemaProviderEx](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Sql.IDBSchemaProviderEx)

## More Examples
- [Query Builder - Limit the list of available Stored Procedures, Tables, or Views](https://www.devexpress.com/Support/Center/Question/Details/T622683/)
