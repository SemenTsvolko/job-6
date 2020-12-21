using System;

namespace job_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Базовый уровень
            Console.WriteLine("Введите число n ");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                if ((x % i) == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
