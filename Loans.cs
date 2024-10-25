using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Loans
    {
        public int LoanerId { get; set; }

        public IItem Item { get; set; }

        public DateOnly LoanDate { get; set; }

        public string LoanerName { get; set; }


        public Loans(int loanerId, IItem item, DateOnly loanDate, string loanerName)
        {
            LoanerId = loanerId;
            Item = item;
            LoanDate = loanDate;
            LoanerName = loanerName;
            Item.InUse = true;
        }

        public bool ItemOverdue()
        {
            // used FromDateTime to get only the date and not the time to see if the due date for returns have been exceeded
            if (Item.InUse && DateOnly.FromDateTime(DateTime.Now) > Item.DueDate)
            {
                OverdueFine();
            }

            return false;
        }

        public decimal OverdueFine()
        {
            if (ItemOverdue())
            {
                // if overdue, the fine will be the cost of the item
                return Item.Cost;
            }

            else
            {
                return 0;
            }
        }

        public void ReturnItem()
        {
            Item.InUse = false;
            Console.WriteLine($"{Item} has been returned");
        }

        public void GetDetails()
        {
            Console.WriteLine($"Details of Loan - Loaner Name: {LoanerName}, Loaner Id: {LoanerId}, Loan Date: {LoanDate}, Due Date: {Item.DueDate}");
            Item.GetInfo();
        }
    }
}
