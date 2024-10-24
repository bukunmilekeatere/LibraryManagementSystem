using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Magazines : IMedia
    {
        public string Title { get; set; }
        public string Distributor { get; set; }

        public string Author { get; set; }

        public int SerialNumber { get; set; }

        public string MediaType { get; set; }

        public DateOnly DueDate { get; set; }

        public bool InUse { get; set; } = false;

        public Magazines(string title, string author, string distributor, int serialNumber, string mediaType, DateOnly dueDate)
        {
            this.Title = title;
            this.Author = author;
            this.Distributor = distributor;
            this.SerialNumber = serialNumber;
            this.MediaType = mediaType;
            this.DueDate = dueDate;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Media Type: {MediaType}, Magazine Author: {Author}, Title: {Title}, Magazine Distributor: {Distributor}, Magazine Number: {SerialNumber}");
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

        public void CalculateOverDueFine()
        {

        }
    }
}
