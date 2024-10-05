using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPA
{
    public interface IAccount
    {
        void ShowBilans();
        void Withdraw(decimal moneyOut);
        void Deposit(decimal moneyIn);
    }
}
