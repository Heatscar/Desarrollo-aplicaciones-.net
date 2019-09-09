using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program

    {
        private static arreglosOp operations;
        private static int[,] m1;
        private static int[,] m2;
        static void Main(string[] args)
        {
            bool KEEP_ALIVE = true;
            operations = new arreglosOp();

            do
            {

                int opcion = menu();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("---Primer Matriz---");
                        Console.WriteLine("Renglones: ");
                        int renglones = Int16.Parse(Console.ReadLine());
                        Console.WriteLine("Columnas: ");
                        int columnas = Int16.Parse(Console.ReadLine());
                        m1 = operations.ingresarA(renglones, columnas);
                        Console.WriteLine("---Segunda Matriz--");
                        Console.WriteLine("Renglones: ");
                        int renglones2 = Int16.Parse(Console.ReadLine());
                        Console.WriteLine("Columnas: ");
                        int columnas2 = Int16.Parse(Console.ReadLine());
                        m2 = operations.ingresarB(renglones2, columnas2);
                        break;
                    case 2:
                        if (m1 != null || m2 != null)
                        {
                            Console.WriteLine("--------Primer Matriz----------");
                            operations.imprimir(m1);
                            Console.WriteLine("--------Segunda Matriz----------");
                            operations.imprimirB(m2);
                        }
                        else
                        {
                            Console.WriteLine("Faltan datos en las matrices");
                        }
                        break;
                    case 3:
                        int z = 0;
                        Console.WriteLine("Suma Lineal, Matriz 1 por defecto");
                        Console.WriteLine("Fila del arreglo a sumar:");
                        int position = Int16.Parse(Console.ReadLine());
                        int[] arreglo = new int[operations.columna];
                        for (int i = 0; i < operations.renglon; i++)
                        {
                            z = m1[position, i];
                            arreglo[i] = z;
                        }
                        int suma = operations.sumaL(arreglo);
                        Console.WriteLine("Resultado: " + suma);
                        break;
                    case 4:
                        int sum = operations.sumarBidimensional(m1);
                        Console.WriteLine("Resultado: " + sum);
                        break;
                    case 5:
                        {
                            int[,] r = operations.sumaBidimencional2(m1, m2);
                            operations.imprimir(r);
                            break;
                        }
                    case 6:
                        {
                            int[,] r = operations.multiplicar(m1, m2);
                            operations.imprimir(r);
                            break;
                        }
                    case 7:
                        {
                            int[,] r = operations.restar(m1, m2);
                            operations.imprimir(r);
                            break;
                        }
                    case 8:
                        KEEP_ALIVE = false;
                        break;
                }


            } while (KEEP_ALIVE);
        }

        static int menu()
        {
            do
            {
                Console.WriteLine("///////////////////////////////");
                Console.WriteLine("Menu de Opciones. ");
                Console.WriteLine("1- Insertar datos. ");
                Console.WriteLine("2- Imprimir. ");
                Console.WriteLine("3- Sumar por Renglon. ");
                Console.WriteLine("4- Suma de una Matriz. ");
                Console.WriteLine("5- Suma de Matrices. ");
                Console.WriteLine("6- Multiplicar Matrices. ");
                //Console.WriteLine("7- Resta Matrices. ");
                Console.WriteLine("8- Salir. ");
                Console.WriteLine("//////////////////////////////");
                int opcion = Int16.Parse(Console.ReadLine());
                if (opcion > 0 && opcion < 9)
                {
                    return opcion;
                }
            } while (true);
        }
    }

}
