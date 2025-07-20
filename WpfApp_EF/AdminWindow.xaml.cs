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
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        ICategoryService categoryService = new CategoryService();
        IProductService productService = new ProductService();
        bool is_loaded_product_completed = false;
        Category selected_category = null;
        Product selected_product = null;
        TreeViewItem selected_product_node = null;
        public AdminWindow()
        {
            InitializeComponent();
            is_loaded_product_completed = false;
            LoadCategoriesAndProductsIntoTreeView();
            is_loaded_product_completed = true;
        }

        private void LoadCategoriesAndProductsIntoTreeView()
        {
            tvCategory.Items.Clear();
            //tao goc
            TreeViewItem root = new TreeViewItem();
            root.Header = "Kho Hang Cat Lai";
            tvCategory.Items.Add(root);
            //Nap danh muc len treeview
            List<Category> categories = categoryService.GetCategories();
            foreach (Category category in categories)
            {
                //Tao cate node
                TreeViewItem cateNode = new TreeViewItem();
                cateNode.Header = category.CategoryName;
                cateNode.Tag = category;
                root.Items.Add(cateNode);

                //nap product theo danh muc
                List<Product> products = productService.GetProductByCategory(category.CategoryId);
                category.Products = products;
                //dua product node vao cate node
                foreach (Product product in category.Products)
                {
                    TreeViewItem productNode = new TreeViewItem();
                    productNode.Header = product.ProductName;
                    productNode.Tag = product;
                    cateNode.Items.Add(productNode);
                }
            }
            root.ExpandSubtree();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Lay danh muc dang chon ra
                TreeViewItem cate_item = tvCategory.SelectedItem as TreeViewItem;
                if ((cate_item == null || selected_category == null) && selected_product_node == null)
                {
                    MessageBox.Show("Ban chua  chon danh muc, khong them moi duoc", "Loi chua chon danh muc", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                //tao mot doi tuong product
                Product p = new Product();
                p.ProductName = txtName.Text;
                p.UnitPrice = decimal.Parse(txtPrice.Text);
                p.UnitsInStock = short.Parse(txtQuantity.Text);
                if(selected_product_node == null)
                {
                    p.CategoryId = selected_category.CategoryId;
                }
                else
                {
                    p.CategoryId = selected_product.CategoryId;
                }
                p.CategoryId = selected_category.CategoryId;
                bool ret = productService.SavedProduct(p);
                if (ret)
                {
                    //luu thanh cong: Nap lai treeview + listview
                    TreeViewItem p_node = new TreeViewItem();
                    p_node.Header = p.ProductName;
                    p_node.Tag = p;
                    cate_item.Items.Add(p_node);
                    //nap lai listview
                    var products = productService.GetProductByCategory(selected_category.CategoryId);
                    is_loaded_product_completed = false;
                    lvProduct.ItemsSource = null;
                    lvProduct.ItemsSource = products;
                    is_loaded_product_completed = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi luu moi" + ex.Message, "Loi luu moi", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtId.Focus();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TreeViewItem cate_item = tvCategory.SelectedItem as TreeViewItem;
                if (cate_item == null || selected_category == null)
                {
                    MessageBox.Show("Ban chua  chon danh muc, khong them moi duoc", "Loi chua chon danh muc", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                //tao mot doi tuong product
                Product p = new Product();
                p.ProductId = int.Parse(txtId.Text);
                p.ProductName = txtName.Text;
                p.UnitPrice = decimal.Parse(txtPrice.Text);
                p.UnitsInStock = short.Parse(txtQuantity.Text);
                p.CategoryId = selected_category.CategoryId;

                bool ret = productService.UpdateProduct(p);
                if(ret)
                {
                    is_loaded_product_completed = false;
                    //nap lai cay
                    cate_item.Items.Clear();
                    var products = productService.GetProductByCategory(selected_category.CategoryId);
                    foreach (Product product in products)
                    {
                        TreeViewItem productNode = new TreeViewItem();
                        productNode.Header = product.ProductName;
                        productNode.Tag = product;
                        cate_item.Items.Add(productNode);
                    }
                    //nap lai listview
                    lvProduct.ItemsSource = null;
                    lvProduct.ItemsSource = products;
                    is_loaded_product_completed = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi cap nhat" + ex.Message, "Loi cap nhat", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //phai xac thuc muon xoa hay khong
            int productId = int.Parse(txtId.Text);
            bool ret = productService.DeleteProduct(productId);
            if(ret)
            {
                //xoa thanh cong thi nap lai treeview, listview
                //copy update xuong nhung luu y chon node danh muc hay san pham
                if(selected_product_node != null)
                {
                    //xoa node product trong listview
                }
                else
                {
                    //nap lai product list cho cate node va listview
                }
            }
        }

        private void lvProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!is_loaded_product_completed) return;
            if (e.AddedItems.Count <= 0) return;
            Product p = e.AddedItems[0] as Product;
            txtId.Text = p.ProductId.ToString();
            txtName.Text = p.ProductName;
            txtPrice.Text = p.UnitPrice.ToString();
            txtQuantity.Text = p.UnitsInStock.ToString();
        }

        private void tvCategory_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            is_loaded_product_completed = false;
            selected_category = null;
            if (e.NewValue == null) return;
            TreeViewItem item = e.NewValue as TreeViewItem;
            if (item == null) return;
            object data = item.Tag;
            List<Product> products = null;
            if (data == null)
            {
                //nguoi dung an vao node goc => hien thi toan bo san pham
                products = productService.GetProducts();
            }
            else if (data is Category)
            {
                //nguoi dung nhan vao node cate => hien thi san pham danh muc
                Category cate = data as Category;
                selected_category = cate;
                products = productService.GetProductByCategory(cate.CategoryId);
            }
            else if (data is Product)
            {
                //hien thi san pham nay vao listview
                Product product = data as Product;
                products = new List<Product>();
                products.Add(product);

                selected_product = product;
                selected_product_node = item;
            }
            lvProduct.ItemsSource = null;
            lvProduct.ItemsSource = products;
            is_loaded_product_completed = true;
        }
    }
}
