using System;

namespace Csharp{
    class Program{
        static void Main(string[] args){
            //int i = 10;
            int j = 10;
            string[]cadenas = new string[10];
            cadenas[0] = "Jeison";
            cadenas[1] = "Martinez";
            cadenas[2] = "";
            Console.WriteLine(cadenas[0]);

            double[,] doble = new double[10, j]; //Arreglo Multidimensional
            doble[0,0] = 6;
            doble[0,1] = 3.6;
            doble[1,0] = 2;
            doble[1,1] = 2.2;
            Console.WriteLine(doble[0,1]);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
    
}

