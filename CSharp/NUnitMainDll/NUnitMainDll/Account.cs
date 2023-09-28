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
        private float balance = 500.0f;
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

        public int Add(int a, int b)
        {
            int x = a + b;
            return x;
        }

        
        //login validation method
        public string Login(string UserId, string Password)
        {
            if (string.IsNullOrEmpty(UserId) || string.IsNullOrEmpty(Password))
            {
                return "UserId or password cannot be Empty";
            }
            else if (UserId == "Admin" && Password == "Admin123")
            {
                return "Welcome Admin";
            }
            else
                return "Incorrect Userid or Password";
        }
    }

    public class EmployeeDetails
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public List<EmployeeDetails> AllEmployees()
        {
            List<EmployeeDetails> emplist = new List<EmployeeDetails>()
            {
                new EmployeeDetails{ID=10,Name="Arvind",Salary=3500},
                new EmployeeDetails{ID=15,Name="Manisha",Salary=4500},
                new EmployeeDetails{ID=20,Name="Arun",Salary=4500},
                new EmployeeDetails{}
            };
            return emplist;
        }

        public EmployeeDetails GetEmployeeById(int id)
        {
            EmployeeDetails empdata = new EmployeeDetails();
            var emp = AllEmployees();
            foreach(var e in emp)
            {
                if(e.ID==id)
                {
                    return empdata;
                }
            }
            return null;
        }
    }
}
