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
    /// Логика взаимодействия для WindowBook.xaml
    /// </summary>
    public partial class WindowBook : Window
    {
        bookstoreEntities context;
        string currentLetter = "";
        public WindowBook()
        {
            InitializeComponent();
            context = new bookstoreEntities();
            DataGridBook.ItemsSource = context.Book.ToList();
            ShowTable();
        }
        private void ShowTable()
        {
            if (TxtName.Text == null)
                return;
            List<Book> listBook = context.Book.ToList();
            listBook = listBook.Where(x => x.Name.ToLower().Contains(TxtName.Text.ToLower())).ToList();
            if (currentLetter.Count() == 1)
            {
                listBook = listBook.Where(x => x.Name.Contains(currentLetter)).ToList();
            }
            DataGridBook.ItemsSource = listBook.OrderBy(x => x.Name).ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CmbGender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CmbGender.SelectedIndex == 0)
            {
                ShowTable();
            }
            if (CmbGender.SelectedIndex == 1)
            {
                DataGridBook.ItemsSource = context.Book.Where(x => x.SectionID.Contains("1")).ToList();
            }
            if (CmbGender.SelectedIndex == 2)
            {
                DataGridBook.ItemsSource = context.Book.Where(x => x.SectionID.Contains("2")).ToList();

            }
            if (CmbGender.SelectedIndex == 3)
            {
                DataGridBook.ItemsSource = context.Book.Where(x => x.SectionID.Contains("3")).ToList();

            }
            if (CmbGender.SelectedIndex == 4)
            {
                DataGridBook.ItemsSource = context.Book.Where(x => x.SectionID.Contains("4")).ToList();

            }
            if (CmbGender.SelectedIndex == 5)
            {
                DataGridBook.ItemsSource = context.Book.Where(x => x.SectionID.Contains("5")).ToList();

            }
        }

        private void TxtName_TextChanged(object sender, TextChangedEventArgs e)
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
