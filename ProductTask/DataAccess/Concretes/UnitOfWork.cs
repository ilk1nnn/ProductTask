using ProductTask.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTask.DataAccess.Concretes
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICategoryRepository CategoryRepository => new CategoryRepository();

        public IProductRepository ProductRepository => new ProductRepository();

        public IOrderDetailsRepository OrderDetailsRepository => new OrderDetailsRepository();

        public ICustomerRepository CustomerRepository => new CustomerRepository();
    }
}
