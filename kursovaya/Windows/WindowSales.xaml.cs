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
    /// Логика взаимодействия для WindowSales.xaml
    /// </summary>
    public partial class WindowSales : Window
    {
        bookstoreEntities context;
       
        string currentLetter = "";
        public WindowSales()
        {
            InitializeComponent();
            context = new bookstoreEntities();
            ShowLetters();
            ShowTable();
        }
        private void ShowTable()
        {
            DataGridSales.ItemsSource = context.Sales.ToList();
            //if (txtBook.Text == null)
            //    return;
            //List<Client> listClient = context.Client.ToList();
            //listClient = listClient.Where(x => x.Book.ToLower().Contains(txtBook.Text.ToLower())).ToList();
            //if (currentLetter.Count() == 1)
            //{
            //    listClient = listClient.Where(x => x.FirstName.Contains(currentLetter)).ToList();
            //}
            //DataGridSales.ItemsSource = listClient.OrderBy(x => x.FirstName).ToList();
        }
        private void ShowLetters()
        {
            //for (char i = 'А'; i <= 'Я'; i++)
            //{
            //    TextBlock letter = new TextBlock
            //    {
            //        Text = i.ToString(),
            //        FontWeight = FontWeights.Bold,
            //        Foreground = Brushes.White,
            //        Margin = new Thickness(10, 0, 0, 0)
            //    };
            //    letter.MouseLeftButtonDown += TextBlock_MouseLeftButtonDown;
            //    StackLetters.Children.Add(letter);
            //}
        }
        private void BtnAddClient_Click(object sender, RoutedEventArgs e)
        {
            var NewSales = new Sales();
            context.Sales.Add(NewSales);
            var EditWindows = new WindowAddSales(context, NewSales);
            EditWindows.ShowDialog();
            ShowTable();
        }

        private void BtnDeleteClientS_Click(object sender, RoutedEventArgs e)
        {
            var currentRegistr = DataGridSales.SelectedItem as Sales;
            if (currentRegistr == null)
            {
                MessageBox.Show("Выберите строку");
                return;
            }
            MessageBoxResult messageBoxResult = MessageBox.Show("Вы действительно хотите удалить эту строку?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                context.Sales.Remove(currentRegistr);
                context.SaveChanges();
                ShowTable();
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Button sales = sender as Button;
            var currentRegistr = sales.DataContext as Sales;
            var salees = new WindowAddSales(context, currentRegistr);
            salees.ShowDialog();
        }
        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //var label = (TextBlock)sender;
            //currentLetter = label.Text;
            //foreach (TextBlock letter in StackLetters.Children)
            //{
            //    letter.Foreground = Brushes.White;
            //}
            //label.Foreground = Brushes.Gold;
            //ShowTable();
        }
        private void BtnBackClientS_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CmbFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowTable();
        }
        private void txtBook_TextChanged(object sender, TextChangedEventArgs e)
        {
            ShowTable();
        }
        private void TextBlock_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            ShowTable();
        }

    }
}
