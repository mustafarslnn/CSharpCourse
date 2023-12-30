namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();

            //WhileLoop();

            //DoWhileLoop();

            //ForeeachLoop();

            if (IsPrimeNumber(17))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }


            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;

            for (int i = 2;  i < number-1; i++)
            {
                if(number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }
        private static void ForLoop()
        {
            for (int i = 0; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }

        }

        private static void ForeeachLoop()
        {
            string[] students = new string[3] { "Ali", "Veli", "Celil" };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;

            } while (number >= 0);
        }

        private static void WhileLoop()
        {
            int i = 100;
            while (i >= 0)
            {
                Console.WriteLine(i);
                i--;
            }
            Console.WriteLine("Now i is {0}", i);
        }
    }
}
