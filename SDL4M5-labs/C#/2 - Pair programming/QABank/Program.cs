using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace QABank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount firstAccount = new BankAccount("Tristan", 5.43);
            Console.WriteLine(firstAccount.AccountName);
      Console.ReadLine();
            BankAccount secondAccount = new BankAccount("Another Name", 100.58, 5);
        }
    }

    class BankAccount
    {
        public String AccountName;
        public double Balance;
        public int AccountNum;
        private static int lastAccNum = 100000;
        public BankAccount(String customerName, double balance){
            if(!string.IsNullOrWhiteSpace(customerName)){
                AccountName = customerName;
                Balance = balance;
                AccountNum = lastAccNum;
                lastAccNum ++;
            }
        }
        public BankAccount(String customerName, double balance, int accountNum){
            if(!string.IsNullOrWhiteSpace(customerName)){
                AccountName = customerName;
                Balance = balance;
                AccountNum = accountNum;
            }
        }
    }
}
