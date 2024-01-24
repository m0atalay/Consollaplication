using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consollaplication
{
    internal class CustomerManager
    {
      public void AddCustomer(Class1 customer)
        {
            Console.WriteLine("Eklenen Müşteri: " + customer.Name + "" + customer.Surname);
        }
        public void RemoveCustomer(Class1 customer2)
        {
            Console.WriteLine("Silinen Müşteri: " + customer2.Name + "" + customer2.Surname);
        }
        public void CustomerList(Class1[] customers)
        {
           foreach(var item in customers)
            {
                Console.WriteLine("Müşteri: " + item.Name + " " + item.Surname);
            }
        }
    }

}
