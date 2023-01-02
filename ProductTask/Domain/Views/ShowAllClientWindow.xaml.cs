using ProductTask.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProductTask.Domain.Views
{
    /// <summary>
    /// Interaction logic for ShowAllClientWindow.xaml
    /// </summary>
    public partial class ShowAllClientWindow : Window
    {
        public ShowAllClientWindow()
        {
            InitializeComponent();
            var vm = new ShowAllClientViewModel();
            this.DataContext = vm;
        }
    }
}
