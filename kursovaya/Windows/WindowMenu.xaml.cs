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

namespace kursovaya.Windows
{
    /// <summary>
    /// Логика взаимодействия для WindowMenu.xaml
    /// </summary>
    public partial class WindowMenu : Window
    {
        public WindowMenu()
        {
            InitializeComponent();
        }

        private void BtnSales_Click(object sender, RoutedEventArgs e)
        {
            var NewWindowSales = new WindowSales();
            NewWindowSales.ShowDialog();
        }

        private void BtnBook_Click(object sender, RoutedEventArgs e)
        {
            var NewWindowBook = new WindowBook();
            NewWindowBook.ShowDialog();
        }

        private void BtnClient_Click(object sender, RoutedEventArgs e)
        {
            var NewWindowClient = new WindowClient();
            NewWindowClient.ShowDialog();
        }

        private void BtnReceiptsBook_Click(object sender, RoutedEventArgs e)
        {
            var NewWindowReceiptsBook = new WindowReceiptsBook();
            NewWindowReceiptsBook.ShowDialog();
        }
    }
}
