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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string FIO = FIOBox.Text;
            string password = PasswordBox.Password;
            string Email = EmailBox.Text;


            if (FIO == "" || password == "")
            {
                MessageBox.Show("Ошибка: ФИО и пароль должны быть заполнены");
                return;
            }


            if (!Email.Contains("@"))
            {
                MessageBox.Show("Ошибка: Email должен содержать @");
                return;
            }


            if (RBox.IsChecked != true)
            {
                MessageBox.Show("Ошибка: необходимо согласиться с условиями регистрации");
                return;
            }


            MessageBox.Show("Регистрация успешна! Добро пожаловать, " + FIO);
        }
    }
}
  