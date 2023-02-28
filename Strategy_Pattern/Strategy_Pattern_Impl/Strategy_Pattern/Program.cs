using System;
using Strategy_Pattern.Abstraction;
using Strategy_Pattern.Implementation.Characters;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Strategy Pattern --------------");

            Character king = new King();
            king.Fight();

            Character queen = new Queen();
            queen.Fight();

            Console.ReadLine();
        }
    }
}
