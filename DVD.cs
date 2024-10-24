using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class DVD : IMedia
    {
        public string ProducerName { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        public int SerialNumber { get; set; }

        public string MediaType { get; set; }

        public DateOnly DueDate { get; set; }

        public bool InUse { get; set; } = false;

        public DVD(string producerName, string title, string genre, int serialNumber,string mediaType, DateOnly dueDate) 
        {
            this.ProducerName = producerName;
            this.Title = title;
            this.Genre = genre;
            this.SerialNumber = serialNumber;
            this.MediaType = mediaType;
            this.DueDate = dueDate;
        }


        public void GetInfo()
        {
            Console.WriteLine($"Media Type: {MediaType}, Producer: {ProducerName}, Book Title: {Title}, Book Genre: {Genre}, Book Identification Number: {SerialNumber}");
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

        public void CalculateOverDueFine()
        {

        }
    }
}
