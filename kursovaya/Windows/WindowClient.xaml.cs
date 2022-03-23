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
    /// Логика взаимодействия для WindowClient.xaml
    /// </summary>
    public partial class WindowClient : Window
    {
        bookstoreEntities context;
        string currentLetter = "";
        public WindowClient()
        {
            InitializeComponent();
            context = new bookstoreEntities(); 
            DataGridClient.ItemsSource = context.Client.ToList();
            ShowTable();
        }
        private void ShowTable()
        {
         
            if (txtFirstName.Text == null)
                return;
            List<Client> listClient = context.Client.ToList();
            listClient = listClient.Where(x => x.FirstName.ToLower().Contains(txtFirstName.Text.ToLower())).ToList();
            if (currentLetter.Count() == 1)
            {
                listClient = listClient.Where(x => x.LastName.Contains(currentLetter)).ToList();
            }
            DataGridClient.ItemsSource = listClient.OrderBy(x => x.FirstName).ToList();
        }

        private void BtnAddClient_Click(object sender, RoutedEventArgs e)
        {
            var NewClient = new Client();
            context.Client.Add(NewClient);
            var EditWindows = new WindowAddClient(context, NewClient);
            EditWindows.ShowDialog();
            ShowTable();
        }


        private void BtnDeleteClientS_Click(object sender, RoutedEventArgs e)
        {
            var currentRegistr = DataGridClient.SelectedItem as Client;
            if (currentRegistr == null)
            {
                MessageBox.Show("Выберите строку");
                return;
            }
            MessageBoxResult messageBoxResult = MessageBox.Show("Вы действительно хотите удалить эту строку?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                context.Client.Remove(currentRegistr);
                context.SaveChanges();
                ShowTable();
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Button clieent = sender as Button;
            var currentRegistrr = clieent.DataContext as Client;
            var clientt = new WindowAddClient(context, currentRegistrr);
            clientt.ShowDialog();
        }

        private void BtnBackClientS_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            ShowTable();
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var label = (TextBlock)sender;
            currentLetter = label.Text;
            foreach (TextBlock letter in StackLetters.Children)
            {
                letter.Foreground = Brushes.White;
            }
            label.Foreground = Brushes.Gold;
            ShowTable();
        }
    }
}
