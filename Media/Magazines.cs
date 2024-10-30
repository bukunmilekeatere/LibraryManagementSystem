using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Interfaces;

namespace LibraryManagementSystem.Media
{
    public class Magazines : IItem
    {
        public string Title { get; set; }
        public string Distributor { get; set; }

        public string Author { get; set; }

        public int SerialNumber { get; set; }

        public string ItemType { get; set; }

        public DateOnly DueDate { get; set; }

        public bool InUse { get; set; } = false;

        public decimal Cost { get; set; }

        public Magazines(string title, string author, string distributor, int serialNumber, string itemType, DateOnly dueDate, decimal cost)
        {
            Title = title;
            Author = author;
            Distributor = distributor;
            SerialNumber = serialNumber;
            ItemType = itemType;
            DueDate = dueDate;
            Cost = cost;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Item Type: {ItemType}, Magazine Author: {Author}, Title: {Title}, Magazine Distributor: {Distributor}, Magazine Number: {SerialNumber}, Cost: {Cost}");
        }

        public bool IsAvailable()
        {
            if (!InUse)
            {
                Console.WriteLine($"{Title} is not available for loan.");
                InUse = true;
                DueDate = DueDate.AddDays(30);
            }

            else
            {
                Console.WriteLine($"{Title} is available for loan");
            }

            return InUse;
        }

        public void GetDueDate()
        {
            if (!IsAvailable())
            {
                Console.WriteLine($"The magazine, {Title} is not available for loan. It should be returned in 30 days on {DueDate}");
            }

            else
            {
                Console.WriteLine($"The magazine, {Title} is available for loan.");
            }
        }
    }
}
