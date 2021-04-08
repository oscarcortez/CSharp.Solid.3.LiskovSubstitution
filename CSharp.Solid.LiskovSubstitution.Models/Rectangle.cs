using System;

namespace CSharp.Solid.LiskovSubstitution.Models
{
    public class Rectangle
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public virtual void SetBase(double _base) => Base = _base;

        public virtual void SetAltura(double altura) => Altura = altura;

        public virtual double Area() => Base * Altura;
    }
}
