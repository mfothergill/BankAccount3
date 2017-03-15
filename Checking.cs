using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccount3
{
  public  class Checking : AccountAction
    {
        //Class only Field with Timestamp and Stream
        
        DateTime checktime = DateTime.Now;
        private decimal overDFees;
        //Constructor
        public Checking()
        {
            this.balance = 10000.00M;
            this.overDFees = 5.00M;
        }
        //Properties
        public decimal OverDFees
        {
            get { return this.overDFees; }
            set { this.overDFees = 5.00M; }
        }
        
        //Override Methods
        public override void DepositMoney(decimal balance, decimal deposit)
        {
            balance += deposit;
            
            base.DepositMoney(balance, deposit);
            Console.WriteLine("Your current checking balance is{0}", balance);
            Console.WriteLine(checktime);
            Console.WriteLine("\nThank you for your transaction! Have a nice day!");

        }

        public override void WithdrawMoney(decimal balance, decimal withdraw)
        {
            balance -= withdraw;
            if(balance < 0)
            {
                Console.WriteLine("\a\a\aWARNING!! You will be charged a 5.00 transaction fee for overdraft withdrawls!");
            }
            base.WithdrawMoney(balance, withdraw);
            Console.WriteLine("Your current checking balance is{0}", balance);
            Console.WriteLine(checktime);
            Console.WriteLine("\n Thank you for your transaction.Have a nice day!");
        }
        public void CheckingMenu()
        {
            Console.WriteLine("CHECKING ACCOUNT MENU : Would you like to deposit or withdraw?");
            Console.WriteLine("\n1: Deposit");
            Console.WriteLine("\n2: Withdraw"); 
        }
    }
}
