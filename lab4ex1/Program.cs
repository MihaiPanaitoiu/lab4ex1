using System;

namespace lab4ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 1
                Scrieti un program care va citi un vector de intregi de dimensiune n de la tastaura. Scrieti o
                functie care va inversa elementele vectorului, apelati-o si afisati-I rezultatu
             */

            Console.WriteLine("Introduceti dimensiunea vectorului");
            int n = int.Parse(Console.ReadLine());

            int[] ReverseArr = ReverseMatrix(ReadMatrix(n));

            ShowMatrix(ReverseArr);
            

        }

        static int[] ReadMatrix(int n)
        {
            Console.WriteLine("introduceti elementele arrayului");
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                 result[i] =int.Parse(Console.ReadLine());
            }
            return result;
        }

        static void ShowMatrix(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static int[] ReverseMatrix(int [] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                //variabila temporara in care tinem elementul din stanga
                int temporaryHold = arr[i];
                //asignam valoarea din dreapta in partea stanga
                arr[i] = arr[arr.Length - 1 - i];
                //si invers
                arr[arr.Length - 1 - i] = temporaryHold;
            }
            return arr;
        }
    }
}
