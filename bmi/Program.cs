using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Größe in m: \t");
            double length;
            double weight;
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Gewicht in Kilogramm: \t");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"BMI: {weight/(length*length)}");
            Console.ReadKey();
        }
    }
}
