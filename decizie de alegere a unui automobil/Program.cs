using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decizie_de_alegere_a_unui_automobil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cel mai mic pret al masinii:");
            int pret= (int)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Cheltuieli de intretinere minime:");
            int intretinereMin= (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cheltuieli de intretinere maxime:");
            int intretinereMax = (int)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Grad de confort, nivel dotari, siguranta maxim(1-20):");
            int confortMax = (int)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Grad de confort, nivel dotari, siguranta minim(1-20):");
            int confortMin = (int)Convert.ToInt32(Console.ReadLine());


        }
    }
}
