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
    public class OrderRepository : IOrderRepository
    {

        public string ConnectionString { get; set; }


        public OrderRepository()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
        }

        public void AddData(Order data)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                var query = @"SET IDENTITY_INSERT Orders ON
                              INSERT INTO Orders([OrderID],[CustomerID],[ShipName])
                              VALUES(@OrderID,@CustomerID,@ShipName)
                              ";


                conn.Execute(query, new
                {
                    data.OrderID,
                    data.CustomerID,
                    data.ShipName
                });

            }
        }

        public void DeleteData(Order data)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAllData()
        {
            using(var conn = new SqlConnection(ConnectionString))
            {
                var query = @"SELECT * FROM Orders";
                var result = conn.Query<Order>(query);
                return result;
            }
        }

        public Order GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Order data)
        {
            throw new NotImplementedException();
        }
    }
}
