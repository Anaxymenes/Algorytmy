using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grafy_AC
{
    class AdjacencyList
    {
        protected int[][] list;
        public int[][] List { get { return this.list; } }
        #region Tworzenie Listy Sąsiedztwa
        public void CreateList()
        {
            int countEdges;
            while (true)
            {
                Console.Clear();
                Console.Write("Podaj ilość wierzchołków: ");
                string edge = Console.ReadLine();
                try
                {
                    countEdges = Int32.Parse(edge);
                    break;
                }
                catch
                {
                    Console.WriteLine("Musi być to liczba całkowita!\nNaciśnij klawisz by kontynuowac...");
                    Console.ReadKey();
                }
            }
            this.list = new int[countEdges+1][];
            for(int i=1;i<=countEdges;i++)
            {
                int countNeighbors;
                while(true)
                {
                    Console.Write("Podaj liczbę sąsiadów wierzchołka " + i + ": ");
                    string a = Console.ReadLine();
                    try
                    {
                        countNeighbors = Int32.Parse(a);
                        this.list[i] = new int[countNeighbors];
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Liczba sąsiadów musi być liczbą całkowita!");
                    }
                }

                for (int j = 0; j < countNeighbors; j++)
                {
                    while(true)
                    {
                        Console.Write("Podaj nr wierzchołka " + i+": ");
                        string b = Console.ReadLine();
                        try
                        {
                            this.list[i][j] = Int32.Parse(b);
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Musi być to liczba całkowita!");
                        }
                    }
                }
            }
        }
        #endregion
        public override string ToString()
        {
            string txt = "";
            
            try
            {
                for (int i = 1; i < this.list.Length; i++)
                {

                    for (int j = 0; j < this.list[i].Length; j++)
                    {
                        txt += list[i][j] + " ";
                    }
                    txt += "\n";
                }
            }
            catch
            {
                txt = "Nie mam co wyświetlić!";
            }
            return txt;
        }
        public AdjacencyList()
        {
            CreateList();
            Console.Clear();
            Console.WriteLine("Oto powstała lista sąsiedztwa");
            Console.WriteLine(ToString());
        }
    }
}
