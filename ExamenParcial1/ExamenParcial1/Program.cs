using System;

namespace ExamenParcial1
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
                        {
                            int[,] r = operations.multiplicar(m1, m2);
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
                Console.WriteLine("3- Multiplicar Matrices. ");
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
