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
            UserDataContext context = new UserDataContext();
            bool userFound = context.Users.Any(user => user.Login == login && 
            user.Password == password);
            if (userFound)
            {
                MessageBox.Show("Вы успешно вошли в систему", "Входи выполнен", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }
    }
}
