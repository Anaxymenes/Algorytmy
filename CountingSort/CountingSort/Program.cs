using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountingSort
{
    class Program
    {
        private string WyswietlElementyTablicy(int[] a)
        {
            string txt = "";
            for (int i = 0; i < a.Length; i++)
                txt += a[i] + " ";
            return txt;
        }
        static void Main(string[] args)
        {
            Program wyswietl = new Program();
            int[] tab = {6,3,6,1,4,9,0,1,8,2,6,4,9,3,7,5,9,2,7,3,2,4,1,8,7,0,8,5,8,3,6,2,5,3};
            Console.WriteLine("Tablica nie posortowana:\n"+wyswietl.WyswietlElementyTablicy(tab));
            int max = 9+1; //max element tablicy
            int[] temp = new int[max];
            //zerujemy tablice temp
            for (int i = 0; i < temp.Length; i++)
                temp[i] = 0;
            // zliczanie ile razy wystepuje dana liczba
            for (int i = 0; i < tab.Length; i++)
            {
                //Console.Write("Dla wartosciL: {0}, zwiekszamy z wartości: {1} na wartość: ",tab[i],temp[tab[i]]);
                temp[tab[i]]++;
                //Console.WriteLine(temp[tab[i]].ToString());
            }
            Console.WriteLine("Po zliczeniu: \n"+wyswietl.WyswietlElementyTablicy(temp));

            //Sumowanie wartości
            for (int i = 1; i < temp.Length; i++)
                temp[i] += temp[i - 1];
            Console.WriteLine("Po sumowaniu: \n" + wyswietl.WyswietlElementyTablicy(temp));

            //sortowanie
            int[] b = new int[tab.Length];
            //Console.WriteLine(b.Length + " <- b || tab -> " + tab.Length);
            for (int i = 0; i < tab.Length; i++)
            { 
                b[temp[tab[i]]-1] = tab[i];
                temp[tab[i]] -= 1;
            }
            Console.WriteLine("Po sortowaniu: \n" + wyswietl.WyswietlElementyTablicy(b));
            Console.ReadKey();
        }
        
    }
}
