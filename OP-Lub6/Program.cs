using System.Diagnostics;

namespace OP_Lub6
{
    /// <summary>
    /// Статический класс с методами для игры «Отгадай ответ» значения функции
    /// f = Sqrt((sin^2 a + cos^3 b) / (sin^3 a - cos^2 b)).
    /// </summary>
    public static class GuessGame
    {
        /// <summary>
        /// Вычисляет значение функции f = Sqrt((sin^2 a + cos^3 b) / (sin^3 a - cos^2 b)).
        /// </summary>
        /// <param name="a1">Угол a в градусах.</param>
        /// <param name="a2">Угол b в градусах.</param>
        /// <returns>Значение функции, округлённое до 2 знаков, или 0, если функцию нельзя вычислить.</returns>
        public static double func(double a1, double a2)
        {
            double rada = a1 * (Math.PI / 180);
            double radb = a2 * (Math.PI / 180);
            double sina = Math.Sin(rada);
            double cosb = Math.Cos(radb);
            double result;
            double verh = (Math.Pow(sina, 2)) + (Math.Pow(cosb, 3));
            double niz = (Math.Pow(sina, 3)) - (Math.Pow(cosb, 2));
            if (niz != 0)
            {
                if (verh / niz < 0)
                {
                    Console.WriteLine("Число под корнем не положительно."); return 0;
                }
                else
                {
                    result = Math.Sqrt(verh / niz);
                }
            }
            else
            {
                Console.WriteLine("Знаменатель равен нулю!"); return 0;
            }
            return Math.Round(result, 2);
        }
    }

    /// <summary>
    /// Класс для работы с массивом: заполнение, вывод и сортировка (методом Шелла и вставками).
    /// </summary>
    public class ArrayWork
    {
        /// <summary>
        /// Конструктор без параметров: создаёт массив из 10 элементов.
        /// </summary>
        public ArrayWork()
        {
            int n = 10;
            int[] mass = arrinit(n);
        }

        /// <summary>
        /// Конструктор с параметрами: создаёт массив из заданного числа элементов.
        /// </summary>
        /// <param name="n">Количество элементов, введённое пользователем.</param>
        public ArrayWork(int n)
        {
            int[] mass = arrinit(n);
        }

        /// <summary>
        /// Создаёт массив заданной длины и заполняет его случайными числами от -100 до 100.
        /// </summary>
        /// <param name="arrlen">Длина массива.</param>
        /// <returns>Заполненный массив.</returns>
        private int[] arrinit(int arrlen)
        {
            int[] mass = new int[arrlen];
            Random rnd = new Random();
            for (int i = 0; i < arrlen; i++)
            {
                mass[i] = rnd.Next(-100, 100);
            }
            return mass;
        }

        static public int maxinarr(int[] mass)
        {
            int maxvalue = mass[0];
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > maxvalue)
                {
                    maxvalue = mass[i];
                }
            }
            return maxvalue;
        }

        static public int mininarr(int[] mass)
        {
            int minvalue = mass[0];
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < minvalue)
                {
                    minvalue = mass[i];
                }
            }
            return minvalue;
        }

        static public double avginarr(int[] mass)
        {
            double avg = 0;
            int sum = 0;
            for(int i = 0; i< mass.Length; i++)
            {
                sum = sum + mass[i];
            }
            avg=(double)sum/mass.Length;
            return avg;
        }

        /// <summary>
        /// Создаёт копию массива.
        /// </summary>
        /// <param name="mass">Исходный массив.</param>
        /// <returns>Копия массива.</returns>
        static public int[] copyarr(int[] mass)
        {
            int[] copyarr = new int[mass.Length];
            for (int i = 0; i < mass.Length; i++)
            {
                copyarr[i] = mass[i];
            }
            return copyarr;
        }

        /// <summary>
        /// Сортирует массив методом Шелла.
        /// </summary>
        /// <param name="arr">Массив для сортировки.</param>
        static public void shellsort(int[] arr)
        {
            int n = arr.Length;
            for (int gap = n / 2; gap > 0; gap = gap / 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j = j - gap)
                    {
                        arr[j] = arr[j - gap];
                    }
                    arr[j] = temp;
                }
            }
        }

        /// <summary>
        /// Сортирует массив методом вставок.
        /// </summary>
        /// <param name="arr">Массив для сортировки.</param>
        static public void inpsort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        /// <summary>
        /// Сортирует копии массива обоими методами, замеряет время и выводит результаты.
        /// </summary>
        public void arr(int[] mass)
        {
            int[] copymass1 = copyarr(mass);
            int[] copymass2 = copyarr(mass);
            Stopwatch shelltimer = Stopwatch.StartNew();
            shellsort(copymass1);
            shelltimer.Stop();
            Stopwatch inptimer = Stopwatch.StartNew();
            inpsort(copymass2);
            inptimer.Stop();
        }

        internal static class Program
        {
            /// <summary>
            ///  The main entry point for the application.
            /// </summary>
            [STAThread]

            static void Main()
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }
        }
    }
}