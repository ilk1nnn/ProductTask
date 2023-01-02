using ProductTask.Domain.Commands;
using ProductTask.Domain.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTask.Domain.ViewModels
{
    public class AdminViewModel : BaseViewModel
    {

        public RelayCommand ShowAllCommand { get; set; }
        public RelayCommand ShowAllClientsCommand { get; set; }
        public RelayCommand AddProductCommand { get; set; }


        public AdminViewModel()
        {
            ShowAllCommand = new RelayCommand(s =>
            {
                var show_all = new ShowAllProductWindow();
                show_all.Show();
            });

            ShowAllClientsCommand = new RelayCommand(s =>
            {
                var show_all_clients = new ShowAllClientWindow();
                show_all_clients.Show();
            });

            AddProductCommand = new RelayCommand(s =>
            {
                var add_product = new AddProductWindow();
                add_product.Show();
            });


        }


    }
}
