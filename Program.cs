using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Csharp_proba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] niz = new int[5];
            for (int i = 0; i<5; i++) niz[i] = i*i;
            for (int i = 0; i < 5; i++) Console.Write(niz[i]+" ");
            Console.WriteLine();
            Console.WriteLine();
            int[,] matrica = new int[5, 5];
            for (int v = 0; v < 5; v++)
            {
                for (int k = 0; k < 5; k++)
                {
                    matrica[v, (v+k) % 5] = niz[k] ;
                }
            }
            for (int v = 0; v < 5; v++)
            {
                for (int k = 0; k < 5; k++)
                {
                    Console.Write(matrica[v, k] + " ");
                }
                Console.WriteLine();
            }
            ArrayList lista = new ArrayList();
            int zbir = 0;
            for (int i = 0; i < 5; i++)
            {
                lista.Add(niz[i]);
                zbir = zbir + Convert.ToInt16(lista[i]);
            }
            Console.WriteLine(zbir);
            
            // alternativa: genericki tip, nema konverzije
            List<int> lista2 = new List<int>();
            int zbir2 = 0;
            for (int i = 0; i < 5; i++)
            {
                lista2.Add(niz[i]);
                zbir2 = zbir2 + lista2[i];
            }
            Console.WriteLine(zbir2);
        }
    }
}
