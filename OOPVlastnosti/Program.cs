using System;

namespace OOPVlastnosti
{
    class Program
    {
        static void Main(string[] args)
        {
            Student novyStudent = new Student("Luboš Krejčí", true, 29);
            Console.WriteLine(novyStudent);
        }
    }
}
