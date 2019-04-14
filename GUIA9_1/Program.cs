using System;
using System.Linq;

namespace GUIA9_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] ej1;
            int[,] ej2;
            int[,] ej3;
            int[,] ej4;
            ej1 = new int[3, 6];
            ej2 = new int[2, 5];
            ej3 = new int[3, 3];
            ej4 = new int[4, 4];
            int count = 0;
            Console.WriteLine("\n ejercicio 1\n");
            for (int f = 0; f < 3; f++)
            {
                for(int c = 0; c < 6; c++)
                {
                    int value = rnd.Next(1, 100);
                    ej1[f,c] = value;
                }
            }

            foreach (int element in ej1)
            {
                count++;
                Console.WriteLine($"Element #{count}: {element}");
            }

            Console.WriteLine("\n ejercicio 2\n");
            for (int f = 0; f < 2; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    int value = rnd.Next(1, 100);
                    ej2[f, c] = value;
                }
            }
            count = 0;
            Console.WriteLine("\n Matriz Completa \n");
            foreach (int element in ej2)
            {
                count++;
                Console.WriteLine($"Element #{count}: {element}");
            }
            Console.WriteLine("\n Ultima fila \n");
            for (int c = 0; c < 5; c++)
            {
                Console.WriteLine(ej2[1, c]);
            }

            Console.WriteLine("\n ejercicio 3\n");
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    int value = rnd.Next(1, 100);
                    ej3[f, c] = value;
                }
            }
            int numf = 0;
            int numc = 0;
            int numm=0;
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (ej3[f, c] > numm)
                    {
                        numm = ej3[f,c];
                        numf = f;
                        numc = c;
                    }
                }
            }
            Console.WriteLine($"El numero mayor es {numm} con el numero de fila {numf} y numero de columna {numc}");

            Console.WriteLine("\n ejercicio 4\n");
            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    int value = rnd.Next(1, 100);
                    ej4[f, c] = value;
                }
            }
            int suma = 0;
            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 4; c++)
                {

                    suma = suma + ej4[f, c];
                }
            }
            Console.WriteLine($"La suma total es {suma}");

        }
    }
}
