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
                //for (int i = 0; i < AllProducts.Count; i++)
                //{
                //    if((ProductName.Text == AllProducts[i].ProductName && int.Parse(Quantity.Text) <= AllProducts[i].UnitsInStock))
                //    {
                //        for (int k = 0; k < AllCustomers.Count; k++)
                //        {
                //            if(CustomerName.Text == AllCustomers[k].ContactName)
                //            {
                //                MessageBox.Show($@"Congratulations! Order was created Successfully! Person Who bought is {CustomerName.Text}.
                //                                   He bought {ProductName.Text}. Quantity : {Quantity.Text}");
                //            }
                //        }
                //    }
                //    else if(ProductName.Text == AllProducts[i].ProductName && int.Parse(Quantity.Text) > AllProducts[i].UnitsInStock)
                //    {
                //        MessageBox.Show("Wrong Quantity Input!");
                //    }
                //    else if ((ProductName.Text != AllProducts[i].ProductName && i == AllProducts.Count-1) && int.Parse(Quantity.Text) <= AllProducts[i].UnitsInStock)
                //    {
                //        MessageBox.Show("Wrong ProductName Input!");
                //    }

                //}


                var pid = 0;
                for (int i = 0; i < AllProducts.Count; i++)
                {
                    if (productName.Text == AllProducts[i].ProductName)
                    {
                        pid = AllProducts[i].ProductID;
                    }
                }


                var cid = string.Empty;
                for (int k = 0; k < AllCustomers.Count; k++)
                {
                    if (customerName.Text == AllCustomers[k].ContactName)
                    {
                        cid = AllCustomers[k].CustomerID;
                    }
                }





                Order order = new Order
                {
                    OrderID = pid,
                    CustomerID = cid,
                    ShipName = productName.Text
                };



                //for (int i = 0; i < AllProducts.Count; i++)
                //{
                //    for (int k = 0; k < AllCustomers.Count; k++)
                //    {

                //        if (pid == AllProducts[i].ProductID && short.Parse(Quantity.Text) <= AllProducts[i].UnitsInStock && CustomerName.Text == AllCustomers[k].ContactName)
                //        {
                //            AllProducts[i].UnitsInStock -= short.Parse(Quantity.Text);
                //        }
                //        if (pid == AllProducts[i].ProductID && short.Parse(Quantity.Text) >= AllProducts[i].UnitsInStock)
                //        {
                //            MessageBox.Show("Wrong!");
                //            break;
                //        }
                //        if (pid == AllProducts[i].ProductID && CustomerName.Text == AllCustomers[k].ContactName)
                //        {
                //            MessageBox.Show("Wrong!");
                //            break;
                //        }

                //    }
                //}


                App.DB.orderRepository.AddData(order);



                MessageBox.Show("Order Added Successfully!");



            });


        }
    }
}
