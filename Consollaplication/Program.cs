using Consollaplication;

internal class Program
{
    private static void Main(string[] args)
    {
        Class1 customer = new Class1();

        customer.Surname = "ATALAY";
        customer.Name = "Melik Şah";
        customer.TcNo = "147258369";
        customer.Id = 1;

        Class1 customer2 = new Class1();

        customer2.Name = "Melik Şah";
        customer2.Surname = "Atalay";
        customer2.Id = 3;
        customer2.TcNo = "123456789";

        //Add Customer 

        CustomerManager customerManager = new CustomerManager();
        customerManager.AddCustomer(customer)
;
        //Remove Customer 
        customerManager.RemoveCustomer(customer2);

        Class1[] customerList = new Class1[] { customer, customer2 };

        customerManager.CustomerList(customerList);
    }
}