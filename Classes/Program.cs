namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Mustafa";
            customer.LastName = "Arslan";
            customer.City = "Samsun";

            Customer customer2 = new Customer()
            {
                Id = 2, FirstName = "Ali", LastName = "Yazıcı", City = "Trabzon"
            };

            Console.WriteLine(customer2.FirstName);


            Console.ReadLine();
        }
    }

}
