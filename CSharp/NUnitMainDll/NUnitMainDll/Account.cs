using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitMainDll
{
    public class Account
    {
        private string accountno;
        private float balance=500.0f;
        public List<Account> transferaccount;

        public Account(string accno)
        {
            this.accountno = accno;
            transferaccount = new List<Account>();
        }

        public float checkBalance()
        {
            return balance;
        }

        public void Deposit(float amount)
        {
            balance += amount;
        }

        public void Withdraw(float amount)
        {
            if (balance > amount)
                balance -= amount;
            else
                throw new Exception("Not Enough Funds to Withdraw..");
        }
    }
}
