using System;

namespace _2022__ExMAP__VaradiPatricia_10_
{
    class Program
    {
        /* Varadi Patricia
         * a-97(codul ascii) %3=1  [2][1] => exercitiul 10
         * 
         * Se dau două numere n și m. Aflați care este numărul minim și numărul maxim de
         * noduri izolate într-un graf neorientat cu n noduri și m muchii în care nu 
         * există un muchie de la un nod la el însuși și între oricare două noduri 
         * diferite există cel mult o muchie. Programul citește de la tastatură numerele n m.
         * Programul va afișa pe ecran numerele a și b, reprezentând numărul minim, 
         * respectiv numărul maxim de noduri izolate într-un graf neorientat cu n noduri
         * și m muchii în care nu există o muchie de la un nod la el însuși și între 
         * oricare două noduri diferite există cel mult o muchie.
         */
        static void Main(string[] args)
        {
            Console.Write("Introduceti nr nodurilor n = ");
            int n = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            Console.Write("Introduceti nr muchiilor m = ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Nr MIN : ");
            if (m * 2 >= n)
            {
                Console.Write(0 + " ");
            }
            else Console.Write(n - 2 * m + " ");

            Console.WriteLine();
            Console.Write("Nr MAX : ");
            int k = 0;
            while (k * (k - 1) / 2 < m) k++;
            Console.Write(n - k);
        }
    }
}
