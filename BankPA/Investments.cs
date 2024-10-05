using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankPA
{
    public class Investments : Account
    {
        
        public Investments(decimal bilans) : base(bilans, AccountType.Invenstment)
        {

        }

        public void AddStock(int quantity, decimal priceStock, decimal commissionFee)
        {
            decimal price = quantity * priceStock;
            decimal commission = price * commissionFee / 100;
            decimal totalPrice = price + commission;

            if (Bilans >= totalPrice)
            {
                Bilans -= totalPrice;
                Console.WriteLine($"Bought {quantity} stocks for {price}. Commission: {commission}. Total: {totalPrice}.");
            }
            else
            {
                Console.WriteLine("No money to buy stocks.");
            }
        }

        
    }
}
