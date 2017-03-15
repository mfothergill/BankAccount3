using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace BankAccount3
{
  public  class Reserve : AccountAction
    {  //Class only Field with Timestamp 
        
        DateTime reserveTime = DateTime.Now;
        public decimal reserveIntrest;
        //Constructor
        public Reserve()
        {
            this.balance = 50000.00M;
            this.reserveIntrest = 20.00M;
        }
        //Property
        public decimal ReserveInrest
        {
            get { return this.reserveIntrest; }
            set { this.reserveIntrest = 20.00M; }
        }
        //Override Methods
        public override void DepositMoney(decimal balance, decimal deposit)
        {
            balance += (deposit + reserveIntrest);
            base.DepositMoney(balance, deposit);
            Console.WriteLine("Your current Reserve Balance is{0}",balance);
            Console.WriteLine(reserveTime);
            Console.WriteLine("\nThank you for your transaction! Have a nice day!");
        }

        public override void WithdrawMoney(decimal balance, decimal withdraw)
        {
            balance -= withdraw;
            base.WithdrawMoney(balance, withdraw);
            Console.WriteLine("Your current Reserve Balance is{0}",balance);
            Console.WriteLine(reserveTime);
            Console.WriteLine("Thank you for your transaction! Have a nice day!");
        }
        
        public void ReserveMenu()
        {
            Console.WriteLine("RESERVE ACCOUNT MENU: Would you like to deposit or withdraw?");
            Console.WriteLine("**IMPORTANT**: Every deposit into this account incurs 20.00 of interest! :)");
            Console.WriteLine("\n1: Deposit");
            Console.WriteLine("\n2: Withdraw");
        }
    }
}
