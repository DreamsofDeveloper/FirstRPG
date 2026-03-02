using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Floor
{

    // Zemin Kuralları
    public const int FloorWeight = 50;

    
   
    public  List<string> collectableItems = new List<string>();
  


    public void ItemsOnTheFloor(string droppedItem, string owner)
    {
        if (string.IsNullOrEmpty(droppedItem))
        {
            Console.WriteLine("Yere eklenecek eşya yok.");
            return;
        }

        collectableItems.Add(droppedItem);
        Console.WriteLine($"{owner}'den yere düşen eşya: {droppedItem}");
    
    }

    public void ClearFloor()

    {
        collectableItems.Clear();       
    }

    public bool IsWeight()
    {
        if (collectableItems.Count >= FloorWeight)
        {

            return true;
               
            
            
        }else return false;
    }

    public int TurnCount()
    {
       return collectableItems.Count;
    }


    public void ShowItemsOnFloor()
    {

        if(collectableItems.Count==0) Console.WriteLine("Yerde Eşya Yok");

        else foreach(string item in collectableItems)
        {
            
            Console.WriteLine($"Yerdeki İtem: {item}");
        }

    
        
    }

    public void RemoveItem(string item)
    {
        collectableItems.Remove(item);
    }
  

   
}