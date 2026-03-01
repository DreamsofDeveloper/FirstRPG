using System;
using System.Collections.Generic;

public class InventorySystems
{
    private readonly Dictionary<string, int> inventory = new Dictionary<string, int>();

    private int MaxStack = 999;
    private int MaxSlot = 10; // ileride player geliştirmeleri ile arttırılabilir olacak.

  

    public void PrintInventory()
    {
        Console.WriteLine("---------------------------\n        Envanter        \n---------------------------\n");

        if (inventory.Count == 0)
        {
            Console.WriteLine("(Envanter boş)");
            return;
        }

        foreach (var (key, value) in inventory)
            Console.WriteLine($"{key}: {value} adet");
    }

 

    public void AddToInventory(string item, int amount = 1)

    {
        

        if (inventory.ContainsKey(item)) inventory[item] += amount;

        else inventory[item] = amount;


    }

    public void UpdateItem(string item, int amount)
    {
        inventory[item] = amount;
    }
   

    public void RemoveItem(string Item)
    {
        inventory.Remove(Item);
    }


    public int ReturnHave(string value)
    {
        bool key = inventory.TryGetValue(value, out int have);
        return have;
    }
    
    public bool ReturnKey(string value)
    {
       return inventory.TryGetValue(value, out int have);
       

    }

    public bool IsFull()
    {
        if (inventory.Count() < MaxSlot) return false;
        else 
        
        {
            Console.WriteLine("Çanta Dolu!");
            return true;  }
    }
   
}