using ProductTask.DataAccess.Entities;
using ProductTask.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ProductTask.Domain.ViewModels
{
    public class BuyProductViewModel : BaseViewModel
    {

        private ObservableCollection<Product> allProducts;

        public ObservableCollection<Product> AllProducts
        {
            get { return allProducts; }
            set { allProducts = value; OnPropertyChanged(); }
        }


        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }



        private TextBox productName;

        public TextBox ProductName
        {
            get { return productName; }
            set { productName = value; OnPropertyChanged(); }
        }


        private TextBox quantity;

        public TextBox Quantity
        {
            get { return quantity; }
            set { quantity = value; OnPropertyChanged(); }
        }


        private TextBox customerName;

        public TextBox CustomerName
        {
            get { return customerName; }
            set { customerName = value; OnPropertyChanged(); }
        }


        public RelayCommand OrderCommand { get; set; }

        private ObservableCollection<Customer> allCustomers;

        public ObservableCollection<Customer> AllCustomers
        {
            get { return allCustomers; }
            set { allCustomers = value; OnPropertyChanged(); }
        }


        public BuyProductViewModel()
        {
            var productsFromDataBase = App.DB.ProductRepository.GetAllData();
            AllProducts = new ObservableCollection<Product>(productsFromDataBase);


            var customersfromDataBase = App.DB.CustomerRepository.GetAllData();
            AllCustomers = new ObservableCollection<Customer>(customersfromDataBase);

            OrderCommand = new RelayCommand(o =>
            {
                for (int i = 0; i < AllProducts.Count; i++)
                {
                    if((ProductName.Text == AllProducts[i].ProductName && int.Parse(Quantity.Text) <= AllProducts[i].UnitsInStock))
                    {
                        for (int k = 0; k < AllCustomers.Count; k++)
                        {
                            if(CustomerName.Text == AllCustomers[k].ContactName)
                            {
                                MessageBox.Show($@"Congratulations! Order was created Successfully! Person Who bought is {CustomerName.Text}.
                                                   He bought {ProductName.Text}. Quantity : {Quantity.Text}");
                            }
                        }
                    }
                    else if(ProductName.Text == AllProducts[i].ProductName && int.Parse(Quantity.Text) > AllProducts[i].UnitsInStock)
                    {
                        MessageBox.Show("Wrong Quantity Input!");
                    }
                    else if ((ProductName.Text != AllProducts[i].ProductName && i == AllProducts.Count-1) && int.Parse(Quantity.Text) <= AllProducts[i].UnitsInStock)
                    {
                        MessageBox.Show("Wrong ProductName Input!");
                    }
                   
                }
            });


        }
    }
}
