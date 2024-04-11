using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Interface19
{
    class Сircle : IFunc
    {
        public string Name { get; set; }
        public int Rad { get; set; }
        public Сircle() { }
        public Сircle(string name, int rad)
        {
            Name = name;
            Rad = rad;
        }
        public double Area()
        {
            return Math.PI * Math.Pow(Rad, 2);
        }
        public double Per()
        {
            return 2 * Math.PI * Rad; ;
        }
        public override string ToString()
        {
            return $"Название фигуры: {Name}\nРадиус:{Rad}\nПлощадь: {Math.Round(Area(),2)}\nПериметр: {Per():f2}";
        }
    }
}
