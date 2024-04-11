using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Interface19
{
    class Rectangle : IFunc
    {
        public string Name { get; set; }
        public int SideA { get; set; }
        public int SideB { get; set; }
        public Rectangle() { }
        public Rectangle(string name, int sideA, int sideB)
        {
            Name = name;
            SideA = sideA;
            SideB = sideB;
        }
        public double Area()
        {
            return SideA * SideB;
        }
        public double Per()
        {
            return (SideA + SideB) * 2;
        }
        public override string ToString()
        {
            return $"Название фигуры: {Name}\na={SideA}\nb={SideB}\nПлощадь: {Area():f2}\nПериметр: {Per():f2}";
        }
    }
}
