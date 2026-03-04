using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FirstRPG.Entities.Items;

public class Floor
{

    // Zemin Kuralları
    public const int FloorWeight = 50;

    
   
    public  List<Item> collectableItems = new List<Item>();
  


    public void ItemsOnTheFloor(Item droppedItem, string owner)
    {
        if (droppedItem == null)
        {
            Console.WriteLine("Yere eklenecek eşya yok.");
            return;
        }

        collectableItems.Add(droppedItem);
        Console.WriteLine($"{owner}'den yere düşen eşya: {droppedItem.Name}");
    
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

        else foreach(Item item in collectableItems)
        {
            
            Console.WriteLine($"Yerdeki İtem: {item.Name}");
        }

    
        
    }

    public void RemoveItem(Item item)
    {
        collectableItems.Remove(item);
    }
  

   
}