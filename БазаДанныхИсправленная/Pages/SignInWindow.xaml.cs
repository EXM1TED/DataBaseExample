using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Data.Common;
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
using БазаДанныхИсправленная.Classes;

namespace БазаДанныхИсправленная.Pages
{
    /// <summary>
    /// Логика взаимодействия для SignInWindow.xaml
    /// </summary>
    public partial class SignInWindow : Window
    {
        public SignInWindow()
        {
            InitializeComponent();
        }

        private void OpenRegistrationWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            string login = loginInput.Text;
            string password = passwordInput.Password;
            UserDataContext db = new UserDataContext();
            db.Database.EnsureCreated();
            var checkUser = db.Users.FromSqlRaw($"SELECT Id, Login, Password, Number_of_class_id FROM Users WHERE Login = '{login}' and Password = '{password}'").ToList();
            if ( checkUser.Count == 1 )
            {
                User user = new User();
                user.Login = login;
                user.Password = password;
                foreach (var className in checkUser)
                    user.NumberOfClassId = className.NumberOfClassId;
                UserSave.userSave = user;
                MessageBox.Show("Вы успешно вошли в систему", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
