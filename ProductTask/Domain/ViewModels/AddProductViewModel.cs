using ProductTask.DataAccess.Entities;
using ProductTask.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ProductTask.Domain.ViewModels
{
    public class AddProductViewModel : BaseViewModel
    {

        public RelayCommand AddProductCommand { get; set; }

		private TextBox productNameT;

		public TextBox ProductNameT
		{
			get { return productNameT; }
			set { productNameT = value; OnPropertyChanged(); }
		}


        private TextBox productDiscountT;

        public TextBox ProductDiscountT
        {
            get { return productDiscountT; }
            set { productDiscountT = value; OnPropertyChanged(); }
        }


        private TextBox unitPriceT;

        public TextBox UnitPriceT
        {
            get { return unitPriceT; }
            set { unitPriceT = value; OnPropertyChanged(); }
        }


        private TextBox unitInStockT;

        public TextBox UnitInStockT
        {
            get { return unitInStockT; }
            set { unitInStockT = value; OnPropertyChanged(); }
        }



        public AddProductViewModel()
        {
            AddProductCommand = new RelayCommand(a =>
            {
                Product p = new Product
                {
                    ProductName = ProductNameT.Text,
                    UnitPrice = decimal.Parse(UnitPriceT.Text),
                    UnitsInStock = short.Parse(UnitInStockT.Text),
                };
                App.DB.ProductRepository.AddData(p);
                MessageBox.Show("Product Added Successfully");
            });
        }





    }
}
