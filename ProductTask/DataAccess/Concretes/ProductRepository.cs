using Dapper;
using ProductTask.DataAccess.Abstractions;
using ProductTask.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTask.DataAccess.Concretes
{
    public class ProductRepository : IProductRepository
    {

        public string ConnectionString { get; set; }


        public ProductRepository()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
        }

        public void AddData(Product data)
        {
            using(var conn = new SqlConnection(ConnectionString))
            {
                var query = @"INSERT INTO Products([ProductName],[UnitPrice],[UnitsInStock])
                              VALUES(@ProductName,@UnitPrice,@UnitsInStock)";

                conn.Execute(query, new
                {
                    data.ProductName,
                    data.UnitsInStock,
                    data.UnitPrice
                });


            }
        }

        public void DeleteData(Product data)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllData()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                var query = "SELECT * FROM Products";
                var products =  conn.Query<Product>(query).ToList();
                return products;
            }
        }

        public Product GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Product data)
        {
            throw new NotImplementedException();
        }
    }
}
