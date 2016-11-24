using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeSort
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
        private void MergeSort(int[] a, int[] b, int start, int end)
        {
            if (start == end)
                return;
            int center = (start + end) / 2;
            MergeSort(a, b, start, center);
            MergeSort(a, b, center + 1, end);
            Merge(a, b, start, center, end);
        }
        private void Merge(int[] a, int[] b, int start, int center, int end)
        {
            int i = start, j = center + 1, k = start;
            while (i <= center && j <= end)
            {
                if (a[i] < a[j])
                {
                    b[k] = a[i];
                    i++;
                }
                else
                {
                    b[k] = a[j];
                    j++;
                }
                k++;
            }
            while (i <= center)
            {
                b[k] = a[i];
                i++;
                k++;
            }
            while (j <= end)
            {
                b[k] = a[j];
                k++;
                j++;
            }
            for (int z = start; z <= end; z++)
                a[z] = b[z];
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            int n = 10;
            int[] a = new int[n],b=new int[n];
            program.LosujLiczby(a, 0, 9);
            program.MergeSort(a, b, 0, n - 1);
            Console.WriteLine("\nTablica posortowana");
            program.WyswietlTablice(a);
            Console.ReadKey();
        }
    }
}
