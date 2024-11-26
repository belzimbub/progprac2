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
                Console.Write(i + " ");
            }
            Console.WriteLine();
            var M = ma.Length;
            for (int i = M - 1; i >= 0; i--)
            {
                Console.Write(ma[i] + " ");
            }
            Console.WriteLine();
        }
        public static void MassSquare(int N)
        {
            int[,] mass = new int[N, N];
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
            Console.WriteLine();
        }
        public static void MassBublik(int N)
        {
            int value = 1;
            int[,] array = new int[N, N];

            int minRow = 0, maxRow = N - 1;
            int minCol = 0, maxCol = N - 1;

            while (value <= N * N)
            {
                // Заполняем верхнюю строку слева направо
                for (int i = minCol; i <= maxCol; i++)
                    array[minRow, i] = value++;
                minRow++;

                // Заполняем правый столбец сверху вниз
                for (int i = minRow; i <= maxRow; i++)
                    array[i, maxCol] = value++;
                maxCol--;

                // Заполняем нижнюю строку справа налево
                for (int i = maxCol; i >= minCol; i--)
                    array[maxRow, i] = value++;
                maxRow--;

                // Заполняем левый столбец снизу вверх
                for (int i = maxRow; i >= minRow; i--)
                    array[i, minCol] = value++;
                minCol++;
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(array[i, j].ToString().PadLeft(3) + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void fourthTask(int N)
        {
            int n, m;
            Console.Write("Введите количество строк массива M: ");
            m = Convert.ToInt32(Console.ReadLine());
            n = N;
            int value = 1;
            int[,] array = new int[m, N];

            int minRow = 0, maxRow = m - 1;
            int minCol = 0, maxCol = N - 1;

            while (value <= m * N)
            {
                // Заполняем верхнюю строку слева направо
                for (int i = minCol; i <= maxCol && value <= m * N; i++)
                    array[minRow, i] = value++;
                minRow++;

                // Заполняем правый столбец сверху вниз
                for (int i = minRow; i <= maxRow && value <= m * N; i++)
                    array[i, maxCol] = value++;
                maxCol--;

                // Заполняем нижнюю строку справа налево
                for (int i = maxCol; i >= minCol && value <= m * N; i--)
                    array[maxRow, i] = value++;
                maxRow--;

                // Заполняем левый столбец снизу вверх
                for (int i = maxRow; i >= minRow && value <= m * N; i--)
                    array[i, minCol] = value++;
                minCol++;
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(array[i, j].ToString().PadLeft(3) + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        enum Operations
        {
            division,
            powering,
            squareRoot
        }
        int DoOperation(Operations op, int a, int b)
        {
            switch (op)
            {
                case Operations.division: return a / b;
                case Operations.powering: return (int)Math.Pow(a, b);
                case Operations.squareRoot: return (int)Math.Sqrt(a);
                default: return 0;
            }
        }
        static void Main()
        {
            Console.WriteLine("Введите размер массива:");
            var N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Первое задание\n");
            MassVivod(MassCreate(N));
            Console.WriteLine("Второе задание\n");
            MassSquare(N);
            Console.WriteLine("Третье задание\n");
            MassBublik(N);
            Console.WriteLine("Четвертое задание\n");
            fourthTask(N);
        }
    }
}
