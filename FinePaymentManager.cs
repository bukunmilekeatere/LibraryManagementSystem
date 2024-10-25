using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class FinePaymentManager
    {
        List<CashFinePayments> cashFinePaymentList = new List<CashFinePayments>();
        List<CreditCardFinePayments> creditCardFinePaymentList = new List<CreditCardFinePayments>();

        public void AddPayment(CreditCardFinePayments creditCardPayment)
        {
            creditCardFinePaymentList.Add(creditCardPayment);
        }

        public void AddPayment(CashFinePayments cashFinePayment)
        {
            cashFinePaymentList.Add(cashFinePayment);
        }

        public void ProccessPayments()
        {
            foreach (CreditCardFinePayments creditCardFinePayment in creditCardFinePaymentList)
            {
                if (creditCardFinePayment.ValidateFinePayment())
                {
                    creditCardFinePayment.Authorize();
                    creditCardFinePayment.FineProcessing();
                    creditCardFinePayment.LogFinePayment();
                }
            }

            foreach (CashFinePayments cashFinePayment in cashFinePaymentList)
            {
                if (cashFinePayment.ValidateFinePayment())
                {
                    cashFinePayment.FineProcessing();
                    cashFinePayment.LogFinePayment();
                    cashFinePayment.RecordFinePayment();
                }
            }
        }

    }
}
