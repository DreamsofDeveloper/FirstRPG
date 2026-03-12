using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FirstRPG.Entities.Items;

public class Floor
{

    // Zemin Kuralları
    public const int FloorWeight = 50;

    
   
    public  Dictionary<Item, int> collectableItems = new Dictionary<Item, int>();
  


    public void ItemsOnTheFloor(Item droppedItem, string owner)
    {
        if (droppedItem == null)
        {
            Console.WriteLine("Yere eklenecek eşya yok.");
            return;
        }

        AddItemToFloor(droppedItem, 1);
        Console.WriteLine($"{owner}'den yere düşen eşya: {droppedItem.Name}");
    
    }


    public void AddItemToFloor(Item item, int amuont)
    {
        if (collectableItems.ContainsKey(item))
        {
            collectableItems[item]+= amuont;
        }
        else
        {
            collectableItems[item] = amuont;
        }

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

        else foreach(var item in collectableItems)
        {
            
            Console.WriteLine($"Yerdeki İtem: {item.Key.Name} X {item.Value}");
        }

    
        
    }

    public void RemoveItem(Item item)
    {
        collectableItems.Remove(item);
    }
  

   
}