using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Payments
{
    public class CashFinePayments
    {
        private string paymentType;

        public string PaymentType
        {
            get { return paymentType; }
            set { paymentType = value; }
        }

        private decimal paymentAmount;

        public decimal PaymentAmount
        {
            get { return paymentAmount; }
            set { paymentAmount = value; }
        }

        private string paymentCurrency;

        public string PaymentCurrency
        {
            get { return paymentCurrency; }
            set
            {

                if (value != "CAD")
                {
                    throw new ArgumentException("Failed to validate. Input valid currency of Canadian Dollars");
                }

                paymentCurrency = value;
            }
        }

        public CashFinePayments(decimal paymentAmount, string paymentCurrency)
        {
            paymentType = "Cash Payment";
            this.paymentAmount = paymentAmount;
            this.paymentCurrency = paymentCurrency;
        }

        public bool ValidateFinePayment()
        {
            if (paymentCurrency != "CAD")
            {
                Console.WriteLine("Fine payment was not validated. Pay in Canadian Dollars(CAD).");
                return false;
            }

            return true;
        }

        public void FineProcessing()
        {
            Console.WriteLine($"{PaymentType} of {PaymentAmount} was successfully processed");
        }

        public void RecordFinePayment()
        {
            Console.WriteLine($"{PaymentType} was recorded");
        }

        public void LogFinePayment()
        {
            Console.WriteLine($"Payment Type: {paymentType}, Payment Amount: {paymentAmount}, Payment Currency: {paymentCurrency}");
        }
    }
}
