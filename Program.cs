using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccount3
{
    class Program
    {
        static void Main(string[] args)
            //Declaring instances of Classes and Stream
        {
            StreamWriter mainStream = new StreamWriter(@"BankAccount.txt");
            Checking checkingAction = new Checking();
            Reserve reserveAction = new Reserve();
            Savings savingAction = new Savings();
            AccountAction mainAction = new AccountAction();

            //Where the magic happens!
            Console.WriteLine("Welcome to StarBank!");
            Console.WriteLine("\nName : Dallas Hickman");
            mainStream.WriteLine("Name : Dallas Hickman");
            Console.WriteLine("Account# : 1234567890");
            mainStream.WriteLine("Account# : 1234567890");
            Console.WriteLine("\nChecking Account Balance:{0}",checkingAction.balance);
            mainStream.WriteLine("\nChecking Account Balance:{0}", checkingAction.balance);
            Console.WriteLine("\nSavings Account Balance:{0}",savingAction.balance);
            mainStream.WriteLine("\nSavings Account Balance:{0}", checkingAction.balance);
            Console.WriteLine("\nReserve Account Balance:{0}",reserveAction.balance);
            mainStream.WriteLine("\nReserve Account Balance:{0}", reserveAction.balance);
            Console.WriteLine("\nPlease select from the following menu options:");
            Console.WriteLine('\n');
            Console.WriteLine("\n1: Checking");
            Console.WriteLine("\n2: Savings");
            Console.WriteLine("\n3: Reserve");
            Console.WriteLine("\n4: Exit");

            int menuChoice = int.Parse(Console.ReadLine());
            switch(menuChoice)
            {
                case 1:
                    checkingAction.CheckingMenu();
                    int cMenu = int.Parse(Console.ReadLine());
                    switch (cMenu)
                    {
                        case 1:
                            Console.WriteLine("How much would you like to deposit?");
                            checkingAction.DepositMoney(10000.00M, decimal.Parse(Console.ReadLine()));
                            break;

                        case 2:
                            Console.WriteLine("How much would you like to withdraw?" );
                            checkingAction.WithdrawMoney(10000.00M, decimal.Parse(Console.ReadLine()));
                            break;
                    }
                    break;

                case 2:
                    savingAction.SavingsMenu();
                    int sMenu = int.Parse(Console.ReadLine());
                    switch (sMenu)
                    {
                        case 1:
                            Console.WriteLine("How much would you like to deposit?");
                            savingAction.DepositMoney(20000.00M, decimal.Parse(Console.ReadLine()));
                            break;

                        case 2:
                            Console.WriteLine("How much would you like to withdaw?");
                            savingAction.WithdrawMoney(20000.00M, decimal.Parse(Console.ReadLine()));
                            break;
                    }
                    break;

                case 3:
                    reserveAction.ReserveMenu();
                    int rMenu = int.Parse(Console.ReadLine());
                    switch (rMenu)
                    {
                        case 1:
                            Console.WriteLine("How much would you like to deposit?");
                            reserveAction.DepositMoney(50000.00M, decimal.Parse(Console.ReadLine()));
                            break;

                        case 2:
                            Console.WriteLine("How much would you like to withdraw?");
                            reserveAction.WithdrawMoney(50000.00M, decimal.Parse(Console.ReadLine()));
                            break;
                    }
                    break;

                case 4:
                    Console.WriteLine("Thank you! We'll see you soon!");
                    break;
            }

            mainStream.Close();
              

        }
    }
}
