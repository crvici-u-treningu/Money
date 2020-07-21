using System;
using System.Collections.Generic;

namespace Money
{
    class MoneyExchange3 {
        Dictionary<int, int> inventar = new Dictionary<int, int>();

        public MoneyExchange3()
        {
            int[] velicine = new int[4] { 100, 50, 20, 10 };

            foreach (var v in velicine)
            {
                Console.WriteLine($"Koliko imate novcanica od {v} din? ");
                inventar[v] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nUnesite sumu koju zelite da usitnite.");
            Console.WriteLine("Novcanica od 1din imamo beskonacno mnogo.");
            Console.WriteLine("Uvek cemo vratiti najmanji broj novcanica dostupan.\n");
            while (true)
            {
                Console.Write("Suma: ");
                int suma = int.Parse(Console.ReadLine());

                if (suma == 0) break;

                Console.WriteLine("Potrebne su vam sledece novcanice: ");

                foreach (var v in inventar)
                {
                    int vrednost = v.Key;
                    int kolicina = v.Value;

                    int upotrebljeno = Math.Min(suma / vrednost, kolicina);
                    Console.WriteLine($"{vrednost}din: " + upotrebljeno);
                    suma -= upotrebljeno * vrednost;
                }

                if (suma > 0) 
                    Console.WriteLine("1din: " + suma);
            }
        }

        static void Main(string[] _)
        {
            new MoneyExchange3();
        }
    }
}
