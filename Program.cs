using LibraryManagementSystem.Managers;
using LibraryManagementSystem.Media;
using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // accountmanager to manage users
            AccountManager accountManager = new AccountManager();

            // user1 using  builder pattern
            User user1 = new UserAccount()
                .UserName("Ella Charles")
                .UserEmail("ella.charles@example.com")
                .UserPhone("204-123-4567")
                .UserPassword("HYUEU45jk")
                .UserCreate();

            Console.WriteLine("adding user1:");
            accountManager.AddUser(user1);

            //  add to AccountManager
            User user2 = new UserAccount()
                .UserName("Adeola Yusuf")
                .UserEmail("adeola.yusuf@example.com")
                .UserPhone("204-891-0112")
                .UserPassword("babyShark123")
                .UserCreate();

            Console.WriteLine("Adding user2:");
            accountManager.AddUser(user2);

         
            ReservationManager reservationManager = new ReservationManager();

            // Sample media items to reserve
            Books book1 = new Books("Oluwabukunmi Leke-Atere", "A Guide to Being Short", "Non-Fiction", 123, 555, DateOnly.FromDateTime(DateTime.Now), "Book", 8.99m);

            // maked reservation for user1
            Console.WriteLine("creating a reservation:");
            BaseReservation bookReservation = new BaseReservation(user1, book1);
            reservationManager.AddReservation(bookReservation);
            Console.WriteLine($"reservation made for {user1.Name} on book '{book1.Title}'");

            Console.WriteLine("Completing book reservation for user1:");
            reservationManager.CompleteReservation(bookReservation);
            Console.WriteLine($"reservation status for '{book1.Title}': {bookReservation.Status}");

            Console.ReadLine();
        }
    }
}
