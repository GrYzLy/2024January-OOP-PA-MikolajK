using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPA
{
    public class Savings : Account
    {
        public decimal InterestRate { get;  set; }
        public Savings(decimal bilans, decimal interestRate) : base(bilans, AccountType.Savings)
        {
            InterestRate = interestRate;
        }

        public void ApplyInterest(string customerFullName)
        {
            var interest = Bilans * InterestRate;
            Bilans += interest;
            Console.WriteLine($"Interest of {interest} applied to {customerFullName} account.");
        }
    }
}
