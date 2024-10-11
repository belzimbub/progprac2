using System.Linq.Expressions;

namespace Prag
{
    class MainForm
    {
        public static int[] MassCreate(int N)
        {
            
            int[] mass = new int[N];
            for (int i = 0; i < N; i++)
            {
                mass[i] = i + 1;
            }
            return mass;
        }
        public static void MassVivod(int[] ma)
        {
            foreach (int i in ma)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            var M = ma.Length;
            for (int i = M-1; i >= 0; i--)
            {
                Console.Write(ma[i]+" ");
            }
        }
        public static void MassSquare(int N)
        {
            int[,] mass = new int[N,N];
            for (int i = 0; i < N; i++)
            {
                bool k = false;
                for (int j = 0; j < N; j++)
                {
                    if (k == true) mass[i, j] = 1;
                    else 
                    {
                        if (i == j || j == i - 1)
                        {
                            mass[i, j] = 1;
                            k = true;
                        }
                        else
                        {
                            mass[i, j] = 0;
                        } 
                    }
                    Console.Write(mass[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            Console.WriteLine("1. Введите размер массива:");
            var N = Convert.ToInt32(Console.ReadLine());
            MassVivod(MassCreate(N));
            Console.WriteLine();
            MassSquare(N);
        }
    }
}