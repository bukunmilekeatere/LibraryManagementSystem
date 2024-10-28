namespace LibraryManagementSystem
{
    // handles the list of items under user's account
    public class UserManagement : User
    {
        // stores the loaned items speciified to each user 
        public List<Loans> LoanedItems;

        // stores list of user accounts made
        public UserManagement()
        {
            LoanedItems = new List<Loans>();
        }


        // adds item to list if borrowed
        public void BorrowItem(Loans loan)
        {
            LoanedItems.Add(loan);
        }

        // removes item from list if returned
        public void ReturnItem(Loans loan)
        {
            if (LoanedItems.Contains(loan))
            {
                LoanedItems.Remove(loan);
            }
        }

        // displays each item for each user
        public void Display()
        {
            Console.WriteLine($"List of items from {Name}:");
            foreach(Loans item in LoanedItems)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
