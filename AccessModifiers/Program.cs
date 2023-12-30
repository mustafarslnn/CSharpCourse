using System.Reflection.Metadata.Ecma335;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Customer
    {
        protected int Id { get; set; }
        public void Save()
        {
            
        }
        public void Delete()
        {

        }
    }

    class Student : Customer 
    {
        public void Save2()
        {
            
        }
    }

    public class Course
    {
        public string Name { get; set; }
    }
}
