
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

   
}
