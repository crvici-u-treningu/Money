using System;

namespace Money
{
    class MoneyExchange
    {
        static int[] m = new int[4] { 0, 0, 0, 0 };
        static int[] p = new int[5] { 100, 50, 20, 10, 1 };

        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Koliko imate novcanica od {p[i]} din? ");
                m[i] = int.Parse(Console.ReadLine());
            }

            while(true) {
                int[] rez = new int[5] { 0, 0, 0, 0, 0 };

                Console.Write("Unesite sumu koju zelite da usitnite (0 za kraj): ");
                int s = int.Parse(Console.ReadLine());

                if (s == 0) break;

                for(int i = 0; i < 4; i++)
                {
                    int novc = s / p[i];
                    if (novc > m[i]) novc = m[i];
                    rez[i] = novc;
                    s -= novc * p[i];
                }

                if (s > 0) rez[4] = s;

                Console.WriteLine("Potrebne su vam sledece novcanice: ");
                for(int i = 0; i < 5; i++)
                    Console.WriteLine($"{p[i]}: {rez[i]}");
            }
        }
    }
}
