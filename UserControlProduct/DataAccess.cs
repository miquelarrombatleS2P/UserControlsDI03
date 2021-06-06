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

namespace UserControlProduct
{
    class DataAccess
    {
        public static ProductPhoto GetProductWithImage(int productModelID)
        {
            string connectionString = "Server = tcp:spdvi2020.database.windows.net,1433; Initial Catalog = AdventureWorks2016; Persist Security Info = False; User ID = spdvi; Password = Miquel1997; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30; ";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                string sql = $@"SELECT Product.ProductId, Name, ProductPhoto.ProductPhotoId, ThumbnailPhoto, ThumbnailPhotoFileName, LargePhoto, LargePhotoFileName 
                                FROM Production.Product 
                                INNER JOIN Production.ProductProductPhoto ON Product.ProductID = ProductProductPhoto.ProductID 
                                INNER JOIN Production.ProductPhoto ON ProductProductPhoto.ProductPhotoID = ProductPhoto.ProductPhotoID 
                                WHERE Product.ProductModelID = {productModelID} AND Product.Color is not null; ";

                ProductPhoto productPhoto = connection.Query<ProductPhoto>(sql).FirstOrDefault();
                
                return productPhoto;
            }
        }

        public static List<Product> GetProduct(int productModelID)
        {
            string connectionString = "Server = tcp:spdvi2020.database.windows.net,1433; Initial Catalog = AdventureWorks2016; Persist Security Info = False; User ID = spdvi; Password = Miquel1997; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30; ";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"SELECT "
                       + $"Production.Product.ProductID AS ProductID, Production.Product.ProductModelID AS ProductModelID, Production.ProductModel.Name, "
                       + $"Production.ProductDescription.Description, Production.Product.ListPrice, Production.Product.Size, Production.Product.Color "
                       + $"FROM "
                       + $"Production.Product "
                       + $"INNER JOIN Production.ProductSubcategory on Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID "
                       + $"INNER JOIN Production.ProductCategory on Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID "
                       + $"INNER JOIN Production.ProductModel on Production.Product.ProductModelID = Production.ProductModel.ProductModelID "
                       + $"INNER JOIN Production.ProductModelProductDescriptionCulture on Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID "
                       + $"INNER JOIN Production.ProductDescription on Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID "
                       + $"WHERE ProductModelProductDescriptionCulture.CultureID = 'en' AND Product.ProductModelID IS NOT NULL "
                       + $"AND Product.ProductModelID = '{productModelID}';";

                List<Product> products = connection.Query<Product>(sql).ToList();
                return products;
            }
        }

        public static List<Product> GetProductSizeWithColor(string size, string color)
        {
            string connectionString = "Server = tcp:spdvi2020.database.windows.net,1433; Initial Catalog = AdventureWorks2016; Persist Security Info = False; User ID = spdvi; Password = Miquel1997; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30; ";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"SELECT "
                       + $"Production.Product.ProductID AS ProductID, Production.Product.ProductModelID AS ProductModelID, Production.ProductModel.Name, "
                       + $"Production.ProductDescription.Description, Production.Product.ListPrice, Production.Product.Size, Production.Product.Color "
                       + $"FROM "
                       + $"Production.Product "
                       + $"INNER JOIN Production.ProductSubcategory on Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID "
                       + $"INNER JOIN Production.ProductCategory on Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID "
                       + $"INNER JOIN Production.ProductModel on Production.Product.ProductModelID = Production.ProductModel.ProductModelID "
                       + $"INNER JOIN Production.ProductModelProductDescriptionCulture on Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID "
                       + $"INNER JOIN Production.ProductDescription on Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID "
                       + $"WHERE ProductModelProductDescriptionCulture.CultureID = 'en' AND Product.ProductModelID IS NOT NULL "
                       + $"AND Product.Size = '{size}' AND Product.Color = '{color}';";

                List<Product> products = connection.Query<Product>(sql).ToList();
                return products;
            }
        }

        public static ProductPhoto GetProductWithImageSelectedSizeAndColor(int ProductId)
        {
            string connectionString = "Server = tcp:spdvi2020.database.windows.net,1433; Initial Catalog = AdventureWorks2016; Persist Security Info = False; User ID = spdvi; Password = Miquel1997; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30; ";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                string sql = $@"SELECT Product.ProductId, Name, ProductPhoto.ProductPhotoId, ThumbnailPhoto, ThumbnailPhotoFileName, LargePhoto, LargePhotoFileName 
                                FROM Production.Product 
                                INNER JOIN Production.ProductProductPhoto ON Product.ProductID = ProductProductPhoto.ProductID 
                                INNER JOIN Production.ProductPhoto ON ProductProductPhoto.ProductPhotoID = ProductPhoto.ProductPhotoID 
                                WHERE Product.ProductId = {ProductId}; ";

                ProductPhoto productPhoto = connection.Query<ProductPhoto>(sql).FirstOrDefault();
                return productPhoto;
            }
        }
    }
}
