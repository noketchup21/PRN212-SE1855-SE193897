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
using BusinessObject;
using Services;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        ProductService productService = new ProductService();

        bool isCompleted = false;
        public ProductWindow()
        {
            InitializeComponent();
            DisplayProduct();

        }

        private void DisplayProduct()
        {
            isCompleted = false;
            productService.GenerateSampleDataset();
            lvProduct.ItemsSource = productService.GetProducts();
            isCompleted = true;
        }

        private void btnThemSanPham_Click(object sender, RoutedEventArgs e)
        {
            isCompleted = false;
            Product p = new Product();
            p.Id = int.Parse(txtId.Text);
            p.Name = txtName.Text;
            p.Quantity = int.Parse(txtQuantity.Text);
            p.Price = double.Parse(txtPrice.Text);

            bool ret = productService.SaveProduct(p);
            if (ret)
            {
                lvProduct.ItemsSource = null; // Clear the current items
                lvProduct.ItemsSource = productService.GetProducts(); // Refresh the list
            }
            else
            {
                MessageBox.Show("Co loi xay ra khi them moi san pham");
            }
            isCompleted = true;
        }

        private void lvProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(!isCompleted)
            {
                return;
            }
            if(e.AddedItems.Count < 0)
            {
                return;
            }
            //lay dong du lieu dang chon ra
            //vi ta binding list product nen item la product
            Product p = e.AddedItems[0] as Product;
            if(p == null)
            {
                return;
            }
            txtId.Text = p.Id.ToString();
            txtName.Text = p.Name.ToString();
            txtQuantity.Text = p.Quantity.ToString();
            txtPrice.Text = p.Price.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                isCompleted = false;
                int id = int.Parse(txtId.Text);
                string name = txtName.Text;
                double price = double.Parse(txtPrice.Text);
                int quantity = int.Parse(txtQuantity.Text);
                Product product = new Product()
                {
                    Id = id,
                    Name = name,
                    Price = price,
                    Quantity = quantity
                };
                bool kq = productService.UpdateProduct(product);
                if (kq)
                {
                    lvProduct.ItemsSource = null; // Clear the current items
                    lvProduct.ItemsSource = productService.GetProducts(); // Refresh the list
                }
                isCompleted = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Loi: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult ret = MessageBox.Show("Muon xoa san pham nay?", "Xac nhan xoa", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(ret == MessageBoxResult.No)
            {
                return;
            }
            isCompleted = false;
            Product pDel = new Product();
            pDel.Id = int.Parse(txtId.Text);
            bool kq = productService.DeleteProduct(pDel);
            if (kq)
            {
                lvProduct.ItemsSource = null;
                lvProduct.ItemsSource = productService.GetProducts(); // Refresh the list
            }
            isCompleted = true;
        }
    }
}
