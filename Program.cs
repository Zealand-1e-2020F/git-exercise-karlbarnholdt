using System;

namespace GitExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ulrik Vinblad", "Chardonnayvej 11", 2900);

            Console.WriteLine(person);
        }
    }
}
