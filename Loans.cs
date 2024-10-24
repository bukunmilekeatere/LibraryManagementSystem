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

        public IMedia MediaItem { get; set; }

        public DateOnly LoanDate { get; set; }

        public string LoanerName { get; set; }

        public DateOnly DueDate
        {
            get { return MediaItem.DueDate; }
        }


        public Loans(int loanerId, IMedia mediaItem, DateOnly loanDate, string loanerName)
        {
            LoanerId = loanerId;
            MediaItem = mediaItem;
            LoanDate = loanDate;
            LoanerName = loanerName;
            MediaItem.InUse = true;
        }

        public void ReturnItem()
        {
            MediaItem.InUse = false;
            Console.WriteLine($"{MediaItem} has been returned");
        }

        public void GetDetails()
        {
            Console.WriteLine($"Details of Loan - Loaner Name: {LoanerName}, Loaner Id: {LoanerId}, Loan Date: {LoanDate}, Due Date: {DueDate}");
            MediaItem.GetInfo();
        }
    }
}
