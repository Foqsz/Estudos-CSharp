using Course.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Course.Entities
{
    internal class AccountEx
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; } 

        public AccountEx() 
        { 
        } 
        public AccountEx(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }  

        public void Deposit(double amount)
        {
            Balance = Balance - amount;
            if (amount > WithdrawLimit)
            {
                throw new AccountException(" The amount exceeds withdraw limit");
            }
            else if (amount > Balance)
            {
                throw new AccountException(" Not enough balance");
            } 
        }
    }
}
