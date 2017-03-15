using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace BankAccount3
{
   public class Savings : AccountAction
    {     // Class only field with Timestamp and Stream
        
        DateTime savingsTime = DateTime.Now;
         public decimal savingsintrest;
        //Constructor
        public Savings()
        {
            this.balance = 20000.00M;
            this.savingsintrest = .10M;
        }
        //Property
        public decimal SavingsInterest
        {
            get { return this.savingsintrest; }
            set { this.savingsintrest = .10M; }
        }
        //Override Methods
        public override void DepositMoney(decimal balance, decimal deposit)
        {
            balance += (deposit + savingsintrest);
            base.DepositMoney(balance, deposit);
            Console.WriteLine("Your current Savings Balance is{0}", balance);
            Console.WriteLine(savingsTime);
            Console.WriteLine("\nThank you for your transaction! Have a nice day!");
        }
        public override void WithdrawMoney(decimal balance, decimal withdraw)
        {
            balance -= withdraw;
            base.WithdrawMoney(balance, withdraw);
            Console.WriteLine("Your current Savings Balance is{0}", balance);
            Console.WriteLine(savingsTime);
            Console.WriteLine("Thank you for your transaction! Have a nice day!");
        }
        public void SavingsMenu()
        {
            Console.WriteLine("SAVINGS ACCOUNT MENU: Would you like to deposit or withdraw?");
            Console.WriteLine("**IMPORTANT**: Deposits into this account will inucr .10 in interest");
            Console.WriteLine("\n1: Deposit");
            Console.WriteLine("\n2: Withdraw");
        }
    }
    

}
