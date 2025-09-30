using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM atm1 = new ATM(100000F, 10);

            Console.WriteLine(atm1.check_balance());
            atm1.deposit(29F);
            Console.WriteLine(atm1.check_balance());
            atm1.withdraw(100000F);
            Console.WriteLine(atm1.check_balance());
            atm1.transaction_history();
        }


    }

    class ATM
    {
        public float Balance;
        public int TransactionCount;
        public int MaxTransactions;
        
        string[] TransactionType;

        float[] TransactionAmount;

        public ATM(float balance, int max_transactions)
        {
            TransactionCount = 0;
            Balance = balance;
            MaxTransactions = max_transactions;
            TransactionType = new string[MaxTransactions];
            TransactionAmount = new float[MaxTransactions];
        }

        public void add_transaction(string type, float amount)
        {
            TransactionType[TransactionCount] = type;
            TransactionAmount[TransactionCount] = amount;
            TransactionCount++;
        }
        public void deposit(float amount)
        {
            if (TransactionCount < MaxTransactions)
            {
                Balance += amount;
                add_transaction("Deposited: ", amount);
            }
            else
            {
                Console.WriteLine("Max Transactions Hit!!");
            }
        }

        public void withdraw(float amount)
        {
            if (TransactionCount < MaxTransactions)
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                    add_transaction("Withdrew: ", amount);
                }
                else
                {
                    Console.WriteLine("Insufficient Balance!!");
                }
            }
            else
            {
                Console.WriteLine("Max Transactions Hit!!");
            }
        }

        public float check_balance()
        {
            return Balance;
        }

        public void transaction_history()
        {
            Console.WriteLine("\n---Transaction History---\n");
            for (int i = 0; i < TransactionCount; i++)
            {
                Console.WriteLine(TransactionType[i] + TransactionAmount[i]);
            }
        }
    }

}
