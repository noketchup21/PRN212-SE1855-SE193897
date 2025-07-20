using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects_EF;

namespace Repositories_EF
{
    public interface IProductRepository
    {
        public List<Product> GetProducts();
        public List<Product> GetProductByCategory(int cateId);
        public bool SavedProduct(Product product);
        public bool UpdateProduct(Product product);
        public bool DeleteProduct(int productId);
    }
}
