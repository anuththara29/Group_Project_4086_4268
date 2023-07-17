using Microsoft.Data.Sqlite;
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
using System.Xml.Linq;
using Registration.Models;


namespace Registration
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

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            using (var context = new DataBaseContext())
            {
                User user = context.Users.SingleOrDefault(u => u.Username == username && u.Password == password);

                if (user != null)
                {
                    
                    MessageBox.Show("Login successful!");

                    
                    if (user.Role == "Admin")
                    {
                        AdminMainWindow adminMainWindow = new AdminMainWindow();
                        adminMainWindow.Show();
                    }
                    else
                    {
                        UserMainWindow userMainWindow = new UserMainWindow();
                        userMainWindow.Show();
                    }

                    this.Close();
                }
                else
                {
                    
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
