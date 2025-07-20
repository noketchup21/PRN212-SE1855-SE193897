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
using BusinessObjects_EF;
using Services_EF;

namespace WpfApp_EF
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        IAccountMemberService accountMemberService = new AccountMemberService();
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AccountMember am = accountMemberService.Login(txtEmail.Text, txtPassword.Password);
            if(am == null)
            {
                MessageBox.Show("Dang nhap that bai - vui long kiem tra lai", "Dang nhap that bai", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if(am.MemberRole == 1)
                {
                    AdminWindow aw = new AdminWindow();
                    aw.Show();
                    Close();
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
