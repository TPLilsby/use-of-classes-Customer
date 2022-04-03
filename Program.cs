
namespace Test2
{
    public class Program
    {

        static void Main(string[] args)
        {
            bool run = true;

            List<Customer> list = new List<Customer>();

            while (run)
            {
                int index = 1;

                Console.Clear();
                foreach (Customer customer in list)
                {
                    Console.WriteLine(index);
                    index++;
                    customer.Write();
                }

                Console.WriteLine("Do want to add a customer or delete: add/del. Show all customer or quit: show/q ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "add":
                        Customer one = new Customer();
                        one.Write();
                        list.Add(one);
                        break;

                    case "del":
                        Console.WriteLine("Write the the number you want to delete");
                        int input = int.Parse(Console.ReadLine());
                        list.RemoveAt(input--);
                        break;

                    case "show":
                        foreach (Customer customer in list)
                        {
                            customer.Write();
                        }
                        break;

                    case "q":
                        run = false;
                        break;
                }
            }
        }
    }

    public class Customer
    {
        string name;
        int balance;

        public Customer()
        {
                Console.WriteLine("\nWrite your name: ");
                name = Console.ReadLine();
                GetRandomNumber();
        }

        public void Write()
        {
            Console.WriteLine("\nName: " + name);
            Console.WriteLine("Balance: " + balance);
        }

        public void GetRandomNumber()
        {
            Random rnd = new Random();
            balance = rnd.Next(0, 5000);
            
        }
    }
}