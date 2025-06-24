using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TreeViewWpfAPp.models;

namespace TreeViewWpfAPp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<int, Category> categories = SampleDataset.GenerateDataset();
        public MainWindow()
        {
            InitializeComponent();
            DisplayDatasetOnTreeView();
        }

        private void DisplayDatasetOnTreeView()
        {
            //xoa du lieu cu tren treeview
            tvCategory.Items.Clear();
            //tao goc cay truoc (hoac ko tao)
            TreeViewItem root = new TreeViewItem();
            root.Header = "Kho hang";
            tvCategory.Items.Add(root);
            //vong lap so 1 de nap danh muc len cay
            foreach (KeyValuePair<int, Category> item in categories)
            {
                Category cate = item.Value;
                //tao node cho Category
                TreeViewItem cateNode = new TreeViewItem();
                cateNode.Header = cate;
                //dua node category vao goc cay
                root.Items.Add(cateNode);
                //vong lap so 2 de nap san pham vao node Danh muc
                foreach (KeyValuePair<int, Product> subitem in cate.Products)
                {
                    Product product = subitem.Value;
                    //tao node cho Product
                    TreeViewItem productNode = new TreeViewItem();
                    productNode.Header = product;
                    cateNode.Items.Add(productNode);
                }
            }
        }
    }
}