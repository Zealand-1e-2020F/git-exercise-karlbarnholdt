using System;

namespace GitExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass("Ulrik Vinblad", "Chardonnayvej 11", 2900);

            Console.WriteLine(myClass);
        }
    }
}
