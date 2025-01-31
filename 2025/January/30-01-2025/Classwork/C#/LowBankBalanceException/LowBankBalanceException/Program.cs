using System;

namespace LowBankBalance
{
    public class LowBankBalance : Exception
    {
        public LowBankBalance(String message) : base (message)
        {

        }
    }

    class BankBalance
    {
        public void checkBalance(int balance, int withdrawalAmount)
        {
            if(withdrawalAmount > balance)
            {
                throw new LowBankBalance($"You are trying to withdraw more than your balance.");
            }
            else
            {
                int remainingBalance = balance - withdrawalAmount;
                Console.WriteLine($"You have withdrawn {withdrawalAmount}");
                Console.WriteLine($"Remaining Balance {remainingBalance}");
            }
        }
        static void Main(string[] args)
        {
            BankBalance balance = new BankBalance();
            int bankBalance = 95000;
            Console.Write("Enter amount to withdraw: ");
            int withdrawalAmount = int.Parse(Console.ReadLine());
            try
            {
                balance.checkBalance(bankBalance, withdrawalAmount);
            }
            catch(LowBankBalance e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}