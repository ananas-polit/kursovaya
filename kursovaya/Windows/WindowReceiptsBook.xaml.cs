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
    /// Логика взаимодействия для WindowReceiptsBook.xaml
    /// </summary>
    public partial class WindowReceiptsBook : Window
    {
        bookstoreEntities context;
        public WindowReceiptsBook()
        {
            InitializeComponent();
            context = new bookstoreEntities();
            ShowTable();
        }
        private void ShowTable()
        {
            DataGridReceiptsBook.ItemsSource = context.ReceiptsBook.ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
