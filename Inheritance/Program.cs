namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Student{FirstName = "Ali"},
                new Customer{FirstName = "Veli"},
                new Person{FirstName = "Göktuğ"} 
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }

    }

    class Student : Person
    {
        public string Departmant { get; set; }
    }
}
