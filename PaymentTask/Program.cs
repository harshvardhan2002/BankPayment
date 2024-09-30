namespace PaymentTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Payment Processing System!");
            Console.WriteLine("Please choose a payment method: ");
            Console.WriteLine("1. Credit Card");
            Console.WriteLine("2. Paypal");
            Console.WriteLine("3. Bank Transfer");
            Console.Write("Enter your choice (1/2/3): ");
            int choice = Convert.ToInt32(Console.ReadLine());
            IPaymentProcessor paymentProcessor = null;
            

            switch (choice)
            {
                case 1: paymentProcessor = new CreditCard();
                    break;

                case 2: paymentProcessor = new Paypal();
                    break;
                case 3: paymentProcessor = new BankTransfer();
                    break;

                default: Console.WriteLine("Invalid choice, re-enter:");
                    break;

            }
            Console.Write("Enter the base amount to pay: ");
            double baseAmount= Convert.ToDouble(Console.ReadLine());
            double totalAmount = paymentProcessor.ProcessPayment(baseAmount);
            
        }
    }
}
