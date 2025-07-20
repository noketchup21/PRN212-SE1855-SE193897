using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects_EF;
using Repositories_EF;

namespace Services_EF
{
    public class ProductService : IProductService
    {
        IProductRepository repository;
        public ProductService()
        {
            repository = new ProductRepository();
        }

        public bool DeleteProduct(int productId)
        {
            return repository.DeleteProduct(productId);
        }

        public List<Product> GetProductByCategory(int cateId)
        {
            return repository.GetProductByCategory(cateId);
        }

        public List<Product> GetProducts()
        {
            return repository.GetProducts();
        }

        public bool SavedProduct(Product product)
        {
            return repository.SavedProduct(product);
        }

        public bool UpdateProduct(Product product)
        {
            return repository.UpdateProduct(product);
        }
    }
}
