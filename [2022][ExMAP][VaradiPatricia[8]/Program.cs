using System;
using System.IO;
namespace _2022__ExMAP__VaradiPatricia_8_
{
    class Program
    {
        /* Varadi Patricia
         * a-97(codul ascii) %5=2  [1][2] => exercitiul 8
         * 
         * Se citesc două numere naturale nenule n și k. 
         * Să se afişeze, în ordine lexicografică,aranjamentele 
         * de câte k elemente ale mulţimii {1,2,..,n}. Fişierul de intrare
         * aranjamente.in conţine pe prima linie numerele n și k, 
         * separate printr-un spatiu.Fişierul de ieşire aranjamente.out 
         * va conţine pe fiecare linie câte k valori, separate
         * prin câte un spaţiu, reprezentând elementele unei aranjări.
         */

        static int x, y;
        static int[] n, m;
        static TextReader citire = new StreamReader(@"..\..\..\aranjamente.in");
        static TextWriter scri = new StreamWriter(@"..\..\..\aranjamente.out");
        static string[] afisat;
        static void Main(string[] args)
        {
            string buffer;
            while ((buffer = citire.ReadLine()) != null)
            {
                string[] local_data = buffer.Split(' ');
                x = int.Parse(local_data[0]);
                y = int.Parse(local_data[1]);
            }
            // Console.WriteLine(x + " " + y); //pt verificare
            n = new int[10];
            m = new int[10];
            afisat = new string[100];
            backtracking(1);
            scri.Close();
        }

        private static void backtracking(int v)
        {
            for (int i = 1; i <= x; i++)
            {
                if (m[i] == 0)
                {
                    m[i] = 1;
                    n[v] = i;
                    if (v == y)
                    {
                        afisare();
                    }
                    else backtracking(v + 1);
                    m[i] = 0;
                }
            }
        }

        private static void afisare()
        {
            for (int i = 1; i <= y; i++)
            {
                afisat[i - 1] = n[i] + " ";
            }
            for (int i = 0; i < afisat.Length; i++)
                scri.Write(afisat[i]);
            scri.WriteLine();
        }
    }
}
