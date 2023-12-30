namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //var result = Add2();
            int number1 = 50;
            int number2 = 70;
            var result2 = Add3(ref number1,number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            Console.WriteLine(Add4(1,2,3,4,5,6));
            Console.ReadLine();
        }

        static void Add() 
        {
            Console.WriteLine("Added!'!"); 
        }
        static int Add2(int number1 = 20,int number2 = 30)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(ref int number1,int number2)
        {
            return number1 + number2;
        }

        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
