using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects_EF;
using DataAccessLayer_EF;

namespace Repositories_EF
{
    public class ProductRepository : IProductRepository
    {
        ProductDAO productDAO = new ProductDAO();

        public bool DeleteProduct(int productId)
        {
            return productDAO.DeleteProduct(productId);
        }

        public List<Product> GetProductByCategory(int cateId)
        {
            return productDAO.GetProductByCategory(cateId);
        }

        public List<Product> GetProducts()
        {
            return productDAO.GetProducts();
        }

        public bool SavedProduct(Product product)
        {
            return productDAO.SavedProduct(product);
        }

        public bool UpdateProduct(Product product)
        {
            return productDAO.UpdateProduct(product);
        }
    }
}
