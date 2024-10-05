using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPA
{
    public abstract class Account : IAccount
    {
        public AccountType Type { get; set; }

        public decimal Bilans { get; set; }

        public Account(decimal bilans, AccountType type)
        {
            Bilans = bilans;
            Type = type;
        }
        public virtual void Deposit(decimal moneyIn)
        {
            Bilans += moneyIn;
            Console.WriteLine($"Deposited {moneyIn} into your {Type} account.");
        }

        public virtual void ShowBilans()
        {
            Console.WriteLine($"{Type} Bilans: {Bilans}");
        }

        public virtual void Withdraw(decimal moneyOut)
        {
            if (Bilans >= moneyOut)
            {
                Bilans -= moneyOut;
                Console.WriteLine($"Withdrew {moneyOut} from your {Type} account.");
            }
            else
            {
                Console.WriteLine("No money!.");
            }
        }

       

       
    }
}
