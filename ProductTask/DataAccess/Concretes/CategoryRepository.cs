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
    public class CategoryRepository : ICategoryRepository
    {
        public string ConnectionString { get; set; }

        public CategoryRepository()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
        }

        public void AddData(Category data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Category data)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAllData()
        {
            using(var conn = new SqlConnection(ConnectionString))
            {
                var query = "SELECT * FROM Categories";
                var categories = conn.Query<Category>(query).ToList();
                return categories;
            }
        }

        public Category GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Category data)
        {
            throw new NotImplementedException();
        }
    }
}
