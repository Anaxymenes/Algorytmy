using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickSort
{
    class Program
    {
        private void WyswietlTablice(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
        }
        private void LosujLiczby(int[] a, int rMin, int rMax)
        {
            Random rand = new Random();
            for (int i = 0; i < a.Length; i++)
                a[i] = rand.Next(rMin, rMax);
            Console.WriteLine("Tablica nieposortowana:");
            this.WyswietlTablice(a);
        }
        private int MedianOfThree(int[]a ,int start, int end)
        {
            //Pobietamy srodkowy index
            int center = (start + end) / 2;
            //Ustawiamy tak by na pierwszym miejscu byla najmniejsza
            //na ostatnim najwieksza warotsc z tablicy
            if (a[start] > a[center])
            { int temp = a[start]; a[start] = a[center]; a[center] = temp; }
            if (a[start] > a[end])
            { int temp = a[start]; a[start] = a[end]; a[end] = temp; }
            if (a[center] > a[end])
            { int temp = a[center]; a[center] = a[end]; a[end] = temp; }
            //zwracamy mediane z trzech liczb
            return a[center];
        }
        private void QuickSort(int[] a, int start, int end)
        {
            if (start >= end)
                return;
            int i = start - 1, j = end + 1;
            //int pivot = a[(start + end) / 2]; //Pivot jako srodkowy element
            //int pivot = MedianOfThree(a, start, end); //Pivot jako mediana z trzech
            //int pivot = a[start]; //Pivot jako pierwszy element tablicy
            int pivot = a[end]; //Pivot jako ostatni element tablicy
            while (true)
            {
                while (pivot > a[++i]) ; //Szukamy wartości większej od pivota
                while (pivot < a[--j]) ; //Szukamy wartosci mniejszej od pivota
                if (i <= j) //Jeśli i nie spotkało, lub nie jest większe od j to dokonujemy zamiany
                    { int temp = a[i]; a[i] = a[j]; a[j] = temp; }
                else
                    break; //jeśli i>=j, przerywamy przeszukiwanie tablicy
            }
            if (j > start)
                QuickSort(a, start, j);
            if (i < end)
                QuickSort(a, i, end);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            int n = 10;
            int[] a = new int[n];
            program.LosujLiczby(a,0,9);
            program.QuickSort(a, 0, n - 1);
            Console.WriteLine("\nTablica po sortowaniu");
            program.WyswietlTablice(a);
            Console.ReadKey();
        }
    }
}
