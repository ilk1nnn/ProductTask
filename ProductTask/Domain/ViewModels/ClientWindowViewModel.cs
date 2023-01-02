using ProductTask.Domain.Commands;
using ProductTask.Domain.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTask.Domain.ViewModels
{
    public class ClientWindowViewModel : BaseViewModel
    {

        public RelayCommand ShowAllProductsCommand { get; set; }
        public RelayCommand BuyProductCommand { get; set; }

        public ClientWindowViewModel()
        {
            ShowAllProductsCommand = new RelayCommand(s =>
            {
                var show_all = new ShowAllProductWindow();
                show_all.Show();
            });


            BuyProductCommand = new RelayCommand(b =>
            {
                var buy_product = new BuyProductWindow();
                buy_product.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;
                buy_product.Show();
            });

        }


    }
}
