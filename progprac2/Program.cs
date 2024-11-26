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
        public static void fourthTask()
{
    int n, m;
    Console.Write("Введите количесвто строк массива M: ");
    m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количесвто строк массива N: ");
    n = Convert.ToInt32(Console.ReadLine());
    int value = 1;
    int[,] array = new int[m, n];

    int minRow = 0, maxRow = m - 1;
    int minCol = 0, maxCol = n - 1;

    while (value <= m * n)
    {
        // Заполняем верхнюю строку слева направо
        for (int i = minCol; i <= maxCol && value <= m * n; i++)
            array[minRow, i] = value++;
        minRow++;

        // Заполняем правый столбец сверху вниз
        for (int i = minRow; i <= maxRow && value <= m * n; i++)
            array[i, maxCol] = value++;
        maxCol--;

        // Заполняем нижнюю строку справа налево
        for (int i = maxCol; i >= minCol && value <= m * n; i--)
            array[maxRow, i] = value++;
        maxRow--;

        // Заполняем левый столбец снизу вверх
        for (int i = maxRow; i >= minRow && value <= m * n; i--)
            array[i, minCol] = value++;
        minCol++;
    }
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j].ToString().PadLeft(3) + " ");
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
            fourthTask();
        }
    }
}
