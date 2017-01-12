using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grafy_AC
{
    class AdjacencyMatrix
    {
        protected int[][] matrix;

        public void CreateMatrixFromList(int[][] list)
        {
            this.matrix = new int[list.Length][];
            for (int i = 0; i < list.Length; i++)
                this.matrix[i] = new int[list.Length];

            for (int i = 1; i < list.Length; i++)
            {

                for (int j = 0; j < list[i].Length; j++)
                {
                    this.matrix[i][list[i][j]] = 1;
                }
            }
        }

        public override string ToString()
        {
            string txt = "";
             try
            {
                for (int i = 1; i < this.matrix.Length; i++)
                {

                    for (int j = 0; j < this.matrix[i].Length; j++)
                    {
                        txt += matrix[i][j] + " ";
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

    }
}
