using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPA
{
    public class Customer
    {
        public string? FullName {  get; set; }

        public string? HomeAdress { get; set; }

        public List<Account> Accounts { get; set; } 

        public Customer(string fullName, string homeAdress)
        {
            FullName = fullName;
            HomeAdress = homeAdress;
            Accounts = new List<Account>();
            
        }

        public void AddAccount(Account account)
        {
            Accounts.Add(account);
            Console.WriteLine($"Added {account.Type} account for {FullName}.");
        }

        
        public Account GetAccountByType(AccountType type)
        {
            return Accounts.FirstOrDefault(acc => acc.Type == type);
        }


    }
}
