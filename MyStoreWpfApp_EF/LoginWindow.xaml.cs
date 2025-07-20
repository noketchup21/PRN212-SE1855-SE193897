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
using MyStoreWpfApp_EF.Models;

namespace MyStoreWpfApp_EF
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        MyStoreContext context = new MyStoreContext();
        public LoginWindow()
        {
            InitializeComponent();
            ChangeBackground();
        }

        private void ChangeBackground()
        {
            LinearGradientBrush brush = new LinearGradientBrush();
            brush.GradientStops.Add(new GradientStop(Colors.Yellow, 0.0));
            brush.GradientStops.Add(new GradientStop(Colors.Green, 0.5));
            brush.GradientStops.Add(new GradientStop(Colors.Purple, 1.0));
            btnThoat.Background = brush;

            RadialGradientBrush gradientBrush = new RadialGradientBrush();
            gradientBrush.GradientOrigin = new Point(0.75, 0.25);
            gradientBrush.GradientStops.Add(new GradientStop(Colors.LightBlue, 0.0));
            gradientBrush.GradientStops.Add(new GradientStop(Colors.Purple, 1.0));
            gradientBrush.GradientStops.Add(new GradientStop(Colors.White, 0.5));
            btnDangnhap.Background = gradientBrush;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Password;
            AccountMember am = context.AccountMembers.FirstOrDefault(a => a.EmailAddress == email && a.MemberPassword == password);
            if (am == null)
            {
                MessageBox.Show("Dang nhap that bai", "Failed login", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            else
            {
                if(am.MemberRole == 1)
                {
                    MessageBox.Show("Dang nhap Admin thanh cong", "Success login", MessageBoxButton.OK, MessageBoxImage.Information);
                    AdminWindow aw = new AdminWindow();
                    aw.Show();
                    Close();
                }
                else if (am.MemberRole == 2)
                {
                    MessageBox.Show("Dang nhap Staff thanh cong", "Success login", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if (am.MemberRole == 3)
                {
                    MessageBox.Show("Dang nhap Vang lai thanh cong", "Success login", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }
    }
}
