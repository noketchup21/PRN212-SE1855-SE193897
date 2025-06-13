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

namespace HelloWpfApp
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //login neu thanh cong thi vao MainWindow
            //neu that bai thi thong bao failed
            if(txtUsername.Text == "obama" && txtPassword.Password == "123")
            {
                MainWindow mw = new MainWindow(); //mo man hinh MainWindow
                mw.Show();
                Close(); //dong man hinh dang nhap
            }
            else
            {
                MessageBox.Show("Dang nhap failed");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
