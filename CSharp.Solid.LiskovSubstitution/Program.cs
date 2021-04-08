using CSharp.Solid.LiskovSubstitution.Models;
using System;

namespace CSharp.Solid.LiskovSubstitution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Rectangle rectangle = new ();
            rectangle.SetBase(5);
            rectangle.SetAltura(6);

            Console.WriteLine(rectangle.Area());

            Rectangle square = new Square();
            square.SetBase(5);
            square.SetAltura(10); // change the order to work
            // expected 5*5 = 25
            Console.WriteLine($"expected 25: {square.Area()}");

        }
    }
}
