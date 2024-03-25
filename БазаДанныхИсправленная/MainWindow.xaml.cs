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
            string login = loginInput.Text;
            string password = passwordInput.Password;
            User user = new User();
            user.Login = login;
            user.Password = password;
            db.Users.Add(user);
            db.SaveChanges();
        }

        private void signIn_Click(object sender, RoutedEventArgs e)
        {
            SignInWindow signInWindow = new SignInWindow();
            signInWindow.Show();
            this.Close();
        }
    }
}
