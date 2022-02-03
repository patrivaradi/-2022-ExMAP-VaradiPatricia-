using System;

namespace _2022__ExMAP__VaradiPatricia_15_
{
    class Program
    {
        /*Varadi Patricia
         * V=86(codul ascii) %4=2   [0][2] => exexcitiul 15
         * 
         * Scrieţi un program care citeşte de la tastatură numere naturale din
         * intervalul [3,102], în această ordine: n şi m, apoi elementele unui tablou
         * bidimensional cu n linii şi m coloane, iar la final un număr x. Programul afişează pe
         * ecran mesajul DA, dacă există cel puțin un element egal cu x aflat pe conturul
         * * tabloului (format din prima linie, ultima linie, prima coloană și ultima coloană), 
         * sau mesajul NU în caz contrar. 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti m = ");
            int m = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, m];
            Console.WriteLine("Introduceti elementele matricii:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"[{i},{j}] : ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Introduceti x = ");
            int x = int.Parse(Console.ReadLine());
            bool buffer = false;
            for (int i = 0; i < n; i++)
            {
                if (mat[i, 0] == x || mat[i, m - 1] == x)
                {
                    buffer = true;
                    break;
                }

            }
            for (int i = 0; i < m; i++)
            {
                if (mat[0, i] == x || mat[n - 1, i] == x)
                {
                    buffer = true;
                    break;
                }
            }
            if (buffer == true)
                Console.WriteLine("DA");
            else Console.WriteLine("NU");
        }
    }
}
