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
    /// Логика взаимодействия для WindowAddSales.xaml
    /// </summary>
    public partial class WindowAddSales : Window
    {
        bookstoreEntities context;
        public WindowAddSales(bookstoreEntities context1, Sales sales )
        {
            InitializeComponent();
            this.context = context1;
            CmbClient.ItemsSource = context.Client.ToList();
            CmbBook.ItemsSource = context.Book.ToList();
            CmbPersonnel.ItemsSource = context.Personnel.ToList();
            this.DataContext = sales;

        }

        private void BtnSaveData_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
            MessageBox.Show("Данные добавлены!");
            this.Close();
        }
    }
}
