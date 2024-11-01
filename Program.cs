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

            // Instantiate AccountManager to manage users
            AccountManager accountManager = new AccountManager();

            // Step 1: Create user1 using UserAccount builder pattern
            User user1 = new UserAccount()
                .UserName("Ella Charles")
                .UserEmail("ella.charles@example.com")
                .UserPhone("204-698-2682")
                .UserPassword("password123")
                .UserCreate();

            // Step 2: Add user1 to the AccountManager
            Console.WriteLine("Adding user1:");
            accountManager.AddUser(user1);

            // Step 3: Create a second user (user2) and add to AccountManager
            User user2 = new UserAccount()
                .UserName("John Doe")
                .UserEmail("john.doe@example.com")
                .UserPhone("204-555-1234")
                .UserPassword("doeSecurePass")
                .UserCreate();

            Console.WriteLine("\nAdding user2:");
            accountManager.AddUser(user2);

            //add user1 again to check account 
            Console.WriteLine("\nAttempting to add user1 again:");
            accountManager.AddUser(user1);

            //Remove user1 from the AccountManager
            Console.WriteLine("\nRemoving user1:");
            accountManager.RemoveUser(user1.UserId);

            //remove a non-existent user
            Console.WriteLine("\nAttempting to remove a non-existent user (random ID):");
            accountManager.RemoveUser(14758120);

            accountManager.DisplayUsers();
            Console.ReadLine();
        }

    }
}
