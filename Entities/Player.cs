using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


public class Player
{
    
public int level = 0 ;
public int healt;
public int AttackPower;
private InventorySystems inv;

public Player(int healt, int AttackPower, InventorySystems inv)
    {
        this.healt = healt;
        this.AttackPower = AttackPower;
        this.inv = inv;
    }
  

    public void Attack()
    {
        
        Console.WriteLine("Kahraman: Düşmana Saldırı Yapıldı!");
        
        
    }

      public void CollectItems(Floor floor)
    {
        if (floor.collectableItems.Count == 0)
        {
            Console.WriteLine("Toplanacak eşya yok.");
            return;
        }

        foreach (string item in floor.collectableItems)
        {

            inv.AddToInventory(item);
            Console.WriteLine("Toplanan Eşya: " + item);
        }

            floor.collectableItems.Clear();
    }

     public bool SpendFromInventory(string item, int amount)
       
    {
        bool TrygetValue = inv.ReturnKey(item);
        int have = inv.ReturnHave(item);


        if (!TrygetValue || have < amount) return false;

        else if (TrygetValue && have >= amount )int left = have - amount;


        if (left == 0) inv.RemoveItem(item);

        else inv.UpdateItem(item,amount);
        
        return true;
    }

    public void AddPlayerInventory(string item)
       {
        inv.AddToInventory(item,1);
    }



}