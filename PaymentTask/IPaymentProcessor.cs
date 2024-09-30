using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentTask
{
    internal interface IPaymentProcessor
    {
        public double ProcessingFee { get; set; }
        abstract double CalculateProcessingFee(double amount);
        abstract double ProcessPayment(double amount);
        public void PrintDetails(double baseAmount, double processingFee, double tax, double totalAmount)
        {
            
        }
    }
}
