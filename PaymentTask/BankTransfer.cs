using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentTask
{
    internal class BankTransfer: IPaymentProcessor
    {
        const double DEFAULT_PROCESSING_FEE = 0.015;
        const double DEFAULT_TAX = 0.1;
        public double ProcessingFee { get; set; } = DEFAULT_PROCESSING_FEE;
        public double CalculateProcessingFee(double amount)
        {
            return amount * ProcessingFee;
        }
        public double ProcessPayment(double amount)
        {
            double processingFee = CalculateProcessingFee(amount);
            double tax = amount * DEFAULT_TAX;

            double totalAmount = amount + tax+ processingFee;
            PrintDetails(amount, processingFee, tax, totalAmount);
            return totalAmount;
        }
        public void PrintDetails(double baseAmount, double processingFee, double tax, double totalAmount)
        {
            Console.WriteLine($"Base Amount: ${baseAmount:F2}");
            Console.WriteLine($"Processing Fee: ${processingFee:F2}");
            Console.WriteLine($"Tax (10%): ${tax:F2}");
            Console.WriteLine($"Total Amount: ${totalAmount:F2}");
            Console.WriteLine($"Processing Bank Transfer payment of ${totalAmount:F2}");
        }
    }
}
