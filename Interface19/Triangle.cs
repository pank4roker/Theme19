using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Interface19
{
    class Triangle : IFunc
    {
        public string Name { get; set; }
        public int SideA { get; set; }
        public int SideB { get; set; }
        public int SideC { get; set; }
        public Triangle() { }
        public Triangle(string name, int sidea, int sideb, int sidec)
        {
            Name = name;
            SideA = sidea;
            SideB = sideb;
            SideC = sidec;
        }
        public double Area()
        {
            double p = Per() / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public double Per()
        {
            return SideA + SideB + SideC;
        }
        public override string ToString()
        {
            return $"Название фигуры: {Name}\na={SideA}\nb={SideB}\nc={SideC}\nПлощадь: {Area():f2}\nПериметр: {Per():f2}";
        }
    }
}