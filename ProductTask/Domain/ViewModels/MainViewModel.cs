using ProductTask.Domain.Commands;
using ProductTask.Domain.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTask.Domain.ViewModels
{
    public class MainViewModel : BaseViewModel
    {

        public RelayCommand AdminCommand { get; set; }
        public RelayCommand ClientCommand { get; set; }

        public MainViewModel()
        {
            AdminCommand = new RelayCommand(a =>
            {
                var admin_window = new AdminWindow();
                admin_window.Show();
            });

            ClientCommand = new RelayCommand(c =>
            {
                var client_window = new ClientWindow(); 
                client_window.Show();
            });
        }

    }
}
