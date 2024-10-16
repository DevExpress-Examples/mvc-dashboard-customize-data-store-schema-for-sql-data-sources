<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579120/21.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T584271)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Dashboard for MVC - How to customize a database schema for SQL data sources

This example shows how to create a custom database schema for the dashboard. The example contains two implementation of the [IDBSchemaProviderEx](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Sql.IDBSchemaProviderEx) interface, `LimitDBSchemaProvider` and `ManualDBSchemaProvider`. Call the [DashboardConfigurator.SetDBSchemaProvider](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.DashboardConfigurator.SetDBSchemaProvider(DevExpress.DataAccess.Sql.IDBSchemaProviderEx)) method to assign the database schema to the Web Dashboard.

To see the result, add a new query or edit the existing query.

### The LimitDBSchemaProvider class

File: [LimitDBSchemaProvider.cs](./CS/MvcDashboard_CustomSchemaProvider/Code/LimitDBSchemaProvider.cs) (VB: [LimitDBSchemaProvider.vb](./VB/MvcDashboard_CustomSchemaProvider/Code/LimitDBSchemaProvider.vb))

This provider displays only the following database entities:

- Tables which names start with the letter *C*
- Views which names start with *Sales*
- Stored procedures with zero arguments

![](images/custom_dbschema_views.png)

### The ManualDBSchemaProvider class

File: [ManualDBSchemaProvider.cs](./CS/MvcDashboard_CustomSchemaProvider/Code/ManualDBSchemaProvider.cs) (VB: [ManualDBSchemaProvider.vb](./VB/MvcDashboard_CustomSchemaProvider/Code/ManualDBSchemaProvider.vb))

This provider loads two tables (`Categories` and `Products`) for the `nwindConnection` connection. Both tables contain only two columns and the tables are linked by the `CategoryID` field.

![](images/custom_dbschema_tables.png)

This technique improves the [Data Source Wizard](https://docs.devexpress.com/Dashboard/117680/) performance when loading the database schema to the dashboard.

## Files to Review

* [LimitDBSchemaProvider.cs](./CS/MvcDashboard_CustomSchemaProvider/Code/LimitDBSchemaProvider.cs) (VB: [LimitDBSchemaProvider.vb](./VB/MvcDashboard_CustomSchemaProvider/Code/LimitDBSchemaProvider.vb))
* [ManualDBSchemaProvider.cs](./CS/MvcDashboard_CustomSchemaProvider/Code/ManualDBSchemaProvider.cs) (VB: [ManualDBSchemaProvider.vb](./VB/MvcDashboard_CustomSchemaProvider/Code/ManualDBSchemaProvider.vb))
* [DashboardConfig.cs](/CS/MvcDashboard_CustomSchemaProvider/App_Start/DashboardConfig.cs) (VB: [DashboardConfig.vb](./VB/MvcDashboard_CustomSchemaProvider/App_Start/DashboardConfig.vb))

## Documentation

* [Implement a Custom Database Schema](https://docs.devexpress.com/Dashboard/404044/web-dashboard/dashboard-backend/implement-a-custom-database-schema?p=netframework)

## More Examples

* [Dashboard for ASP.NET Core - How to customize a database schema for SQL data sources](https://github.com/DevExpress-Examples/asp-net-core-dashboard-custom-database-schema-for-sql-data-sources)
* [Dashboard for ASP.NET Web Forms - How to customize a database schema for SQL data sources](https://github.com/DevExpress-Examples/web-forms-dashboard-custom-database-schema-for-sql-data-sources)
* [Dashboard for MVC - How to implement multi-tenant Dashboard architecture](https://github.com/DevExpress-Examples/DashboardUserBasedMVC)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=mvc-dashboard-customize-data-store-schema-for-sql-data-sources&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=mvc-dashboard-customize-data-store-schema-for-sql-data-sources&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
