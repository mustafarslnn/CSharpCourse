namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3]{ "Ali", "Veli", "Celil" };

            string[] students2 = { "Selim", "Can", "Göktuğ" };

            foreach (var student in students2)
            {
                Console.WriteLine(student);
                
            }

            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmit","Bursa"},
                {"Antalya","Adana","Mersin"},
                {"Ankara","Konya","Kırıkkale"},
                {"Samsun","Sinop","Ordu"},
                {"İzmir","Aydın","Muğla"},
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("******");
            }

            Console.ReadLine();

        }


    }
}
