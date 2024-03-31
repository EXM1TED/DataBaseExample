using Microsoft.EntityFrameworkCore;
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
using БазаДанныхИсправленная.Classes;
using БазаДанныхИсправленная.Pages;

namespace БазаДанныхИсправленная
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnRegestration_Click(object sender, RoutedEventArgs e)
        {
            UserDataContext db = new UserDataContext();
            db.Database.EnsureCreated();
            string login = loginInput.Text;
            string password = passwordInput.Password;
            User user = new User();
            user.Login = login;
            user.Password = password;
            if (loginInput.Text == "" && passwordInput.Password == "")
            {
                MessageBox.Show("Заполните поле: Логнин, Пароль", "Ошибка регистрации", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (loginInput.Text == "")
            {
                MessageBox.Show("Заполните поле: Логин", "Ошибка регистрации", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (passwordInput.Password == "")
            {
                MessageBox.Show("Заполните поле: Пароль", "Ошибка регистрации", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (rdBtnSevenClass.IsChecked == true)
            {
                db.Users.FromSqlRaw("INSERT INTO Users (Number_of_class_id) VALUES (7)");
                db.SaveChanges();
            }
            if (rdBtnEightClass.IsChecked == true)
            {
                db.Users.FromSqlRaw("INSERT INTO Users (Number_of_class_id) VALUES (8)");
                db.SaveChanges();
            }
            if (rdBtnNineClass.IsChecked == true)
            {
                db.Users.FromSqlRaw("INSERT INTO Users (Number_of_class_id) VALUES (9)");
                db.SaveChanges();
            }
            if (db.Users.Any(user => user.Login == login))
            {
                MessageBox.Show("Такой логин уже существует", "Ошибка регистрации", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }
        private void signIn_Click(object sender, RoutedEventArgs e)
        {
            SignInWindow signInWindow = new SignInWindow();
            signInWindow.Show();
            this.Close();
        }
    }
}
