using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccessLayer
{
    public class CustomerDAO
    {
        static List<Customer> customers = new List<Customer>();
        public void GenerateSampleDataset()
        {
            customers.Add(new Customer { Id = 1, Name = "Alice", Phone = "123-456-7890" });
            customers.Add(new Customer { Id = 2, Name = "Bob", Phone = "234-567-8901" });
            customers.Add(new Customer { Id = 3, Name = "Charlie", Phone = "345-678-9012" });
            customers.Add(new Customer { Id = 4, Name = "David", Phone = "456-789-0123" });
            customers.Add(new Customer { Id = 5, Name = "Eve", Phone = "567-890-1234" });
        }
        public List<Customer> GetAllCustomers()
        {
            return customers;
        }
    }
}
