
// generic search  to find items in list based on condition
using LibraryManagementSystem.Interfaces;
using System;
using System.Collections.Generic;

public class SearchService<T> where T : IItem
{
    private List<T> items;

    // constructor to initialize searche with list 
    public SearchService(List<T> items)
    {
        this.items = items;
    }
    // searches list for items that match 
    public List<T> SearchBy(Func<T, bool> predicate)
    {
        List<T> results = new List<T>();
        foreach (var item in items)
        {
            // ff the item matches add 
            if (predicate(item))
            {
                results.Add(item);
            }
        }
        return results;
    }

}
