using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CsharpEx5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fase 1

            int[] numberArray = new int[] { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4};

            IEnumerable<int> evenNumbers = from num in numberArray
                                            where num % 2 == 0        //Parells: Al dividir entre 2 la resta és 0
                                            select num;
            Console.WriteLine("Números parells");
            foreach (int num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            //FASE 2

            var noteMax = numberArray.Max();
            var noteMin = numberArray.Min();
            var noteAvg = numberArray.Average();

            Console.WriteLine("\nNota màxima: " + noteMax);
            Console.WriteLine("Nota mínima: " + noteMin);
            Console.WriteLine("Nota mitjana: " + noteAvg);


            //Fase 3

            IEnumerable<int> greater = from num in numberArray
                                       where num > 5
                                       select num;

            var less = from num in numberArray
                       where num < 5
                       select num;

            Console.WriteLine("\nNúmeros més grans que 5: ");
            foreach (var num in greater)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\nNúmeros més petits que 5: ");
            foreach (var num in less)
            {
                Console.WriteLine(num);
            }

            //Fase 4

            string[] nameArray = new string[] {"David", "Sergio", "Maria", "Laura", "Oscar", "Julia", "Oriol"};

            var startingByO = from name in nameArray
                              where name.StartsWith('O')
                              select name;

            Console.WriteLine("\nNoms que comencen amb 'O':");
            foreach (string name in startingByO)
            {
                Console.WriteLine(name);
            }

            var moreThanSix = from name in nameArray
                              where name.Length > 6
                              select name;

            Console.WriteLine("Noms amb més de 6 lletres:");
            foreach (string name in moreThanSix)
            {
                Console.WriteLine(name);
            }

            var orderedDesc = from name in nameArray
                              orderby name descending
                              select name;

            Console.WriteLine("Noms ordenats de la Z a la A:");
            foreach (string name in orderedDesc)
            {
                Console.WriteLine(name);
            }
        }
    }
}
