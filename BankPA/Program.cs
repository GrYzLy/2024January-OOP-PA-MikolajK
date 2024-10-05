using BankPA;

internal class Program
{
    private static void Main(string[] args)
    {
        BankController bank = new BankController();

        Customer customer1 = new Customer("Ken Joy", "Long street");
        Customer customer2 = new Customer("John Snow", "Main Winterfell street");

        bank.AddCustomer(customer1);
        bank.AddCustomer(customer2);

        Savings kenSavingsAcc = new Savings(1000m, 0.05m);
        Investments kenInvestmentAcc = new Investments(1000m);

        Investments johnInvestmentsAcc = new Investments(1000m);
        Savings johnSavingAcc = new Savings(500m, 0.2m);

        customer1.AddAccount(kenSavingsAcc);
        customer1.AddAccount(kenInvestmentAcc);

        customer2.AddAccount(johnInvestmentsAcc);
        customer2.AddAccount(johnSavingAcc);

        kenSavingsAcc.Deposit(1000m);
        kenSavingsAcc.ShowBilans();
        kenSavingsAcc.ApplyInterest("ken Joy");
        kenSavingsAcc.Withdraw(200m);
        kenSavingsAcc.ShowBilans();

        johnInvestmentsAcc.AddStock(5, 50m, 0.5m);
        

        bank.ShowCustomerAccounts("ken Joy");
        bank.ShowCustomerAccounts("john snow");

        bank.ApplyInterestToAllSavingsAccounts();

        bank.ShowAllCustomersAccounts();
    }
}