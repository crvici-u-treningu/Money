using System;
using System.Collections.Generic;

namespace Money
{
    class MoneyExchange4 {
        enum Bill
        {
            ONE = 1,
            TEN = 10,
            TWENTY = 20,
            FIFTY = 50,
            HUNDRED = 100
        }

        static void Main(string[] args)
        {
            Dictionary<Bill, int> bank = new Dictionary<Bill, int>()
            {
                { Bill.HUNDRED, 0 },
                { Bill.FIFTY, 0 },
                { Bill.TWENTY, 0 },
                { Bill.TEN, 0 },
                { Bill.ONE, int.MaxValue },
            };

            Console.WriteLine("100?");
            bank[Bill.HUNDRED] = int.Parse(Console.ReadLine());

            Console.WriteLine("50?");
            bank[Bill.FIFTY] = int.Parse(Console.ReadLine());

            Console.WriteLine("20?");
            bank[Bill.TWENTY] = int.Parse(Console.ReadLine());

            Console.WriteLine("10?");
            bank[Bill.TEN] = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int n = 0;
            do
            {
                Console.WriteLine("Give some value? ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine($"100 -> {GetNumOfBills(bank, Bill.HUNDRED, ref n)}");
                Console.WriteLine($"50  -> {GetNumOfBills(bank, Bill.FIFTY, ref n)}");
                Console.WriteLine($"20  -> {GetNumOfBills(bank, Bill.TWENTY, ref n)}");
                Console.WriteLine($"10  -> {GetNumOfBills(bank, Bill.TEN, ref n)}");
                Console.WriteLine($"1   -> {GetNumOfBills(bank, Bill.ONE, ref n)}");
            } while (n != 0);
        }

        static int GetNumOfBills(Dictionary<Bill, int> bank, Bill bill, ref int cashValue)
        {
            int numOfBills = 0;
            while(bank[bill] > 0 && cashValue - (int)bill >= 0)
            {
                cashValue -= (int)bill;
                ++numOfBills;
            }

            return numOfBills;
        }
    }
}
