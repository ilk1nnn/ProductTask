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



		private ObservableCollection<Order> allOrders;

		public ObservableCollection<Order> AllOrders
		{
			get { return allOrders; }
			set { allOrders = value; OnPropertyChanged(); }
		}



		private ObservableCollection<string> customersName;

		public ObservableCollection<string> CustomersName
		{
			get { return customersName; }
			set { customersName = value; OnPropertyChanged(); }
		}

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value;OnPropertyChanged(); }
		}



		public ShowAllClientViewModel()
		{
			var customersFromDataBase = App.DB.CustomerRepository.GetAllData();
			AllCustomers = new ObservableCollection<Customer>(customersFromDataBase);


			var ordersfromdatabase = App.DB.orderRepository.GetAllData(); 
			AllOrders = new ObservableCollection<Order>(ordersfromdatabase);


			


			//CustomersName = new ObservableCollection<string>();

			//for (int i = 0; i < AllCustomers.Count; i++)
			//{
			//	for (int k = 0; k < AllOrders.Count; k++)
			//	{
			//		if (AllCustomers[i].CustomerID == AllOrders[k].CustomerID)
			//		{
			//			CustomersName.Add(AllCustomers[i].ContactName);	
			//		}
			//	}
			//}

			Name= string.Empty;

			Name = "A";


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
