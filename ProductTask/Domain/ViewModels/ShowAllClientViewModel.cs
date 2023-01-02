using ProductTask.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTask.Domain.ViewModels
{
    public class ShowAllClientViewModel : BaseViewModel
    {
		private ObservableCollection<Customer> allCustomers;

		public ObservableCollection<Customer> AllCustomers
		{
			get { return allCustomers; }
			set { allCustomers = value; OnPropertyChanged(); }
		}


		private ObservableCollection<OrderDetails> allOrderDetails;

		public ObservableCollection<OrderDetails> AllOrderDetails
        {
			get { return allOrderDetails; }
			set { allOrderDetails = value; OnPropertyChanged(); }
		}



		private Order order;

		public Order Order
		{
			get { return order; }
			set { order = value; OnPropertyChanged(); }
		}


		private string productName;

		public string ProductName
        {
			get { return productName; }
			set { productName = value; OnPropertyChanged(); }
		}


		private ObservableCollection<Product> allProducts;

		public ObservableCollection<Product> AllProducts
        {
			get { return allProducts; }
			set { allProducts = value; OnPropertyChanged(); }
		}


		public ShowAllClientViewModel()
		{
			var customersFromDataBase = App.DB.CustomerRepository.GetAllData();
			AllCustomers = new ObservableCollection<Customer>(customersFromDataBase);


			//var allproducts = App.DB.ProductRepository.GetAllData();
			//AllProducts = new ObservableCollection<Product>(allproducts);

			//OrderDetails od = new OrderDetails();

			//var orderdetailsfromDataBase = App.DB.OrderDetailsRepository.GetAllData();
			//AllOrderDetails = new ObservableCollection<OrderDetails>(orderdetailsfromDataBase);
			//foreach (var item in AllOrderDetails)
			//{
			//	foreach (var item2 in AllProducts)
			//	{
			//		if(item.ProductId == item2.ProductID)
			//		{
			//			od.ProductName = item2.ProductName;
			//		}
			//	}
			//}


		}


	}
}
