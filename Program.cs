using LojinhaDoTioJoao.Entities.Enums;
using System.Collections.Generic;


namespace LojinhaDoTioJoao.Entities
{
    
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, date);                      
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");         
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status , client);
            Console.Clear();
            Console.Write("How many items to whis order?: ");
            int rep = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rep; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.WriteLine("Product name: ");
                string Pname = Console.ReadLine();
                Console.WriteLine("Poduct price: ");
                float price = float.Parse(Console.ReadLine());
                Product p = new Product(Pname, price);
                Console.WriteLine("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
               
                OrderItem orderItem = new OrderItem(quantity, price, p);
                order.AddItem(orderItem);

            }



        }
    }
}