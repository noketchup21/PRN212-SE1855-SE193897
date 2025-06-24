using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Repository;

namespace Services
{
    public class ProductService : IProductService
    {
        IProductRepository irepository;
        public ProductService()
        {
            irepository = new ProductRepository();
        }

        public bool DeleteProduct(Product product)
        {
            return irepository.DeleteProduct(product);
        }

        public void GenerateSampleDataset()
        {
            irepository.GenerateSampleDataset();
        }

        public List<Product> GetProducts()
        {
            return irepository.GetProducts();
        }

        public bool SaveProduct(Product product)
        {
            return irepository.SaveProduct(product);
        }

        public bool UpdateProduct(Product product)
        {
            return irepository.UpdateProduct(product);
        }
    }
}
