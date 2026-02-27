using System;
using System.Collections.Generic;

public class Floor
{
    public List<string> collectableItems = new List<string>();

    public void ItemsOnTheFloor(string droppedItem)
    {
        if (string.IsNullOrEmpty(droppedItem))
        {
            Console.WriteLine("Yere eklenecek eşya yok.");
            return;
        }

        collectableItems.Add(droppedItem);
    
    }

   
}