using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace Repository
{
    public interface ICustomerRepository
    {
        public void GenerateSampleDataset();
        public List<Customer> GetAllCustomers();

    }
}
