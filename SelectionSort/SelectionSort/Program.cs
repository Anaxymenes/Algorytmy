using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelectionSort
{
    class Program
    {
        private void WyswietlTablice(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
                Console.Write(tab[i] + " ");
            Console.WriteLine();
        }
        private void SelectionSort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[min] > a[j])
                        min = j;
                }
                int temp = a[i];
                a[i] = a[min];
                a[min] = temp;
            }
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            Program program = new Program();
            //int[] a = { 3, 2, 7, 4, 1, 9, 5, 3, 1, 0 };
            int n = 10; // zmienna odpowiedzialna za wielkosc tablicy
            int rMin = 0, rMax = 9; //zmienne odpowiedzialne za zakres losowania liczb
            int[] a = new int[n];
            //generowanie liczb i wstawienie do tablicy
            for(int i=0;i<n;i++)
                a[i] = rand.Next(rMin,rMax);
            //wyswietlenie tablicy
            Console.WriteLine("Tablica nieposortowana");
            program.WyswietlTablice(a);
            //sortowanie
            program.SelectionSort(a);
            //Wyswietlenie posortowanej tablicy
            Console.WriteLine("Tablica po sortowaniu");
            program.WyswietlTablice(a);
            Console.ReadKey();
        }
    }
}
