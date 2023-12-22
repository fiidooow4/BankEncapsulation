namespace Bank_Encapsulations
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Create a new instance of the BankAccount class
            BankAccount myAccount = new BankAccount();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("How much would you deposit?");
            var amountToDeposit = double.Parse(Console.ReadLine());
            myAccount.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you! Your Balance is now {myAccount.GetBalance()}");
        }
    }
}
