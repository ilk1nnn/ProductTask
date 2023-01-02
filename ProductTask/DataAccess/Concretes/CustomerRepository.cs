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
    public class CustomerRepository : ICustomerRepository
    {

        public string ConnectionString { get; set; }

        public CustomerRepository()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
        }

        public void AddData(Customer data)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                var query = @"INSERT INTO Customers([ContactName],[Country],[City],[Phone],[PostalCode])
                              VALUES(@ContactName,@Country,@City,@Phone,@PostalCode)";


                conn.Execute(query, new
                {
                    data.ContactName,
                    data.City,
                    data.Country,
                    data.Phone,
                    data.PostalCode
                });

            }
        }


        public void DeleteData(Customer data)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAllData()
        {
            using(var conn = new SqlConnection(ConnectionString))
            {
                var query = "SELECT * FROM Customers";
                var customers = conn.Query<Customer>(query).ToList();
                return customers;
            }
        }

        public Customer GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Customer data)
        {
            throw new NotImplementedException();
        }
    }
}
