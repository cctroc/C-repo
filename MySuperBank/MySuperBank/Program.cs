using System;

namespace MySuperBank
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!, my super bank!!");

            bool b = "bank!!" is string;
            System.Diagnostics.Debug.WriteLine(b);
            System.Diagnostics.Debug.WriteLine(sizeof(int));
            System.Diagnostics.Debug.WriteLine(typeof(bool));



            //var account = new BankAccount("cctroc", "123",  100);
            //Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");

            var account = new BankAccount("cctroc", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");

            account.MakeWithdrawal(120, DateTime.Now, "Buy a book");
            Console.WriteLine(account.Balance);

            account.MakeDeposit(50, DateTime.Now, "make Deposit");
            Console.WriteLine(account.Balance);

            //account.MakeDeposit(-50, DateTime.Now, "make Deposit");
            //Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());



        }

    }
}