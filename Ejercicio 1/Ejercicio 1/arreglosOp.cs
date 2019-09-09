using System;

public class arreglosOp
{
    public int renglon;
    public int columna;
    public int renglon2;
    public int columna2;


    public arreglosOp()
    {

    }

    public int[,] ingresarA(int r, int c)
    {
        int[,] arreglo = new int[r, c];
        this.renglon = r;
        this.columna = c;

        Random rnd = new Random();

        for (int i = 0; i < this.renglon; i++)
        {
            for (int j = 0; j < this.columna; j++)
            {
                arreglo[i, j] = rnd.Next(0, 99);
            }
        }
        return arreglo;
    }

    public int[,] ingresarB(int r, int c)
    {
        int[,] arregloB = new int[r, c];
        this.renglon2 = r;
        this.columna2 = c;

        Random rnd = new Random();

        for (int a = 0; a < this.renglon2; a++)
        {
            for (int b = 0; b < this.columna2; b++)
            {
                arregloB[a, b] = rnd.Next(0, 99);
            }
        }
        return arregloB;
    }

    public void imprimir(int[,] m)
    {
        string s = "";
        Console.WriteLine("---------------------------");
        for (int a = 0; a < this.renglon; a++)
        {
            for (int b = 0; b < this.columna; b++)
            {
                s += m[a, b].ToString() + "\t";
            }
            s += "\n";
        }
        Console.WriteLine(s);
    }
    public void imprimirB(int[,] m)
    {
        string s = "";
        Console.WriteLine("---------------------------");
        for (int a = 0; a < this.renglon2; a++)
        {
            for (int b = 0; b < this.columna2; b++)
            {
                s += m[a, b].ToString() + "\t";
            }
            s += "\n";
        }
        Console.WriteLine(s);
    }

    public int sumaL(int[] m1)
    {
        int sum = 0;
        int n = 0;
        for (int i = 0; i < m1.Length; i++)
        {
            n = m1[i];
            Console.WriteLine(n);
            sum = sum + n;
        }
        return sum;
    }

    public int sumarBidimensional(int[,] m1)
    {
        int s = 0;
        int n = 0;
        for (int a = 0; a < this.renglon; a++)
        {
            for (int b = 0; b < this.columna; b++)
            {
                n = m1[a, b];
                Console.WriteLine(n);
                s += n;

            }
        }
        return s;
    }

    public int[,] sumaBidimencional2(int[,] m1, int[,] m2)
    {
        int[,] r = new int[this.renglon, this.columna];
        for (int a = 0; a < this.renglon; a++)
        {
            for (int b = 0; b < this.columna; b++)
            {
                r[a, b] = m1[a, b] + m2[a, b];
            }
        }
        return r;
    }

    public int[,] multiplicar(int[,] x, int[,] y)
    {
        int[,] arreglo = new int[this.renglon, this.columna];
        for (int a = 0; a < this.renglon; a++)
        {
            for (int b = 0; b < this.columna; b++)
            {
                arreglo[a, b] = x[a, b] * y[a, b];
            }
        }
        return arreglo;
    }

    public int[,] restar(int[,] x, int[,] y)
    {
        int[,] r = new int[this.renglon, this.columna];
        for (int a = 0; a < this.renglon; a++)
        {
            for (int b = 0; b < this.columna; b++)
            {
                r[a, b] = x[a, b] - y[a, b];
            }
        }
        return r;
    }

}
