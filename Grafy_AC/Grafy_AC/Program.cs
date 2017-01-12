using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grafy_AC
{
    class Program
    {
        static void Main(string[] args)
        {
            AdjacencyList lista = new AdjacencyList();
            AdjacencyMatrix macierz = new AdjacencyMatrix();
            macierz.CreateMatrixFromList(lista.List);
            Console.WriteLine("Oto powstała macierz!");
            Console.WriteLine(macierz.ToString());
            Console.ReadKey();
        }
    }
}
