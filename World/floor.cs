using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FirstRPG.Entities.Items;

public class Floor
{

    // Zemin Kuralları
    public const int FloorWeight = 50;

    
        private List<Item> ItemsOnTheFloor = new List<Item>();
        private Dictionary<Item, int> givenitems = new Dictionary<Item, int>();
        public bool isthereItems;
  


    public void FallingItem(Item droppedItem, string owner)
    {
        if (droppedItem == null)
        {
            Console.WriteLine("Yere eklenecek eşya yok.");
            return;
        }

        AddItemToFloor(droppedItem);
        Console.WriteLine($"{owner}'den yere düşen eşya: {droppedItem.Name}");
    
    }


    public void AddItemToFloor(Item item)
    {
        if(item != null)
        {
            ItemsOnTheFloor.Add(item);

        }
        else
        {
            Console.WriteLine("In the floor file, the parameter of the AddItemToFloor function is null.");
        }

    }

    public void ClearFloor()

    {
        ItemsOnTheFloor.Clear();       
    }

    public bool IsWeight()
    {
        if (ItemsOnTheFloor.Count >= FloorWeight)
        {

            return true;
               
            
            
        }else return false;
    }

    public int TurnCount()
    {
       return ItemsOnTheFloor.Count;
    }


    public void ShowItemsOnFloor()
    {

        if(ItemsOnTheFloor.Count==0) Console.WriteLine("Yerde Eşya Yok");

        foreach (var item in ItemsOnTheFloor)
        {
            Console.WriteLine($"Yerdeki Eşya: {item.Name}");
        }

    
        
    }

    public void RemoveItem(Item item)
    {
        ItemsOnTheFloor.Remove(item);
    }
  
    public List<Item> GetItemsOnTheFloor()
    {
        
        return ItemsOnTheFloor;
    }



  public void GiveItems(Container container)
    {
         if (!IsthereItems())
    {
        return;
    }
        for(int i = ItemsOnTheFloor.Count - 1 ; i>= 0 ; i--)
        {
            
                var item = ItemsOnTheFloor[i];
                int left = container.AddItem(item,1);

                if (left > 0) continue;

                ItemsOnTheFloor.Remove(item);


            if (givenitems.ContainsKey(item))
            {
                givenitems[item] ++;
            }
            else
            {
                givenitems[item] = 1;
            }
                

        }

        foreach(var items in givenitems)
        {
            Console.WriteLine($"{items.Key.Name} X {items.Value} toplandı.");
        }
        givenitems.Clear();

    }


    public bool IsthereItems()
    {
        if( ItemsOnTheFloor.Count == 0) return isthereItems = false;
        else return isthereItems = true;
    }

   
}