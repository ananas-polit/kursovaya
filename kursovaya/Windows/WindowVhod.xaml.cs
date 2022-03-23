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
    /// Логика взаимодействия для WindowVhod.xaml
    /// </summary>
    public partial class WindowVhod : Window
    {
        public WindowVhod()
        {
            InitializeComponent();
            bookstoreEntities context = new bookstoreEntities();
        }

        private void vhod_Click(object sender, RoutedEventArgs e)
        {
            string Login = "5";
            string Password = "1223";
            if (login.Text == Login && password.Text == Password)
           
                MessageBox.Show("Добро Пожаловать");
                var menu = new WindowMenu();
                menu.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Не удалось войти. Введен не правильно логин или пароль");
            //}
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
