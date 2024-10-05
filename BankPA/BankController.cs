using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPA
{
    public class BankController
    {
        public List<Customer> CustomerList { get; set; } = new List<Customer>();

        public Customer GetCustomerByName(string fullName)
        {
            return CustomerList.FirstOrDefault(c => c.FullName.Equals(fullName, StringComparison.OrdinalIgnoreCase));
        }

        public void AddCustomer(Customer customer)
        {
            CustomerList.Add(customer);
            Console.WriteLine($"Added customer {customer.FullName}.");
        }

        public void DisplayCustomers()
        {
            Console.WriteLine("Bank Customers:");
            foreach (var customer in CustomerList)
            {
                Console.WriteLine($"- {customer.FullName} {customer.HomeAdress}");
            }
        }

        public void ShowCustomerAccounts(string customerName)
        {
            var customer = GetCustomerByName(customerName);
            if (customer != null )
            {
                Console.WriteLine($"{customer.FullName}'s Accounts:");
                foreach (var account in customer.Accounts)
                {
                    account.ShowBilans();
                }
            }
            else
            {
                Console.WriteLine($"Customer {customerName} not found.");
            }
        }

        public void ShowAllCustomersAccounts()
        {
            Console.WriteLine(new String('-', 50));

            foreach (var customer in CustomerList)
            {
                Console.WriteLine($"{customer.FullName}'s Accounts:");

                
                var groupedAccounts = customer.Accounts.GroupBy(a => a.Type);

                foreach (var accountGroup in groupedAccounts)
                {
                    Console.WriteLine($"--> Account Type: {accountGroup.Key}");

                    foreach (var account in accountGroup)
                    {
                        account.ShowBilans(); 
                    }
                }

                Console.WriteLine(); 
            }
        }

        public void ApplyInterestToAllSavingsAccounts()
        {
            foreach (var customer in CustomerList)
            {
                foreach (var account in customer.Accounts)
                {
                    if (account is Savings savingsAccount) 
                    {
                        savingsAccount.ApplyInterest(customer.FullName);
                    }
                }
            }
        }
    }
}
