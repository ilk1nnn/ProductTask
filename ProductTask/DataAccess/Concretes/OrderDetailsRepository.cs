using Dapper;
using ProductTask.DataAccess.Abstractions;
using ProductTask.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTask.DataAccess.Concretes
{
    public class OrderDetailsRepository : IOrderDetailsRepository
    {

        public string ConnectionString { get; set; }


        public OrderDetailsRepository()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
        }

        public void AddData(OrderDetails data)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                var query = @"INSERT INTO OrderDetails([OrderID],[ProductID],[UnitPrice],[Quantity],[Discount])";


                conn.Execute(query, new
                {
                    data.OrderID,
                    data.Quantity,
                    data.UnitPrice,
                    data.Discount,
                    data.ProductId
                });

            }
        }

        public void DeleteData(OrderDetails data)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDetails> GetAllData()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                var query = "SELECT * FROM OrderDetails";
                var details = conn.Query<OrderDetails>(query).ToList();
                return details;

            }
        }
            public OrderDetails GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(OrderDetails data)
        {
            throw new NotImplementedException();
        }
    }
}
