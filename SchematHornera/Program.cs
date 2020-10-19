using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchematHornera
{
    class Program
    {
        static void oblicz(List<Double> lista,double x)
        {
            int i = 0;
            double j = lista[0];
            Console.WriteLine($"Krok {i+1}: j wynosi = {j}");
            for (i=1; i <lista.Count(); i++)
            {
                j = j * x + lista[i];
                Console.WriteLine($"Krok {i+1}: j wynosi = {j}");
            }
            Console.WriteLine($"Odpowiedz: W({lista.Count()-1}) = {j}");
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Podaj stopnien wielomianu:");
            int stopien;
            stopien = Int32.Parse(Console.ReadLine());
            List<Double> lista = new List<double>();
            for (int i = 0;i <= stopien;i++)
            {
                Console.WriteLine($"Podaj współczynnik {stopien-i} stopnia" );
                lista.Add(Double.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Podaj x");
            double x = Double.Parse(Console.ReadLine());
            oblicz(lista,x);
            Console.WriteLine("Koniec programu.");
            Console.ReadKey();
        }
    }
}
