namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Mustafa Arslan";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Satu Arslan";

            bool result3 = sentence.EndsWith("n"); // cümlenin bu karakter ile bitip bitmediğini sorgular
            bool result4 = sentence.StartsWith("My name"); // başlangıç karakterini ya da öbeğini sorgular

            var result5 = sentence.IndexOf("namee");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 = sentence.Remove(1,4);           //Şu karakterden başla şu kadar karakter sil  
            var result10 = sentence.Replace(" ", "*");
            var result11 = sentence.Substring(3, 4);
            var result12 = sentence.ToLower();
            var result13 = sentence.ToUpper();

            Console.WriteLine(result9);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "İstanbul";

            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "Adana";

            Console.WriteLine(string.Format("{0} {1}", city, city2));
        }
    }
}
