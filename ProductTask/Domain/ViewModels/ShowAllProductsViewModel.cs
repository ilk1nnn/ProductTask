using ProductTask.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTask.Domain.ViewModels
{
    public class ShowAllProductsViewModel  :BaseViewModel
    {

        private ObservableCollection<Product> allProducts;

        public ObservableCollection<Product> AllProducts
        {
            get { return allProducts; }
            set { allProducts = value; OnPropertyChanged(); }
        }


        public ShowAllProductsViewModel()
        {
            var productsFromDataBase = App.DB.ProductRepository.GetAllData();
            AllProducts = new ObservableCollection<Product>(productsFromDataBase);
        }

    }
}
