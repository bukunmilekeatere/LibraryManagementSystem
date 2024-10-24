using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Books : IMedia
    {
        public string AuthorName { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int SerialNumber { get; set; }

        public int PageCount { get; set; }

        public string MediaType { get; set; }

        public DateOnly DueDate { get; set; }

        public bool InUse { get; set; } = false;


        public Books(string authorName, string title, string genre, int serialNumber, int pageCount, DateOnly dueDate, string mediaType)
        {
            this.AuthorName = authorName;
            this.Title = title;
            this.Genre = genre;
            this.SerialNumber = serialNumber;
            this.PageCount = pageCount;
            this.DueDate = dueDate;
            this.MediaType = mediaType;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Media Type: {MediaType}, Author: {AuthorName}, Book Title: {Title}, Book Genre: {Genre}, Book Identification Number: {SerialNumber}, Page Count of Book: {PageCount}");
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
