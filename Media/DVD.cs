using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Interfaces;

namespace LibraryManagementSystem.Media
{
    public class DVD : IItem
    {
        public string ProducerName { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        public int SerialNumber { get; set; }

        public string ItemType { get; set; }

        public DateOnly DueDate { get; set; }

        public bool InUse { get; set; } = false;

        public decimal Cost { get; set; }

        public DVD(string producerName, string title, string genre, int serialNumber, string itemType, DateOnly dueDate, decimal cost)
        {
            ProducerName = producerName;
            Title = title;
            Genre = genre;
            SerialNumber = serialNumber;
            ItemType = itemType;
            DueDate = dueDate;
            Cost = cost;
        }


        public void GetInfo()
        {
            Console.WriteLine($"Item Type: {ItemType}, Producer: {ProducerName}, Book Title: {Title}, Book Genre: {Genre}, Book Identification Number: {SerialNumber}, Cost: {Cost}");
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
                Console.WriteLine($"{Title} is available for loan.");
            }

            return InUse;
        }

        public void GetDueDate()
        {
            if (!IsAvailable())
            {
                Console.WriteLine($"The book, {Title} is not available for loan. It should be returned in 30 days on {DueDate}");
            }

            else
            {
                Console.WriteLine($"The book, {Title} is available for loan.");
            }
        }
    }
}
