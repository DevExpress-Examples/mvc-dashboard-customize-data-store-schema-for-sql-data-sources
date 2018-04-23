using DevExpress.DashboardWeb;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.DataAccess.Sql;
using DevExpress.Xpo.DB;
using System.Collections.Specialized;
using System.Web.Routing;

namespace MvcDashboard_CustomSchemaProvider {
    public static class DashboardConfig {
        public static void RegisterService(RouteCollection routes) {
            routes.MapDashboardRoute("dashboardControl");

            DashboardFileStorage dashboardFileStorage = new DashboardFileStorage("~/App_Data/Dashboards");
            DashboardConfigurator.Default.SetDashboardStorage(dashboardFileStorage);  

            DashboardConfigurator.Default.SetDBSchemaProvider(new CustomDBSchemaProvider());
        }
    }

    // Creates a new class that defines a custom data store schema by implementing the 
    // IDBSchemaProvider interface.
    class CustomDBSchemaProvider : IDBSchemaProviderEx {
        DBTable[] tables;
        public void LoadColumns(SqlDataConnection connection, params DBTable[] tables) {
            foreach (DBTable table in tables) {
                if (table.Name == "Categories" && table.Columns.Count == 0) {
                    DBColumn categoryIdColumn = new DBColumn { Name = "CategoryID" };
                    table.AddColumn(categoryIdColumn);
                    DBColumn categoryNameColumn = new DBColumn { Name = "CategoryName" };
                    table.AddColumn(categoryNameColumn);
                }
                if (table.Name == "Products" && table.Columns.Count == 0) {
                    DBColumn categoryIdColumn = new DBColumn { Name = "CategoryID" };
                    table.AddColumn(categoryIdColumn);
                    DBColumn productNameColumn = new DBColumn { Name = "ProductName" };
                    table.AddColumn(productNameColumn);

                    DBForeignKey foreignKey = new DBForeignKey(
                        new[] { categoryIdColumn },
                        "Categories",
                        CustomDBSchemaProvider.CreatePrimaryKeys("CategoryID"));
                    table.ForeignKeys.Add(foreignKey);
                }
            }
        }

        public static StringCollection CreatePrimaryKeys(params string[] names) {
            StringCollection collection = new StringCollection();
            collection.AddRange(names);
            return collection;
        }

        public DBTable[] GetTables(SqlDataConnection connection, params string[] tableList) {
            if (connection.Name == "nwindConnection") {
                if (tables != null) {
                    return tables;
                }
                tables = new DBTable[2];

                DBTable categoriesTable = new DBTable("Categories");
                tables[0] = categoriesTable;

                DBTable productsTable = new DBTable("Products");
                tables[1] = productsTable;
            }
            else
                tables = new DBTable[0];
            return tables;
        }

        public DBTable[] GetViews(SqlDataConnection connection, params string[] viewList) {
            DBTable[] views = new DBTable[0];
            return views;
        }

        public DBStoredProcedure[] GetProcedures(SqlDataConnection connection, params string[] procedureList) {
            DBStoredProcedure[] storedProcedures = new DBStoredProcedure[0];
            return storedProcedures;
        }
    }
}