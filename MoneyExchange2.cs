using System;

namespace Money
{
    class MoneyExchange2
    {
        static int m100 = 0;
        static int m50 = 0;
        static int m20 = 0;
        static int m10 = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Koliko imate novcanica od 100 din? ");
            m100 = int.Parse(Console.ReadLine());

            Console.WriteLine("Koliko imate novcanica od 50 din? ");
            m50 = int.Parse(Console.ReadLine());

            Console.WriteLine("Koliko imate novcanica od 20 din? ");
            m20 = int.Parse(Console.ReadLine());

            Console.WriteLine("Koliko imate novcanica od 10 din? ");
            m10 = int.Parse(Console.ReadLine());

            while(true) {
                Console.WriteLine("Unesite sumu koju zelite da usitnite (0 za kraj): ");
                int s = int.Parse(Console.ReadLine());

                if (s == 0) break;

                int sp100 = s / 100;
                if (sp100 > m100) sp100 = m100;
                s = s - sp100 * 100;

                int sp50 = s / 50;
                if (sp50 > m50) sp50 = m50;
                s = s - sp50 * 50;

                int sp20 = s / 20;
                if (sp20 > m20) sp20 = m20;
                s = s - sp20 * 20;

                int sp10 = s / 10;
                if (sp10 > m10) sp10 = m10;
                s = s - sp10 * 10;

                int sp1 = 0;
                if (s > 0) sp1 = s;

                Console.WriteLine("Potrebne su vam sledece novcanice: ");
                Console.WriteLine("100: " + sp100);
                Console.WriteLine("50:  " + sp50);
                Console.WriteLine("20:  " + sp20);
                Console.WriteLine("10:  " + sp10);
                Console.WriteLine("1:   " + sp1);
            }
        }
    }
}
