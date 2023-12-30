namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ValueTypes
            //Console.WriteLine("Hello, World!");
            int number1 = 2147483647;
            long number2 = 9223372036854775807;
            short number3 = 32767;
            byte number4 = 255; // 0 - 255
            bool condition = false;
            char character = 'A';
            double number5 = 10.4;
            decimal number6 = 15.7m;
            var number7 = 10;
            number7 = 'B';
            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Character is : {0}",(int)character);
            Console.WriteLine((int)Days.Saturday);
            Console.WriteLine("Number7 is : {0}",number7);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday = 1,Tuesday, Wednesday,Thursday,Friday,Saturday,Sunday
    }        
}
