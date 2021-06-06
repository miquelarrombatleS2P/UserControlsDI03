using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Dapper;

namespace WindowsFormsApp1
{
    class DataAccess
    {
        public static int GetMinProductModel()
        {
            string connectionString = "Server = tcp:spdvi2020.database.windows.net,1433; Initial Catalog = AdventureWorks2016; Persist Security Info = False; User ID = spdvi; Password = Miquel1997; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30; ";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                string sql = $@"SELECT MIN(Product.ProductID)
                                FROM Production.Product 
                                where Product.ProductModelID is not null ;";

                int productMin = connection.Query<int>(sql).FirstOrDefault();

                return productMin;
            }
        }
        public static int GetMaxProductModel()
        {
            string connectionString = "Server = tcp:spdvi2020.database.windows.net,1433; Initial Catalog = AdventureWorks2016; Persist Security Info = False; User ID = spdvi; Password = Miquel1997; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30; ";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                string sql = $@"SELECT MAX(Product.ProductID) 
                                FROM Production.Product 
                                where Product.ProductModelID is not null ;";

                int productMin = connection.Query<int>(sql).FirstOrDefault();

                return productMin;
            }
        }

        public static int GetProductModelToRandom(int productID)
        {
            string connectionString = "Server = tcp:spdvi2020.database.windows.net,1433; Initial Catalog = AdventureWorks2016; Persist Security Info = False; User ID = spdvi; Password = Miquel1997; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30; ";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                string sql = $@"SELECT Product.ProductModelID
                                FROM Production.Product 
                                where Product.ProductID = {productID} AND Product.ProductModelID is not null ;";

                int productModelId = connection.Query<int>(sql).FirstOrDefault();

                return productModelId;
            }
        }

        public static int GetProductModelIsExists(int productModelID)
        {
            string connectionString = "Server = tcp:spdvi2020.database.windows.net,1433; Initial Catalog = AdventureWorks2016; Persist Security Info = False; User ID = spdvi; Password = Miquel1997; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30; ";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                string sql = $@"select case when exists (SELECT [ProductModelID]
                                FROM [Production].[ProductModel]
                                where Production.ProductModel.ProductModelID = 25)
                                then 1 else 0 end";

                int productModelId = connection.Query<int>(sql).FirstOrDefault();

                return productModelId;
            }
        }
    }
}
